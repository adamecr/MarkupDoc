using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.CodeModel.Builder;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages
{
    /// <summary>
    /// Output generator add-on for documenting the source-only packages
    /// </summary>
    public class SourceOnlyPackagesAddOn : IAddOn
    {
        /// <summary>
        /// Output configuration
        /// </summary>
        public OutputOptions OutputOptions { get; }

        /// <summary>
        /// List of source-only packages' properties
        /// </summary>
        public IReadOnlyList<NuProps> SourceOnlyPackages { get; private set; }

        /// <summary>
        /// Dictionary of source-only packages by member
        /// </summary>
        public IReadOnlyDictionary<Member, List<NuProps>> SourceOnlyPackagesByMember { get; private set; }

        /// <summary>
        /// Dictionary of members by source-only package
        /// </summary>
        public IReadOnlyDictionary<NuProps, List<Member>> MembersBySourceOnlyPackage { get; private set; }

        /// <summary>
        /// CTOR - initialize add-on
        /// </summary>
        /// <param name="outputOptions">Output options</param>
        public SourceOnlyPackagesAddOn(OutputOptions outputOptions)
        {
            OutputOptions = outputOptions;
            ConsoleUtils.WriteInfo("SourceOnlyPackagesAddOn initialized");
        }

        /// <summary>
        /// Add-on priority for processing the add-on data as a part of <see cref="RootMember"/> constructor.
        /// SourceOnlyPackagesAddOn priority is 1
        /// </summary>
        public int PriorityRootData => 1;

        /// <summary>
        /// Let the add-on to prepare it's own data as a part of <see cref="RootMember"/> constructor.
        /// </summary>
        /// <remarks>
        /// The add-on checks all compilation files for the &lt;NuProp.xxx&gt; comments with source-only package metadata
        /// and builds the list of source-only packages and the indexes between the packages and code model members.
        /// </remarks>
        /// <param name="root">Code model root</param>
        /// <param name="builder">Code model buildel root</param>
        public void ProcessRootData(RootMember root, RootMemberBuilder builder)
        {
            ConsoleUtils.WriteInfo("SourceOnlyPackagesAddOn preparing data...");
            //Get source-only packages info
            var packages = new List<NuProps>();
            SourceOnlyPackages = packages;
            var sourceOnlyPackagesByMember = new Dictionary<Member, List<NuProps>>();
            SourceOnlyPackagesByMember = sourceOnlyPackagesByMember;
            var membersBySourceOnlyPackage = new Dictionary<NuProps, List<Member>>();
            MembersBySourceOnlyPackage = membersBySourceOnlyPackage;
            foreach (var compilationFile in builder.CompilationFiles)
            {
                var nuProps = new NuProps(compilationFile, builder.CompilationFiles);
                if (!nuProps.HasNuProps) continue;
                packages.Add(nuProps);

                //add members to indexes
                foreach (var packageFile in nuProps.PackageFiles)
                {
                    if (!root.AllMembersBySourceFile.TryGetValue(packageFile, out var packageMembers)) continue;
                    foreach (var packageMember in packageMembers)
                    {
                        if (!sourceOnlyPackagesByMember.TryGetValue(packageMember, out var packagesForMember))
                        {
                            packagesForMember = new List<NuProps>();
                            sourceOnlyPackagesByMember.Add(packageMember, packagesForMember);
                        }
                        packagesForMember.Add(nuProps);

                        if (!membersBySourceOnlyPackage.TryGetValue(nuProps, out var membersForPackage))
                        {
                            membersForPackage = new List<Member>();
                            membersBySourceOnlyPackage.Add(nuProps, membersForPackage);
                        }
                        membersForPackage.Add(packageMember);
                    }
                }
            }
            ConsoleUtils.WriteInfo($"SourceOnlyPackagesAddOn finished preparing data - {packages.Count} source only packages found");
        }

        /// <summary>
        /// Add-on priority for generating the add-on output to the (main) index page.
        /// SourceOnlyPackagesAddOn priority is 1
        /// </summary>
        public int PriorityIndexPage => 1;

        /// <summary>
        /// Writes the table of all source-only packages within the code model into the output
        /// </summary>
        /// <param name="root">Code model root</param>
        /// <param name="markup">Markup provider</param>
        /// <returns>True when any output has been generated</returns>
        public async Task<bool> WriteIndexAsync(RootMember root, IMarkupProvider markup)
        {

            if (SourceOnlyPackages == null || SourceOnlyPackages.Count < 1) return false;

            await markup.WriteH2Async("Source-only packages", "package-list");
            await markup.WriteTableHeaderAsync("Name", "Summary");
            foreach (var nuProps in SourceOnlyPackages.OrderBy(p => p.PackageId))
            {
                await markup.WriteTableColsAsync(Link(nuProps.PackageId, nuProps, markup), nuProps.PackageDescription ?? string.Empty);
            }
            await markup.WriteTableFooterAsync();
            return true;
        }

        /// <summary>
        /// Add-on priority for generating the add-on output pages.
        /// SourceOnlyPackagesAddOn priority is 1
        /// </summary>
        public int PriorityOwnPages => 1;

        /// <summary>
        /// Writes the source-only packages pages into the output
        /// </summary>
        /// <param name="root">Code model root</param>
        /// <param name="markup">Markup provider</param>
        /// <param name="generator">Markup generator</param>
        /// <returns>Async task</returns>
        public async Task WriteOwnPagesAsync(RootMember root, IMarkupProvider markup, MarkupGenerator generator)
        {
            if (SourceOnlyPackages == null || SourceOnlyPackages.Count < 1) return;

            if (OutputOptions.SplitNs && !OutputOptions.SplitType)
            {
                //split by Ns only -> all source only packages will be on single page
                await generator.SplitAsync(GetPackagePagesFileName());
            }
            foreach (var nuProps in SourceOnlyPackages.OrderBy(p => p.PackageId))
            {
                if (OutputOptions.SplitType)
                {
                    //split by Type -> each source only packages will be on dedicated page
                    await generator.SplitAsync(GetPackagePageFileName(nuProps));
                }

                await markup.WriteH2Async($"{nuProps.PackageId} Source only package", GetPackageAnchor(nuProps));
                await markup.WriteParaAsync(
                    markup.Small(
                        new Txt()
                            .AddIf($"Version: {nuProps.PackageVersion}", !string.IsNullOrEmpty(nuProps.PackageVersion))
                            .AddIf(markup.LineBreak(), !string.IsNullOrEmpty(nuProps.PackageVersion))
                            .AddIf($"Tags: {nuProps.PackageTags}", !string.IsNullOrEmpty(nuProps.PackageTags))
                            .AddIf(markup.LineBreak(), !string.IsNullOrEmpty(nuProps.PackageTags))
                            .Add($"Includes: {nuProps.IncludesType}")
                            .Add(markup.LineBreak())
                            .Add($"Declaring file: {nuProps.DeclaringFile.Substring(root.ProjectRootDir.Length + 1)}")
                            ));

                await markup.WriteParaAsync(nuProps.PackageDescription);

                if (nuProps.Usings != null && nuProps.Usings.Count > 0)
                {
                    await markup.WriteParaAsync(new Txt()
                        .Add(markup.Bold("Usings"))
                        .Add(markup.DescriptionList(
                            u =>
                            {
                                var refPkg = SourceOnlyPackages.FirstOrDefault(p => p.PackageId == u.PackageId);
                                return refPkg == null ? u.PackageId : Link(u.PackageId, refPkg, markup);
                            },
                            u => string.IsNullOrEmpty(u.PackageVersion) ? string.Empty : $"version: {u.PackageVersion}",
                            nuProps.Usings)));
                }

                if (nuProps.ExternalReferences != null && nuProps.ExternalReferences.Count > 0)
                {
                    await markup.WriteParaAsync(new Txt()
                        .Add(markup.Bold("References needed"))
                        .Add(markup.DescriptionList(
                            er => er,
                            er => string.Empty,
                            nuProps.ExternalReferences)));
                }

                if (MembersBySourceOnlyPackage.TryGetValue(nuProps, out var members) && members.Count > 0)
                {
                    await markup.WriteParaAsync(new Txt()
                        .Add(markup.Bold("Package members"))
                        .Add(markup.DescriptionList(
                            m => markup.Link($"{m.Name} ({m.MemberKind})", m),
                            m => m.Documentation?.GetSummary(m)?.Render(markup, m),
                            members)));
                }
                await markup.WriteParaAsync(new Txt()
                    .Add(markup.Bold("Sources"))
                    .Add(markup.DescriptionList(
                        f => $"{f.Substring(root.ProjectRootDir.Length + 1)}",
                        f => string.Empty,
                        nuProps.PackageFiles)));

                await generator.WritePageFooterAsync();
            }

        }

        /// <summary>
        /// Creates the link to the <see cref="package"/> page
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="package">Package metadata</param>
        /// <param name="markup">Markup provider</param>
        /// <returns>Markup with the link to the <param name="package"></param></returns>
        private string Link(string text, NuProps package, IMarkupProvider markup)
        {
            var fileName = string.Empty;
            if (OutputOptions.SplitNs && !OutputOptions.SplitType)
            {
                fileName = GetPackagePagesFileName();
            }
            if (OutputOptions.SplitType)
            {
                fileName = GetPackagePageFileName(package);
            }

            var extension = markup.Extension;
            return markup.Link(text, string.IsNullOrEmpty(fileName) ? "" : $"{fileName}.{extension}", GetPackageAnchor(package));
        }

        /// <summary>
        /// Returns the anchor for given <see cref="package"/> within the package page(s) file.
        /// </summary>
        ///<param name="package">Package metadata</param>    
        /// <returns>Anchor for given <see cref="package"/> within the package page(s) file</returns>
        private string GetPackageAnchor(NuProps package)
        {
            return $"src-only-package--{package.PackageId}";
        }

        /// <summary>
        /// Returns the name of the generated file (without extension) for <see cref="package"/> when the split by type is set, so the all package pages are generated into dedicated files.
        /// </summary>
        ///<param name="package">Package metadata</param>    
        /// <returns>The name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into dedicated files</returns>
        private string GetPackagePageFileName(NuProps package)
        {
            return $"src-only-package--{package.PackageId}";
        }

        /// <summary>
        /// Returns the name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into single file.
        /// </summary>
        /// <returns>The name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into single file</returns>
        private string GetPackagePagesFileName()
        {
            return $"src-only-packages--";
        }

        /// <summary>
        /// Add-on priority for generating the add-on output to header of code model member page header.
        /// SourceOnlyPackagesAddOn priority is 1
        /// </summary>
        public int PriorityPageHeader => 1;

        /// <summary>
        /// Writes the header for the code model member
        /// </summary>
        /// <remarks>Writes source-only packages list if available</remarks>
        /// <param name="member">Member being documented</param>
        /// <param name="markup">Markup provider</param>
        /// <returns>String to be added to the header text builder</returns>
        public string WritePageHeader(Member member, IMarkupProvider markup)
        {
            SourceOnlyPackagesByMember.TryGetValue(member, out var packages);
            if (packages == null || packages.Count < 1) return string.Empty;

            return markup.LineBreak() + "Source-only packages: " + string.Join(", ", packages.Select(p => Link(p.PackageId, p, markup)));
        }

        /// <summary>
        /// Add-on priority for generating the add-on output to header of code model member page body.
        /// SourceOnlyPackagesAddOn priority is 0, so no output will be generator to member page body
        /// </summary>
        /// <remarks><see cref="WritePageBodyAsync"/> method is used as a sample only. It's not called as the <see cref="PriorityPageBody"/> is zero</remarks>
        public int PriorityPageBody => 0;

        /// <summary>
        /// Writes the body fro the code model member
        /// </summary>
        /// <remarks>This method is used as a sample only. It's not called as the <see cref="PriorityPageBody"/> is zero</remarks>
        /// <param name="member">Member being documented</param>
        /// <param name="markup">Markup provider</param>
        /// <returns>Async task</returns>
        public async Task WritePageBodyAsync(Member member, IMarkupProvider markup)
        {
            SourceOnlyPackagesByMember.TryGetValue(member, out var packages);
            if (packages == null || packages.Count < 1) return;

            await markup.WriteH3Async("Source-only packages");

            await markup.WriteParaAsync(new Txt()
                .AddEach(p => $"{p.PackageId} - {p.PackageDescription}", packages, markup.LineBreak()));
        }

        /// <summary>
        /// Add-on priority for generating the add-on output to header of code model member page footer.
        /// SourceOnlyPackagesAddOn priority is 1
        /// </summary>
        public int PriorityPageFooter => 1;

        /// <summary>
        /// Writes to the footer for the code model member page
        /// </summary>
        /// <param name="baseFileName">Name of the main file</param>
        /// <param name="markup">Markup provider</param>
        /// <returns>String to be added to the footer</returns>
        public string WritePageFooter(string baseFileName, IMarkupProvider markup)
        {
            if(SourceOnlyPackages!=null && SourceOnlyPackages.Count>0)
                return markup.Link("source-only packages", baseFileName, "package-list");

            return "";
        }
    }
}
