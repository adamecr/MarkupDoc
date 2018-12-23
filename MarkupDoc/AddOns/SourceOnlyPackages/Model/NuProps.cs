using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model
{
    /// <summary>
    /// Metadata defining the source-only NuGet packages generated from the source code using the customized build process
    /// </summary>
    /// <remarks>
    /// Source-only NuGet packages contain just the source code that is added to the project the package is added to.
    /// The package is created from the (partial) class or classes in the project folder based on the metadata provided as special XML Documentation Comments.
    /// <list type="bullet">
    /// <item><term>&lt;NuProp.Id&gt;&lt;/NuProp.Id&gt;</term><description>package ID (mandatory)</description></item> 
    /// <item><term>&lt;NuProp.Version&gt;&lt;/NuProp.Version&gt;</term><description>package version base (major.minor.patch) - optional</description></item>     
    /// <item><term>&lt;NuProp.Description&gt;&lt;/NuProp.Description&gt;</term><description>package description (optional)</description></item>     
    /// <item><term>&lt;NuProp.Tags&gt;&lt;/NuProp.Tags&gt;</term><description>package tags (optional)</description></item> 
    /// <item><term>&lt;NuProp.Includes type = ""  /&gt;</term><description>file includes (optional). If type="Folder", the package will include all compile files in folder, if type="FolderRecursive" the subfolders will be also included</description></item>       
    /// <item><term>&lt;NuProp.Using id = "" version=""/&gt;</term><description>package imports (optional). Version is optional</description></item>     
    /// <item><term>&lt;NuProp.Needs id="" /&gt;</term><description>"external" imports needed (optional) - not included in package, just info when consuming!!!</description></item>     
    /// </list>
    /// </remarks>
    public class NuProps
    {
        /// <summary>
        /// Metadata from &lt;NuProp.Using id = "" version=""/&gt; XML documentation comment
        /// </summary>
        public class NuPropUsing
        {
            /// <summary>
            /// Unique ID of the package
            /// </summary>
            public string PackageId { get; }
            /// <summary>
            /// Optional version of the package
            /// </summary>
            public string PackageVersion { get; }

            /// <summary>
            /// CTOR
            /// </summary>
            /// <param name="packageId">Unique ID of the package</param>
            /// <param name="packageVersion">Optional version of the package</param>
            public NuPropUsing(string packageId, string packageVersion)
            {
                PackageId = packageId;
                PackageVersion = packageVersion;
            }
        }

        /// <summary>
        /// Definition of the additional files to include into the source-only package
        /// </summary>
        public enum IncludesTypeEnum
        {
            /// <summary>
            /// Don't include any other files (only the file defining the source-only package will be included)
            /// </summary>
            None,
            /// <summary>
            /// Include all compilation files from the same folder where the file defining the source-only package is stored
            /// </summary>
            Folder,
            /// <summary>
            /// Include all compilation files from the same folder where the file defining the source-only package is stored and the subfolders
            /// </summary>
            FolderRecursive
        }

        /// <summary>
        /// Master flag whether the <see cref="NuProps"/> class containts the valid metadata for source-only package
        /// </summary>
        public bool HasNuProps { get; }
        /// <summary>
        /// Full path to the file declaring the source-only package (containing the package metadata as &lt;NuProp.xxxx/&gt; XML documentation comments
        /// </summary>
        public string DeclaringFile { get; }
        /// <summary>
        /// List of all files to be included into the source-only package
        /// </summary>
        public IReadOnlyList<string> PackageFiles { get; }
        /// <summary>
        /// Unique ID of the package
        /// </summary>
        public string PackageId { get; }
        /// <summary>
        /// Optional version of the package. 
        /// </summary>
        /// <remarks>If not defined, the custom build process uses the solution version information</remarks>
        public string PackageVersion { get; }
        /// <summary>
        /// Optional description of the package
        /// </summary>
        /// <remarks>If not defined, the custom build process uses the default generic description</remarks>
        public string PackageDescription { get; }
        /// <summary>
        /// Optional package tags divided by space
        /// </summary>
        public string PackageTags { get; }
        /// <summary>
        /// Definition of the additional files to include into the source-only package
        /// </summary>
        public IncludesTypeEnum IncludesType { get; } = IncludesTypeEnum.None;

        /// <summary>
        /// List of the dependencied that are to be declared within the package
        /// </summary>
        public IReadOnlyList<NuPropUsing> Usings { get; }

        /// <summary>
        /// List of external references (NuGet package dependencies) that are not declared in the package, but the consumer has to include
        /// </summary>
        public IReadOnlyList<string> ExternalReferences { get; }

        /// <summary>
        /// CTOR - Checks the compilation file with given <paramref name="fileName"/> for the source-only package metadata.
        /// When the metadata are present and valid, the <see cref="NuProps"/> object is initialized and <see cref="HasNuProps"/> property is set to true
        /// </summary>
        /// <param name="fileName">Full path to the compliation file</param>
        /// <param name="allFiles">List of all files in compilation, used to resolve the includes (Folder, FolderRecursive) when needed</param>
        public NuProps(string fileName, IReadOnlyCollection<string> allFiles)
        {
            if (allFiles == null || allFiles.Count < 1) return;
            if (string.IsNullOrEmpty(fileName) || !File.Exists(fileName))
            {
                ConsoleUtils.WriteErrWarn($"Initialize NuProps with empty of non existing file {fileName}");
                return;
            }

            //Get the NuProps from XML Documentation Comments <NuProp.xxxx>
            var sourceContent = File.ReadAllText(fileName);
            var sourceLines = sourceContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //Extract all comments
            var stringBuilder = new StringBuilder();
            foreach (var contentLine in sourceLines)
            {
                var sourceLine = contentLine.Trim();
                if (sourceLine.StartsWith("///"))
                {
                    stringBuilder.AppendLine(sourceLine.Substring(3));
                }
            }
            //Get all comments in single XML - encapsulate the whole bunch with dummy tag "doc" allowing the XDocument to parse it
            var xmlDocumentationComments = "<doc>" + stringBuilder + "</doc>";

            if (string.IsNullOrEmpty(xmlDocumentationComments)) return;
            var xDoc = XDocument.Parse(xmlDocumentationComments);
            var nuPropElements = xDoc.Descendants()
                .Where(n => n is XElement e && e.Name.LocalName.StartsWith("NuProp.")).ToList();
            if (nuPropElements.Count <= 0) return; //no NuProps - continue with the next file

            //Get package ID
            PackageId = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Id")?.Value.Trim();
            if (string.IsNullOrEmpty(PackageId))
            {
                ConsoleUtils.WriteErrWarn($"NuProp.Id not found for {fileName}");
                return;
            }

            //Get package metadata
            PackageVersion = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Version")?.Value.Trim();
            PackageDescription = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Description")?.Value.Trim();
            PackageTags = nuPropElements.FirstOrDefault(e => e.Name.LocalName == "NuProp.Tags")?.Value.Trim();

            var nuPropIncludesStr = nuPropElements
                  .FirstOrDefault(e => e.Name.LocalName == "NuProp.Includes" && e.Attribute("type")?.Value != null)?
                  .Attribute("type")?.Value;
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (nuPropIncludesStr)
            {
                case "Folder": IncludesType = IncludesTypeEnum.Folder; break;
                case "FolderRecursive": IncludesType = IncludesTypeEnum.FolderRecursive; break;
            }

            var nuPropUsings = nuPropElements.Where(e => e.Name.LocalName == "NuProp.Using" && e.Attribute("id")?.Value != null).ToList();
            if (nuPropUsings.Count > 0)
            {
                var usings = new List<NuPropUsing>();
                Usings = usings;
                //have some dependencies
                foreach (var nuPropUsing in nuPropUsings)
                {
                    // ReSharper disable once PossibleNullReferenceException - should not be null based on Where clause for nuPropUsings
                    var depId = nuPropUsing.Attribute("id").Value;
                    var depVersion = nuPropUsing.Attribute("version")?.Value;
                    usings.Add(new NuPropUsing(depId, depVersion));
                }
            }

            var nuPropNeeds = nuPropElements.Where(e => e.Name.LocalName == "NuProp.Needs" && e.Attribute("id")?.Value != null).ToList();
            if (nuPropNeeds.Count > 0)
            {
                var externalReferences = new List<string>();
                ExternalReferences = externalReferences;
                //have some dependencies
                foreach (var nuPropNeed in nuPropNeeds)
                {
                    // ReSharper disable once PossibleNullReferenceException - should not be null based on Where clause for nuPropNeeds
                    externalReferences.Add(nuPropNeed.Attribute("id").Value);
                }
            }

            //Get all package files (processing the includes when applicable)
            var packageFiles = new List<string>();
            PackageFiles = packageFiles;
            packageFiles.Add(fileName);
            if (IncludesType != IncludesTypeEnum.None)
            {
                var mainItemDir = new FileInfo(fileName).DirectoryName;
                if (mainItemDir != null)
                {
                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (IncludesType)
                    {
                        case IncludesTypeEnum.Folder:
                            packageFiles.AddRange(allFiles.Where(itm => new FileInfo(itm).DirectoryName == mainItemDir && itm != fileName));
                            break;
                        case IncludesTypeEnum.FolderRecursive:
                            packageFiles.AddRange(allFiles.Where(itm => itm.StartsWith(mainItemDir) && itm != fileName));
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }

            DeclaringFile = fileName;
            //It's valid source-only package definition (metadata)
            HasNuProps = true;
        }
    }
}
