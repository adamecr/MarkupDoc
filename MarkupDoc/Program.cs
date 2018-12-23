using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.MsApiDoc;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc
{
    //TODO remove Todo file
    /// <summary>
    /// Main program entry class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Default configuration file name
        /// </summary>
        private const string DefaultConfigFile = "markupdoc.json";

        /// <summary>
        /// Main console application entry point
        /// </summary>
        /// <param name="args">Command line arguments</param>
        private static async Task<int> Main(string[] args)
        {
            if (args.Length < 1)
            {
                ConsoleUtils.WriteErr("Missing project file parameter");
                Help();
                return -1;
            }

            //check help before project file validation 
            var isCmdHelp = args.FirstOrDefault(a => a == "/h" || a == "/help" || a == "/?" || a == "-h" || a == "-help" || a == "-?") != null;
            if (isCmdHelp)
            {
                Help();
                return 1;
            }

            var projectFile = args[0];
            if (!File.Exists(projectFile))
            {
                ConsoleUtils.WriteErr($"Project file {projectFile} not found");
                Help();
                return -1;
            }
            var projectDir = new FileInfo(projectFile).DirectoryName;
            var cmdConfigFile = args.FirstOrDefault(a => a.StartsWith("-c:") || a.StartsWith("/c:"))?.Substring(3);

            try
            {
                //Order:
                //(defaults)       
                //config file at project
                //environment values
                //config file from command line -  
                //command line
                Configuration.Builder()
                    // ReSharper disable once AssignNullToNotNullAttribute - projectDir always exist here
                    .AddJsonFile(Path.Combine(projectDir, DefaultConfigFile), ignoreIfNotExist: true) //ignore if doesn't exist
                    .AddEnvironmentVariables()
                    // ReSharper disable once ArgumentsStyleLiteral
                    .AddJsonFile(cmdConfigFile, ignoreNullOrEmptyFileName: true) //ignore if null <- parameter not provided
                    .AddCommandLineArguments("-p:", "/p:")
                    .Build();

                var outputOptions = Configuration.Bind<OutputOptions>("Output");
                Configuration.Bind<MsApiDocOptions>("MicrosoftApi");
                
                //initialize and run the application
                var app = new Application(outputOptions);
                await app.RunAsync(projectFile);

                return 0;
            }
            catch (Exception e)
            {
                ConsoleUtils.WriteErr($"Critical error during processing: {e.Message}");
                ConsoleUtils.WriteErrWarn(e.StackTrace);
                Console.WriteLine();
                Console.WriteLine("Press enter to close");
                Console.ReadLine();
                return -1;
            }
        }

        /// <summary>
        /// Writes the help to console
        /// </summary>
        public static void Help()
        {
            Console.WriteLine("Generates the markup documentation of C# project code.");
            Console.WriteLine("");
            Console.WriteLine("usage: MarkupDoc <project_file> [<help>] [<config_file>] [<Options>...]");
            Console.WriteLine("");
            Console.WriteLine("Project file");
            Console.WriteLine(" <project_file>");
            Console.WriteLine(" Full path to the C# project file (.csproj) of the project to be documented.");
            Console.WriteLine("");
            Console.WriteLine("Help");
            Console.WriteLine(" /h | /help | /? | -h | -help | -?");
            Console.WriteLine(" Shows this help and don't start any processing.");
            Console.WriteLine(" In this case, the <project_file> may be missing.");
            Console.WriteLine("");
            Console.WriteLine("Config file");
            Console.WriteLine(" -c:<config_file> | /c:<config_file>");
            Console.WriteLine(" Use the options from given configuration JSON file. <config_file> is");
            Console.WriteLine(" the full path of the configuration file.");
            Console.WriteLine("");
            Console.WriteLine("Options");
            Console.WriteLine(" -p:key=value | /p:key=value");
            Console.WriteLine(" Set the processing option(s):");
            Console.WriteLine("  Output.Target=<target>");
            Console.WriteLine("   Full path to the target file without the extension (will be added for");
            Console.WriteLine("   individual markup outputs).");
            Console.WriteLine("   When not provided, the documentation will be generated to the project");
            Console.WriteLine("   directory to the file \"doc.<ext>\".");
            Console.WriteLine("   When splitting the output, the target file is the name of the main");
            Console.WriteLine("   (index) file.");
            Console.WriteLine("");
            Console.WriteLine("  Output.Title=<title>");
            Console.WriteLine("   The title is added to the header of each generated documentation page.");
            Console.WriteLine("   When not provided, the default title \"Documentation\" will be used.");
            Console.WriteLine("");
            Console.WriteLine("  Output.Html[=true] | Output.Html=false");
            Console.WriteLine("   Flag whether to generate the documentation in HTML format.");
            Console.WriteLine("   When not provided, the HTML documentation will be generated.");
            Console.WriteLine("");
            Console.WriteLine("  Output.HtmlExtension=<html_extension>");
            Console.WriteLine("   Extension (without leading dot) of the generated HTML files.");
            Console.WriteLine("   When not provided, \"html\" will be used.");
            Console.WriteLine("");
            Console.WriteLine("  Output.Markdown[=true] | Output.Markdown=false");
            Console.WriteLine("   Flag whether to generate the documentation in Markdown format.");
            Console.WriteLine("   When not provided, the Markdown documentation will be generated.");
            Console.WriteLine("");
            Console.WriteLine("  Output.MarkdownExtension=<markdown_extension>");
            Console.WriteLine("   Extension (without leading dot) of the generated Markdown files.");
            Console.WriteLine("   When not provided, \"md\" will be used.");
            Console.WriteLine("");
            Console.WriteLine("  Output.SplitNs[=true] | Output.SplitNs=false");
            Console.WriteLine("   Flag whether to split the output per namespace.");
            Console.WriteLine("   When not provided, namespace splits will not be generated.");
            Console.WriteLine("");
            Console.WriteLine("  Output.SplitType[=true] | Output.SplitType=false");
            Console.WriteLine("   Flag whether to split the output per type. When splitting per file,");
            Console.WriteLine("   the namespace splits will be also generated.");
            Console.WriteLine("   When not provided, type splits will not be generated.");
            Console.WriteLine("");
            Console.WriteLine("  Output.EnableAddOns[=true] | Output.EnableAddOns=false");
            Console.WriteLine("   Flag whether to enable the add-ons for output generator.");
            Console.WriteLine("");
            Console.WriteLine("  MicrosoftApi.LinkToApi[=true] | MicrosoftApi.LinkToApi=false");
            Console.WriteLine("   Set to true, to allow the links to MS API to be generated to the output.");
            Console.WriteLine("   If false, no \"external\" links will be created at all.");
            Console.WriteLine("   When not provided, the links will to MS API will be generated.");
            Console.WriteLine("");
            Console.WriteLine("  MicrosoftApi.ApiBaseUrl=<base_url>");
            Console.WriteLine("   MS online API documentation base url including the ending slash.");
            Console.WriteLine("   When not provided, https://docs.microsoft.com/en-us/dotnet/api/");
            Console.WriteLine("   is used by default.");
            Console.WriteLine("");
            Console.WriteLine("  MicrosoftApi.RequireLocalDoc[=true] | MicrosoftApi.RequireLocalDoc=false");
            Console.WriteLine("   Set to true to minimize the false links by forcing the use of local");
            Console.WriteLine("   clone of the MS documentation.");
            Console.WriteLine("   Set to false, allowing the engine to try to create the links even if");
            Console.WriteLine("   the type is not found in local documentation.");
            Console.WriteLine("   When not set, the engine will not force the use of local clone.");
            Console.WriteLine("");
            Console.WriteLine("  MicrosoftApi.LocalDocDir=<path>");
            Console.WriteLine("   Path to the local clone of MS documentation (directory must contain");
            Console.WriteLine("   \"xml\\FrameworksIndex\" subdirectory.");
            Console.WriteLine("   When not provided, the warning will be raised and the \"empty\" local");
            Console.WriteLine("   documentation will be used (meaning that no links will be generated");
            Console.WriteLine("   when the MicrosoftApi.RequireLocalDoc is set).");
            Console.WriteLine("");
            Console.WriteLine(" These options can be set in:");
            Console.WriteLine("  (built-in default values)");
            Console.WriteLine("  markupdoc.json file stored in project directory");
            Console.WriteLine("  environment variables");
            Console.WriteLine("  JSON configuration file provided as a command line parameter");
            Console.WriteLine("  Command line options (-p:key=value or /p:key=value)");
            Console.WriteLine("");
            Console.WriteLine("  The lower overwrite the upper ones (meaning that the command line");
            Console.WriteLine("  options have the highest priority).");
            Console.WriteLine("");
            Console.WriteLine("Exit codes: 0=ok, 1=help used, -1=error");
            Console.WriteLine("");
        }
    }
}
