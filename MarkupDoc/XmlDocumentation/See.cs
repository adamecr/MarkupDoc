using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;see&gt; element of XML Documentation Comments
    /// </summary>
    public class See : ModelElementWithCrefSimple
    {
        /// <summary>
        /// Initialize <see cref="See"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public See(XElement element) : base(element) { }
    }
}
