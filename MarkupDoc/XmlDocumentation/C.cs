﻿using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Markup;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing &lt;c&gt; element of XML Documentation Comments
    /// </summary>
    public class C : ModelElement
    {
        /// <summary>
        /// Initialize <see cref="C"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public C(XNode element) : base(element) { }

        /// <summary>
        /// Renders the <see cref="C"/> and its content to string
        /// containing the markup provided by <paramref name="markupProvider"/>
        /// </summary>
        /// <remarks>
        /// Gets (fully) trimmed content of the tag and renders it using <see cref="IMarkupProvider.InlineCode"/>
        /// </remarks>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> allowing using the markup within the rendered content</param>
        /// <param name="member">Code model <see cref="Member"/> to render the XML Documentation Comment for</param>
        /// <param name="trim">Flag whether to (full) trim the rendered content</param>
        /// <returns>Rendered content of &lt;c&gt; element of XML Documentation Comments</returns>
        protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
        {
            // ReSharper disable once RedundantArgumentDefaultValue
            var content = base.RenderElement(markupProvider, member, true); //always trim spaces for inline code.Text
            content = markupProvider.InlineCode(content);
            return content;
        }
    }
}
