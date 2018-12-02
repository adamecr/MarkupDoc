using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;para&gt; element of XML Documentation Comments
    /// </summary>
    public class Para : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Para"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Para(XNode element) : base(element) { }

        /// <summary>
        /// Renders the <see cref="Para"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Gets trimmed content of the tag and renders it using <see cref="IMarkupProvider.Para"/>.
        /// Replaces the line breaks within the output with <see cref="ModelElement.TagKeepLineBreak"/> pseudo-tag
        /// to preserve the line breaks in the markup when the parent element is to be rendered (and its content trimmed)
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of &lt;para&gt; element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            // ReSharper disable once RedundantArgumentDefaultValue
            var content = base.RenderElement(markupProvider, member, true); //always trim the content
            content = markupProvider.Para(content);
            content = content
                .Replace("\r\n", TagKeepLineBreak)
                .Replace("\r", TagKeepLineBreak)
                .Replace("\n", TagKeepLineBreak);//preserve line breaks
            return content;
        }
    }

}
