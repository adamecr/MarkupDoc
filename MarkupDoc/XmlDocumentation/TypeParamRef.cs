using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;typeparamref&gt; element of XML Documentation Comments
    /// </summary>
    public class TypeParamRef : ModelElementWithName
    {
        /// <summary>
        /// Initialize <see cref="TypeRef"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public TypeParamRef(XElement element) : base(element) { }

        /// <summary>
        /// Renders the <see cref="TypeParamRef"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// When the element has the content (text), the content is rendered, otherwise the <c>name</c> attribute value in bold is rendered.
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of &lt;typeparamref&gt; element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            var content = base.RenderElement(markupProvider, member, trim);
            return !string.IsNullOrEmpty(content) ? content : markupProvider.Bold(Name);
        }
    }

}
