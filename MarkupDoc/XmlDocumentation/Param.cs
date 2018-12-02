using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;param&gt; element of XML Documentation  Comments
    /// </summary>
    public class Param : ModelElementWithName
    {
        public Param(XElement element) : base(element) { }
    }

}
