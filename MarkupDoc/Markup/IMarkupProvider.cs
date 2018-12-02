﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Markup provider interface
    /// </summary>
    public interface IMarkupProvider
    {
        /// <summary>
        /// Gets or sets the <see cref="IMarkupWriter"/> used for the markup output
        /// </summary>
        IMarkupWriter MarkupWriter { get; set; }

        /// <summary>
        /// Writes the markup for the beginning of the document (file)
        /// </summary>
        /// <param name="title">Document title</param>
        /// <returns>Async task</returns>
        Task WriteDocumentStartAsync(string title = null);

        /// <summary>
        /// Writes the markup for the end of the document (file)
        /// </summary>
        /// <returns>Async task</returns>
        Task WriteDocumentEndAsync();

        /// <summary>
        /// Writes the <paramref name="text"/> to the output
        /// </summary>
        /// <param name="text">Text to write to the output</param>
        /// <returns>Async task</returns>
        Task WriteTextAsync(string text = null);

        /// <summary>
        /// Writes the markup for paragraph with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content of the paragraph</param>
        /// <returns>Async task</returns>
        Task WriteParaAsync(string text);

        /// <summary>
        /// Writes the level 1 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        Task WriteH1Async(string header, string bookmark = null);

        /// <summary>
        /// Writes the level 2 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        Task WriteH2Async(string header, string bookmark = null);

        /// <summary>
        /// Writes the level 3 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        Task WriteH3Async(string header, string bookmark = null);

        /// <summary>
        /// Writes the level 4 <paramref name="header"/> with  optional bookmark
        /// </summary>
        /// <param name="header">Header content</param>
        /// <param name="bookmark">Optional bookmark ID</param>
        /// <returns>Async task</returns>
        Task WriteH4Async(string header, string bookmark = null);

        /// <summary>
        /// Writes the markup for horizontal line
        /// </summary>
        /// <returns>Async task</returns>
        Task WriteHorizontalLineAsync();

        /// <summary>
        /// Writes the markup for multi-line code with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Async task</returns>
        Task WriteCodeAsync(string text, bool encodeNeeded = false);

        /// <summary>
        /// Writes the markup for the table header with given columns 
        /// </summary>
        /// <param name="items">Content of individual header columns</param>
        /// <returns>Async task</returns>
        Task WriteTableHeaderAsync(params string[] items);

        /// <summary>
        /// Writes the markup for the table row with given columns 
        /// </summary>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Async task</returns>
        Task WriteTableColsAsync(params string[] items);

        /// <summary>
        /// Writes the markup for the table footer
        /// </summary>
        /// <returns>Async task</returns>
        Task WriteTableFooterAsync();

        /// <summary>
        /// Returns the markup for the "plain" text 
        /// </summary>
        /// <param name="text">Content</param>
        /// <returns>Markup for the "plain" text </returns>
        string Text(string text);

        /// <summary>
        /// Returns the markup for bold (strong) <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content</param>
        /// <returns>Markup for bold (strong) <paramref name="text"/></returns>
        string Bold(string text);

        /// <summary>
        /// Returns the markup for italic (emphasized) <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content</param>
        /// <returns>Markup for italic (emphasized) <paramref name="text"/></returns>
        string Italic(string text);

        /// <summary>
        /// Returns the markup for small <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content</param>
        /// <returns>Markup for small <paramref name="text"/></returns>
        string Small(string text);

        /// <summary>
        /// Returns the markup for multi-line code with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for code with given <paramref name="text"/></returns>
        string Code(string text, bool encodeNeeded = false);

        /// <summary>
        /// Returns the markup for inline code with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Inline code</param>
        /// <param name="encodeNeeded">Flag whether it's the <paramref name="text"/> needs the HTML encoding
        /// (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</param>
        /// <returns>Markup for inline code with given <paramref name="text"/></returns>
        string InlineCode(string text, bool encodeNeeded=false);

        /// <summary>
        /// Returns the markup for paragraph with given <paramref name="text"/>
        /// </summary>
        /// <param name="text">Content of the paragraph</param>
        /// <returns>Markup for paragraph with given <paramref name="text"/></returns>
        string Para(string text);

        /// <summary>
        /// Returns the markup for the list of the items 
        /// </summary>
        /// <typeparam name="TItemType">Type of the list item entry object</typeparam>
        /// <param name="itemOutput">Function returning the markup for single item</param>
        /// <param name="items">List items</param>
        /// <param name="numbered">Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</param>
        /// <returns>Markup for the list of the items</returns>
        string List<TItemType>(Func<TItemType, string> itemOutput, IEnumerable<TItemType> items, bool numbered = false);

        /// <summary>
        /// Returns the markup for the table header with given columns 
        /// </summary>
        /// <param name="items">Content of individual header columns</param>
        /// <returns>Markup for the table header with given columns</returns>
        string TableHeader(params string[] items);

        /// <summary>
        /// Returns the markup for the table row with given columns 
        /// </summary>
        /// <param name="items">Content of individual columns</param>
        /// <returns>Markup for the table row with given columns</returns>
        string TableCols(params string[] items);

        /// <summary>
        /// Returns the markup for the table footer
        /// </summary>
        /// <returns>Markup for the table footer</returns>
        string TableFooter();

        /// <summary>
        /// Returns the markup for the description list with the given <paramref name="items"/>
        /// </summary>
        ///<typeparam name="TItemType">Type of the object to generate the description list item for</typeparam>
        /// <param name="itemTerm">Function to get the term for given item</param>
        /// <param name="itemDescription">Function to get the description for given item</param>
        /// <param name="items">Description list items</param>
        /// <returns>Markup for the description list with the given <paramref name="items"/></returns>
        string DescriptionList<TItemType>(Func<TItemType, string> itemTerm, Func<TItemType, string> itemDescription, IEnumerable<TItemType> items);

        /// <summary>
        /// Returns the markup for the description list with the given <paramref name="renderedItems"/>
        /// </summary>
        /// <param name="renderedItems">Description list items markup</param>
        /// <returns>Markup for the description list with the given <paramref name="renderedItems"/></returns>
        string DescriptionList(IList<string> renderedItems);

        /// <summary>
        /// Returns the markup of the description list item
        /// </summary>
        ///<typeparam name="TItemType">Type of the object to generate the description list item for</typeparam>
        /// <param name="itemTerm">Function to get the term for given item</param>
        /// <param name="itemDescription">Function to get the description for given item</param>
        /// <param name="item">Object to generate the description list item for</param>
        /// <returns>Markup of the description list item</returns>
        string DescriptionListItem<TItemType>(Func<TItemType, string> itemTerm, Func<TItemType, string> itemDescription, TItemType item);

        /// <summary>
        /// Returns the markup of the description list item
        /// </summary>
        /// <param name="itemTerm">Item term</param>
        /// <param name="itemDescription">Item description</param>
        /// <returns>Markup of the description list item</returns>
        string DescriptionListItem(string itemTerm, string itemDescription);

        /// <summary>
        /// Returns the markup of the bookmark with given <paramref name="id"/>
        /// </summary>
        /// <param name="id">Bookmark id</param>
        /// <returns>Markup of the bookmark with given <paramref name="id"/></returns>
        string Bookmark(string id);

        /// <summary>
        /// Returns the markup for the internal link
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="member"><see cref="Member"/> to generate the link to</param>
        /// <returns>Markup for the internal link</returns>
        string Link(string text, Member member);

        /// <summary>
        /// Returns the markup for the internal link
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="file">Name of the file relative to the documentation root (index file)</param>
        /// <param name="bookmark">Optional bookmark</param>
        /// <returns>Markup for the internal link</returns>
        string Link(string text, string file, string bookmark);
        /// <summary>
        /// Returns the markup for the external link
        /// </summary>
        /// <param name="text">Link text</param>
        /// <param name="url">Link URL</param>
        /// <returns>Markup for the external link</returns>
        string ExternalLink(string text, string url);
        /// <summary>
        /// Returns the markup for the line break
        /// </summary>
        /// <returns>Markup for the line break</returns>
        string LineBreak();
    }
}