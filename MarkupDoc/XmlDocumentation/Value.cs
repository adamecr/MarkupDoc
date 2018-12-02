using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;value&gt; element of XML Documentation  Comments
    /// </summary>
    public class Value : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Value"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Value(XNode element) : base(element) { }
    }
}
