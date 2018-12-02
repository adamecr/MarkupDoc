using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Abstract class representing the element of XML Documentation Comments that have the <c>name</c> attribute
    /// </summary>
    public abstract class ModelElementWithName : ModelElement
    {
        /// <summary>
        /// name attribute value
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Initialize <see cref="ModelElementWithName"/> instance from XML Documentation Comments element
        /// Extracts the name attribute
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        protected ModelElementWithName(XElement element) : base(element)
        {
            Name = element?.Attribute("name")?.Value;
        }
    }
}
