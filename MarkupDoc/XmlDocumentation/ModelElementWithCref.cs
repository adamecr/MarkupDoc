using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Abstract class representing the element of XML Documentation Comments that have the <c>cref</c> attribute
    /// </summary>
    public abstract class ModelElementWithCref : ModelElement
    {
        /// <summary>
        /// cref attribute value
        /// </summary>
        public string Ref { get; }

        /// <summary>
        /// Initialize <see cref="ModelElementWithCref"/> instance from XML Documentation Comments element
        /// Extracts the cref attribute
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        protected ModelElementWithCref(XElement element) : base(element)
        {
            Ref = element?.Attribute("cref")?.Value;
        }

        /// <summary>
        /// Returns the element content as string if <see cref="ModelElementWithCref.Ref"/> when there is no content
        /// </summary>
        /// <returns>The element content as string if <see cref="ModelElementWithCref.Ref"/> when there is no content</returns>
        public override string ToString()
        {
            var content = base.ToString();
            return !string.IsNullOrEmpty(content) ? content : Ref;
        }

    }
}
