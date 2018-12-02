using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;summary&gt; element of XML Documentation Comments
    /// </summary>
    public class Summary : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Summary"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Summary(XNode element) : base(element) { }
    }
}
