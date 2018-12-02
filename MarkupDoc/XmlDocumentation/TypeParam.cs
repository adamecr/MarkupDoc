using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;typeparam&gt; element of XML Documentation Comments
    /// </summary>
    public class TypeParam : ModelElementWithName
    {
        /// <summary>
        /// Initialize <see cref="TypeParam"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public TypeParam(XElement element) : base(element) { }
    }
}
