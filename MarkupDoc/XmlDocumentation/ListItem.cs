using System.Xml.Linq;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;item&gt; and &lt;listheader&gt; elements of XML Documentation Comments
    /// </summary>
    public class ListItem : ModelElement
    {
        /// <summary>
        /// Flag whether the <see cref="ListItem"/> is a list header (represents the &lt;listheader&gt; tag)
        /// </summary>
        public bool IsHeader { get; }
        /// <summary>
        /// <see cref="ModelElement"/> representing &lt;term&gt; child element of list item
        /// </summary>
        public ModelElement Term { get; }
        /// <summary>
        /// <see cref="ModelElement"/> representing &lt;description&gt; child element of list item
        /// </summary>
        public ModelElement Description { get; }

        /// <summary>
        /// Initialize <see cref="ListItem"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public ListItem(XElement element) : base(element)
        {
            IsHeader = element.Name.LocalName == "listheader";
            Term = Read(element.Element("term"));
            Description = Read(element.Element("description"));
        }
    }
}
