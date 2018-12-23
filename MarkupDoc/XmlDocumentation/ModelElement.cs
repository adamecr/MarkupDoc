using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Base class for the XML Documentation Comments elements and nodes
    /// It's inherited by "known" nodes/elements, itself instanciated when the node/element is not recognized (known). 
    /// </summary>
    public class ModelElement
    {
        /// <summary>
        /// Pseudo-tag used to keep the line break in <see cref="RenderElement"/> output
        /// </summary>
        protected static string TagKeepLineBreak = "<BREAK>";
        /// <summary>
        /// Pseudo-tag used to keep the space in <see cref="RenderElement"/> output
        /// </summary>
        protected static string TagKeepSpace = "<SPACE>"; 
        /// <summary>
        /// Element name (tag) or "Text" for the <see cref="Text"/> node
        /// </summary>
        public string Kind { get; protected set; }

        /// <summary>
        /// List of  child elements
        /// </summary>
        public IReadOnlyList<ModelElement> Elements => ElementsProtected;
        /// <summary>
        /// Internal list of child elements
        /// </summary>
        protected List<ModelElement> ElementsProtected { get; } = new List<ModelElement>();

        /// <summary>
        /// Initialize <see cref="ModelElement"/> instance from XML Documentation Comments node.
        /// Sets the <see cref="Kind"/> property from the element's tag (for elements only)
        /// </summary>
        /// <param name="node">XML node of XML Documentation Comments</param>
        protected ModelElement(XNode node)
        {
            if (node is XElement element)
            {
                Kind = element.Name.LocalName;
            }
        }

        /// <summary>
        /// Reads the node from XML - checks the node type (text node + named elements) and calls
        /// the appropriate constructor of derived classes. When the element is "unknown",
        /// the <see cref="ModelElement"/> is created.
        /// The method is recursively called for all child nodes and the created child objects are
        /// inserted into <see cref="Elements"/> list. This keeps the hierarchy of elements as in XML. 
        /// </summary>
        /// <param name="node">XML Documentation  Comments node to read</param>
        /// <returns>The element/node class read from XML containing the children in <see cref="Elements"/> list.</returns>
        public static ModelElement Read(XNode node)
        {
            ModelElement retVal = null;
            switch (node)
            {
                case XDocument document:
                    // ReSharper disable once TailRecursiveCall
                    return Read(document.Root);
                case XElement element:
                    switch (element.Name.LocalName)
                    {
                        case "member":
                            retVal = new Documentation(element);
                            break;
                        case "c":
                            retVal = new C(element);
                            break;
                        case "code":
                            retVal = new Code(element);
                            break;
                        case "example":
                            retVal = new Example(element);
                            break;
                        case "exception":
                            retVal = new ExceptionDoc(element);
                            break;
                        case "para":
                            retVal = new Para(element);
                            break;
                        case "param":
                            retVal = new Param(element);
                            break;
                        case "paramref":
                            retVal = new ParamRef(element);
                            break;
                        case "remarks":
                            retVal = new Remarks(element);
                            break;
                        case "returns":
                            retVal = new Returns(element);
                            break;
                        case "see":
                            retVal = new See(element);
                            break;
                        case "seealso":
                            retVal = new SeeAlso(element);
                            break;
                        case "summary":
                            retVal = new Summary(element);
                            break;
                        case "typeparam":
                            retVal = new TypeParam(element);
                            break;
                        case "typeparamref":
                            retVal = new TypeParamRef(element);
                            break;
                        case "value":
                            retVal = new Value(element);
                            break;
                        case "list":
                            retVal = new List(element);
                            break;
                        case "listheader":
                            retVal = new ListItem(element);
                            break;
                        case "item": //list item
                            retVal = new ListItem(element);
                            break;
                        case "inheritdoc": 
                            retVal = new Inheritdoc(element);
                            break;
                        default:
                            retVal = new ModelElement(element);
                            break;
                    }

                    foreach (var child in element.Nodes())
                    {
                        var childModelElement = Read(child);
                        if (childModelElement != null)
                            retVal.ElementsProtected.Add(childModelElement);
                    }
                    break;

                case XText text:
                    return new Text(text);
            }
            return retVal;
        }

        /// <summary>
        /// Returns the element content as string. It gets the content of all child <see cref="Elements"/>, merges into single line and trims (full trim)
        /// </summary>
        /// <remarks>Use <see cref="TagKeepLineBreak"/> and <see cref="TagKeepSpace"/> in derived classes to preserve the whitespaces.</remarks>
        /// <returns>The element content as string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var element in Elements)
            {
                sb.Append(element+" ");
            }

            return sb.ToString().TrimAndMergeLines();
        }

        /// <summary>
        /// Renders the <see cref="ModelElement"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Gets content of the all child <see cref="Elements"/>  and merges it together with a space as a separator.
        /// If <paramref name="trim"/> parameter is set, the result is "fully" trimmed - the line breaks are replaced by spaces and leading/ending spaces are removed.
        /// The parameter is also propagated to child's RenderElement function when getting the content.
        /// Use <see cref="TagKeepLineBreak"/> and <see cref="TagKeepSpace"/> in derived classes to preserve the whitespaces.
        /// when the parent element is to be rendered (and its content trimmed)
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of element/node of XML Documentation Comments</returns>
        protected virtual string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true) 
        {
            var sb = new StringBuilder();
            foreach (var element in Elements)
            {
                sb.Append(element.RenderElement(markupProvider, member, trim) + " ");
            }
            return trim ? sb.ToString().TrimAndMergeLines() : sb.ToString();
        }

        /// <summary>
        /// Renders the <see cref="ModelElement"/> and its content to string containing the markup provided by <paramref name="markupProvider"/>.
        /// This is the public "entry point" to <see cref="RenderElement"/> that does the final adjustment of the whitespaces.
        /// </summary>
        /// <remarks>
        /// Gets content of the all child <see cref="Elements"/>  and merges it together with a space as a separator.
        /// The result is "fully" trimmed - the line breaks are replaced by spaces and leading/ending spaces are removed.
        /// Use <see cref="TagKeepLineBreak"/> and <see cref="TagKeepSpace"/> in derived classes' <see cref="RenderElement"/> to preserve the whitespaces.
        /// The <see cref="Render"/> method replaces <see cref="ModelElement.TagKeepLineBreak"/> and  <see cref="ModelElement.TagKeepSpace"/>
        /// pseudo-tags back to line breaks and spaces to preserve the "hard" whitespace required by the rendering method
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <returns>Rendered content of element/node of XML Documentation Comments</returns>
        public virtual string Render(IMarkupProvider markupProvider, Member member)
        {
            var o = RenderElement(markupProvider, member);
            o = o.TrimAndMergeLines(); //shrink whitespaces

            //restore the "hard" whitespaces
            o = o.Replace(TagKeepLineBreak, Environment.NewLine);
            o = o.Replace(TagKeepSpace, " ");
            o = o.Replace(TagKeepLineBreak.HtmlEncode(), Environment.NewLine); //also the html encoded values for code
            o = o.Replace(TagKeepSpace.HtmlEncode(), " ");
            return o;
        }
    }

}
