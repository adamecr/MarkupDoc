using System;
using System.IO;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.CodeModel.Builder;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.MsApiDoc;
using net.adamec.dev.markupdoc.Options;

namespace net.adamec.dev.markupdoc
{
    /// <summary>
    /// Main application class - encapsulates the documentation building logic
    /// </summary>
    public class Application
    {
        /// <summary>
        /// Output configuration
        /// </summary>
        public OutputOptions OutputOptions { get; }

        /// <summary>
        /// CTOR with output configuration
        /// </summary>
        /// <param name="outputOptions">Output configuration</param>
        public Application(OutputOptions outputOptions)
        {
            OutputOptions = outputOptions;
        }

        /// <summary>
        /// Runs the documentation building logic
        /// </summary>
        /// <param name="projectFile">Project file of C# project to build the documentation for</param>
        /// <returns>Async task</returns>
        public async Task RunAsync(string projectFile)
        {
            if (string.IsNullOrEmpty(projectFile)) throw new ArgumentNullException(nameof(projectFile));
            if (!File.Exists(projectFile)) throw new ArgumentException($"Project file {projectFile} doesn't exist");

            var projectDir = new FileInfo(projectFile).DirectoryName;
            if (projectDir == null) throw new Exception($"Can't get the project directory from {projectFile}");

            //Read MS API local documentation to get the links to MS API online documentation
            MsApiDocEngine.ReadLocalDoc();

            //Build code model
            var root = await ModelBuilder.BuildFromProjectSourcesAsync(projectFile);

            //Prepare for the output
            var targetBase = OutputOptions.Target; //full name w/o extension
            if (string.IsNullOrEmpty(targetBase)) targetBase = Path.Combine(projectDir, "doc"); //if not set, proj dir will be used and file doc.html/doc.md

            var targetDir = new FileInfo(targetBase).DirectoryName;
            var targetFileBase = new FileInfo(targetBase).Name;

            if (OutputOptions.SplitNs) root.ProcessingInfo.SplitFileType = SplitTypeEnum.Namespace;
            if (OutputOptions.SplitType) root.ProcessingInfo.SplitFileType = SplitTypeEnum.Type;

            root.ProcessingInfo.BaseMainFile = targetFileBase;

            //Generate markup outputs
            if (OutputOptions.Markdown)
            {
                var writer = new MarkupGenerator(
                    // ReSharper disable once AssignNullToNotNullAttribute
                    Path.Combine(targetDir, $"{targetFileBase}.{OutputOptions.MarkdownExtension}"), root,
                    new MarkdownMarkupProvider(OutputOptions));
                await writer.WriteModelAsync(OutputOptions.Title);
            }

            if (OutputOptions.Html)
            {
                var writer = new MarkupGenerator(
                    // ReSharper disable once AssignNullToNotNullAttribute
                    Path.Combine(targetDir, $"{targetFileBase}.{OutputOptions.HtmlExtension}"), root,
                    new HtmlMarkupProvider(OutputOptions));

                await writer.WriteModelAsync(OutputOptions.Title);
            }
        }
    }
}
