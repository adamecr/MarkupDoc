using System;
using System.IO;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Markup output multi file writer
    /// </summary>
    public class MarkupMultiFileWriter : MarkupFileWriter
    {
        /// <summary>
        /// Full path of the file the output is currently being written to
        /// </summary>
        public string CurrentFile { get; protected set; }
        /// <summary>
        /// Extension of the output files
        /// </summary>
        public string Extension { get; protected set; }

        /// <summary>
        /// Sets the target directory of the markdown writer (directory of index file provided in <paramref name="indexFileName"/>)
        /// </summary>
        /// <remarks>
        /// The <see cref="MarkupFileWriter.Target"/> is the full path to the directory to write the output files to
        /// Clears the files having the same extension as the given <paramref name="indexFileName"/> from the target directory
        /// The target can't be set when the output is being generated.</remarks>
        /// <param name="indexFileName">Full path to the index file (including the extension) to write the output to</param>
        /// <returns>True when the target has been set, otherwise false (because the output is in progress)</returns>
        public override bool SetTarget(string indexFileName)
        {
            if (string.IsNullOrEmpty(indexFileName)) throw new ArgumentNullException(nameof(indexFileName));
            if (IsInProgress) return false;

            var fileInfo = new FileInfo(indexFileName);
            Target = fileInfo.DirectoryName;
            Extension = fileInfo.Extension;
            CurrentFile = indexFileName;

            if (Target == null) throw new ArgumentException($"Can't get the target directory from {indexFileName}");
            //clean the dir 
            foreach (var file in new DirectoryInfo(Target).GetFiles($"*{Extension}"))
            {
                try
                {
                    file.Delete();
                }
                catch (Exception ex)
                {
                    ConsoleUtils.WriteWarn($"Can't delete the file {file.FullName}: {ex.Message}");
                }
            }

            return true;
        }

        /// <summary>
        /// Starts a new split of the output - closes the current file and opens a new one having the <paramref name="splitName"/> and <see cref="Extension"/>
        /// </summary>
        /// <param name="splitName">Name of the split</param>
        public override void Split(string splitName)
        {
            Writer?.Flush();
            Writer?.Close();
            Writer?.Dispose();
            CurrentFile = Path.Combine(Target, $"{splitName}{Extension}");
            Writer = new StreamWriter(CurrentFile);
        }

        /// <summary>
        /// Writes the code model to the output
        /// </summary>
        /// <param name="writeContentActionAsync">Function rendering the model to the output</param>
        /// <returns>Async task</returns>
        public override async Task WriteModelAsync(Func<Task> writeContentActionAsync)
        {
            Writer = new StreamWriter(CurrentFile);
            IsInProgress = true;

            await writeContentActionAsync.Invoke();

            IsInProgress = false;
            Writer?.Dispose();
        }
    }
}


