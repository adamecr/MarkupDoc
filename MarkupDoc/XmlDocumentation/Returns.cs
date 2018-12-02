using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;returns&gt; element of XML Documentation Comments
    /// </summary>
    public class Returns : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Returns"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Returns(XNode element) : base(element) { }
    }
}
