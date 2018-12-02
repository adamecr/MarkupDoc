using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.MsApiDoc;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;exception&gt; element of XML Documentation  Comments
    /// </summary>
    public class ExceptionDoc : ModelElementWithCref
    {
        /// <summary>
        /// Initialize <see cref="ExceptionDoc"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public ExceptionDoc(XElement element) : base(element) { }

        /// <summary>
        /// Renders the <see cref="ExceptionDoc"/> element  to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Builds the link with the reference according to the <c>cref</c> attribute value. The value represents the Documentation ID
        /// that can be matched to the information got during the code analysis or to build the link to MS API reference for the "MS objects".
        /// First, it tries to resolve the <see cref="Member"/> in code being documented (internal link). If not successful, tries to look for
        /// the <c>cref</c> (Documentation ID) in the MS API documentation if allowed/available (see <see cref="MsApiDocEngine"/> for details)
        /// <para>
        /// The link text is the the name of linked entity when using internal <see cref="IMarkupProvider.Link(string,net.adamec.dev.markupdoc.CodeModel.Member)"/>
        /// or the <c>cref</c> without the leading type information when rendering .
        /// When the link is not constructed ("target unknown"), the <c>cref</c>  value without the leading type information is rendered in italic
        /// </para>
        /// <para>
        /// The &lt;exception&gt; element is then rendered as <see cref="IMarkupProvider.DescriptionListItem"/> where
        ///<c>Term</c> is the link and <c>Description</c> is the fully trimmed element content.
        /// Important: it returns description list item, so must be encapsulated on higher level !!!
        /// </para>
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of &lt;exception&gt; element of XML Documentation Comments.
        /// Important: it returns description list item, so must be encapsulated on higher level !!!</returns>
        ///<seealso cref="MsApiDocEngine"/>
        /// <seealso cref="MsApiDocOptions"/>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            //for exception always render both Ref(link if available) AND content

            //content
            var content = base.RenderElement(markupProvider, member, trim);

            //ref
            string exceptionRef;

            if (member.Root.AllMembersByDocId.TryGetValue(Ref, out var refMember))
            {
                exceptionRef = markupProvider.Link(refMember.Name, refMember);
            }
            else
            {
                //Try to get the MS API link from reference
                var msLink = MsApiDocEngine.GetLink(Ref);
                //Got the MS link, so use external link
                // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
                if (msLink != null)
                {
                    exceptionRef = markupProvider.ExternalLink(Ref.Substring(2), msLink);

                }
                else
                {
                    //No link -  Ref without leading "ref type"
                    exceptionRef = markupProvider.Italic(Ref.Substring(2));
                }
            }
            //output
            return markupProvider.DescriptionListItem(exceptionRef, content);
        }
    }

}
