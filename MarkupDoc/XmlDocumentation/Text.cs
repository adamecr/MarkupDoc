using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing text node (content) of XML Documentation Comments
    /// </summary>
    public class Text : ModelElement
    {
        public string Content { get; }

        /// <summary>
        /// Initialize <see cref="Text"/> instance from XML Documentation Comments node
        /// (element content or it's part when child elements are in place)
        /// </summary>
        /// <param name="text"><see cref="XText"/> node of XML Documentation Comments</param>
        public Text(XText text):base(text)
        {
            Content = text.Value;
            Kind = "Text";
        }

        /// <summary>
        /// Gets the fully trimmed text content (part) of the XML Documentation Comment
        /// </summary>
        /// <returns>Fully trimmed text content (part) of the XML Documentation Comment</returns>
        public override string ToString()
        {
            return Content.TrimAndMergeLines();
        }

        /// <summary>
        /// Renders the <see cref="Text"/> content to string
        /// </summary>
        /// <remarks>
        /// The text content is by default fully trimmed meaning that the inner line breaks are replaced by spaces
        /// and leading and ending spaces and line breaks are cut out.
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered text content of element in XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            return markupProvider.Text(trim ? Content.TrimAndMergeLines() : Content);
        }
    }

}
