using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.MsApiDoc;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;see&gt; element of XML Documentation Comments
    /// </summary>
    public class See : ModelElementWithCrefSimple
    {
        /// <summary>
        /// langword attribute value
        /// </summary>
        public string Langword { get; }

        /// <summary>
        /// Initialize <see cref="See"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public See(XElement element) : base(element)
        {
            Langword = element?.Attribute("langword")?.Value;
        }

        /// <summary>
        /// Renders the <c>see</c> element - by default the <see cref="ModelElementWithCrefSimple.RenderElement"/> is used.
        /// <c>langword</c> attribute is rendered when the base renders null or empty
        /// </summary>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true) //used  for links
        {
            // ReSharper disable once RedundantArgumentDefaultValue
            var content = base.RenderElement(markupProvider, member, true); //always trim content for links
            if (string.IsNullOrEmpty(content) && !string.IsNullOrEmpty(Langword))
            {
                return markupProvider.InlineCode(Langword);
            }

            return content ?? "";
            
        }
    }
}
