# MarkupDoc #
MarkupDoc is a command line application that creates the code documentation for C# projects in selected markup format(s). MarkupDoc currently supports the [Markdown](https://daringfireball.net/projects/markdown/syntax) (output optimized for [GitHub's GFM](https://github.github.com/gfm/)) and HTML markup formats.

I have created the MarkupDoc as could not find any tool allowing me to simply generate the markdown (GFM) code documentation during the build process. During the development I have added the support to HTML as I have used some HTML constructs anyway and the HTML provides better flexibility in terms of styling the output. 

## Key features ##
- Generates Markdown (GFM) and/or HTML documentation from the C# source code (C# project). I have tried to have a look and feel similar to [MS API browser](https://docs.microsoft.com/en-us/dotnet/api/) (without the side navigation)
- It's possible to generate single file for the whole documentation or split the files per namespace or per type
- MarkupDoc works just with the source code, no XML documentation file nor compiled binary (assembly) is needed
- Implicitly declared members and members with attribute `CompilerGenerated` are excluded from generated documentation.
- Special names for types - The common types like `System.Int32` are translated to common form (`int` in this example). Also common types like `System.Collections.Generic.List` are shortened (`List` here). For the complete list see the implementation if `TypeRef.ApplySpecialName` (the private overload ;-) ).
- The generated "internal" (member) links should be stable (deterministic), so it might be possible to have the permanent links to the generated documentation as far as the members' signatures remains the same.
- Links to online Microsoft API documentation can be generated when the "MS types" are referred
- It's possible to extend the markup providers, that are responsible for formatting the output to required markup, however this currently means to build the own clone of the MarkupDoc.

Just see yourself in [samples](doc/samples). The `SampleToDocument` project contains no logic, just a bunch of samples to see, how the different language constructs and XML documentation comments render to markup documentation. It might also help to understand the limitations described below (so you can compare the code and the sample output). The "real code" documentation can be seen in markup [code documentation](doc/MarkupDoc.md). 

## How to use MarkupDoc ##
Generate the markup documentation of C# project code by running the `MarkupDoc` from the command line

**Usage**
`MarkupDoc <project_file> [<help>] [<config_file>] [<Options>...]`

**Project file**
`<project_file>` - Full path to the C# project file (.csproj) of the project to be documented

**Help**
`/h | /help | /? | -h | -help | -?` - Shows the help and don't start any processing. In this case, the `<project_file>` may be missing.

**Config file**
`-c:<config_file> | /c:<config_file>` - Use the options from given configuration JSON file. `<config_file>` is 
 the full path of the configuration file.

**Options**
`-p:key=value | /p:key=value`

