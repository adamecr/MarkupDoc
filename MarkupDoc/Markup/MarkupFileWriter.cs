using System;
using System.IO;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Markup output single file writer
    /// </summary>
    public class MarkupFileWriter : BaseDisposable, IMarkupWriter
    {
        /// <summary>
        /// Full path to the target output file
        /// </summary>
        public string Target { get; protected set; }
        /// <summary>
        /// Flag whether the output is currently being generated
        /// </summary>
        public bool IsInProgress { get; protected set; }
        /// <summary>
        /// Underlying <see cref="StreamWriter"/> used to write the output to the file.
        /// </summary>
        protected StreamWriter Writer { get; set; }

        /// <summary>
        /// Disposes the markup writer - flush the output, close the output file and dispose the underlying stream writer
        /// </summary>
        protected override void DisposeManaged()
        {
            Writer?.Flush();
            Writer?.Close();
            Writer?.Dispose();
            base.DisposeManaged();
        }

        /// <summary>
        /// Sets the target of the markdown writer
        /// </summary>
        /// <remarks>
        /// The <see cref="Target"/> is the full path to the output file.
        /// The target can't be set when the output is being generated</remarks>
        /// <param name="fileName">Full path to the file (including the extension) to write the output to</param>
        /// <returns>True when the target has been set, otherwise false (because the output is in progress)</returns>
        public virtual bool SetTarget(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException(nameof(fileName));
            if (IsInProgress) return false;
            Target = fileName;
            return true;
        }

        /// <summary>
        /// Starts a new split of the output - it's ignored for the single file output
        /// </summary>
        /// <param name="splitName">Name of the split</param>
        public virtual void Split(string splitName)
        {
            //do nothing here
        }

        /// <summary>
        /// Writes the code model to the output
        /// </summary>
        /// <param name="writeContentActionAsync">Function rendering the model to the output</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteModelAsync(Func<Task> writeContentActionAsync)
        {
            using (Writer = new StreamWriter(Target))
            {
                IsInProgress = true;
                await writeContentActionAsync.Invoke();
                IsInProgress = false;
            }
        }

        /// <summary>
        /// Writes the <paramref name="text"/> to the output
        /// </summary>
        /// <param name="text">Text to write</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteAsync(string text)
        {
            if (Writer == null) throw new InvalidOperationException("Writer is not initialized");
            await Writer.WriteAsync(text);
        }

        /// <summary>
        /// Writes the <paramref name="text"/> and a new line to the output
        /// </summary>
        /// <param name="text">Text to write</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteLineAsync(string text = null)
        {
            if (Writer == null) throw new InvalidOperationException("Writer is not initialized");
            if (text == null)
            {
                await Writer.WriteLineAsync();
            }
            else
            {
                await Writer.WriteLineAsync(text);
            }
        }
    }
}
