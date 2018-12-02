using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;example&gt; element of XML Documentation Comments
    /// </summary>
    public class Example : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Example"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Example(XNode element) : base(element) { }
    }
}