Set the processing option(s):
 - **`Output.Target=<target>`** - Full path to the target file without the extension (will be added for individual markup outputs). When not provided, the documentation will be generated to the project directory to the file `doc.<ext>`. When splitting the output, the target file is the name of the main (index) file.
 - **`Output.Title=<title>`** - The title is added to the header of each generated documentation page. When not provided, the default title "Documentation" will be used.
 - **`Output.Html[=true] | Output.Html=false`** - Flag whether to generate the documentation in HTML format. When not provided, the HTML documentation will be generated.
 - **`Output.HtmlExtension=<html_extension>`** - Extension (without leading dot) of the generated HTML files. When not provided, `html` will be used.
 - **`Output.Markdown[=true] | Output.Markdown=false`** - Flag whether to generate the documentation in Markdown format. When not provided, the Markdown documentation will be generated.
 - **`Output.MarkdownExtension=<markdown_extension>`** - Extension (without leading dot) of the generated Markdown files. When not provided, `md` will be used.
 - **`Output.SplitNs[=true] | Output.SplitNs=false`** - Flag whether to split the output per namespace.When not provided, namespace splits will not be generated.
 - **`Output.SplitType[=true] | Output.SplitType=false`** - Flag whether to split the output per type. When splitting per file, the namespace splits will be also generated. When not provided, type splits will not be generated.
 - **`MicrosoftApi.LinkToApi[=true] | MicrosoftApi.LinkToApi=false`** - Set to true, to allow the links to MS API to be generated to the output. If false, no "external" links will be created at all. When not provided, the links will to MS API will be generated.
 - **`MicrosoftApi.ApiBaseUrl=<base_url>`** - MS online API documentation base url including the ending slash. When not provided, `https://docs.microsoft.com/en-us/dotnet/api/` is used by default.
 - **`MicrosoftApi.RequireLocalDoc[=true] | MicrosoftApi.RequireLocalDoc=false`** - Set to `true` to minimize the false links by forcing the use of local clone of the MS documentation. Set to `false`, allowing the engine to try to create the links even if the type is not found in local documentation. When not set, the engine will not force the use of local clone.
 - **`MicrosoftApi.LocalDocDir=<path>`** - Path to the local clone of MS documentation (directory must contain `xml\FrameworksIndex` subdirectory. When not provided, the warning will be raised and the "empty" local documentation will be used (meaning that no links will be generated when the `MicrosoftApi.RequireLocalDoc` is set).
   
These options can be set in:
 - *built-in default values*
 - `markupdoc.json` file stored in project directory
 - environment variables
 - JSON configuration file provided as a command line parameter
 - Command line options (`-p:key=value` or `/p:key=value`)

The lower overwrite the upper ones (meaning that the command line options have the highest priority)

Note: The binaries are built for .NET Framework 4.7 and [Costura add-in for Fody](https://github.com/Fody/Costura) is used to embed the most of referenced libraries into the executable.

Note: The sources also contain the `Directory.Build.props` and `Directory.Build.targets` demonstrating the **use of MarkupDoc within a build process**. It's safe to remove or modify the files - no key functionality is in there.

### Namespace documentation ###
The namespace XML documentation comments are not available for the namespace itself. To document the namespace, create a class `NamespaceDoc` within the namespace and add the namespace documentation to this class. It's recommended to mark the class with `CompilerGenerated` attribute, so it will be excluded from the documentation as a type (meaning, the documentation will be applied to namespace and the class itself will not appear in the documentation).

```csharp
namespace net.adamec.lib.common.dummy
{
	/// <summary>
	/// Test namespace comment
	/// </summary>
	/// <remarks>Add something more if you want</remarks>
	/// <seealso cref="Dummy"/>
	[System.Runtime.CompilerServices.CompilerGeneratedAttribute]
	internal class NamespaceDoc { }

	...
}
``` 

## Limitations ##
These are the know limitations of MarkupDoc. Note, that "not supported" usually mean that it's not reflected in output, but will not stop processing or throw an exception.

- **Works with C# projects only**. Implementation is based on https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/ and I have tried to add as much from C# up to version 7.2 where it made sense to me (or I didn't forget about)
- Modifier `unsafe` not supported (at all). 
- Enums - when a value refers to another one, the "final" value is show (for definition `ValueA=4` and `ValueB=ValueA`, the output states `ValueB=4`)
- The generic type references are expanded (for field `public V Field1` in class `TestFields<U,V>` the output is `public TestFields<U,V>.V Field1`
- Tuples always contain the name, even if not specified (default `Item*X*` is shown)
- Local functions/methods (declared within method) are intentionally excluded from the output
- Parameter defaults for reference types are always presented as `null` even if defined like `default()`. Value type constants (including enums) are always "evaluated" (`5` is shown where `int p=2+3`) There is a format conversion for some types (char, string, bool, numeric types) to present the value "as much as in code".
- Conversion methods - alias (the name show in member lists) "From" doesn't contain the type (intentionally as it's clear from the signature), alias "To" does contain the simple type name, so both conversions to `List<int>` and `List<string>` will have name `ToList` (but correct signature of course) - this is just to keep the aliases simple
attribute listing is shown for "entity" attributes only to keep output simple, (type) parameters attributes show in code only
- Return type and accessor attributes are not documented
- Nested types (including delegates) are intentionally presented in namespace, to have all types together
- Events with explicit accessors have `{ add; remove; }` in code declaration documentation, but no implementation bodies (intentionally)
- XML documentation 
 - Nested references (for example `<see>` within another `<see>` - not recommended, it somehow manages it, but it doesn't make sense to have nested links anyway
 - `<inheritdoc/>` not supported
- Links to online MS .NET API documentation 
 - The links are provided also for constants, but the there are no dedicated pages for them, so the links will not work. I couldn't recognize the "regular" field and constant
 - When used  in comments, the references to types are always extended (for example System.Collections.Generic.List\`1 is shown
- No special handling of explicit interface implementation members
 

## Ideas for further development ##
I have some ideas in the backlog (unordered)

 - Support `<inheritdoc/>` tag
 - Provide dedicated "section" for explicit interface implementations
 - Provide the list of extension methods for the documented types
 - Provide the list of types that derives for a particular type
 - Provide the list of interfaces and classes that implements a particular interface
 - Get the information about the .NET platform (framework) used in documented project and take it into the consideration when linking to online MS API documentation
 - Better extensibility with support for both built-in and plugin markup generators and providers (configuration and DI)
 - Support external CSS for HTML output (both linked and embedded)

## Links to online Microsoft API documentation ##
[MS API browser](https://docs.microsoft.com/en-us/dotnet/api/) provides the online documentation for .NET API types and their members. The MarkupDoc can generate the links to MS online API documentation when referring to the .NET API types and their members.

The Roslyn compiler returns ID of any symbol via [GetDocumentationCommentId](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol.getdocumentationcommentid) "/>, (even if there is no documentation), so it's possible to use such ID as member identifier for types, properties, methods, etc. MarkupDoc uses the local clone of .NET API documentation [sources](https://github.com/dotnet/dotnet-api-docs) to check whether there might be an online documentation available and generates the links accordingly. When the local clone is not available (or it's use is suppressed), the engine will try to build the links based on the namespace and name of member for limited set of members. When the link can't be generated, there will be no link in the documentation output.


The links are created based on the "observation" how they are composed at the MS API site, so it's best effort approach and the links are not granted to be hundred percent correct. Also the API Browser don't have the pages/anchors for constants (including the enum items), so the generated links will not work in this case.
    
The behavior of MS link handling can be adjusted using the configuration when running MarkupDoc. To get the best results, clone the .NET API documentation from https://github.com/dotnet/dotnet-api-docs to local directory. And use following configuration

 - **MicrosoftApi.LinkToApi** - set to `true`, to allow the links to MS API to be generated into the output (if `false`, no "external" links will be created at all)
 - **MicrosoftApi.ApiBaseUrl** - it's set to https://docs.microsoft.com/en-us/dotnet/api/ by default. As far as there is no change at MS side, no need to configure. *Note: The URL must end with "/"*.
 - **MicrosoftApi.RequireLocalDoc** - set to `true` to minimize the false links. *Note: set to `false` allowing the engine to try to create the links even if not found in local documentation.*
 - **MicrosoftApi.LocalDocDir** - path to the local clone of MS documentation (directory must contain `xml\FrameworksIndex` subdirectory

For more details, check the [code documentation](doc/MarkupDoc.md) (implementation details) and [samples](doc/samples) (the output).

## Extensibility ##
MarkupDoc doesn't provide the "run-time" extensibility, but it's possible to implement own markup providers, that converts the internal code model to required markup.

The process is currently quite simple

1. The `ModelBuilder` creates the code model using Roslyn semantic analyses of the source code. 
2. The `MarkupGenerator` instance is created for each output. The generator gets the name of the file to generate (index file in case or split), code model (`Root` object) and the instance of markup provider and produces required output
 - **Markup generator** implements the overall look and feel 
 - **Markup provider** (`IMarkupProvider`) is used to apply the markup to the fragments and push them to the writer. The markup provider implements the markup format (language)
 - **Markup writer** (`IMarkupWriter`) is the layer responsible for physical output to the file (or virtually to any output stream). It's also responsible for file handling, good example is split of the output, where the writer close the current file and creates a new one when a split is required.   

Notes:

 - The code model should not be manipulated (changed) once built. That's the reason, why the code model member classes are "immutable" and are constructed from mutable builder objects created by `ModelBuilder`. Use the `RootMember` constructor to build the whole code model hierarchy from the `RootMemberBuilder` that contains such hierarchy and the details about individual entities. 
 - Using the Roslyn semantic analyses are used, doesn't grant that the documented code will compile. It just tries to understand the code as much a possible. When I use the MarkupDoc as a part of the build process, it's called after the build target, so in this case, the code is expected to be valid.  

When changing the existing markup provider, simply inherit from the provider class and override the methods to be updated. That's the recommended way, how to do it as it's not destructive for the default providers. When adding a markup format, create a new class implementing the `IMarkupProvider'. It's recommended to extend the options/configuration as well, when a new provider (both for existing and new markup).

The `MarkupGenerator` is the class traversing the code model, building the documentation and render the output using the markup provider. The most of methods are `virtual`, so it should be simple to inherit and override, however the type of the generator is currently hard-coded in `Main` function.

For more details, check the code documentation (implementation details) and samples (the output).


 
### IMarkupProvider ###
Markup provider must implement `IMarkupProvider` interface. There are two types of methods there

- "Write" methods write the output directly to file (respective to `IMarkupWriter` that is a kind of layer between. BTW: The generator should never write to the writer directly, always use the markup provider).
- Other methods return the rendered fragment and are used to build a "composite" that will be written to the output using the "Write" method. 

```csharp
public interface IMarkupProvider
{
	IMarkupWriter MarkupWriter { get; set; }

	Task WriteDocumentStartAsync(string title = null);
	Task WriteDocumentEndAsync();
	Task WriteTextAsync(string text = null);
	Task WriteParaAsync(string text);
	Task WriteH1Async(string header, string bookmark = null);
	Task WriteH2Async(string header, string bookmark = null);
	Task WriteH3Async(string header, string bookmark = null);
	Task WriteH4Async(string header, string bookmark = null);
	Task WriteHorizontalLineAsync();
	Task WriteCodeAsync(string text);
	Task WriteTableHeaderAsync(params string[] items);
	Task WriteTableColsAsync(params string[] items);
	Task WriteTableFooterAsync();

	string Text(string text);
	string Bold(string text);
	string Italic(string text);
	string Small(string text);
	string Code(string text);
	string InlineCode(string text);
	string Para(string text);
	string List<TItemType>(Func<TItemType, string> itemOutput, IEnumerable<TItemType> items, bool numbered = false);
	string TableHeader(params string[] items);
	string TableCols(params string[] items);
	string TableFooter();
	string DescriptionList<TItemType>(Func<TItemType, string> itemTerm, Func<TItemType, string> itemDescription, IEnumerable<TItemType> items);
	string DescriptionList(IList<string> renderedItems);
	string DescriptionListItem<TItemType>(Func<TItemType, string> itemTerm, Func<TItemType, string> itemDescription, TItemType item);
	string DescriptionListItem(string itemTerm, string itemDescription);
	string Bookmark(string id);
	string Link(string text, Member member);
	string Link(string text, string file, string bookmark);
	string ExternalLink(string text, string url);
	string LineBreak();
}
```

### XML Documentation Comments ###
Roslyn provides the XML documentation for symbols via [ISymbol.GetDocumentationCommentXml](https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol.getdocumentationcommentxml). MarkupDoc parses the XML into corresponding classes. The XML Documentation classes renders the content into the output and can use the `IMarkupProvider` to format the output.

### Some HACKs... ###
Sometimes I have used some kind of hacks to get to the required functionality. In general, I'm not really happy with such solution as it might have some side effects or behavior I missed.
 - I found it quite tricky to manage the whitespaces for different markups and "tags". Pseudo-tags `<BREAK>` and `<SPACE>` are used in interim outputs
 - IsNew property is internal in Roslyn, used reflection to invoke it. Seems better to me than walking through the syntax tree
 - The method is marked as extension method, when the first parametr has `this` modifier