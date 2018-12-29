using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.AddOns;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.CodeModel.Builder;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.MsApiDoc;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils;

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

            //Prepare add-ons
            var addOns = GetAddOns();

            //Build code model
            var root = await ModelBuilder.BuildFromProjectSourcesAsync(projectFile,addOns);

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

        /// <summary>
        /// Initialize add-ons
        /// </summary>
        /// <returns>List of add-ons to be used</returns>
        protected virtual IEnumerable<IAddOn> GetAddOns()
        {
            if (!OutputOptions.EnableAddOns) return null;

            var addOnInterface = typeof(IAddOn);
            var addOnClasses =
                AppDomain.CurrentDomain
                    .GetAssemblies()
                    .SelectMany(x => x.GetTypes())
                    .Where(t => 
                        t.IsClass &&
                        !t.IsAbstract &&
                        addOnInterface.IsAssignableFrom(t) && 
                        t.GetInterfaces().Contains(addOnInterface))
                    .ToList();
            if (addOnClasses.Count == 0) return null;

            var addOns = new List<IAddOn>();
            foreach (var addOnClass in addOnClasses)
            {
                var ctor = addOnClass.GetConstructor(new[] {typeof(OutputOptions)});
                if (ctor == null)
                {
                    ConsoleUtils.WriteErrWarn($"Can't find the add-on CTOR for {addOnClass.Name} having single OutputOptions parameter");
                    continue;
                }

                try
                {
                    var addOn = (IAddOn)Activator.CreateInstance(addOnClass, OutputOptions);
                    addOns.Add(addOn);
                }
                catch (Exception ex)
                {
                    ConsoleUtils.WriteErrWarn($"Can't create instance of add-on {addOnClass.Name} - {ex.Message}");
                }
            }

            return addOns.Count > 0 ? addOns : null;

        }
    }
}
