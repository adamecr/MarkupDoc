using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils;
using Path = System.IO.Path;

namespace net.adamec.dev.markupdoc.MsApiDoc
{
    /// <summary>
    /// Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members.
    /// </summary>
    /// <remarks>
    /// The Roslyn compiler uses the member ID in <see cref="Microsoft.CodeAnalysis.ISymbol.GetDocumentationCommentId "/>,
    /// (even if there is no documentation), so it's possible to use such ID as member identifier for types, properties, methods, etc.
    /// Method <see cref="ReadLocalDoc"/> uses  the local clone of .NET API documentation (https://github.com/dotnet/dotnet-api-docs)
    /// and checks for the framework index file containing the list of available IDs. It generates the links for each ID and store it in the
    /// internal dictionary(ID,link) telling "these IDs are documented at MS site and these are the links" .
    ///<para>
    /// The links can be retrieved using the static methods <see cref="GetLink(string)"/> by ID or <see cref="GetLink(TypeRef)"/> by <see cref="TypeRef"/>.
    /// It checks, whether the ID exists in local MS documentation clone and if positive, it uses the generated link stored in internal dictionary.
    /// When the local clone is not available (or it's use is suppressed), the engine will try to build the links based on the namespace and name of member for limited set of members.
    /// </para>
    /// <para>
    /// Note: The links are created based on the "observation" how they are composed at the MS API site, so it's best effort approach and
    /// the links are not granted to be hundred percent correct. Also the API Browser don't have the pages/anchors for constants (including the enum items),
    /// so the generated links will not work in this case.
    ///</para>
    /// <para>
    /// The behavior of engine can be configured using the <see cref="MsApiDocOptions"/> configuration class
    /// </para>
    /// <para>
    /// To get the best results, clone the .NET API documentation from https://github.com/dotnet/dotnet-api-docs to local directory. And configure the engine
    /// </para>
    /// <list type="bullet">
    /// <item><term>LinkToApi</term><description>Set to <c>true</c>, to allow the links to MS Api (if false, no links will be created at all)</description></item>
    /// <item><term>ApiBaseUrl</term><description>It's set to https://docs.microsoft.com/en-us/dotnet/api/. As far as there is no change at MS side, no need to configure. Note: The URL must end with "/".</description></item>
    /// <item><term>RequireLocalDoc</term><description>Set to <c>true</c> to minimize the false links. Note: set to <c>false</c> allowing the engine to try to create the links even if not found in local documentation</description></item>
    /// <item><term>LocalDocDir</term><description>Path to the local clone of MS documentation (directory must contain <c>xml\FrameworksIndex</c> subdirectory</description></item>
    /// </list>
    /// </remarks>
    public class MsApiDocEngine
    {
        public static string BaseUrl { get; private set; }
        /// <summary>
        /// ID to Link read-only dictionary for items read from local clone of MS .NET API documentation
        /// </summary>
        public static IReadOnlyDictionary<string, string> IdToLinkDictionary => IdToLinkDictionaryPrivate;
        /// <summary>
        /// Internal ID to Link dictionary for items read from local clone of MS .NET API documentation
        /// </summary>
        private static Dictionary<string, string> IdToLinkDictionaryPrivate { get; } = new Dictionary<string, string>();

        /// <summary>
        /// Retrieves the link to MS API online documentation based on the member <paramref name="id"/> (documentation ID)
        /// </summary>
        /// <param name="id">Member (type, method, property, etc.) ID as used in documentation comments</param>
        /// <returns>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</returns>
        public static string GetLink(string id)
        {
            var options = Configuration.Retrieve<MsApiDocOptions>();
            return options.LinkToApi && IdToLinkDictionaryPrivate.TryGetValue(id, out var link) ? BaseUrl+ link : null;
        }

        /// <summary>
        /// Retrieves the link to MS API online documentation based on the <paramref name="typeRef"/>.
        ///</summary>
        /// <remarks>
        /// As the query is based on the <see cref="TypeRef"/>, it's applicable to types only (the meaning of "type" includes interfaces, structures, delegates, etc.).
        /// In this case, the links can be also created based on the namespace and name when the local doc is not available or the item has not been found  in the
        /// internal dictionary. This can be suppressed by setting the configuration option <c>RequireLocalDoc</c> to true.
        /// </remarks>
        /// <param name="typeRef">Type reference to get the link for</param>
        /// <returns>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</returns>
        public static string GetLink(TypeRef typeRef)
        {
            if (typeRef == null) throw new ArgumentNullException(nameof(typeRef));

            var options = Configuration.Retrieve<MsApiDocOptions>();
            if (!options.LinkToApi) return null;

            if (IdToLinkDictionaryPrivate.TryGetValue(typeRef.DocumentationId??"", out var link)) return BaseUrl+link;
            if (options.RequireLocalDoc) return null;

            if (typeRef.Namespace != "System" &&
                !typeRef.Namespace.StartsWith("System.") &&
                typeRef.Namespace != "Microsoft" &&
                !typeRef.Namespace.StartsWith("Microsoft.")) return null;

            var msLink = BaseUrl;
            msLink +=
                $"{typeRef.Namespace.ToLower()}.{(typeRef.GenericArity == 0 ? typeRef.Name : typeRef.GenericBaseName + "-" + typeRef.GenericArity).ToLower()}";
            return msLink;
        }

