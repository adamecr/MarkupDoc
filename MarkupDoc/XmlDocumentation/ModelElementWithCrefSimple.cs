using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.MsApiDoc;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Abstract class representing the element of XML Documentation Comments that have the <c>cref</c> attribute
    /// and simple rendering logic - just the link and/or content
    /// </summary>
    public abstract class ModelElementWithCrefSimple : ModelElementWithCref
    {
        /// <summary>
        /// Initialize <see cref="ModelElementWithCrefSimple"/> instance from XML Documentation Comments element
        /// No logic here
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        protected ModelElementWithCrefSimple(XElement element) : base(element) { }


        /// <summary>
        /// Returns the element content as string or <see cref="ModelElementWithCref.Ref"/> when there is no content
        /// </summary>
        /// <returns>The element content as string or <see cref="ModelElementWithCref.Ref"/> when there is no content</returns>
        public override string ToString()
        {
            var content = base.ToString();
            return !string.IsNullOrEmpty(content) ? content : Ref;
        }

        /// <summary>
        /// Renders the element having the <c>cref</c> attribute to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Builds the link with the reference according to the <c>cref</c> attribute value. The value represents the Documentation ID
        /// that can be matched to the information got during the code analysis or to build the link to MS API reference for the "MS objects".
        /// First, it tries to resolve the <see cref="Member"/> in code being documented (internal link). If not successful, tries to look for
        /// the <c>cref</c> (Documentation ID) in the MS API documentation if allowed/available (see <see cref="MsApiDocEngine"/> for details)
        /// <para>
        /// The link text is the rendered trimmed content of the tag if available,
        /// the name of linked entity when using internal <see cref="IMarkupProvider.Link(string,net.adamec.dev.markupdoc.CodeModel.Member)"/>
        /// or the <c>cref</c> without the leading type information when rendering <see cref="IMarkupProvider.ExternalLink"/>.
        /// When the link is not constructed ("target unknown"), the <c>cref</c>  value without the leading type information is rendered in italic
        /// </para>
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of element of XML Documentation Comments</returns>
        ///<seealso cref="MsApiDocEngine"/>
        /// <seealso cref="MsApiDocOptions"/>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true) //used  for links
        {
            
            // ReSharper disable once RedundantArgumentDefaultValue
            var content = base.RenderElement(markupProvider, member, true); //always trim content for links
            if (string.IsNullOrEmpty(Ref)) return content;

            //Return Ref to existing member as link, if available. If no content provided, use the member's name
            if (member.Root.AllMembersByDocId.TryGetValue(Ref, out var refMember))
            {
                return markupProvider.Link(!string.IsNullOrEmpty(content) ? content : refMember.Name, refMember);
            }

            //Try to get the MS API link from reference
            var msLink = MsApiDocEngine.GetLink(Ref);
            //Got the MS link, so return external link
            if (msLink != null) return markupProvider.ExternalLink(!string.IsNullOrEmpty(content) ? content : Ref.Substring(2), msLink);

            //No link, return content if available otherwise Ref without leading "ref type"
            return !string.IsNullOrEmpty(content) ? content : markupProvider.Italic(Ref.Substring(2));
        }
    }

}
