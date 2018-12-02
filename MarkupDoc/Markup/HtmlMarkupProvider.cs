﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.Markup
{
    /*
        ====================================================================
        Highlight.js
        ====================================================================
          Highlight.js (https://highlightjs.org/) is used for highlighting
          Highlight.js is released under the BSD License
          Highlight.js is and it's used from CDN directly
        ====================================================================
     */

    /// <summary>
    /// HTML markup provider
    /// </summary>
    public class HtmlMarkupProvider : IMarkupProvider
    {
        /// <summary>
        /// Output configuration
        /// </summary>
        protected OutputOptions OutputOptions { get; }

        /// <summary>
        /// CTOR with given <see cref="OutputOptions"/>
        /// </summary>
        /// <param name="outputOptions">Output configuration</param>
        public HtmlMarkupProvider(OutputOptions outputOptions)
        {
            OutputOptions = outputOptions;
        }

        /// <summary>
        /// Gets or sets the <see cref="IMarkupWriter"/> used for the markup output
        /// </summary>
        public IMarkupWriter MarkupWriter { get; set; }

        /// <summary>
        /// Writes the markup for the beginning of the document (file) and level 1 header with title
        /// </summary>
        /// <remarks>Writes the HTML header with links the CSS and Javascript for the Highlight.js and the style sheet for the documentation.
        /// Opens the <c>body</c> tag</remarks>
        /// <param name="title">Document title</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteDocumentStartAsync(string title = null)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<!DOCTYPE html>");
            sb.AppendLine("<html>");
            sb.AppendLine("<head>");
            if (title != null)
            {
                sb.AppendLine($"<title>{title}</title>");
            }
            //Highlight.js use start
            sb.AppendLine("<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.13.1/styles/default.min.css\" >");
            sb.AppendLine("<script src = \"https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.13.1/highlight.min.js\" ></script>");
            sb.AppendLine("<script>hljs.initHighlightingOnLoad();</script>");
            //Highlight.js use end
            sb.AppendLine("<style>");
            sb.AppendLine("body { color: #24292e;font-family: -apple-system,BlinkMacSystemFont,Segoe UI,Helvetica,Arial,sans-serif,Apple Color Emoji,Segoe UI Emoji,Segoe UI Symbol;font-size: 16px;line-height: 1.5; word-wrap: break-word;margin: 20px;}");
            sb.AppendLine("h1 {font-size: 2em;}");
            sb.AppendLine("h2 {font-size: 1.5em;}");
            sb.AppendLine("h2 {font-size: 1.25em;}");
            sb.AppendLine("h4 {font-size: 1.25em;}");
            sb.AppendLine("h1, h2 {border-bottom: 1px solid #eaecef; padding-bottom: .3em;}");
            sb.AppendLine("h1, h2, h3,  h4{font-weight: 600;line-height: 1.25;margin-bottom: 16px;margin-top: 24px;}");
            sb.AppendLine("blockquote, ol, p, pre, table, ul {margin-bottom: 16px;margin-top: 0;}");
            sb.AppendLine("a{color: #0366d6;text-decoration: none;}");
            sb.AppendLine("a:hover{text-decoration: underline;}");
            sb.AppendLine("a.link-external:hover{text-decoration: underline; color:gray;}");
            sb.AppendLine("pre code {border: 0;display: inline;line-height: inherit;margin: 2px;overflow: visible;padding: 5px ;word-wrap: normal;}");
            sb.AppendLine("pre>code {font-size: 100%;white-space: pre;word-break: normal;padding: 0px}");
            sb.AppendLine("code {border-radius: 3px;}");
            sb.AppendLine("code, pre {font-family: SFMono-Regular,Consolas,Liberation Mono,Menlo,Courier,monospace;}");
            sb.AppendLine("pre {background-color: #f6f8fa;border-radius: 3px;font-size: 85%;line-height: 1.45;overflow: auto;padding: 0px;word-wrap: normal;}");
            sb.AppendLine("table {display: block;overflow: auto;width: 100%;border-collapse: collapse;border-spacing: 0;border-color: grey;}");
            sb.AppendLine("table tr {background-color: #fff;border-top: 1px solid #c6cbd1;}");
            sb.AppendLine("table tr:nth-child(2n) {background-color: #f6f8fa;}");
            sb.AppendLine("table td, table th {border: 1px solid #dfe2e5;padding: 6px 13px;}");
            sb.AppendLine("dl {display: grid; grid-template-columns: max-content auto; margin: 5px;}");
            sb.AppendLine("p+dl {margin-top: -15px;}");
            sb.AppendLine("dt {grid-column-start: 1;}");
            sb.AppendLine("dd {grid-column-start: 2;}");
            sb.AppendLine("</style>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            await WriteLineAsync(sb.ToString());

            if (title != null)
            {
                await WriteH1Async(title);
            }
        }

        /// <summary>
        /// Writes the markup for the end of the document (file)
        /// </summary>
        /// <remarks>Closed the <c>body</c> and <c>html</c> tags</remarks>
        /// <returns>Async task</returns>
        public virtual Task WriteDocumentEndAsync()
        {
            return WriteLineAsync("</body></html>");
        }

        /// <summary>
        /// Writes the <paramref name="text"/> to the output
        /// </summary>
        /// <param name="text">Text to write to the output</param>
        /// <returns>Async task</returns>
        public virtual Task WriteTextAsync(string text = null)
        {
            return WriteLineAsync(text);
        }

        /// <summary>
        /// Writes the markup for paragraph with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content of the paragraph</param>
        /// <remarks>Uses the <see cref="Para"/> function to get the markup</remarks>
        /// <returns>Async task</returns>
        public virtual Task WriteParaAsync(string text)
        {
            return !string.IsNullOrEmpty(text) ? WriteLineAsync(Para(text)) : Task.CompletedTask;
        }

        /// <summary>
        /// Writes the level 1 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>&lt;h1&gt; {Bookmark(bookmark)} {header} &lt;/h1&gt;</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH1Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"<h1> {Bookmark(bookmark)} {header.HtmlEncode()} </h1>");
        }

        /// <summary>
        /// Writes the level 2 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>&lt;h2&gt; {Bookmark(bookmark)} {header} &lt;/h2&gt;</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH2Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"<h2> {Bookmark(bookmark)} {header.HtmlEncode()} </h2>");
        }

        /// <summary>
        /// Writes the level 3 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>&lt;h3&gt; {Bookmark(bookmark)} {header} &lt;/h3&gt;</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH3Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"<h3> {Bookmark(bookmark)} {header.HtmlEncode()} </h3>");
        }

        /// <summary>
        /// Writes the level 4 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>&lt;h4&gt; {Bookmark(bookmark)} {header} &lt;/h4&gt;</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH4Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"<h4> {Bookmark(bookmark)} {header.HtmlEncode()} </h4>");
        }

        /// <summary>
        /// Writes the markup for horizontal line
        /// <remarks>Writes <c>&lt;hr /&gt;</c> to the output</remarks>   
        /// </summary>
        /// <returns>Async task</returns>
        public virtual Task WriteHorizontalLineAsync()
        {
            return WriteLineAsync("<hr />");
        }

        /// <summary>
        /// Writes the markup for multi-line code with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Uses the <see cref="Code"/> function to get the markup</remarks>
        /// <param name="text">Code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Async task</returns>
        public virtual Task WriteCodeAsync(string text, bool encodeNeeded = false)
        {
            return WriteLineAsync(Code(text, encodeNeeded));
        }

        /// <summary>
        /// Writes the markup for the table header with given columns 
        /// </summary>
        /// <remarks>Uses the <see cref="TableHeader"/> function to get the markup</remarks>
        /// <param name="items">Content of individual header columns</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteTableHeaderAsync(params string[] items)
        {
            await WriteLineAsync(TableHeader(items));
        }

        /// <summary>
        /// Writes the markup for the table row with given columns 
        /// </summary>
        /// <remarks>Uses the <see cref="TableCols"/> function to get the markup</remarks>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Async task</returns>
        public virtual Task WriteTableColsAsync(params string[] items)
        {
            return WriteLineAsync(TableCols(items));
        }

        /// <summary>
        /// Writes the markup for the table footer
        /// </summary>
        /// <remarks>Uses the <see cref="TableFooter"/> function to get the markup</remarks>
        /// <returns>Async task</returns>
        public virtual Task WriteTableFooterAsync()
        {
            return WriteLineAsync(TableFooter());
        }

        /// <summary>
        /// Returns the markup for the "plain" text 
        /// </summary>
        /// <remarks>HTML encodes the <paramref name="text"/></remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for the "plain" text </returns>
        public virtual string Text(string text)
        {
            return text?.HtmlEncode();
        }

        /// <summary>
        /// Returns the markup for bold (strong) <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;strong&gt;{text}&lt;/strong&gt;</c> to the output</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for bold (strong) <paramref name="text"/></returns>
        public virtual string Bold(string text)
        {
            return $"<strong>{text}</strong>";
        }

        /// <summary>
        /// Returns the markup for italic (emphasized) <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;em&gt;{text}&lt;/em&gt;</c> to the output</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for italic (emphasized) <paramref name="text"/></returns>
        public virtual string Italic(string text)
        {
            return $"<em>{text}</em>";
        }

        /// <summary>
        /// Returns the markup for small <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;small&gt;{text}&lt;/small&gt;</c> to the output</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for small <paramref name="text"/></returns>
        public virtual string Small(string text)
        {
            return $"<small>{text}</small>";
        }

        /// <summary>
        /// Returns the markup for multi-line code with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;pre&gt;{InlineCode(text)}&lt;/pre&gt;</c> to the output</remarks>
        /// <seealso cref="InlineCode"/>
        /// <param name="text">Code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for code with given <paramref name="text"/></returns>
        public virtual string Code(string text, bool encodeNeeded = false)
        {
            return $"<pre>{InlineCode(text, encodeNeeded)}</pre>";
        }

        /// <summary>
        /// Returns the markup for inline code with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;code class="csharp"&gt;{text}&lt;/code&gt;</c> to the output</remarks>
        /// <param name="text">Inline code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for inline code with given <paramref name="text"/></returns>
        public virtual string InlineCode(string text, bool encodeNeeded = false)
        {
            if (encodeNeeded) text = text.HtmlEncode();
            return $"<code class=\"csharp\">{text}</code>";
        }

        /// <summary>
        /// Returns the markup for paragraph with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;p&gt;{text}&lt;/p&gt;</c> to the output when the text is provided (so no empty paragraphs are generated)</remarks>
        /// <param name="text">Content of the paragraph</param>
        /// <returns>Markup for paragraph with given <paramref name="text"/></returns>
        public virtual string Para(string text)
        {
            return !string.IsNullOrEmpty(text) ? $"<p>{text}</p>" : string.Empty;
        }

        /// <summary>
        /// Returns the markup for the list of the items 
        /// </summary>
        /// Writes <c>&lt;li&gt;{itemOutput.Invoke(item)}&lt;/li&gt;</c> for each item. The items are encapsulated within the <c>&lt;ol&gt;&lt;/ol&gt;</c> or <c>&lt;ul&gt;&lt;/ul&gt;</c> tags
        /// <typeparam name="TItemType">Type of the list item entry object</typeparam>
        /// <param name="itemOutput">Function returning the markup for single item</param>
        /// <param name="items">List items</param>
        /// <param name="numbered">Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</param>
        /// <returns>Markup for the list of the items</returns>
        public virtual string List<TItemType>(Func<TItemType, string> itemOutput, IEnumerable<TItemType> items, bool numbered = false)
        {
            var itemsArray = items?.ToArray();
            if (itemsArray == null || itemsArray.Length==0 || itemOutput == null) return string.Empty;
            var output = "";
            output += numbered ? "<ol>" : "<ul>";
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var item in itemsArray)
            {
                output += $"<li>{itemOutput.Invoke(item)}</li>";
            }
            output += numbered ? "</ol>" : "</ul>";
            return output;
        }

        /// <summary>
        /// Returns the markup for the table header with given columns 
        /// </summary>
        /// <remarks>Writes <c>&lt;table&gt;&lt;tr&gt;&lt;th&gt;{string.Join("&lt;/th&gt;&lt;th&gt;", items)}&lt;/th&gt;&lt;/tr&gt;</c> to the output</remarks>
        /// <param name="items">Content of individual header columns</param>
        /// <returns>Markup for the table header with given columns</returns>
        public virtual string TableHeader(params string[] items)
        {
            return $"<table><tr><th>{string.Join("</th><th>", items)}</th></tr>";
        }

        /// <summary>
        /// Returns the markup for the table row with given columns 
        /// </summary>
        /// <remarks>Writes <c>&lt;tr&gt;&lt;td&gt;{string.Join("&lt;/td&gt;&lt;td&gt;", items)}&lt;/td&gt;&lt;/tr&gt;</c> to the output</remarks>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Markup for the table row with given columns</returns>
        public virtual string TableCols(params string[] items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            return $"<tr><td>{string.Join("</td><td>", items)}</td></tr>";
        }

        /// <summary>
        /// Returns the markup for the table footer
        /// </summary>
        /// <remarks>Writes <c>&lt;/table&gt;</c> to the output</remarks>
        /// <returns>Markup for the table footer</returns>
        public virtual string TableFooter()
        {
            return "</table>";
        }

        /// <summary>
        /// Returns the markup for the description list with the given <paramref name="items"/>
        /// </summary>
        /// <remarks>Renders the individual items using <see cref="DescriptionListItem{TItemType}"/>
        /// and then uses <see cref="DescriptionList"/> to render the whole list</remarks>
        ///<typeparam name="TItemType">Type of the object to generate the description list item for</typeparam>
        /// <param name="itemTerm">Function to get the term for given item</param>
        /// <param name="itemDescription">Function to get the description for given item</param>
        /// <param name="items">Description list items</param>
        /// <returns>Markup for the description list with the given <paramref name="items"/></returns>
        public virtual string DescriptionList<TItemType>(
            Func<TItemType, string> itemTerm,
            Func<TItemType, string> itemDescription,
            IEnumerable<TItemType> items)
        {
            var itemsArray = items?.ToArray();
            if (itemsArray == null || itemsArray.Length == 0 || itemTerm == null || itemDescription == null) return string.Empty;
            var renderedItems = new List<string>();
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var item in itemsArray)
            {
                var renderedItem = DescriptionListItem(itemTerm, itemDescription, item);
                if (!string.IsNullOrEmpty(renderedItem))
                    renderedItems.Add(renderedItem);
            }

            var output = DescriptionList(renderedItems);
            return output;
        }

        /// <summary>
        /// Returns the markup for the description list with the given <paramref name="renderedItems"/>
        /// </summary>
        /// <remarks>Writes the <paramref name="renderedItems"/> between <c>&lt;dl&gt;</c> tags</remarks>
        /// <param name="renderedItems">Description list items markup</param>
        /// <returns>Markup for the description list with the given <paramref name="renderedItems"/></returns>
        public virtual string DescriptionList(IList<string> renderedItems)
        {
            if (renderedItems == null || renderedItems.Count == 0) return string.Empty;
            var output = "";
            output += "<dl>";
            // ReSharper disable once LoopCanBeConvertedToQuery
            foreach (var item in renderedItems)
            {
                output += item;
            }
            output += "</dl>";
            return output;
        }

        /// <summary>
        /// Returns the markup of the description list item
        /// </summary>
        /// <remarks>Uses <see cref="DescriptionListItem"/> to render the individual items once the functions are evaluated</remarks>
        /// <typeparam name="TItemType">Type of the object to generate the description list item for</typeparam>
        /// <param name="itemTerm">Function to get the term for given item</param>
        /// <param name="itemDescription">Function to get the description for given item</param>
        /// <param name="item">Object to generate the description list item for</param>
        /// <returns>Markup of the description list item</returns>
        public virtual string DescriptionListItem<TItemType>(
            Func<TItemType, string> itemTerm,
            Func<TItemType, string> itemDescription,
            TItemType item)
        {
            if (item == null || itemTerm == null || itemDescription == null) return string.Empty;
            var output = DescriptionListItem(itemTerm.Invoke(item), itemDescription.Invoke(item));
            return output;
        }

        /// <summary>
        /// Returns the markup of the description list item
        /// </summary>
        /// <remarks>Writes <c>&lt;dt&gt;{itemTerm}&lt;/dt&gt;&lt;dd&gt;{itemDescription}&lt;/dd&gt;</c> to the output</remarks>
        /// <param name="itemTerm">Item term</param>
        /// <param name="itemDescription">Item description</param>
        /// <returns>Markup of the description list item</returns>
        public virtual string DescriptionListItem(string itemTerm, string itemDescription)
        {
            var output = "";
            output += $"<dt>{itemTerm}</dt>";
            output += $"<dd>{itemDescription}</dd>";
            return output;
        }

        /// <summary>
        /// Returns the markup of the bookmark with given <paramref name="id"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;a id=\"" + id + "\" &gt;&lt;/a&gt;</c> to the output</remarks>
        /// <param name="id">Bookmark id</param>
        /// <returns>Markup of the bookmark with given <paramref name="id"/></returns>
        public virtual string Bookmark(string id)
        {
            return !string.IsNullOrEmpty(id) ? " <a id=\"" + id + "\" ></a> " : "";
        }

        /// <summary>
        /// Returns the markup for the internal link
        /// </summary>
        /// <remarks>Gets the information about <paramref name="member"/> and uses <see cref="Link(string,string, string)"/> to render the link</remarks>
        /// <param name="text">Link text</param>
        /// <param name="member"><see cref="Member"/> to generate the link to</param>
        /// <returns>Markup for the internal link</returns>
        public virtual string Link(string text, Member member)
        {
            return Link(text, string.IsNullOrEmpty(member.FileName) ? "" : $"{member.FileName}.{OutputOptions.HtmlExtension}", member.Anchor);
        }

        /// <summary>
        /// Returns the markup for the internal link
        /// </summary>
        /// <remarks>Writes <c>&lt;a href=\"{file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")}\" &gt;{text}&lt;/a&gt;</c> to the output</remarks>
        /// <param name="text">Link text</param>
        /// <param name="file">Name of the file relative to the documentation root (index file)</param>
        /// <param name="bookmark">Optional bookmark</param>
        /// <returns>Markup for the internal link</returns>
        public virtual string Link(string text, string file, string bookmark)
        {
            return $"<a href=\"{file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")}\" >{text.HtmlEncode()}</a>";
        }

        /// <summary>
        /// Returns the markup for the external link
        /// </summary>
        /// <remarks>Writes <c>&lt;a href=\"{url}\" class=\"link-external\" target=\"_blank\" &gt;{text}&lt;/a&gt;</c> to the output</remarks>
        /// <param name="text">Link text</param>
        /// <param name="url">Link URL</param>
        /// <returns>Markup for the external link</returns>
        public virtual string ExternalLink(string text, string url)
        {
            return $"<a href=\"{url}\" class=\"link-external\" target=\"_blank\" >{text.HtmlEncode()}</a>";
        }

        /// <summary>
        /// Returns the markup for the line break
        ///  </summary>
        /// <remarks>Writes <c>"&lt;br /&gt;" + Environment.NewLine</c> to the output</remarks>
        /// <returns>Markup for the line break</returns>
        public virtual string LineBreak()
        {
            return "<br />" + Environment.NewLine;
        }

        /// <summary>
        /// Writes the line into the <see cref="MarkupWriter"/>
        /// </summary>
        /// <param name="text">Line content</param>
        /// <returns>Async task</returns>
        protected Task WriteLineAsync(string text = null)
        {
            if (MarkupWriter == null) throw new Exception("MarkupWriter not initialized (null)");
            return MarkupWriter.WriteLineAsync(text);
        }

    }
}
