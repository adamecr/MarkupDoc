using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;remarks&gt; element of XML Documentation Comments
    /// </summary>
    public class Remarks : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="Remarks"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Remarks(XNode element) : base(element) { }
    }
}