        /// <summary>
        /// Reads the local clone of MS .NET API documentation and builds the internal dictionary of member IDs and links to MS online API documentation
        /// </summary>
        /// <remarks>
        /// Path to the local clone od MS documentation is taken from configuration <see cref="MsApiDocOptions.LocalDocDir"/>.
        /// Directory must contain <c>xml\FrameworksIndex</c> subdirectory. This directory contains the indexes for different frameworks (.NET frameworks, .NET standard, ...).
        /// For the simplicity, the biggest index (XML) file is used as a source. The index file contains records like
        /// <code>
        ///  &lt;Namespace Name="Microsoft.CSharp"&gt;
        ///      &lt;Type Name = "Microsoft.CSharp.CSharpCodeProvider" Id="T:Microsoft.CSharp.CSharpCodeProvider"&gt;
        ///         &lt;Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.#ctor" /&gt;
        ///         &lt;Member Id="M:Microsoft.CSharp.CSharpCodeProvider.#ctor(System.Collections.Generic.IDictionary{System.String,System.String})" /&gt;
        ///         &lt;Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.CreateCompiler" /&gt;
        ///         &lt;Member Id="M:Microsoft.CSharp.CSharpCodeProvider.CreateGenerator" /&gt;
        ///         &lt;Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.GenerateCodeFromMember(System.CodeDom.CodeTypeMember,System.IO.TextWriter,System.CodeDom.Compiler.CodeGeneratorOptions)" /&gt;
        ///         &lt;Member Id="M:Microsoft.CSharp.CSharpCodeProvider.GetConverter(System.Type)" /&gt;
        ///         &lt;Member Id = "P:Microsoft.CSharp.CSharpCodeProvider.FileExtension" /&gt;
        ///      &lt;/Type &gt;
        ///  &lt;/Namespace &gt;
        /// </code>
        /// The method gets all type and (type) member ID and generates the links for them. The links are created based on the "observation" how they are composed at the MS API site, so it's best effort approach and
        /// the links are not granted to be hundred percent correct. The base URL is set in <see cref="MsApiDocOptions.ApiBaseUrl"/> (the base URL must end with "/").
        /// </remarks>
        /// <returns>True when the local documentation has been read, otherwise false (the errors are "soft" - provided to console standard output as warnings)</returns>
        public static bool ReadLocalDoc()
        {
            var options = Configuration.Retrieve<MsApiDocOptions>();
            var baseDirectory = options.LocalDocDir;
            BaseUrl = options.ApiBaseUrl;

            if (!Directory.Exists(baseDirectory))
            {
                ConsoleUtils.WriteWarn($"Read MS API LocalDoc: can't find the base directory {baseDirectory}");
                return false;
            }
            var indexDir = Path.Combine(baseDirectory, @"xml\FrameworksIndex");

            if (!Directory.Exists(indexDir))
            {
                ConsoleUtils.WriteWarn($"Read MS API LocalDoc: can't find the index directory {indexDir}");
                return false;
            }

            var files = new DirectoryInfo(indexDir).GetFiles("*.xml", SearchOption.AllDirectories).ToList();
            var indexFile = files.OrderByDescending(f => f.Length).FirstOrDefault();
            if (indexFile == null)
            {
                ConsoleUtils.WriteWarn($"Read MS API LocalDoc: can't find the index file in {indexDir}");
                return false;
            }

            ConsoleUtils.WriteInfo($"Read MS API LocalDoc: reading {indexFile.FullName}");
            var xDoc = XDocument.Load(indexFile.FullName);
            var types = xDoc.Descendants("Type").ToArray();

            ConsoleUtils.WriteInfo($"Read MS API LocalDoc: processing the types - {types.Length} types to process");

            IdToLinkDictionaryPrivate.Clear();
            foreach (var typeElement in types)
            {
                var typeIdFull = typeElement.Attribute("Id")?.Value;
                if (typeIdFull == null) continue;

                var typeId = typeIdFull.Substring(2);
                var typeLink = Regex.Replace(typeId, "[^a-zA-Z0-9._]", "-").ToLower(); //replace non-alphanum (keep . and _) with "-" and to lowercase
                IdToLinkDictionaryPrivate.Add(typeIdFull,  typeLink);

                var typeMemberIds = typeElement.Descendants("Member").Attributes("Id").Select(a => a.Value).ToList();
                foreach (var memberIdFull in typeMemberIds)
                {
                    var memberId = memberIdFull.Substring(2);
                    var memberIdShort = memberId.Substring(typeId.Length + 1); //member name w/o type
                    var memberLink = typeLink + "." + TypeMemberBaseName(memberIdShort).ToLower(); //actually the link is the "base" name (lowercase) of the member added to type

                    var memberAnchor = Regex.Replace(memberId, "[^a-zA-Z0-9]", "_"); //anchor is whole ID (w/o "tag") with non-alphanum replaced by "_"
                    IdToLinkDictionaryPrivate.Add(memberIdFull, memberLink + "#" + memberAnchor);
                }
            }
            ConsoleUtils.WriteInfo($"Read MS API LocalDoc: finished - {IdToLinkDictionary.Count} records generated");

            return true;
        }

        /// <summary>
        /// Extracts the base name for the type member.
        /// </summary>
        /// <remarks>
        /// Single member page can contain multiple overloads, so it's necessary to extract the base name that will be used as a part of the link.
        /// The particular overload is then identified by anchor.
        /// </remarks>
        /// <param name="str">Name of the type member</param>
        /// <returns>Base name for the type member</returns>
        private static string TypeMemberBaseName(string str)
        {
            var o = "";
            foreach (var c in str)
            {
                if (char.IsLetterOrDigit(c) ||
                    c == '_' || c == '#' || c == '<' || c == '>' || c == ',') //"non-breakers" - these character can be part of the base ne
                {

                    o += c != '#' && c != '<' && c != '>' && c != ',' ? c : '-'; //characters in condition and not "breakers", but is replaced by "-"
                }
                else
                {
                    return o; //character is "breaker", so we are at the end of the base name. Typical "breaker" is '('
                }
            }
            return o;
        }
    }
}
