using System;
using System.IO;

namespace net.adamec.dev.markupdoc.Utils
{
    /// <summary>
    /// File path utilities
    /// </summary>
    public class PathUtils
    {
        /// <summary>
        /// Gets the relative path of the source file with the project root as a base
        /// </summary>
        /// <remarks>
        /// Returns substring of the <paramref name="sourceFile"/> with removed starting part of <paramref name="projectRoot"/> for standard source files within the project.
        /// When a source-only package is consumed, the source file is physically in .nuget package dir and in <c>App_Packages</c> virtual dir in project.
        /// It looks for the "signature" <c>contentFiles\\cs\\any\\App_Packages\\</c> of the source-only package, get's the path relative to package and prefixes it with <c>App_Packages</c>.
        /// For any other files (not really have a case for it), just the file name is returned.
        /// </remarks>
        /// <param name="sourceFile">Full path to the source file</param>
        /// <param name="projectRoot">Full path to the project root directory</param>
        /// <returns>Relative path of the source file with the project root as a base</returns>
        public static string GetRelativeSourceFile(string sourceFile, string projectRoot)
        {
            //standard file within project
            if (sourceFile.StartsWith(projectRoot))
            {
                return sourceFile.Substring(projectRoot.Length + 1);
            }

            //source only package - do it "App_Packages\....."
            const string sourceOnlyPackageLocation = "contentFiles\\cs\\any\\App_Packages\\";
            // ReSharper disable once InvertIf
            if (sourceFile.Contains(sourceOnlyPackageLocation))
            {
                var idx = sourceFile.IndexOf(sourceOnlyPackageLocation, StringComparison.InvariantCulture);
                idx += sourceOnlyPackageLocation.Length;
                return "App_Packages\\" + sourceFile.Substring(idx);
            }

            //another file (maybe link) - return just file name
            return new FileInfo(sourceFile).Name;
        }
    }
}
