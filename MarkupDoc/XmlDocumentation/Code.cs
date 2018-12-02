using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;code&gt; element of XML Documentation Comments
    /// </summary>
    public class Code : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Code"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Code(XNode element) : base(element) { }

        /// <summary>
        /// Renders the <see cref="Code"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Gets not-trimmed content of the tag and renders it using <see cref="IMarkupProvider.Code"/>.
        /// Replaces the line breaks within the output with <see cref="ModelElement.TagKeepLineBreak"/> pseudo-tag and
        /// spaces with <see cref="ModelElement.TagKeepSpace"/> pseudo-tag to preserve the whitespace when the
        /// parent element is to be rendered (and its content trimmed)
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of &lt;code&gt; element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            var content = base.RenderElement(markupProvider, member, false); //don't trim spaces for code.Text
            content = content.Trim('\n').Trim('\r').TrimEnd().Trim('\n').Trim('\r'); //ensure "just code" without leading/ending line breaks and ending spaces
            content = markupProvider.Code(content);
            content = content
                .Replace("\r\n", TagKeepLineBreak)
                .Replace("\r", TagKeepLineBreak)
                .Replace("\n", TagKeepLineBreak)
                .Replace(" ", TagKeepSpace); //preserve whitespaces

            return content;
        }
    }
}
