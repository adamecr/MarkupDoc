using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;seealso&gt; element of XML Documentation Comments
    /// </summary>
    public class SeeAlso : ModelElementWithCrefSimple
    {
        /// <summary>
        /// Initialize <see cref="SeeAlso"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public SeeAlso(XElement element) : base(element) { }

    }
}
