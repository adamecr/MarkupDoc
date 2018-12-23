using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{

    /// <summary>
    /// Class representing the <c>inheritdoc</c>element of XML Documentation Comments
    /// </summary>
    public class Inheritdoc : ModelElementWithCref
    {
        /// <summary>
        /// Initialize <see cref="Inheritdoc"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Inheritdoc(XElement element) : base(element) { }
    }
}
