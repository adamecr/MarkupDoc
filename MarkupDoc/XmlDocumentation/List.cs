using System;
using System.Linq;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;list&gt; element of XML Documentation  Comments
    /// </summary>
    public class List : ModelElement
    {
        /// <summary>
        /// List rendering type
        /// </summary>
        public enum ListTypeEnum
        {
            /// <summary>
            /// Render as bullet list.
            /// Each item contains "Term" in bold and "Description" (separated by dash). Both parts are optional. 
            /// </summary>
            Bullet,
            /// <summary>
            /// Render as numbered list.
            /// Each item contains "Term" in bold and "Description" (separated by dash). Both parts are optional. 
            /// </summary>
            Number,
            /// <summary>
            /// Render as two column table (term and description).
            /// Header item should be provided to define the table header
            /// ("Term" and "Description" are used as defaults)
            /// </summary>
            Table,
        }
        /// <summary>
        /// Required type of the list rendering
        /// </summary>
        public ListTypeEnum ListType { get; }

        /// <summary>
        /// Initialize <see cref="List"/> instance from XML Documentation Comments element.
        /// Extracts the <c>type</c> attribute
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public List(XElement element) : base(element)
        {
            switch (element?.Attribute("type")?.Value)
            {
                case "number":
                    ListType = ListTypeEnum.Number;
                    break;
                case "table":
                    ListType = ListTypeEnum.Table;
                    break;
                default:
                    ListType = ListTypeEnum.Bullet;
                    break;
            }
        }

        /// <summary>
        /// Renders the <see cref="List"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Gets content of the all child <see cref="ListItem"/> elements and renders them into the list of required <see cref="ListType"/>.
        ///<list type="bullet">
        /// <item>
        /// <term>Bullet list</term>
        /// <description>Each item contains "Term" in bold and "Description" (separated by dash). Both parts are optional.
        /// This includes the list header item if present, however, there is no special handling for such item.</description>
        /// </item>
        /// <item>
        /// <term>Numbered list</term>
        /// <description>Each item contains "Term" in bold and "Description" (separated by dash). Both parts are optional.
        /// This includes the list header item if present, however, there is no special handling for such item.</description></item>
        /// <item>
        /// <term>Table</term>
        /// <description>Rendered as two column table (term and description). Both parts are optional.
        /// Header item should be provided to define the table header ("Term" and "Description" are used as defaults)</description></item>
        /// </list>
        ///The rendering uses <see cref="IMarkupProvider.List{T}"/> to render the lists and <see cref="IMarkupProvider.TableHeader"/>,
        /// <see cref="IMarkupProvider.TableCols"/> and<see cref="IMarkupProvider.TableFooter"/> for table rendering.
        /// Pseudo-tags <see cref="ModelElement.TagKeepLineBreak"/> and <see cref="ModelElement.TagKeepSpace"/> are used in the rendering output, to preserve the whitespaces
        /// when the parent element is to be rendered (and its content trimmed)
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered list element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            switch (ListType)
            {
                case ListTypeEnum.Bullet:
                case ListTypeEnum.Number:
                    var content = markupProvider.List(li =>
                    {
                        {
                            var term = li.Term?.Render(markupProvider, member);
                            var description = li.Description?.Render(markupProvider, member) ?? "";
                            return !string.IsNullOrEmpty(term)
                                ? $"{markupProvider.Bold(term)}{(!string.IsNullOrEmpty(description) ? $" - {description}" : "")}"
                                : description;
                        }
                    }, Elements.OfType<ListItem>().ToList(), ListType == ListTypeEnum.Number);
                    content = $"{Environment.NewLine}{Environment.NewLine}{content}{Environment.NewLine}{Environment.NewLine}" //ensure proper separation from the text
                        .Replace("\r\n", TagKeepLineBreak)
                        .Replace("\r", TagKeepLineBreak)
                        .Replace("\n", TagKeepLineBreak)
                        .Replace(" ", TagKeepSpace); //preserve whitespaces
                    return content;

                case ListTypeEnum.Table:
                    var headerItem = Elements.OfType<ListItem>().FirstOrDefault(li => li.IsHeader);
                    var headerTerm = headerItem?.Term?.Render(markupProvider, member) ?? "Term";
                    var headerDescription = headerItem?.Description?.Render(markupProvider, member) ?? "Description";
                    var contentTbl = markupProvider.TableHeader(headerTerm, headerDescription);
                    foreach (var listItem in Elements.OfType<ListItem>().Where(li => !li.IsHeader))
                    {
                        var term = listItem.Term?.Render(markupProvider, member) ?? "";
                        var description = listItem.Description?.Render(markupProvider, member) ?? "";
                        contentTbl += markupProvider.TableCols(term, description);
                    }
                    contentTbl += markupProvider.TableFooter();
                    contentTbl = $"{Environment.NewLine}{Environment.NewLine}{contentTbl}{Environment.NewLine}{Environment.NewLine}" //ensure proper separation from the text
                        .Replace("\r\n", TagKeepLineBreak)
                        .Replace("\r", TagKeepLineBreak)
                        .Replace("\n", TagKeepLineBreak)
                        .Replace(" ", TagKeepSpace); //preserve whitespaces
                    return contentTbl;

                default:
                    return "";
            }
        }
    }
}
