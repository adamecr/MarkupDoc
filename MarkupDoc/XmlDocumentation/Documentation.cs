using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing (internal) &lt;member&gt; element of XML Documentation Comments.
    /// Used as a root documentation object for the code model <see cref="Member"/>
    /// </summary>
    /// <remarks>
    /// The <see cref="Documentation"/> class provides the "alias" properties
    /// to access the common elements like <see cref="Summary"/>, <see cref="Remarks"/>, <see cref="Exceptions"/>, etc.</remarks>
    public class Documentation : ModelElement
    {
        /// <summary>
        /// Content of <c>name</c> attribute of <c>member</c> element
        /// </summary>
        public string OwnRef { get; }

        /// <summary>
        /// Returns the first <c>summary</c> documentation element or null if not available
        /// </summary>
        public Summary Summary => Elements.OfType<Summary>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>remarks</c> documentation element or null if not available
        /// </summary>
        public Remarks Remarks => Elements.OfType<Remarks>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>example</c> documentation element or null if not available
        /// </summary>
        public Example Example => Elements.OfType<Example>().FirstOrDefault();
        /// <summary>
        /// Returns the <c>exception</c> documentation elements or null if not available
        /// </summary>
        public IList<ExceptionDoc> Exceptions => Elements.OfType<ExceptionDoc>().ToList();
        /// <summary>
        /// Returns the <c>seealso</c> documentation elements or null if not available
        /// </summary>
        public IList<SeeAlso> SeeAlso => Elements.OfType<SeeAlso>().ToList();
        /// <summary>
        /// Returns the first <c>value</c> documentation element or null if not available
        /// </summary>
        public Value Value => Elements.OfType<Value>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>returns</c> documentation element or null if not available
        /// </summary>
        public Returns Returns => Elements.OfType<Returns>().FirstOrDefault();

        /// <summary>
        /// Returns the first <c>param</c> documentation element with given <paramref name="name"/> or null if not available
        /// </summary>
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>param</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        public Param Param(string name) => Elements.OfType<Param>().FirstOrDefault(p => p.Name == name);
        /// <summary>
        /// Returns the first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available
        /// </summary>
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        public TypeParam TypeParam(string name) => Elements.OfType<TypeParam>().FirstOrDefault(tp => tp.Name == name);

        /// <summary>
        /// Initialize <see cref="Documentation"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Documentation(XElement element) : base(element)
        {
            OwnRef = element?.Attribute("name")?.Value;
        }

        /// <summary>
        /// Reads the XML Documentation Comments from given <see cref="xml"/> string
        /// </summary>
        /// <param name="xml">XML with documentation comments to parse</param>
        /// <returns>The new instance of <see cref="Documentation"/> class with XML Documentation Comments parsed from given <paramref name="xml"/></returns>
        public static Documentation Read(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return null;
            return Read(XDocument.Parse(xml)) as Documentation;
        }

    }

}
