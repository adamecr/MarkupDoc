using System.Dynamic;

namespace net.adamec.dev.markupdoc.Options
{
    /// <summary>
    /// Output configuration
    /// </summary>
    public class OutputOptions
    {
        /// <summary>
        /// Title of documentation show at the top of each page
        /// </summary>
        public string Title { get; set; } = "Documentation";
        /// <summary>
        /// Output target - full path including file name without extension for single file output, index file without extension for multi-file output
        /// </summary>
        public string Target { get; set; } = "";
        /// <summary>
        /// Flag whether to generate the HTML output
        /// </summary>
        public bool Html { get; set; } = true;
        /// <summary>
        /// Flag whether to generate the Markdown output
        /// </summary>
        public bool Markdown { get; set; }=true;
        /// <summary>
        /// Extension of generated HTML file
        /// </summary>
        public string HtmlExtension { get; set; } = "html";
        /// <summary>
        /// Extension of generated Markdown file
        /// </summary>
        public string MarkdownExtension { get; set; } = "md";
        /// <summary>
        /// Flag whether to split the output per namespace
        /// </summary>
        public bool SplitNs { get; set; } = false;
        /// <summary>
        /// Flag whether to split the output per type. In this case, the split per namespace will also be applied.
        /// </summary>
        public bool SplitType { get; set; } = false;

        /// <summary>
        /// Flag whether to enable AddOns (false by default)
        /// </summary>
        public bool EnableAddOns { get; set; } = false;
    }
}
