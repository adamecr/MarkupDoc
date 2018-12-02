using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Markdown markup provider
    /// </summary>
    public class MarkdownMarkupProvider : IMarkupProvider
    {
        /// <summary>
        /// Output configuration
        /// </summary>
        protected OutputOptions OutputOptions { get; }

        /// <summary>
        /// CTOR with given <see cref="OutputOptions"/>
        /// </summary>
        /// <param name="outputOptions">Output configuration</param>
        public MarkdownMarkupProvider(OutputOptions outputOptions)
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
        /// <param name="title">Document title</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteDocumentStartAsync(string title = null)
        {
            if (title != null)
            {
                await WriteH1Async(title);
            }
        }

        /// <summary>
        /// Writes the markup for the end of the document (file)
        /// </summary>
        /// <returns>Async task</returns>
        public virtual Task WriteDocumentEndAsync()
        {
            return WriteLineAsync();
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
        /// <remarks>Uses the <see cref="Para"/> function to get the markup</remarks>
        /// <param name="text">Content of the paragraph</param>
        /// <returns>Async task</returns>
        public virtual Task WriteParaAsync(string text)
        {
            return !string.IsNullOrEmpty(text) ? WriteLineAsync(Para(text)) : Task.CompletedTask;
        }

        /// <summary>
        /// Writes the level 1 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c># {Bookmark(bookmark)} {header} #</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH1Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"# {Bookmark(bookmark)} {header.HtmlEncode()} #");
        }

        /// <summary>
        /// Writes the level 2 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>## {Bookmark(bookmark)} {header} ##</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH2Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"## {Bookmark(bookmark)} {header.HtmlEncode()} ##");
        }

        /// <summary>
        /// Writes the level 3 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>### {Bookmark(bookmark)} {header} ###</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH3Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"### {Bookmark(bookmark)} {header.HtmlEncode()} ###");
        }

        /// <summary>
        /// Writes the level 4 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <remarks>Writes <c>#### {Bookmark(bookmark)} {header} ####</c> to the output</remarks>
        /// <seealso cref="Bookmark"/>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        public virtual Task WriteH4Async(string header, string bookmark = null)
        {
            return WriteLineAsync($"#### {Bookmark(bookmark)} {header.HtmlEncode()} ####");
        }


        /// <summary>
        /// Writes the markup for horizontal line
        /// <remarks>Writes <c>----</c> to the output</remarks>   
        /// </summary>
        /// <returns>Async task</returns>
        public virtual Task WriteHorizontalLineAsync()
        {
            return WriteLineAsync("----");
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
            await WriteAsync(TableHeader(items)); //newline managed by TableHeader func
        }

        /// <summary>
        /// Writes the markup for the table row with given columns 
        /// </summary>
        /// <remarks>Uses the <see cref="TableCols"/> function to get the markup</remarks>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Async task</returns>
        public virtual Task WriteTableColsAsync(params string[] items)
        {
            return WriteAsync(TableCols(items)); //newline managed by TableCols func
        }

        /// <summary>
        /// Writes the markup for the table footer
        /// </summary>
        /// <remarks>Uses the <see cref="TableFooter"/> function to get the markup</remarks>
        /// <returns>Async task</returns>
        public virtual Task WriteTableFooterAsync()
        {
            return WriteAsync(TableFooter());//newline managed by TableFooter func
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
        /// <remarks>Writes <c>&lt;strong&gt;{text}&lt;/strong&gt;</c> to the output.
        /// There are problems when markdown "tags" are used within HTML tags (for example in description lists), so better to use the HTML tags for bold text as well</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for bold (strong) <paramref name="text"/></returns>
        public virtual string Bold(string text)
        {
            //return $"**{text}**";
            return $"<strong>{text}</strong>";  //had problems when markdown "tags" are used within HTML tags, so better to use this
        }

        /// <summary>
        /// Returns the markup for italic (emphasized) <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>&lt;em&gt;{text}&lt;/em&gt;</c> to the output.
        /// There are problems when markdown "tags" are used within HTML tags (for example in description lists), so better to use the HTML tags for italic text as well</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for italic (emphasized) <paramref name="text"/></returns>
        public virtual string Italic(string text)
        {
            //return $"*{text}*";
            return $"<em>{text}</em>";//had problems when markdown "tags" are used within HTML tags, so better to use this
        }

        /// <summary>
        /// Returns the markup for small <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c><small>{text}</small></c> to the output</remarks>
        /// <param name="text">Content</param>
        /// <returns>Markup for small <paramref name="text"/></returns>
        public virtual string Small(string text)
        {
            return $"<small>{text}</small>";
        }

        /// <summary>
        /// Returns the markup for multi-line code with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>{Environment.NewLine}```csharp{Environment.NewLine}{text}{Environment.NewLine}```{Environment.NewLine}</c> to the output</remarks>
        /// <param name="text">Code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for code with given <paramref name="text"/></returns>
        public virtual string Code(string text, bool encodeNeeded = false)
        {
            if (!encodeNeeded) text = text.HtmlDecode();
            return $"{Environment.NewLine}```csharp{Environment.NewLine}{text}{Environment.NewLine}```{Environment.NewLine}";
        }

        /// <summary>
        /// Returns the markup for inline code with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>`{text}`</c> to the output</remarks>
        /// <param name="text">Inline code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for inline code with given <paramref name="text"/></returns>
        public virtual string InlineCode(string text, bool encodeNeeded = false)
        {
            if (!encodeNeeded) text = text.HtmlDecode();
            return $"`{text}`";
        }

        /// <summary>
        /// Returns the markup for paragraph with given <paramref name="text"/>
        /// </summary>
        /// <remarks>Writes <c>text + Environment.NewLine + Environment.NewLine</c> to the output when the text is provided (so no empty paragraphs are generated)</remarks>
        /// <param name="text">Content of the paragraph</param>
        /// <returns>Markup for paragraph with given <paramref name="text"/></returns>
        public virtual string Para(string text)
        {
            return !string.IsNullOrEmpty(text) ? text + Environment.NewLine + Environment.NewLine : string.Empty;
        }


        /// <summary>
        /// Returns the markup for the list of the items 
        /// </summary>
        /// <remarks>Writes <c>{(numbered ? $"{idx}." : " -")} {itemOutput.Invoke(item)}{Environment.NewLine}</c> for each item with additional new lines before and after the list</remarks>
        /// <typeparam name="TItemType">Type of the list item entry object</typeparam>
        /// <param name="itemOutput">Function returning the markup for single item</param>
        /// <param name="items">List items</param>
        /// <param name="numbered">Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</param>
        /// <returns>Markup for the list of the items</returns>
        public virtual string List<TItemType>(Func<TItemType, string> itemOutput, IEnumerable<TItemType> items, bool numbered = false)
        {
            var itemsArray = items?.ToArray();
            if (itemsArray == null || itemsArray.Length == 0 || itemOutput == null) return string.Empty;
            var output = "";
            output += Environment.NewLine;
            var idx = 1;
            foreach (var item in itemsArray)
            {
                output += $"{(numbered ? $"{idx}." : " -")} {itemOutput.Invoke(item)}{Environment.NewLine}";
                idx++;
            }
            output += "           " + Environment.NewLine;
            return output;
        }


        /// <summary>
        /// Returns the markup for the table header with given columns 
        /// </summary>
        /// <remarks>Writes the header columns split by "|" and the table header row like "|---|---|---|" (of course with the proper number of columns</remarks>
        /// <param name="items">Content of individual header columns</param>
        /// <returns>Markup for the table header with given columns</returns>
        public virtual string TableHeader(params string[] items)
        {
            var o = Environment.NewLine;
            o += TableCols(items);
            var hdr = new string[items.Length];
            for (var i = 0; i < items.Length; i++)
            {
                hdr[i] = new string('-', items[i].Length) + "--"; //just to prevent the empty strings
            }
            o += TableCols(hdr);
            return o;
        }

        /// <summary>
        /// Returns the markup for the table row with given columns 
        /// </summary>
        /// <remarks>Writes <c> | {string.Join(" | ", items)} | {Environment.NewLine}</c> to the output</remarks>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Markup for the table row with given columns</returns>
        public virtual string TableCols(params string[] items)
        {
            if (items == null) throw new ArgumentNullException(nameof(items));
            for (var i = 0; i < items.Length; i++)
            {
                items[i] = items[i].TrimAndMergeLines();
            }
            return $" | {string.Join(" | ", items)} | {Environment.NewLine}";
        }

        /// <summary>
        /// Returns the markup for the table footer
        /// </summary>
        /// <remarks>Writes just the line break to the output</remarks>
        /// <returns>Markup for the table footer</returns>
        public virtual string TableFooter()
        {
            return Environment.NewLine;
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
            return !string.IsNullOrEmpty(id) ? " <a id=\"" + id + "\" /> " : "";
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
            return Link(text, string.IsNullOrEmpty(member.FileName) ? "" : $"{member.FileName}.{OutputOptions.MarkdownExtension}", member.Anchor);
        }

        /// <summary>
        /// Returns the markup for the internal link
        /// </summary>
        /// <remarks>Writes <c>[{text}]({file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")})</c> to the output</remarks>
        /// <param name="text">Link text</param>
        /// <param name="file">Name of the file relative to the documentation root (index file)</param>
        /// <param name="bookmark">Optional bookmark</param>
        /// <returns>Markup for the internal link</returns>
        public virtual string Link(string text, string file, string bookmark)
        {
            return $"[{text.HtmlEncode()}]({file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")})";
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
            return $"<a href=\"{url}\" target=\"_blank\" >{text.HtmlEncode()}</a>";
        }

        /// <summary>
        /// Returns the markup for the line break
        /// </summary>
        /// <returns>Markup for the line break</returns>
        public virtual string LineBreak()
        {
            return "           " + Environment.NewLine;
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

        /// <summary>
        /// Writes the text into the <see cref="MarkupWriter"/>
        /// </summary>
        /// <param name="text">Content</param>
        /// <returns>Async task</returns>
        protected Task WriteAsync(string text = null)
        {
            if (MarkupWriter == null) throw new Exception("MarkupWriter not initialized (null)");
            return MarkupWriter.WriteAsync(text);
        }
    }
}
