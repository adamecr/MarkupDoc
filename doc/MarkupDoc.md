#  MarkupDoc Documentation #
##  <a id="namespace-list" />  Namespaces ##

 | Name | Summary | 
 | ------ | --------- | 
 | [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh) | Main application namespace. Contains [Program](#t-net.adamec.dev.markupdoc.program__cagybt) and [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn) classes | 
 | [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55) | Code model related classes | 
 | [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa) | Code model builder classes | 
 | [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv) | Markup composition related classes | 
 | [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l) | MS online API links helper classes | 
 | [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn) | Configuration container and output options classes | 
 | [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs) | Utility classes | 
 | [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw) | Extension classes | 
 | [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6) | XML Comment Documentation DTO classes | 

##  <a id="type-list" />  Types ##

 | Name | Modifier | Kind | Summary | 
 | ------ | ---------- | ------ | --------- | 
 | [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn) | public | Class | Main application class - encapsulates the documentation building logic | 
 | [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | public | Class | Represents an assembly within the code model | 
 | [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) | public | Class | Builder for [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | 
 | [AttributeDataExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y) | public static | Class | Extension methods for <em>Microsoft.CodeAnalysis.AttributeData</em> | 
 | [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9) | public abstract | Class | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) | public | Class | Class representing &lt;c&gt; element of XML Documentation Comments | 
 | [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) | public | Class | Class representing &lt;code&gt; element of XML Documentation Comments | 
 | [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) | public | Class | Singleton holding the application configuration (options) | 
 | [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) | public | Class | Configuration builder providing the methods for adding the configuration items from individual sources | 
 | [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2) | public static | Class | Console output helpers | 
 | [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) | public | Class | Class representing (internal) &lt;member&gt; element of XML Documentation Comments. Used as a root documentation object for the code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | 
 | [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | public | Class | Represents an event within the code model | 
 | [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) | public | Class | Builder for [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | 
 | [Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54) | public | Class | Class representing &lt;example&gt; element of XML Documentation Comments | 
 | [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) | public | Class | Class representing &lt;exception&gt; element of XML Documentation  Comments | 
 | [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | public | Class | Represents a field within the code model | 
 | [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) | public | Class | Builder for [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | 
 | [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj) | public | Class | HTML markup provider | 
 | [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0) | public static | Class | Extension methods for <em>Microsoft.CodeAnalysis.IMethodSymbol</em> related to the operators | 
 | [IsNewUtils](#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x) | public static | Class | Helpers to get the access to internal ISymbol.IsNew property | 
 | [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) | public | Class | Class representing &lt;list&gt; element of XML Documentation  Comments | 
 | [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) | public | Class | Class representing &lt;item&gt; and &lt;listheader&gt; elements of XML Documentation Comments | 
 | [ListOfParametersExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r) | public static | Class | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >System.Collections.Generic.ICollection`1</a> of [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) and [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9) | public | Class | Markdown markup provider | 
 | [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys) | public | Class | Markup output single file writer | 
 | [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36) | public | Class | Markup generator | 
 | [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb) | public | Class | Markup output multi file writer | 
 | [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | public abstract | Class | Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc. | 
 | [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) | public abstract | Class | Builder for [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | 
 | [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | public | Class | Represents a method within the code model | 
 | [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) | public | Class | Builder for [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | 
 | [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | public | Class | Represents a method parameter within the code model | 
 | [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux) | public | Class | Builder for [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2) | public static | Class | Code model builder | 
 | [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) | public | Class | Base class for the XML Documentation Comments elements and nodes It&#39;s inherited by &quot;known&quot; nodes/elements, itself instanciated when the node/element is not recognized (known). | 
 | [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) | public abstract | Class | Abstract class representing the element of XML Documentation Comments that have the `cref` attribute | 
 | [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3) | public abstract | Class | Abstract class representing the element of XML Documentation Comments that have the `cref` attribute and simple rendering logic - just the link and/or content | 
 | [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe) | public abstract | Class | Abstract class representing the element of XML Documentation Comments that have the `name` attribute | 
 | [ModifierEnumExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re) | public static | Class | Extension methods and factory for [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | 
 | [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | public | Class | Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members. | 
 | [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn) | public | Class | Configuration class for [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | 
 | [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | public | Class | Represents a namespace within the code model | 
 | [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) | public | Class | Builder for [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | 
 | [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) | public | Class | Output configuration | 
 | [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) | public | Class | Class representing &lt;para&gt; element of XML Documentation Comments | 
 | [Param](#t-net.adamec.dev.markupdoc.xmldocumentation.param__7q99qf) | public | Class | Class representing &lt;param&gt; element of XML Documentation  Comments | 
 | [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) | public | Class | Class representing &lt;paramref&gt; element of XML Documentation Comments | 
 | [Program](#t-net.adamec.dev.markupdoc.program__cagybt) | internal | Class | Main program entry class | 
 | [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | public | Class | Represents a property within the code model | 
 | [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) | public | Class | Builder for [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | 
 | [Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45) | public | Class | Class representing &lt;remarks&gt; element of XML Documentation Comments | 
 | [Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401) | public | Class | Class representing &lt;returns&gt; element of XML Documentation Comments | 
 | [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | public | Class | Represents a root of the code model | 
 | [RootMember.ProcessingInfoContainer](#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn) | public | Class | Processing information | 
 | [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) | public | Class | Builder for [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | 
 | [See](#t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun) | public | Class | Class representing &lt;see&gt; element of XML Documentation Comments | 
 | [SeeAlso](#t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46) | public | Class | Class representing &lt;seealso&gt; element of XML Documentation Comments | 
 | [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz) | public static | Class | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> | 
 | [Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy) | public | Class | Class representing &lt;summary&gt; element of XML Documentation Comments | 
 | [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) | public | Class | Class representing text node (content) of XML Documentation Comments | 
 | [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) | public | Class | Text builder | 
 | [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | public abstract | Class | Abstract class for type members (fields, properties, etc.) within the code model | 
 | [TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4) | public abstract | Class | Builder for [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | 
 | [TypeKindExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0) | public static | Class | Extension methods for <em>Microsoft.CodeAnalysis.TypeKind</em> | 
 | [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | public | Class | Represents a type within the code model | 
 | [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) | public | Class | Builder for [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | 
 | [TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z) | public | Class | Class representing &lt;typeparam&gt; element of XML Documentation Comments | 
 | [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | public | Class | Represents a type parameter within the code model | 
 | [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w) | public | Class | Builder for [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | 
 | [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo) | public | Class | Class representing &lt;typeparamref&gt; element of XML Documentation Comments | 
 | [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) | public | Class | Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types. There is only single TypeRef for a type even if used on multiple &quot;places&quot; | 
 | [Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn) | public | Class | Class representing &lt;value&gt; element of XML Documentation  Comments | 
 | [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) | public abstract | Interface | Markup provider interface | 
 | [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) | public abstract | Interface | Interface of the markup output writer | 
 | [INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg) | public abstract | Interface | Non writable interface of the output writer | 
 | [List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725) | public | Enum | List rendering type | 
 | [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0) | public | Enum | Possible member kinds | 
 | [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9) | public | Enum | Possible kinds of method symbols | 
 | [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | public | Enum | Possible access modifiers | 
 | [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7) | public | Enum | Possible reference parameter kinds | 
 | [SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km) | public | Enum | Possible split definitions | 
 | [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm) | public | Enum | Possible kinds of type symbol | 

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc__1d9f9qh" />  net.adamec.dev.markupdoc Namespace ##
Main application namespace. Contains [Program](#t-net.adamec.dev.markupdoc.program__cagybt) and [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn) classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn) | public | Main application class - encapsulates the documentation building logic | 
 | [Program](#t-net.adamec.dev.markupdoc.program__cagybt) | internal | Main program entry class | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.application__s1pcmn" />  Application Class ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc</small>


Main application class - encapsulates the documentation building logic



```csharp
public class Application
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [OutputOptions](#p-net.adamec.dev.markupdoc.application.outputoptions__66qbpi) | public | Output configuration | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Application(OutputOptions)](#m-net.adamec.dev.markupdoc.application.-ctor_net.adamec.dev.markupdoc.options.outputoptions___7a5mu0) | public | CTOR with output configuration | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RunAsync(string)](#m-net.adamec.dev.markupdoc.application.runasync_system.string___1ym8d3g) | public | Runs the documentation building logic | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.application.outputoptions__66qbpi" />  Application.OutputOptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn)</small>


Output configuration



```csharp
public OutputOptions OutputOptions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.application.-ctor_net.adamec.dev.markupdoc.options.outputoptions___7a5mu0" />  Application.Application(OutputOptions) Title ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn)</small>


CTOR with output configuration



```csharp
public Application(OutputOptions outputOptions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) <strong>outputOptions</strong></dt><dd>Output configuration</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.application.runasync_system.string___1ym8d3g" />  Application.RunAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](#t-net.adamec.dev.markupdoc.application__s1pcmn)</small>


Runs the documentation building logic



```csharp
public async Task RunAsync(string projectFile)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>projectFile</strong></dt><dd>Project file of C# project to build the documentation for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.program__cagybt" />  Program Class ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc</small>


Main program entry class



```csharp
internal class Program
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [DefaultConfigFile](#f-net.adamec.dev.markupdoc.program.defaultconfigfile__1hwhxfi) | markupdoc.json | Default configuration file name | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Help()](#m-net.adamec.dev.markupdoc.program.help__hbeo67) | public static | Writes the help to console | 
 | [Main(string[])](#m-net.adamec.dev.markupdoc.program.main_system.string_____1nu6hy8) | private static | Main console application entry point | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.program.defaultconfigfile__1hwhxfi" />  Program.DefaultConfigFile Constant ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](#t-net.adamec.dev.markupdoc.program__cagybt)</small>


Default configuration file name



```csharp
private const string DefaultConfigFile = "markupdoc.json"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.program.help__hbeo67" />  Program.Help() Title ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](#t-net.adamec.dev.markupdoc.program__cagybt)</small>


Writes the help to console



```csharp
public static void Help()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.program.main_system.string_____1nu6hy8" />  Program.Main(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc](#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](#t-net.adamec.dev.markupdoc.program__cagybt)</small>


Main console application entry point



```csharp
private static async Task<int> Main(string[] args)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>args</strong></dt><dd>Command line arguments</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;int&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.codemodel__1f8sg55" />  net.adamec.dev.markupdoc.CodeModel Namespace ##
Code model related classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | public | Represents an assembly within the code model | 
 | [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | public | Represents an event within the code model | 
 | [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | public | Represents a field within the code model | 
 | [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | public abstract | Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc. | 
 | [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | public | Represents a method within the code model | 
 | [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | public | Represents a method parameter within the code model | 
 | [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | public | Represents a namespace within the code model | 
 | [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | public | Represents a property within the code model | 
 | [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | public | Represents a root of the code model | 
 | [RootMember.ProcessingInfoContainer](#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn) | public | Processing information | 
 | [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | public abstract | Abstract class for type members (fields, properties, etc.) within the code model | 
 | [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | public | Represents a type within the code model | 
 | [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | public | Represents a type parameter within the code model | 
 | [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) | public | Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types. There is only single TypeRef for a type even if used on multiple &quot;places&quot; | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0) | public | Possible member kinds | 
 | [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9) | public | Possible kinds of method symbols | 
 | [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | public | Possible access modifiers | 
 | [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7) | public | Possible reference parameter kinds | 
 | [SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km) | public | Possible split definitions | 
 | [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm) | public | Possible kinds of type symbol | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j" />  AssemblyMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents an assembly within the code model



```csharp
public class AssemblyMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllTypes](#p-net.adamec.dev.markupdoc.codemodel.assemblymember.alltypes__4kuzf7) | public | List of all types (including interfaces, delegates, etc.) defined within the assembly | 
 | [Namespaces](#p-net.adamec.dev.markupdoc.codemodel.assemblymember.namespaces__88sxjl) | public | List of namespaces within the assembly | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMember(AssemblyMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.assemblymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder___nqmg6r) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.assemblymember.alltypes__4kuzf7" />  AssemblyMember.AllTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</small>


List of all types (including interfaces, delegates, etc.) defined within the assembly



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> AllTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.assemblymember.namespaces__88sxjl" />  AssemblyMember.Namespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</small>


List of namespaces within the assembly



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.NamespaceMember> Namespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.NamespaceMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.assemblymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder___nqmg6r" />  AssemblyMember.AssemblyMember(AssemblyMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</small>


CTOR - from builder



```csharp
public AssemblyMember(AssemblyMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l" />  EventMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents an event within the code model



```csharp
public class EventMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasExplicitAddAndRemove](#p-net.adamec.dev.markupdoc.codemodel.eventmember.hasexplicitaddandremove__1jois6b) | public | Flag whether the event has explicit implementation of add and remove accessors | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.eventmember.typeref__1klwzm2) | public | Delegate type (type reference) of the event handler | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EventMember(EventMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.eventmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder___ggrb3b) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.eventmember.hasexplicitaddandremove__1jois6b" />  EventMember.HasExplicitAddAndRemove Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)</small>


Flag whether the event has explicit implementation of add and remove accessors



```csharp
public bool HasExplicitAddAndRemove { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.eventmember.typeref__1klwzm2" />  EventMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)</small>


Delegate type (type reference) of the event handler



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.eventmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder___ggrb3b" />  EventMember.EventMember(EventMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)</small>


CTOR - from builder



```csharp
public EventMember(EventMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z" />  FieldMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a field within the code model



```csharp
public class FieldMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConstantValue](#p-net.adamec.dev.markupdoc.codemodel.fieldmember.constantvalue__16xaw06) | public | The constant value of the field | 
 | [IsConst](#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isconst__ynfeu8) | public | Flag whether the field is constant | 
 | [IsReadOnly](#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isreadonly__wmv1mh) | public | Flag whether the field is read only | 
 | [IsVolatile](#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isvolatile__b4otyf) | public | Flag whether the field is volatile | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.fieldmember.typeref__167hm5u) | public | Type (type reference) of the field value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FieldMember(FieldMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.fieldmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder___1fpgncf) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetConstantValueString()](#m-net.adamec.dev.markupdoc.codemodel.fieldmember.getconstantvaluestring__10j93v2) | public | Gets the constant value as string with &quot;code syntax&quot; (meaning how would be the value defined in the code) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.constantvalue__16xaw06" />  FieldMember.ConstantValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


The constant value of the field



```csharp
public object ConstantValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Remarks ###
The ConstantValue is not the definition (for example &quot;2+customId&quot;) but the value is evaluated to the target type (for example 1002 if the customId in previous example is constant 1000). It&#39;s also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isconst__ynfeu8" />  FieldMember.IsConst Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


Flag whether the field is constant



```csharp
public bool IsConst { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isreadonly__wmv1mh" />  FieldMember.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


Flag whether the field is read only



```csharp
public bool IsReadOnly { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isvolatile__b4otyf" />  FieldMember.IsVolatile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


Flag whether the field is volatile



```csharp
public bool IsVolatile { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.typeref__167hm5u" />  FieldMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


Type (type reference) of the field value



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.fieldmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder___1fpgncf" />  FieldMember.FieldMember(FieldMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


CTOR - from builder



```csharp
public FieldMember(FieldMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.fieldmember.getconstantvaluestring__10j93v2" />  FieldMember.GetConstantValueString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)</small>


Gets the constant value as string with &quot;code syntax&quot; (meaning how would be the value defined in the code)



```csharp
public string GetConstantValueString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The constant value constant</dd></dl>


###  Remarks ###
The constant value is stored as the object, so it&#39;s necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh" />  Member Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc.



```csharp
public abstract class Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
The code model should not be manipulated (changed) once built, however for the sake of the simplicity, the setters are currently kept public. This might change in future when (if) the MarkupDoc will come with greater extensibility


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Base36Chars](#f-net.adamec.dev.markupdoc.codemodel.member.base36chars__l4rdpm) | 0123456789abcdefghijklmnopqrstuvwxyz | Characters allowed in Base36 encoding | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllMembers](#p-net.adamec.dev.markupdoc.codemodel.member.allmembers__19b310x) | public | All child members, for example types for namespace; fields, properties, methods, etc. for types | 
 | [Anchor](#p-net.adamec.dev.markupdoc.codemodel.member.anchor__18l6dou) | public | Anchor to the member to point the links  (FileName.extension#Anchor) to proper part of generated output file. | 
 | [Assembly](#p-net.adamec.dev.markupdoc.codemodel.member.assembly__qc3fud) | public | Reference to the containing assembly member | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.member.attributes__rcsj8a) | public | Member&#39;s attributes definition (including the parameters). | 
 | [AttributeTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.member.attributetyperefs__1fb8l8x) | public | Types (type references) of the member attributes | 
 | [Documentation](#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) | public | Parsed XML documentation comments. [Documentation](#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) is the root element of the parsed XML documentation comments | 
 | [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) | public | Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod) | 
 | [DocumentationXml](#p-net.adamec.dev.markupdoc.codemodel.member.documentationxml__4przj0) | public | XML documentation comments | 
 | [FileName](#p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq) | public | File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor) | 
 | [Id](#p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq) | public | Member id, used to distinguish between the names when building the &quot;internal&quot; links (for example when ti difference is in case only) | 
 | [IsAbstract](#p-net.adamec.dev.markupdoc.codemodel.member.isabstract__1gf9bb1) | public | Flag whether the member is abstract | 
 | [IsExtern](#p-net.adamec.dev.markupdoc.codemodel.member.isextern__1tt02ct) | public | Flag whether the member is extern | 
 | [IsNew](#p-net.adamec.dev.markupdoc.codemodel.member.isnew__1y68kz9) | public | Flag whether the member hides member with the same name in base class | 
 | [IsOverride](#p-net.adamec.dev.markupdoc.codemodel.member.isoverride__hfq1uh) | public | Flag whether the member overrides the member in the base class | 
 | [IsSealed](#p-net.adamec.dev.markupdoc.codemodel.member.issealed__f7nzi7) | public | Flag whether the member is sealed | 
 | [IsStatic](#p-net.adamec.dev.markupdoc.codemodel.member.isstatic__5j9jyt) | public | Flag whether the member is static | 
 | [IsVirtual](#p-net.adamec.dev.markupdoc.codemodel.member.isvirtual__1ha2d4u) | public | Flag whether the member is virtual (can be overriden) | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.member.memberkind__vd33lr) | public | Kind (type) of the member | 
 | [Modifier](#p-net.adamec.dev.markupdoc.codemodel.member.modifier__11o4ay6) | public | Member modifier (public, private, etc.) | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w) | public | Name of the member as presented in generated output | 
 | [NameBase](#p-net.adamec.dev.markupdoc.codemodel.member.namebase__j1nvad) | public | Name of the member without type params, indexer params, operator params, etc. | 
 | [Namespace](#p-net.adamec.dev.markupdoc.codemodel.member.namespace__1asgr92) | public | Reference to the containing namespace member | 
 | [Root](#p-net.adamec.dev.markupdoc.codemodel.member.root__gg0v8x) | public | Reference to the root of the code model | 
 | [Symbol](#p-net.adamec.dev.markupdoc.codemodel.member.symbol__t0bfa1) | public | Roslyn semantic analysis symbol of the member | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Member(MemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.member.-ctor_net.adamec.dev.markupdoc.codemodel.builder.memberbuilder___z47b5f) | protected | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Base36(uint)](#m-net.adamec.dev.markupdoc.codemodel.member.base36_system.uint32___1qf9alr) | public static | Encodes the <strong>input</strong> number to Base36 encoded string | 
 | [FormatAnchor()](#m-net.adamec.dev.markupdoc.codemodel.member.formatanchor__17xjba4) | protected | Creates and format the anchor based on the [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) . In general, it gets the DocumentationID, trims is, converts it to lower case and replaces the &quot;special&quot; characters with &#39;_&#39; or &#39;-&#39; | 
 | [StableHash(string)](#m-net.adamec.dev.markupdoc.codemodel.member.stablehash_system.string___1fyn53c) | public static | Hashing function for strings that generates the sting hash as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >System.UInt32</a> | 
 | [ToString()](#m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm) | public | Returns the brief description of the member | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.member.base36chars__l4rdpm" />  Member.Base36Chars Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Characters allowed in Base36 encoding



```csharp
private const string Base36Chars = "0123456789abcdefghijklmnopqrstuvwxyz"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.allmembers__19b310x" />  Member.AllMembers Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


All child members, for example types for namespace; fields, properties, methods, etc. for types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.Member> AllMembers { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.anchor__18l6dou" />  Member.Anchor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Anchor to the member to point the links  (FileName.extension#Anchor) to proper part of generated output file.



```csharp
public virtual string Anchor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.assembly__qc3fud" />  Member.Assembly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Reference to the containing assembly member



```csharp
public AssemblyMember Assembly { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.attributes__rcsj8a" />  Member.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Member&#39;s attributes definition (including the parameters).



```csharp
public IReadOnlyList<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.attributetyperefs__1fb8l8x" />  Member.AttributeTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Types (type references) of the member attributes



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AttributeTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl" />  Member.Documentation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Parsed XML documentation comments. [Documentation](#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) is the root element of the parsed XML documentation comments



```csharp
public Documentation Documentation { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi" />  Member.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)



```csharp
public string DocumentationId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentationxml__4przj0" />  Member.DocumentationXml Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


XML documentation comments



```csharp
public string DocumentationXml { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq" />  Member.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor)



```csharp
public virtual string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq" />  Member.Id Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Member id, used to distinguish between the names when building the &quot;internal&quot; links (for example when ti difference is in case only)



```csharp
public string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
Id is not necessary unique across all members, but the combination [Name](#p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w) + [Id](#p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq) is believed to be unique. The Id is created/updated when the [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) is set and it&#39;s calculated as Base36 encoded hash of the DocumentationId




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isabstract__1gf9bb1" />  Member.IsAbstract Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member is abstract



```csharp
public bool IsAbstract { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isextern__1tt02ct" />  Member.IsExtern Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member is extern



```csharp
public bool IsExtern { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isnew__1y68kz9" />  Member.IsNew Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member hides member with the same name in base class



```csharp
public bool IsNew { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isoverride__hfq1uh" />  Member.IsOverride Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member overrides the member in the base class



```csharp
public bool IsOverride { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.issealed__f7nzi7" />  Member.IsSealed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member is sealed



```csharp
public bool IsSealed { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isstatic__5j9jyt" />  Member.IsStatic Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member is static



```csharp
public bool IsStatic { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isvirtual__1ha2d4u" />  Member.IsVirtual Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Flag whether the member is virtual (can be overriden)



```csharp
public bool IsVirtual { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.memberkind__vd33lr" />  Member.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Kind (type) of the member



```csharp
public MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.modifier__11o4ay6" />  Member.Modifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Member modifier (public, private, etc.)



```csharp
public ModifierEnum Modifier { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w" />  Member.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Name of the member as presented in generated output



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.namebase__j1nvad" />  Member.NameBase Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Name of the member without type params, indexer params, operator params, etc.



```csharp
public string NameBase { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.namespace__1asgr92" />  Member.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Reference to the containing namespace member



```csharp
public NamespaceMember Namespace { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.root__gg0v8x" />  Member.Root Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Reference to the root of the code model



```csharp
public RootMember Root { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.symbol__t0bfa1" />  Member.Symbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Roslyn semantic analysis symbol of the member



```csharp
public ISymbol Symbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.-ctor_net.adamec.dev.markupdoc.codemodel.builder.memberbuilder___z47b5f" />  Member.Member(MemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


CTOR - from builder



```csharp
protected Member(MemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.base36_system.uint32___1qf9alr" />  Member.Base36(uint) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Encodes the <strong>input</strong> number to Base36 encoded string



```csharp
public static string Base36(uint input)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >uint</a> <strong>input</strong></dt><dd>Number to encode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Base36 encoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.formatanchor__17xjba4" />  Member.FormatAnchor() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Creates and format the anchor based on the [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) . In general, it gets the DocumentationID, trims is, converts it to lower case and replaces the &quot;special&quot; characters with &#39;_&#39; or &#39;-&#39;



```csharp
protected string FormatAnchor()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The anchor for the member</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.stablehash_system.string___1fyn53c" />  Member.StableHash(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Hashing function for strings that generates the sting hash as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >System.UInt32</a>



```csharp
public static uint StableHash(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String to hash</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >uint</a></dt><dd>Hash of given string</dd></dl>


###  Remarks ###
The hash function is based on the .NET implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string.gethashcode#System_String_GetHashCode" target="_blank" >System.String.GetHashCode</a> optimized for 64bit processors. The reason for the explicit hash function is that the .NET implementation is not granted to be stable across versions and/or frameworks. The stability is needed as the Base36 encoded hash is a part of the file name and may be used in perma links


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm" />  Member.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)</small>


Returns the brief description of the member



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the member</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq" />  MethodMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a method within the code model



```csharp
public class MethodMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasParameters](#p-net.adamec.dev.markupdoc.codemodel.methodmember.hasparameters__1rxkvrw) | public | Flag whether the method has parameters | 
 | [IsAsync](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isasync__ytfsx0) | public | Flag whether the method is async | 
 | [IsConstructor](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isconstructor__ywn7v4) | public | Flag whether the method is construction | 
 | [IsConversion](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isconversion__b8j9og) | public | Flag whether the method is conversion | 
 | [IsDestructor](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isdestructor__ju36r5) | public | Flag whether the method is destructor | 
 | [IsExtensionMethod](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isextensionmethod__18y7t40) | public | Flag whether the method is extension method | 
 | [IsGeneric](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isgeneric__8ey4iz) | public | Flag whether method is generic | 
 | [IsOperator](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperator__1wwd9so) | public | Flag whether the method is operator | 
 | [IsOperatorOrConversion](#p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperatororconversion__1csdo8z) | public | Flag whether the method is operator or conversion | 
 | [MethodKind](#p-net.adamec.dev.markupdoc.codemodel.methodmember.methodkind__1xifuon) | public | Kind of the method (constructor, getter, regular method ...) | 
 | [OperatorCSharpSymbol](#p-net.adamec.dev.markupdoc.codemodel.methodmember.operatorcsharpsymbol__1q138b9) | public | C# operator symbol for operator method | 
 | [Parameters](#p-net.adamec.dev.markupdoc.codemodel.methodmember.parameters__17bkuxc) | public | Method parameters | 
 | [RefKind](#p-net.adamec.dev.markupdoc.codemodel.methodmember.refkind__2zcm51) | public | Method&#39;s return ref kind (none, ref) | 
 | [ReturnsByRef](#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyref__vlkvqj) | public | Flag whether the methods returns by reference | 
 | [ReturnsByRefReadonly](#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyrefreadonly__1dy3n4d) | public | Flag whether the methods returns by read only reference (ref readonly) | 
 | [ReturnsVoid](#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsvoid__1x5yr6t) | public | Flags whether the method returns void | 
 | [ReturnTypeRef](#p-net.adamec.dev.markupdoc.codemodel.methodmember.returntyperef__1kqintr) | public | Type reference of the method return type | 
 | [TypeParameters](#p-net.adamec.dev.markupdoc.codemodel.methodmember.typeparameters__ceqh5s) | public | Type parameters for generic methods | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MethodMember(MethodMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.methodmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder___brj243) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.hasparameters__1rxkvrw" />  MethodMember.HasParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method has parameters



```csharp
public bool HasParameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isasync__ytfsx0" />  MethodMember.IsAsync Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is async



```csharp
public bool IsAsync { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isconstructor__ywn7v4" />  MethodMember.IsConstructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is construction



```csharp
public bool IsConstructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isconversion__b8j9og" />  MethodMember.IsConversion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is conversion



```csharp
public bool IsConversion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isdestructor__ju36r5" />  MethodMember.IsDestructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is destructor



```csharp
public bool IsDestructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isextensionmethod__18y7t40" />  MethodMember.IsExtensionMethod Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is extension method



```csharp
public bool IsExtensionMethod { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isgeneric__8ey4iz" />  MethodMember.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether method is generic



```csharp
public bool IsGeneric { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperator__1wwd9so" />  MethodMember.IsOperator Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is operator



```csharp
public bool IsOperator { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperatororconversion__1csdo8z" />  MethodMember.IsOperatorOrConversion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the method is operator or conversion



```csharp
public bool IsOperatorOrConversion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.methodkind__1xifuon" />  MethodMember.MethodKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Kind of the method (constructor, getter, regular method ...)



```csharp
public MethodKindEnum MethodKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.operatorcsharpsymbol__1q138b9" />  MethodMember.OperatorCSharpSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


C# operator symbol for operator method



```csharp
public string OperatorCSharpSymbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.parameters__17bkuxc" />  MethodMember.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Method parameters



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.refkind__2zcm51" />  MethodMember.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Method&#39;s return ref kind (none, ref)



```csharp
public RefKindEnum RefKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyref__vlkvqj" />  MethodMember.ReturnsByRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the methods returns by reference



```csharp
public bool ReturnsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyrefreadonly__1dy3n4d" />  MethodMember.ReturnsByRefReadonly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flag whether the methods returns by read only reference (ref readonly)



```csharp
public bool ReturnsByRefReadonly { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsvoid__1x5yr6t" />  MethodMember.ReturnsVoid Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Flags whether the method returns void



```csharp
public bool ReturnsVoid { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returntyperef__1kqintr" />  MethodMember.ReturnTypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Type reference of the method return type



```csharp
public TypeRef ReturnTypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.typeparameters__ceqh5s" />  MethodMember.TypeParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


Type parameters for generic methods



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder___brj243" />  MethodMember.MethodMember(MethodMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</small>


CTOR - from builder



```csharp
public MethodMember(MethodMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483" />  MethodParameter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a method parameter within the code model



```csharp
public class MethodParameter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.attributes__njhgum) | public | Parameter attributes definition (including the parameters). | 
 | [ExplicitDefaultValue](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.explicitdefaultvalue__1tgn3en) | public | Parameter&#39;s explicitly defined default value (when available) | 
 | [HasExplicitDefaultValue](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.hasexplicitdefaultvalue__163byvx) | public | Flag whether the parameter has explicitly defined default value | 
 | [IsOptional](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isoptional__k07gdx) | public | Flag whether the parameter is optional | 
 | [IsParams](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isparams__1r0stz3) | public | Flag whether the parameter is with `params` modifier | 
 | [IsThis](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65) | public | Flag whether the parameter is with `this` modifier | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.name__1wzjmfo) | public | Name of the parameter | 
 | [RefKind](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.refkind__1vi47va) | public | Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In) | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.typeref__1j0ijds) | public | Type reference for the parameter&#39;s type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MethodParameter(MethodParameterBuilder)](#m-net.adamec.dev.markupdoc.codemodel.methodparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder___bbc2rj) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDefaultValueString()](#m-net.adamec.dev.markupdoc.codemodel.methodparameter.getdefaultvaluestring__1q0k02v) | public | Gets the default value for the parameter as string with &quot;code syntax&quot; (meaning how would be the value defined in the code) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.attributes__njhgum" />  MethodParameter.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Parameter attributes definition (including the parameters).



```csharp
public IReadOnlyList<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.explicitdefaultvalue__1tgn3en" />  MethodParameter.ExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Parameter&#39;s explicitly defined default value (when available)



```csharp
public object ExplicitDefaultValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.hasexplicitdefaultvalue__163byvx" />  MethodParameter.HasExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Flag whether the parameter has explicitly defined default value



```csharp
public bool HasExplicitDefaultValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isoptional__k07gdx" />  MethodParameter.IsOptional Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Flag whether the parameter is optional



```csharp
public bool IsOptional { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isparams__1r0stz3" />  MethodParameter.IsParams Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Flag whether the parameter is with `params` modifier



```csharp
public bool IsParams { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65" />  MethodParameter.IsThis Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Flag whether the parameter is with `this` modifier



```csharp
public bool IsThis { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.name__1wzjmfo" />  MethodParameter.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Name of the parameter



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.refkind__1vi47va" />  MethodParameter.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In)



```csharp
public RefKindEnum RefKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.typeref__1j0ijds" />  MethodParameter.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Type reference for the parameter&#39;s type



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder___bbc2rj" />  MethodParameter.MethodParameter(MethodParameterBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


CTOR - from builder



```csharp
public MethodParameter(MethodParameterBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodparameter.getdefaultvaluestring__1q0k02v" />  MethodParameter.GetDefaultValueString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)</small>


Gets the default value for the parameter as string with &quot;code syntax&quot; (meaning how would be the value defined in the code)



```csharp
public string GetDefaultValueString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The default value for the parameter or empty string if not defined</dd></dl>


###  Remarks ###
The default value is stored as the object, so it&#39;s necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li" />  NamespaceMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a namespace within the code model



```csharp
public class NamespaceMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsGlobalNamespace](#p-net.adamec.dev.markupdoc.codemodel.namespacemember.isglobalnamespace__1q6idri) | public | Flag whether the namespace is global | 
 | [Types](#p-net.adamec.dev.markupdoc.codemodel.namespacemember.types__16yd0zn) | public | List of all types (including interfaces, delegates, etc.) defined within the namespace | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NamespaceMember(NamespaceMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.namespacemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder___1wmw5ar) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](#m-net.adamec.dev.markupdoc.codemodel.namespacemember.tostring__pk2xyj) | public | Returns the brief description of the namespace | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.namespacemember.isglobalnamespace__1q6idri" />  NamespaceMember.IsGlobalNamespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</small>


Flag whether the namespace is global



```csharp
public bool IsGlobalNamespace { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.namespacemember.types__16yd0zn" />  NamespaceMember.Types Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</small>


List of all types (including interfaces, delegates, etc.) defined within the namespace



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> Types { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.namespacemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder___1wmw5ar" />  NamespaceMember.NamespaceMember(NamespaceMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</small>


CTOR - from builder



```csharp
public NamespaceMember(NamespaceMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.namespacemember.tostring__pk2xyj" />  NamespaceMember.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</small>


Returns the brief description of the namespace



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the namespace</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu" />  PropertyMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a property within the code model



```csharp
public class PropertyMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetterModifier](#p-net.adamec.dev.markupdoc.codemodel.propertymember.gettermodifier__17x8k4y) | public | Getter access modifier if it&#39;s different than the property one | 
 | [IsIndexer](#p-net.adamec.dev.markupdoc.codemodel.propertymember.isindexer__mmbewf) | public | Flag whether the property is indexer; | 
 | [IsReadOnly](#p-net.adamec.dev.markupdoc.codemodel.propertymember.isreadonly__10ggxbi) | public | Flag whether the property is read only | 
 | [IsWriteOnly](#p-net.adamec.dev.markupdoc.codemodel.propertymember.iswriteonly__s5y7lf) | public | Flag whether the property is write only | 
 | [Parameters](#p-net.adamec.dev.markupdoc.codemodel.propertymember.parameters__j2iqt4) | public | List of property parameters (if any). Just the indexers may have the parameters | 
 | [SetterModifier](#p-net.adamec.dev.markupdoc.codemodel.propertymember.settermodifier__j66486) | public | Setter access modifier if it&#39;s different than the property one | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.propertymember.typeref__3apeoh) | public | Type reference of property type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [PropertyMember(PropertyMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.propertymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder___1x2uhir) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.gettermodifier__17x8k4y" />  PropertyMember.GetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Getter access modifier if it&#39;s different than the property one



```csharp
public string GetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.isindexer__mmbewf" />  PropertyMember.IsIndexer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Flag whether the property is indexer;



```csharp
public bool IsIndexer { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.isreadonly__10ggxbi" />  PropertyMember.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Flag whether the property is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.iswriteonly__s5y7lf" />  PropertyMember.IsWriteOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Flag whether the property is write only



```csharp
public bool IsWriteOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.parameters__j2iqt4" />  PropertyMember.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


List of property parameters (if any). Just the indexers may have the parameters



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.settermodifier__j66486" />  PropertyMember.SetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Setter access modifier if it&#39;s different than the property one



```csharp
public string SetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.typeref__3apeoh" />  PropertyMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


Type reference of property type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.propertymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder___1x2uhir" />  PropertyMember.PropertyMember(PropertyMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)</small>


CTOR - from builder



```csharp
public PropertyMember(PropertyMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj" />  RootMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a root of the code model



```csharp
public class RootMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllMembersByDocId](#p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbydocid__lvh671) | public | Dictionary of all members by their documentation ID | 
 | [AllNamespaces](#p-net.adamec.dev.markupdoc.codemodel.rootmember.allnamespaces__uj34ta) | public | List of namespaces within the code model | 
 | [AllTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.rootmember.alltyperefs__loe4tc) | public | List of all type references used within the code model | 
 | [AllTypes](#p-net.adamec.dev.markupdoc.codemodel.rootmember.alltypes__1vf7rd7) | public | List of all types (including interfaces, delegates, etc.) defined within the code model | 
 | [Assemblies](#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih) | public | List of all assemblies defined within the code model | 
 | [ProcessingInfo](#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfo__1h25pqs) | public | Processing information. This is the only part that can be modified after the code model is built as it&#39;s used to adjust the behavior during the processing within markup generator | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RootMember(RootMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.rootmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___14y5g1f) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbydocid__lvh671" />  RootMember.AllMembersByDocId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


Dictionary of all members by their documentation ID



```csharp
public IReadOnlyDictionary<string,net.adamec.dev.markupdoc.CodeModel.Member> AllMembersByDocId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.dev.markupdoc.CodeModel.Member&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allnamespaces__uj34ta" />  RootMember.AllNamespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


List of namespaces within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.NamespaceMember> AllNamespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.NamespaceMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.alltyperefs__loe4tc" />  RootMember.AllTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


List of all type references used within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.alltypes__1vf7rd7" />  RootMember.AllTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


List of all types (including interfaces, delegates, etc.) defined within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> AllTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih" />  RootMember.Assemblies Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


List of all assemblies defined within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.AssemblyMember> Assemblies { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.AssemblyMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfo__1h25pqs" />  RootMember.ProcessingInfo Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


Processing information. This is the only part that can be modified after the code model is built as it&#39;s used to adjust the behavior during the processing within markup generator



```csharp
public RootMember.ProcessingInfoContainer ProcessingInfo { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember.ProcessingInfoContainer](#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___14y5g1f" />  RootMember.RootMember(RootMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</small>


CTOR - from builder



```csharp
public RootMember(RootMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>builder</strong></dt><dd>Builder</dd></dl>
###  Remarks ###
Use the [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) to build the whole code model hierarchy from the [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) that contains such hierarchy and the details about individual entities


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn" />  RootMember.ProcessingInfoContainer Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Processing information



```csharp
public class RootMember.ProcessingInfoContainer
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseMainFile](#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.basemainfile__t5z7wx) | public | Name of the main (index) file without the path and extension | 
 | [SplitFileType](#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.splitfiletype__gcnbr9) | public | Information whether and how to split the output (none, per namespace, per type) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.basemainfile__t5z7wx" />  RootMember.ProcessingInfoContainer.BaseMainFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember.ProcessingInfoContainer](#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)</small>


Name of the main (index) file without the path and extension



```csharp
public string BaseMainFile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.splitfiletype__gcnbr9" />  RootMember.ProcessingInfoContainer.SplitFileType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember.ProcessingInfoContainer](#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)</small>


Information whether and how to split the output (none, per namespace, per type)



```csharp
public SplitTypeEnum SplitFileType { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw" />  TypeContentMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Abstract class for type members (fields, properties, etc.) within the code model



```csharp
public abstract class TypeContentMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FileName](#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7) | public | File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor) | 
 | [Type](#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2) | public | Type containing the content member | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeContentMember(TypeContentMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.typecontentmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder___180rpzv) | protected | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7" />  TypeContentMember.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)</small>


File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor)



```csharp
public override string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
Type content is rendered together with type, so the [FileName](#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7) is taken from [Type](#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2" />  TypeContentMember.Type Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)</small>


Type containing the content member



```csharp
public TypeMember Type { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typecontentmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder___180rpzv" />  TypeContentMember.TypeContentMember(TypeContentMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)</small>


CTOR - from builder



```csharp
protected TypeContentMember(TypeContentMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp" />  TypeMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a type within the code model



```csharp
public class TypeMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DelegateParameters](#f-net.adamec.dev.markupdoc.codemodel.typemember.delegateparameters__1qbjoam) | public | Delegate parameters for delegate types | 
 | [DelegateReturnType](#f-net.adamec.dev.markupdoc.codemodel.typemember.delegatereturntype__bzbjz4) | public | Type reference for delegate return type | 
 | [TypeParameters](#f-net.adamec.dev.markupdoc.codemodel.typemember.typeparameters__994fx3) | public | Type parameters for generic types | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllInterfacesTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.typemember.allinterfacestyperefs__glhkkw) | public | Type references for all implemented interfaces (both directly implemented and inherited) | 
 | [Constructors](#p-net.adamec.dev.markupdoc.codemodel.typemember.constructors__r1xvmy) | public | All constructors defined within the type | 
 | [Conversions](#p-net.adamec.dev.markupdoc.codemodel.typemember.conversions__1u10dmc) | public | All conversions defined within the type | 
 | [Destructor](#p-net.adamec.dev.markupdoc.codemodel.typemember.destructor__xpqlhc) | public | Destructor defined within the type or null if none | 
 | [Events](#p-net.adamec.dev.markupdoc.codemodel.typemember.events__13nod8q) | public | All events defined within the type | 
 | [Fields](#p-net.adamec.dev.markupdoc.codemodel.typemember.fields__1mn3d06) | public | All fields defined within the type | 
 | [FileName](#p-net.adamec.dev.markupdoc.codemodel.typemember.filename__t0861a) | public | File name (without extension !!!) where the type should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is used when building the links to the member (FileName.extension#Anchor) | 
 | [FullName](#p-net.adamec.dev.markupdoc.codemodel.typemember.fullname__1f38d4f) | public | Type full name (namespace.type) | 
 | [ImplementsAnyInterface](#p-net.adamec.dev.markupdoc.codemodel.typemember.implementsanyinterface__1kg40n4) | public | Flag whether the type implements any (at least one) interface | 
 | [InterfacesTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.typemember.interfacestyperefs__11tpv8v) | public | Type references for directly implemented interfaces | 
 | [IsDelegate](#p-net.adamec.dev.markupdoc.codemodel.typemember.isdelegate__1w85a6g) | public | Flag whether type is delegate | 
 | [IsGeneric](#p-net.adamec.dev.markupdoc.codemodel.typemember.isgeneric__1l3ysmo) | public | Flag whether type is generic | 
 | [IsInherited](#p-net.adamec.dev.markupdoc.codemodel.typemember.isinherited__17xrtn5) | public | Flag whether the type is inherited (applicable to classes only) | 
 | [Methods](#p-net.adamec.dev.markupdoc.codemodel.typemember.methods__5f6ltb) | public | All methods defined within the type | 
 | [Operators](#p-net.adamec.dev.markupdoc.codemodel.typemember.operators__li6pd8) | public | All operators defined within the type | 
 | [OperatorsAndConversions](#p-net.adamec.dev.markupdoc.codemodel.typemember.operatorsandconversions__g20s4y) | public | All operators and conversions defined within the type | 
 | [Properties](#p-net.adamec.dev.markupdoc.codemodel.typemember.properties__148da3a) | public | All properties defined within the type | 
 | [TypeKind](#p-net.adamec.dev.markupdoc.codemodel.typemember.typekind__1eer5mr) | public | Type kind (class, interface, ...) | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.typemember.typeref__12qbfl8) | public | Type reference for this type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeMember(TypeMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.typemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder___1xi7kkz) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](#m-net.adamec.dev.markupdoc.codemodel.typemember.tostring__19326cy) | public | Returns the brief description of the type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.delegateparameters__1qbjoam" />  TypeMember.DelegateParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Delegate parameters for delegate types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> DelegateParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.delegatereturntype__bzbjz4" />  TypeMember.DelegateReturnType Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type reference for delegate return type



```csharp
public TypeRef DelegateReturnType
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.typeparameters__994fx3" />  TypeMember.TypeParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type parameters for generic types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.allinterfacestyperefs__glhkkw" />  TypeMember.AllInterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type references for all implemented interfaces (both directly implemented and inherited)



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllInterfacesTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.constructors__r1xvmy" />  TypeMember.Constructors Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All constructors defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Constructors { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.conversions__1u10dmc" />  TypeMember.Conversions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All conversions defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Conversions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.destructor__xpqlhc" />  TypeMember.Destructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Destructor defined within the type or null if none



```csharp
public MethodMember Destructor { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.events__13nod8q" />  TypeMember.Events Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All events defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.EventMember> Events { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.EventMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.fields__1mn3d06" />  TypeMember.Fields Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All fields defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.FieldMember> Fields { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.FieldMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.filename__t0861a" />  TypeMember.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


File name (without extension !!!) where the type should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is used when building the links to the member (FileName.extension#Anchor)



```csharp
public override string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.fullname__1f38d4f" />  TypeMember.FullName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type full name (namespace.type)



```csharp
public string FullName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.implementsanyinterface__1kg40n4" />  TypeMember.ImplementsAnyInterface Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Flag whether the type implements any (at least one) interface



```csharp
public bool ImplementsAnyInterface { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.interfacestyperefs__11tpv8v" />  TypeMember.InterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type references for directly implemented interfaces



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> InterfacesTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isdelegate__1w85a6g" />  TypeMember.IsDelegate Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Flag whether type is delegate



```csharp
public bool IsDelegate { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isgeneric__1l3ysmo" />  TypeMember.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Flag whether type is generic



```csharp
public bool IsGeneric { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isinherited__17xrtn5" />  TypeMember.IsInherited Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Flag whether the type is inherited (applicable to classes only)



```csharp
public bool IsInherited { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.methods__5f6ltb" />  TypeMember.Methods Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All methods defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Methods { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.operators__li6pd8" />  TypeMember.Operators Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All operators defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Operators { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.operatorsandconversions__g20s4y" />  TypeMember.OperatorsAndConversions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All operators and conversions defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> OperatorsAndConversions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.properties__148da3a" />  TypeMember.Properties Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


All properties defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.PropertyMember> Properties { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.PropertyMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.typekind__1eer5mr" />  TypeMember.TypeKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type kind (class, interface, ...)



```csharp
public TypeKindEnum TypeKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.typeref__12qbfl8" />  TypeMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Type reference for this type



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder___1xi7kkz" />  TypeMember.TypeMember(TypeMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


CTOR - from builder



```csharp
public TypeMember(TypeMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typemember.tostring__19326cy" />  TypeMember.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</small>


Returns the brief description of the type



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the type</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408" />  TypeParameter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Represents a type parameter within the code model



```csharp
public class TypeParameter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.attributes__inz4tx) | public | Type parameter attributes definition (including the parameters). | 
 | [ConstraintTypes](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.constrainttypes__z92o1e) | public | List of type references of constraint types  when the concrete types are defined as constraints | 
 | [HasAnyConstraint](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasanyconstraint__1iy1zr7) | public | Flag whether the type parameter has any constraint | 
 | [HasConstructorConstraint](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasconstructorconstraint__wqv9qt) | public | Flag whether the type parameter has constructor constraint ( new() ) | 
 | [HasReferenceTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasreferencetypeconstraint__143rl1s) | public | Flag whether the type parameter has reference type constraint ( class ) | 
 | [HasUnmanagedTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasunmanagedtypeconstraint__nm7zzj) | public | Flag whether the type parameter has unmanaged type constraint ( unmanaged ) | 
 | [HasValueTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasvaluetypeconstraint__1ukksns) | public | Flag whether the type parameter has value type constraint ( struct ) | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.name__1h5j7x) | public | Name of the parameter | 
 | [Variance](#p-net.adamec.dev.markupdoc.codemodel.typeparameter.variance__a30lyr) | public | Variance (covariance and contravariance) modifier (in, out) for the type parameter if available. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeParameter(TypeParameterBuilder)](#m-net.adamec.dev.markupdoc.codemodel.typeparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder___nocdp7) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetConstraintsString()](#m-net.adamec.dev.markupdoc.codemodel.typeparameter.getconstraintsstring__iddb2s) | public | Returns the string with all constraints as defined in code | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.attributes__inz4tx" />  TypeParameter.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Type parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.constrainttypes__z92o1e" />  TypeParameter.ConstraintTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


List of type references of constraint types  when the concrete types are defined as constraints



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> ConstraintTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasanyconstraint__1iy1zr7" />  TypeParameter.HasAnyConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Flag whether the type parameter has any constraint



```csharp
public bool HasAnyConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasconstructorconstraint__wqv9qt" />  TypeParameter.HasConstructorConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Flag whether the type parameter has constructor constraint ( new() )



```csharp
public bool HasConstructorConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasreferencetypeconstraint__143rl1s" />  TypeParameter.HasReferenceTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Flag whether the type parameter has reference type constraint ( class )



```csharp
public bool HasReferenceTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasunmanagedtypeconstraint__nm7zzj" />  TypeParameter.HasUnmanagedTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Flag whether the type parameter has unmanaged type constraint ( unmanaged )



```csharp
public bool HasUnmanagedTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasvaluetypeconstraint__1ukksns" />  TypeParameter.HasValueTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Flag whether the type parameter has value type constraint ( struct )



```csharp
public bool HasValueTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.name__1h5j7x" />  TypeParameter.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Name of the parameter



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.variance__a30lyr" />  TypeParameter.Variance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.



```csharp
public string Variance { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder___nocdp7" />  TypeParameter.TypeParameter(TypeParameterBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


CTOR - from builder



```csharp
public TypeParameter(TypeParameterBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeparameter.getconstraintsstring__iddb2s" />  TypeParameter.GetConstraintsString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)</small>


Returns the string with all constraints as defined in code



```csharp
public string GetConstraintsString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String with all constraints as defined in code</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm" />  TypeRef Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types. There is only single TypeRef for a type even if used on multiple &quot;places&quot;



```csharp
public class TypeRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ArrayElementType](#p-net.adamec.dev.markupdoc.codemodel.typeref.arrayelementtype__byw1yl) | public | Type reference of array element type when available | 
 | [Base](#p-net.adamec.dev.markupdoc.codemodel.typeref.base__9jxpo3) | public | Base (parent) type when available | 
 | [BaseExclObject](#p-net.adamec.dev.markupdoc.codemodel.typeref.baseexclobject__uyu8rc) | public | Base (parent) type excluding the System.Object, when available | 
 | [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.typeref.documentationid__1fruy65) | public | Documentation ID of type when available | 
 | [EnumValueType](#p-net.adamec.dev.markupdoc.codemodel.typeref.enumvaluetype__1wygike) | public | Underlying value type name for enums | 
 | [GenericArity](#p-net.adamec.dev.markupdoc.codemodel.typeref.genericarity__1yz9ryu) | public | Generic type arity (number of type parameters) when available | 
 | [GenericBaseName](#p-net.adamec.dev.markupdoc.codemodel.typeref.genericbasename__iwu9kd) | public | Base name (without the type parameters) for generic types | 
 | [GenericDefinition](#p-net.adamec.dev.markupdoc.codemodel.typeref.genericdefinition__7s13og) | public | Base generic type when available - used for the types that have applied generic parameters. In such case, GenericDefinition refers to the &quot;original&quot; type | 
 | [Member](#p-net.adamec.dev.markupdoc.codemodel.typeref.member__nc9l46) | public | Corresponding type member from the code model when available | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.typeref.name__ic643d) | public | Name of the type | 
 | [Namespace](#p-net.adamec.dev.markupdoc.codemodel.typeref.namespace__1oofukd) | public | Containing namespace of type | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ApplySpecialName(bool)](#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.boolean___1blwydr) | public | Applies the type special name for the current type reference | 
 | [ApplySpecialName(ITypeSymbol, bool)](#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_microsoft.codeanalysis.itypesymbol-system.boolean___fzp5cf) | public static | Applies the type special name for given <strong>typeSymbol</strong> | 
 | [ApplySpecialName(string, string, bool)](#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) | private static | Applies the type special name for given type described by namespace and <strong>name</strong> | 
 | [GetOrCreate(ITypeSymbol, RootMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.typeref.getorcreate_microsoft.codeanalysis.itypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___dytfda) | public static | Gets the [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) from the <em>Microsoft.CodeAnalysis.ITypeSymbol</em> . When such TypeRef doesn&#39;t exist yet, it&#39;s created. | 
 | [ToString()](#m-net.adamec.dev.markupdoc.codemodel.typeref.tostring__ql1z7x) | public | Gets the brief description - name - of the type reference | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.arrayelementtype__byw1yl" />  TypeRef.ArrayElementType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Type reference of array element type when available



```csharp
public TypeRef ArrayElementType { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.base__9jxpo3" />  TypeRef.Base Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Base (parent) type when available



```csharp
public TypeRef Base { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.baseexclobject__uyu8rc" />  TypeRef.BaseExclObject Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Base (parent) type excluding the System.Object, when available



```csharp
public TypeRef BaseExclObject { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.documentationid__1fruy65" />  TypeRef.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Documentation ID of type when available



```csharp
public string DocumentationId { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.enumvaluetype__1wygike" />  TypeRef.EnumValueType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Underlying value type name for enums



```csharp
public string EnumValueType { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericarity__1yz9ryu" />  TypeRef.GenericArity Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Generic type arity (number of type parameters) when available



```csharp
public int GenericArity { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericbasename__iwu9kd" />  TypeRef.GenericBaseName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Base name (without the type parameters) for generic types



```csharp
public string GenericBaseName { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericdefinition__7s13og" />  TypeRef.GenericDefinition Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Base generic type when available - used for the types that have applied generic parameters. In such case, GenericDefinition refers to the &quot;original&quot; type



```csharp
public TypeRef GenericDefinition { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.member__nc9l46" />  TypeRef.Member Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Corresponding type member from the code model when available



```csharp
public TypeMember Member { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.name__ic643d" />  TypeRef.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Name of the type



```csharp
public string Name { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.namespace__1oofukd" />  TypeRef.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Containing namespace of type



```csharp
public string Namespace { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.boolean___1blwydr" />  TypeRef.ApplySpecialName(bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Applies the type special name for the current type reference



```csharp
public string ApplySpecialName(bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
See [ApplySpecialName(string, string, bool)](#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_microsoft.codeanalysis.itypesymbol-system.boolean___fzp5cf" />  TypeRef.ApplySpecialName(ITypeSymbol, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Applies the type special name for given <strong>typeSymbol</strong>



```csharp
public static string ApplySpecialName(ITypeSymbol typeSymbol, bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol" target="_blank" >Microsoft.CodeAnalysis.ITypeSymbol</a> <strong>typeSymbol</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
See [ApplySpecialName(string, string, bool)](#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv" />  TypeRef.ApplySpecialName(string, string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Applies the type special name for given type described by namespace and <strong>name</strong>



```csharp
private static string ApplySpecialName(string ns, string name, bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>ns</strong></dt><dd>Namespace containing the type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
Special name is actually the simplified and/or common name for selected types. For example &quot;string&quot; for &quot;System.String&quot;, &quot;bool&quot; for &quot;System.Boolean&quot;, &quot;int&quot; for &quot;System.Int32&quot;. The simplification means removing the well known namespace (System, System.Collections, ...), using the common name for some types (bool, int, double, ...), replacing Nullable&lt;T&gt; with &quot;T?&quot; syntax. Special names for System namespace: bool, byte, char, DateTime, decimal, double, Enum, IAsyncResult, IDisposable, short, int, long, object, sbyte, float, string, ushort, uint, ulong, void, Delegate, MulticastDelegate, ValueType, Attribute.

 Special names for System.Collections.Generic namespace: ICollection, IDictionary, IEnumerable, IEnumerator, IList, IReadOnlyCollection, IReadOnlyList, List, Dictionary, HashSet, Queue, Stack (all as generics).

 Special names for System.Collections namespace: ICollection, IDictionary, IEnumerable, IDictionary, IEnumerator, IList, Hashtable, Queue, Stack, ArrayList, SortedList.




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.getorcreate_microsoft.codeanalysis.itypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___dytfda" />  TypeRef.GetOrCreate(ITypeSymbol, RootMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Gets the [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) from the <em>Microsoft.CodeAnalysis.ITypeSymbol</em> . When such TypeRef doesn&#39;t exist yet, it&#39;s created.



```csharp
public static TypeRef GetOrCreate(ITypeSymbol symbol, RootMemberBuilder root)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol" target="_blank" >Microsoft.CodeAnalysis.ITypeSymbol</a> <strong>symbol</strong></dt><dd>Type symbol to get the TypeRef for</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder keeping the list of all type references</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd>[TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) corresponding to the <strong>symbol</strong></dd></dl>


###  Remarks ###
The list of existing type references is held by [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) .


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.tostring__ql1z7x" />  TypeRef.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</small>


Gets the brief description - name - of the type reference



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Brief description - name - of the type reference</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0" />  MemberKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible member kinds



```csharp
public enum MemberKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Unknown](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.unknown__1t9t5bu) | 0 | Member type is unknown or not set | 
 | [Root](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.root__boynuw) | 1 | Member is the root | 
 | [Assembly](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.assembly__195rcdw) | 2 | Member is assembly | 
 | [Namespace](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.namespace__1nsxwyd) | 3 | Member is namespace | 
 | [Type](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.type__m8zl20) | 4 | Member is type | 
 | [Event](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.event__kroq58) | 5 | Member is event | 
 | [Field](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.field__1rsexl4) | 6 | Members is field | 
 | [Property](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.property__1p6vnkt) | 7 | Member is property | 
 | [Method](#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.method__1yfg25h) | 8 | Member is method | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.assembly__195rcdw" />  MemberKindEnum.Assembly Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is assembly



```csharp
 Assembly = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.event__kroq58" />  MemberKindEnum.Event Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is event



```csharp
 Event = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.field__1rsexl4" />  MemberKindEnum.Field Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Members is field



```csharp
 Field = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.method__1yfg25h" />  MemberKindEnum.Method Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is method



```csharp
 Method = 8
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.namespace__1nsxwyd" />  MemberKindEnum.Namespace Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is namespace



```csharp
 Namespace = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.property__1p6vnkt" />  MemberKindEnum.Property Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is property



```csharp
 Property = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.root__boynuw" />  MemberKindEnum.Root Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is the root



```csharp
 Root = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.type__m8zl20" />  MemberKindEnum.Type Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member is type



```csharp
 Type = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.unknown__1t9t5bu" />  MemberKindEnum.Unknown Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</small>


Member type is unknown or not set



```csharp
 Unknown = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9" />  MethodKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible kinds of method symbols



```csharp
public enum MethodKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [AnonymousFunction](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.anonymousfunction__1oee5xm) | 0 | An anonymous method or lambda expression | 
 | [LambdaMethod](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.lambdamethod__9dx2i9) | 0 |  | 
 | [Constructor](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.constructor__1nz33wd) | 1 | Method is a constructor. | 
 | [Conversion](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.conversion__y33wax) | 2 | Method is a conversion. | 
 | [DelegateInvoke](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.delegateinvoke__11hlzmy) | 3 | Method is a delegate invoke. | 
 | [Destructor](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.destructor__uituse) | 4 | Method is a destructor. | 
 | [EventAdd](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventadd__jebxkq) | 5 | Method is an event add. | 
 | [EventRaise](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventraise__mzxxud) | 6 | Method is an event raise. | 
 | [EventRemove](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventremove__1n75nqj) | 7 | Method is an event remove. | 
 | [ExplicitInterfaceImplementation](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.explicitinterfaceimplementation__16hqzay) | 8 | Method is an explicit interface implementation. | 
 | [UserDefinedOperator](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.userdefinedoperator__11f8k5d) | 9 | Method is an operator. | 
 | [Ordinary](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.ordinary__owbfct) | 10 | Method is an ordinary method. | 
 | [PropertyGet](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyget__1jgaww0) | 11 | Method is a property get. | 
 | [PropertySet](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyset__1jgaxd8) | 12 | Method is a property set. | 
 | [ReducedExtension](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.reducedextension__7k1du2) | 13 | An extension method with the &quot;this&quot; parameter removed. | 
 | [SharedConstructor](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.sharedconstructor__j724eo) | 14 |  | 
 | [StaticConstructor](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.staticconstructor__6rfcqt) | 14 | Method is a static constructor. | 
 | [BuiltinOperator](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.builtinoperator__2mxmg0) | 15 | A built-in operator. | 
 | [DeclareMethod](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.declaremethod__cyhzzk) | 16 | Declare Sub or Function. | 
 | [LocalFunction](#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.localfunction__1o14ddk) | 17 | Method is declared inside of another method. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.anonymousfunction__1oee5xm" />  MethodKindEnum.AnonymousFunction Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


An anonymous method or lambda expression



```csharp
 AnonymousFunction = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.builtinoperator__2mxmg0" />  MethodKindEnum.BuiltinOperator Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


A built-in operator.



```csharp
 BuiltinOperator = 15
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.constructor__1nz33wd" />  MethodKindEnum.Constructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a constructor.



```csharp
 Constructor = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.conversion__y33wax" />  MethodKindEnum.Conversion Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a conversion.



```csharp
 Conversion = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.declaremethod__cyhzzk" />  MethodKindEnum.DeclareMethod Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Declare Sub or Function.



```csharp
 DeclareMethod = 16
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.delegateinvoke__11hlzmy" />  MethodKindEnum.DelegateInvoke Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a delegate invoke.



```csharp
 DelegateInvoke = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.destructor__uituse" />  MethodKindEnum.Destructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a destructor.



```csharp
 Destructor = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventadd__jebxkq" />  MethodKindEnum.EventAdd Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an event add.



```csharp
 EventAdd = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventraise__mzxxud" />  MethodKindEnum.EventRaise Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an event raise.



```csharp
 EventRaise = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventremove__1n75nqj" />  MethodKindEnum.EventRemove Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an event remove.



```csharp
 EventRemove = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.explicitinterfaceimplementation__16hqzay" />  MethodKindEnum.ExplicitInterfaceImplementation Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an explicit interface implementation.



```csharp
 ExplicitInterfaceImplementation = 8
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.lambdamethod__9dx2i9" />  MethodKindEnum.LambdaMethod Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>



```csharp
 LambdaMethod = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.localfunction__1o14ddk" />  MethodKindEnum.LocalFunction Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is declared inside of another method.



```csharp
 LocalFunction = 17
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.ordinary__owbfct" />  MethodKindEnum.Ordinary Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an ordinary method.



```csharp
 Ordinary = 10
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyget__1jgaww0" />  MethodKindEnum.PropertyGet Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a property get.



```csharp
 PropertyGet = 11
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyset__1jgaxd8" />  MethodKindEnum.PropertySet Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a property set.



```csharp
 PropertySet = 12
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.reducedextension__7k1du2" />  MethodKindEnum.ReducedExtension Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


An extension method with the &quot;this&quot; parameter removed.



```csharp
 ReducedExtension = 13
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.sharedconstructor__j724eo" />  MethodKindEnum.SharedConstructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>



```csharp
 SharedConstructor = 14
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.staticconstructor__6rfcqt" />  MethodKindEnum.StaticConstructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is a static constructor.



```csharp
 StaticConstructor = 14
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.userdefinedoperator__11f8k5d" />  MethodKindEnum.UserDefinedOperator Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</small>


Method is an operator.



```csharp
 UserDefinedOperator = 9
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel" />  ModifierEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible access modifiers



```csharp
public enum ModifierEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [NotApplicable](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.notapplicable__1c9bqep) | 0 | Not applicable/unknown | 
 | [Public](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.public__16bc72i) | 1 | Member is public | 
 | [Private](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.private__10gl1bm) | 2 | Member is private | 
 | [Protected](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.protected__ghfrnv) | 3 | Member is protected | 
 | [Internal](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.internal__1fcelle) | 4 | Member is internal | 
 | [ProtectedInternal](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.protectedinternal__1u0qjgu) | 5 | Member is protected internal (protected or internal) | 
 | [PrivateProtected](#f-net.adamec.dev.markupdoc.codemodel.modifierenum.privateprotected__16sulww) | 6 | Member is private protected (protected and internal) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.internal__1fcelle" />  ModifierEnum.Internal Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is internal



```csharp
 Internal = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.notapplicable__1c9bqep" />  ModifierEnum.NotApplicable Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Not applicable/unknown



```csharp
 NotApplicable = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.private__10gl1bm" />  ModifierEnum.Private Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is private



```csharp
 Private = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.privateprotected__16sulww" />  ModifierEnum.PrivateProtected Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is private protected (protected and internal)



```csharp
 PrivateProtected = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.protected__ghfrnv" />  ModifierEnum.Protected Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is protected



```csharp
 Protected = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.protectedinternal__1u0qjgu" />  ModifierEnum.ProtectedInternal Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is protected internal (protected or internal)



```csharp
 ProtectedInternal = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.public__16bc72i" />  ModifierEnum.Public Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</small>


Member is public



```csharp
 Public = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7" />  RefKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible reference parameter kinds



```csharp
public enum RefKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](#f-net.adamec.dev.markupdoc.codemodel.refkindenum.none__115b1ud) | 0 | None | 
 | [Ref](#f-net.adamec.dev.markupdoc.codemodel.refkindenum.ref__7rm5co) | 1 | Ref | 
 | [Out](#f-net.adamec.dev.markupdoc.codemodel.refkindenum.out__1jsgqj5) | 2 | Out | 
 | [In](#f-net.adamec.dev.markupdoc.codemodel.refkindenum.in__o6c6to) | 3 | In | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.in__o6c6to" />  RefKindEnum.In Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</small>


In



```csharp
 In = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.none__115b1ud" />  RefKindEnum.None Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</small>


None



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.out__1jsgqj5" />  RefKindEnum.Out Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</small>


Out



```csharp
 Out = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.ref__7rm5co" />  RefKindEnum.Ref Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</small>


Ref



```csharp
 Ref = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km" />  SplitTypeEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible split definitions



```csharp
public enum SplitTypeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.none__5fy47s) | 0 | Don&#39;t split | 
 | [Namespace](#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.namespace__1bo5ytj) | 1 | Split per namespace | 
 | [Type](#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.type__hbxlci) | 2 | Split per type (will also force split per namespace) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.namespace__1bo5ytj" />  SplitTypeEnum.Namespace Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</small>


Split per namespace



```csharp
 Namespace = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.none__5fy47s" />  SplitTypeEnum.None Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</small>


Don&#39;t split



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.type__hbxlci" />  SplitTypeEnum.Type Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</small>


Split per type (will also force split per namespace)



```csharp
 Type = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm" />  TypeKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc</small>


Possible kinds of type symbol



```csharp
public enum TypeKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Unknown](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.unknown__6qwupk) | 0 | Unknown or not set | 
 | [Class](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.class__mr4q2m) | 1 | Type is class | 
 | [Interface](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.interface__1kr3gmn) | 2 | Type is interface | 
 | [Delegate](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.delegate__1ia2gv1) | 3 | Type is delegate | 
 | [Array](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.array__1crhs0v) | 4 | Type is array | 
 | [Struct](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.struct__1qs31hl) | 5 | Type is structure | 
 | [Enum](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.enum__xhij1l) | 6 | Type is enum | 
 | [Dynamic](#f-net.adamec.dev.markupdoc.codemodel.typekindenum.dynamic__1ql5ndn) | 7 | Type is dynamic | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.array__1crhs0v" />  TypeKindEnum.Array Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is array



```csharp
 Array = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.class__mr4q2m" />  TypeKindEnum.Class Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is class



```csharp
 Class = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.delegate__1ia2gv1" />  TypeKindEnum.Delegate Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is delegate



```csharp
 Delegate = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.dynamic__1ql5ndn" />  TypeKindEnum.Dynamic Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is dynamic



```csharp
 Dynamic = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.enum__xhij1l" />  TypeKindEnum.Enum Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is enum



```csharp
 Enum = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.interface__1kr3gmn" />  TypeKindEnum.Interface Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is interface



```csharp
 Interface = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.struct__1qs31hl" />  TypeKindEnum.Struct Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Type is structure



```csharp
 Struct = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.unknown__6qwupk" />  TypeKindEnum.Unknown Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</small>


Unknown or not set



```csharp
 Unknown = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa" />  net.adamec.dev.markupdoc.CodeModel.Builder Namespace ##
Code model builder classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) | public | Builder for [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | 
 | [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) | public | Builder for [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | 
 | [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) | public | Builder for [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | 
 | [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) | public abstract | Builder for [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | 
 | [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) | public | Builder for [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | 
 | [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux) | public | Builder for [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2) | public static | Code model builder | 
 | [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) | public | Builder for [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | 
 | [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) | public | Builder for [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | 
 | [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) | public | Builder for [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | 
 | [TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4) | public abstract | Builder for [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | 
 | [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) | public | Builder for [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | 
 | [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w) | public | Builder for [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35" />  AssemblyMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)



```csharp
public class AssemblyMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.memberkind__vdzakj) | public | Kind (type) of the member | 
 | [Namespaces](#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497) | public | List of namespaces within the assembly | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.memberkind__vdzakj" />  AssemblyMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497" />  AssemblyMemberBuilder.Namespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</small>


List of namespaces within the assembly



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder> Namespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn" />  EventMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)



```csharp
public class EventMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasExplicitAddAndRemove](#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.hasexplicitaddandremove__pjyyg5) | public | Flag whether the event has explicit implementation of add and remove accessors | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.memberkind__r2w7o1) | public | Kind (type) of the member | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.typeref__qd87z0) | public | Delegate type (type reference) of the event handler | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.hasexplicitaddandremove__pjyyg5" />  EventMemberBuilder.HasExplicitAddAndRemove Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)</small>


Flag whether the event has explicit implementation of add and remove accessors



```csharp
public bool HasExplicitAddAndRemove { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.memberkind__r2w7o1" />  EventMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.typeref__qd87z0" />  EventMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)</small>


Delegate type (type reference) of the event handler



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush" />  FieldMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)



```csharp
public class FieldMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConstantValue](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.constantvalue__3vfjkc) | public | The constant value of the field | 
 | [IsConst](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isconst__1n6s3ui) | public | Flag whether the field is constant | 
 | [IsReadOnly](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isreadonly__7c8nkj) | public | Flag whether the field is read only | 
 | [IsVolatile](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isvolatile__u90vd5) | public | Flag whether the field is volatile | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.memberkind__m8cfwz) | public | Kind (type) of the member | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.typeref__1yrsoq0) | public | Type (type reference) of the field value | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.constantvalue__3vfjkc" />  FieldMemberBuilder.ConstantValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


The constant value of the field



```csharp
public object ConstantValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Remarks ###
The ConstantValue is not the definition (for example &quot;2+customId&quot;) but the value is evaluated to the target type (for example 1002 if the customId in previous example is constant 1000). It&#39;s also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isconst__1n6s3ui" />  FieldMemberBuilder.IsConst Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


Flag whether the field is constant



```csharp
public bool IsConst { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isreadonly__7c8nkj" />  FieldMemberBuilder.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


Flag whether the field is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isvolatile__u90vd5" />  FieldMemberBuilder.IsVolatile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


Flag whether the field is volatile



```csharp
public bool IsVolatile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.memberkind__m8cfwz" />  FieldMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.typeref__1yrsoq0" />  FieldMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)</small>


Type (type reference) of the field value



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab" />  MemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)



```csharp
public abstract class MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Assembly](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.assembly__u0picr) | public | Reference to the containing assembly member | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) | public | Member&#39;s attributes definition (including the parameters). | 
 | [AttributeTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33) | public | Types (type references) of the member attributes | 
 | [Documentation](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) | public | Parsed XML documentation comments. [Documentation](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) is the root element of the parsed XML documentation comments | 
 | [DocumentationId](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationid__fuj6uu) | public | Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod) | 
 | [DocumentationXml](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationxml__hki5yw) | public | XML documentation comments | 
 | [IsAbstract](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isabstract__1gvw0bf) | public | Flag whether the member is abstract | 
 | [IsExtern](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isextern__1lst26j) | public | Flag whether the member is extern | 
 | [IsNew](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isnew__7v1jmv) | public | Flag whether the member hides member with the same name in base class | 
 | [IsOverride](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isoverride__1p2q36b) | public | Flag whether the member overrides the member in the base class | 
 | [IsSealed](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.issealed__1biaeq1) | public | Flag whether the member is sealed | 
 | [IsStatic](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isstatic__exro8z) | public | Flag whether the member is static | 
 | [IsVirtual](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isvirtual__1rjdu3e) | public | Flag whether the member is virtual (can be overriden) | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat) | public | Kind (type) of the member | 
 | [Modifier](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.modifier__9ghn8u) | public | Member modifier (public, private, etc.) | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.name__1xiduuc) | public | Name of the member as presented in generated output | 
 | [NameBase](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namebase__1uczvyr) | public | Name of the member without type params, indexer params, operator params, etc. | 
 | [Namespace](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namespace__k8my0i) | public | Reference to the containing namespace member | 
 | [Root](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.root__1dexqz) | public | Reference to the root of the code model | 
 | [Symbol](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.symbol__11sbm3v) | public | Roslyn semantic analysis symbol of the member | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetAttributes(RootMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.setattributes_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___y95mcr) | public | Sets the member&#39;s [Attributes](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) and [AttributeTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.assembly__u0picr" />  MemberBuilder.Assembly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Reference to the containing assembly member



```csharp
public AssemblyMember Assembly { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.AssemblyMember](#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce" />  MemberBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Member&#39;s attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33" />  MemberBuilder.AttributeTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Types (type references) of the member attributes



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AttributeTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf" />  MemberBuilder.Documentation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Parsed XML documentation comments. [Documentation](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) is the root element of the parsed XML documentation comments



```csharp
public Documentation Documentation { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationid__fuj6uu" />  MemberBuilder.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)



```csharp
public string DocumentationId { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationxml__hki5yw" />  MemberBuilder.DocumentationXml Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


XML documentation comments



```csharp
public string DocumentationXml { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isabstract__1gvw0bf" />  MemberBuilder.IsAbstract Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member is abstract



```csharp
public bool IsAbstract { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isextern__1lst26j" />  MemberBuilder.IsExtern Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member is extern



```csharp
public bool IsExtern { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isnew__7v1jmv" />  MemberBuilder.IsNew Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member hides member with the same name in base class



```csharp
public bool IsNew { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isoverride__1p2q36b" />  MemberBuilder.IsOverride Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member overrides the member in the base class



```csharp
public bool IsOverride { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.issealed__1biaeq1" />  MemberBuilder.IsSealed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member is sealed



```csharp
public bool IsSealed { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isstatic__exro8z" />  MemberBuilder.IsStatic Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member is static



```csharp
public bool IsStatic { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isvirtual__1rjdu3e" />  MemberBuilder.IsVirtual Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Flag whether the member is virtual (can be overriden)



```csharp
public bool IsVirtual { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat" />  MemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Kind (type) of the member



```csharp
public virtual MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.modifier__9ghn8u" />  MemberBuilder.Modifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Member modifier (public, private, etc.)



```csharp
public ModifierEnum Modifier { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.name__1xiduuc" />  MemberBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Name of the member as presented in generated output



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namebase__1uczvyr" />  MemberBuilder.NameBase Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Name of the member without type params, indexer params, operator params, etc.



```csharp
public string NameBase { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namespace__k8my0i" />  MemberBuilder.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Reference to the containing namespace member



```csharp
public NamespaceMember Namespace { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.root__1dexqz" />  MemberBuilder.Root Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Reference to the root of the code model



```csharp
public RootMember Root { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.symbol__11sbm3v" />  MemberBuilder.Symbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Roslyn semantic analysis symbol of the member



```csharp
public ISymbol Symbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.setattributes_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___y95mcr" />  MemberBuilder.SetAttributes(RootMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)</small>


Sets the member&#39;s [Attributes](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) and [AttributeTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33)



```csharp
public void SetAttributes(RootMemberBuilder rootBuilder)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>rootBuilder</strong></dt><dd>Root builder used to resolve the type references</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w" />  MethodMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)



```csharp
public class MethodMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsAsync](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isasync__8y3p82) | public | Flag whether the method is async | 
 | [IsConstructor](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isconstructor__1r17j86) | public | Flag whether the method is construction | 
 | [IsDestructor](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isdestructor__1xax39j) | public | Flag whether the method is destructor | 
 | [IsExtensionMethod](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isextensionmethod__pmj45m) | public | Flag whether the method is extension method | 
 | [IsGeneric](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isgeneric__1pwvqjl) | public | Flag whether method is generic | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.memberkind__woi5v2) | public | Kind (type) of the member | 
 | [MethodKind](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.methodkind__f41fm9) | public | Kind of the method (constructor, getter, regular method ...) | 
 | [OperatorCSharpSymbol](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.operatorcsharpsymbol__1f31bmr) | public | C# operator symbol for operator method | 
 | [Parameters](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.parameters__1usepgy) | public | Method parameters | 
 | [RefKind](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.refkind__1cgi9xv) | public | Method&#39;s return ref kind (none, ref) | 
 | [ReturnsByRef](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyref__1bdbn1h) | public | Flag whether the methods returns by reference | 
 | [ReturnsByRefReadonly](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyrefreadonly__ez3crj) | public | Flag whether the methods returns by read only reference (ref readonly) | 
 | [ReturnsVoid](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsvoid__n964nn) | public | Flags whether the method returns void | 
 | [ReturnTypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returntyperef__iiyukl) | public | Type reference of the method return type | 
 | [TypeParameters](#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.typeparameters__n6xbei) | public | Type parameters for generic methods | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isasync__8y3p82" />  MethodMemberBuilder.IsAsync Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the method is async



```csharp
public bool IsAsync { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isconstructor__1r17j86" />  MethodMemberBuilder.IsConstructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the method is construction



```csharp
public bool IsConstructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isdestructor__1xax39j" />  MethodMemberBuilder.IsDestructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the method is destructor



```csharp
public bool IsDestructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isextensionmethod__pmj45m" />  MethodMemberBuilder.IsExtensionMethod Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the method is extension method



```csharp
public bool IsExtensionMethod { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isgeneric__1pwvqjl" />  MethodMemberBuilder.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether method is generic



```csharp
public bool IsGeneric { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.memberkind__woi5v2" />  MethodMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.methodkind__f41fm9" />  MethodMemberBuilder.MethodKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Kind of the method (constructor, getter, regular method ...)



```csharp
public MethodKindEnum MethodKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.operatorcsharpsymbol__1f31bmr" />  MethodMemberBuilder.OperatorCSharpSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


C# operator symbol for operator method



```csharp
public string OperatorCSharpSymbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.parameters__1usepgy" />  MethodMemberBuilder.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Method parameters



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.refkind__1cgi9xv" />  MethodMemberBuilder.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Method&#39;s return ref kind (none, ref)



```csharp
public RefKindEnum RefKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyref__1bdbn1h" />  MethodMemberBuilder.ReturnsByRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the methods returns by reference



```csharp
public bool ReturnsByRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyrefreadonly__ez3crj" />  MethodMemberBuilder.ReturnsByRefReadonly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flag whether the methods returns by read only reference (ref readonly)



```csharp
public bool ReturnsByRefReadonly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsvoid__n964nn" />  MethodMemberBuilder.ReturnsVoid Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Flags whether the method returns void



```csharp
public bool ReturnsVoid { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returntyperef__iiyukl" />  MethodMemberBuilder.ReturnTypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Type reference of the method return type



```csharp
public TypeRef ReturnTypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.typeparameters__n6xbei" />  MethodMemberBuilder.TypeParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)</small>


Type parameters for generic methods



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux" />  MethodParameterBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)



```csharp
public class MethodParameterBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.attributes__1t8c7wg) | public | Parameter attributes definition (including the parameters). | 
 | [ExplicitDefaultValue](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.explicitdefaultvalue__gvc0n5) | public | Parameter&#39;s explicitly defined default value (when available) | 
 | [HasExplicitDefaultValue](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.hasexplicitdefaultvalue__1kulx9f) | public | Flag whether the parameter has explicitly defined default value | 
 | [IsOptional](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isoptional__1rtnv9j) | public | Flag whether the parameter is optional | 
 | [IsParams](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isparams__b64bjt) | public | Flag whether the parameter is with `params` modifier | 
 | [IsThis](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isthis__xj2zwv) | public | Flag whether the parameter is with `this` modifier | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.name__zd3u2a) | public | Name of the parameter | 
 | [RefKind](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.refkind__1xrhok) | public | Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In) | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.typeref__r2j80u) | public | Type reference for the parameter&#39;s type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.attributes__1t8c7wg" />  MethodParameterBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.explicitdefaultvalue__gvc0n5" />  MethodParameterBuilder.ExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Parameter&#39;s explicitly defined default value (when available)



```csharp
public object ExplicitDefaultValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.hasexplicitdefaultvalue__1kulx9f" />  MethodParameterBuilder.HasExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Flag whether the parameter has explicitly defined default value



```csharp
public bool HasExplicitDefaultValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isoptional__1rtnv9j" />  MethodParameterBuilder.IsOptional Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Flag whether the parameter is optional



```csharp
public bool IsOptional { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isparams__b64bjt" />  MethodParameterBuilder.IsParams Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Flag whether the parameter is with `params` modifier



```csharp
public bool IsParams { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isthis__xj2zwv" />  MethodParameterBuilder.IsThis Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Flag whether the parameter is with `this` modifier



```csharp
public bool IsThis { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.name__zd3u2a" />  MethodParameterBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Name of the parameter



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.refkind__1xrhok" />  MethodParameterBuilder.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In)



```csharp
public RefKindEnum RefKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.typeref__r2j80u" />  MethodParameterBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)</small>


Type reference for the parameter&#39;s type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2" />  ModelBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Code model builder



```csharp
public static class ModelBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build(ISymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.build_microsoft.codeanalysis.isymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___15bn67a) | private static | Walks through the Roslyn symbols hierarchy and prepares the member builders hierarchy into the given <strong>root</strong> builder. | 
 | [BuildAssembly(IAssemblySymbol, RootMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildassembly_microsoft.codeanalysis.iassemblysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.int32___1lbqkgy) | private static | Prepares the [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) from the <strong>symbol</strong> and adds it to [Assemblies](#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih) | 
 | [BuildEvent(IEventSymbol, RootMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildevent_microsoft.codeanalysis.ieventsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___jk6kv) | private static | Prepares the [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildField(IFieldSymbol, RootMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfield_microsoft.codeanalysis.ifieldsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___pykoun) | private static | Prepares the [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildFromProjectSourcesAsync(string)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfromprojectsourcesasync_system.string___zrjhad) | public static | Builds a code model for C# project | 
 | [BuildMethod(IMethodSymbol, RootMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildmethod_microsoft.codeanalysis.imethodsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___18on0xf) | private static | Prepares the [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildNamespace(INamespaceSymbol, RootMemberBuilder, AssemblyMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildnamespace_microsoft.codeanalysis.inamespacesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-system.int32___1weblwh) | private static | Prepares the [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) from the <strong>symbol</strong> and adds it to [Namespaces](#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497) | 
 | [BuildProperty(IPropertySymbol, RootMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildproperty_microsoft.codeanalysis.ipropertysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___gfm8xv) | private static | Prepares the [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildType(INamedTypeSymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildtype_microsoft.codeanalysis.inamedtypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___af53q5) | private static | Prepares the [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) from the <strong>symbol</strong> and adds it to [Types](#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp) | 
 | [GetMethodParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;, RootMemberBuilder, bool)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.getmethodparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.iparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.boolean___134ezzp) | private static | Gets the list of method parameters (also used for retrieving delegate and indexer parameters) | 
 | [GetTypeParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;, RootMemberBuilder)](#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.gettypeparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.itypeparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___4af5sd) | private static | Gets the list of type parameters for generic type or generic method | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.build_microsoft.codeanalysis.isymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___15bn67a" />  ModelBuilder.Build(ISymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Walks through the Roslyn symbols hierarchy and prepares the member builders hierarchy into the given <strong>root</strong> builder.



```csharp
private static void Build(ISymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a> <strong>symbol</strong></dt><dd>Symbol to process</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Containing assembly builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>ns</strong></dt><dd>Containing namespace builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Containing type builder (used for nested types)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildassembly_microsoft.codeanalysis.iassemblysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.int32___1lbqkgy" />  ModelBuilder.BuildAssembly(IAssemblySymbol, RootMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) from the <strong>symbol</strong> and adds it to [Assemblies](#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih)



```csharp
private static void BuildAssembly(IAssemblySymbol symbol, RootMemberBuilder root, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.iassemblysymbol" target="_blank" >Microsoft.CodeAnalysis.IAssemblySymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.IAssemblySymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildevent_microsoft.codeanalysis.ieventsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___jk6kv" />  ModelBuilder.BuildEvent(IEventSymbol, RootMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [EventMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildEvent(IEventSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ieventsymbol" target="_blank" >Microsoft.CodeAnalysis.IEventSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfield_microsoft.codeanalysis.ifieldsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___pykoun" />  ModelBuilder.BuildField(IFieldSymbol, RootMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [FieldMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildField(IFieldSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ifieldsymbol" target="_blank" >Microsoft.CodeAnalysis.IFieldSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfromprojectsourcesasync_system.string___zrjhad" />  ModelBuilder.BuildFromProjectSourcesAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Builds a code model for C# project



```csharp
public static async Task<net.adamec.dev.markupdoc.CodeModel.RootMember> BuildFromProjectSourcesAsync(string projectFile)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>projectFile</strong></dt><dd>Project file full path</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;net.adamec.dev.markupdoc.CodeModel.RootMember&gt;</a></dt><dd>Code model root (async)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildmethod_microsoft.codeanalysis.imethodsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___18on0xf" />  ModelBuilder.BuildMethod(IMethodSymbol, RootMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [MethodMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildMethod(IMethodSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildnamespace_microsoft.codeanalysis.inamespacesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-system.int32___1weblwh" />  ModelBuilder.BuildNamespace(INamespaceSymbol, RootMemberBuilder, AssemblyMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) from the <strong>symbol</strong> and adds it to [Namespaces](#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497)



```csharp
private static void BuildNamespace(INamespaceSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespacesymbol" target="_blank" >Microsoft.CodeAnalysis.INamespaceSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamespaceSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Parent [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildproperty_microsoft.codeanalysis.ipropertysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___gfm8xv" />  ModelBuilder.BuildProperty(IPropertySymbol, RootMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) from the <strong>symbol</strong> and adds it to [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildProperty(IPropertySymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ipropertysymbol" target="_blank" >Microsoft.CodeAnalysis.IPropertySymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildtype_microsoft.codeanalysis.inamedtypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___af53q5" />  ModelBuilder.BuildType(INamedTypeSymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Prepares the [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) from the <strong>symbol</strong> and adds it to [Types](#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp)



```csharp
private static void BuildType(INamedTypeSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol" target="_blank" >Microsoft.CodeAnalysis.INamedTypeSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Containing [AssemblyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>ns</strong></dt><dd>Parent [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) for nested types</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.getmethodparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.iparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.boolean___134ezzp" />  ModelBuilder.GetMethodParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;, RootMemberBuilder, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Gets the list of method parameters (also used for retrieving delegate and indexer parameters)



```csharp
private static List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> GetMethodParameters(ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol> parameterSymbols, RootMemberBuilder root, bool isExtensionMethod = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablearray-1" target="_blank" >System.Collections.Immutable.ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;</a> <strong>parameterSymbols</strong></dt><dd>Method parameter symbols</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isExtensionMethod</strong></dt><dd>Flag whether the <strong>parameterSymbols</strong> are of an extension method</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd>List of method parameters</dd></dl>


###  Remarks ###
As <em>Microsoft.CodeAnalysis.IParameterSymbol.IsThis</em> doesn&#39;t provide the correct info, there is a workaround and [IsThis](#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65) is set for the first param of an extension method. The <strong>isExtensionMethod</strong> must be set to true to apply the workaround (the default value is false)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.gettypeparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.itypeparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___4af5sd" />  ModelBuilder.GetTypeParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;, RootMemberBuilder) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)</small>


Gets the list of type parameters for generic type or generic method



```csharp
private static List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> GetTypeParameters(ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol> parameterSymbols, RootMemberBuilder root)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablearray-1" target="_blank" >System.Collections.Immutable.ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;</a> <strong>parameterSymbols</strong></dt><dd>Type parameter symbols</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd>List of type parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm" />  NamespaceMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)



```csharp
public class NamespaceMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsGlobalNamespace](#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.isglobalnamespace__1idlboq) | public | Flag whether the namespace is global | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.memberkind__1w0tyvk) | public | Kind (type) of the member | 
 | [Types](#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp) | public | List of all types (including interfaces, delegates, etc.) defined within the namespace | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.isglobalnamespace__1idlboq" />  NamespaceMemberBuilder.IsGlobalNamespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)</small>


Flag whether the namespace is global



```csharp
public bool IsGlobalNamespace { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.memberkind__1w0tyvk" />  NamespaceMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp" />  NamespaceMemberBuilder.Types Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)</small>


List of all types (including interfaces, delegates, etc.) defined within the namespace



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder> Types { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c" />  PropertyMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)



```csharp
public class PropertyMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetterModifier](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.gettermodifier__114qq8s) | public | Getter access modifier if it&#39;s different than the property one | 
 | [IsIndexer](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isindexer__1ux36yh) | public | Flag whether the property is indexer; | 
 | [IsReadOnly](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isreadonly__evv3bs) | public | Flag whether the property is read only | 
 | [IsWriteOnly](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.iswriteonly__z59w9d) | public | Flag whether the property is write only | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.memberkind__6klili) | public | Kind (type) of the member | 
 | [Parameters](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.parameters__1xthnx6) | public | List of property parameters (if any). Just the indexers may have the parameters | 
 | [SetterModifier](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.settermodifier__13b9zlk) | public | Setter access modifier if it&#39;s different than the property one | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.typeref__1tm2yvr) | public | Type reference of property type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.gettermodifier__114qq8s" />  PropertyMemberBuilder.GetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Getter access modifier if it&#39;s different than the property one



```csharp
public string GetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isindexer__1ux36yh" />  PropertyMemberBuilder.IsIndexer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Flag whether the property is indexer;



```csharp
public bool IsIndexer { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isreadonly__evv3bs" />  PropertyMemberBuilder.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Flag whether the property is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.iswriteonly__z59w9d" />  PropertyMemberBuilder.IsWriteOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Flag whether the property is write only



```csharp
public bool IsWriteOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.memberkind__6klili" />  PropertyMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.parameters__1xthnx6" />  PropertyMemberBuilder.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


List of property parameters (if any). Just the indexers may have the parameters



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.settermodifier__13b9zlk" />  PropertyMemberBuilder.SetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Setter access modifier if it&#39;s different than the property one



```csharp
public string SetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.typeref__1tm2yvr" />  PropertyMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)</small>


Type reference of property type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad" />  RootMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)



```csharp
public class RootMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.alltyperefs__6pc6ms) | public | List of all type references used within the code model | 
 | [Assemblies](#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.assemblies__1y8u6kb) | public | List of all assemblies defined within the code model | 
 | [BaseMainFile](#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.basemainfile__152qap3) | public | Name of the main (index) file without the path and extension | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.memberkind__1hvln7) | public | Kind (type) of the member | 
 | [SplitFileType](#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.splitfiletype__jt8zgj) | public | Information whether and how to split the output (none, per namespace, per type) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RootMemberBuilder()](#m-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.-ctor__1ut3l6j) | public | CTOR - sets the name to `<ROOT>` | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.alltyperefs__6pc6ms" />  RootMemberBuilder.AllTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


List of all type references used within the code model



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.assemblies__1y8u6kb" />  RootMemberBuilder.Assemblies Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


List of all assemblies defined within the code model



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder> Assemblies { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.basemainfile__152qap3" />  RootMemberBuilder.BaseMainFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


Name of the main (index) file without the path and extension



```csharp
public string BaseMainFile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.memberkind__1hvln7" />  RootMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.splitfiletype__jt8zgj" />  RootMemberBuilder.SplitFileType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


Information whether and how to split the output (none, per namespace, per type)



```csharp
public SplitTypeEnum SplitFileType { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.-ctor__1ut3l6j" />  RootMemberBuilder.RootMemberBuilder() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)</small>


CTOR - sets the name to `<ROOT>`



```csharp
public RootMemberBuilder()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4" />  TypeContentMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)



```csharp
public abstract class TypeContentMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Type](#p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.type__1bgq70u) | public | Type containing the content member | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.type__1bgq70u" />  TypeContentMemberBuilder.Type Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeContentMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)</small>


Type containing the content member



```csharp
public TypeMember Type { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn" />  TypeMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)



```csharp
public class TypeMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DelegateParameters](#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegateparameters__14r3a3m) | public | Delegate parameters for delegate types | 
 | [DelegateReturnType](#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegatereturntype__10z9wvk) | public | Type reference for delegate return type | 
 | [TypeParameters](#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeparameters__7d95h) | public | Type parameters for generic types | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllInterfacesTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.allinterfacestyperefs__br2ak) | public | Type references for all implemented interfaces (both directly implemented and inherited) | 
 | [ContentMembers](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | public | List of all type content members (fields, properties, methods, events) | 
 | [InterfacesTypeRefs](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacestyperefs__3ufra9) | public | Type references for directly implemented interfaces | 
 | [IsGeneric](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.isgeneric__utg9go) | public | Flag whether type is generic | 
 | [MemberKind](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.memberkind__1y10oqd) | public | Kind (type) of the member | 
 | [TypeKind](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typekind__qphofl) | public | Type kind (class, interface, ...) | 
 | [TypeRef](#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeref__1hwjb38) | public | Type reference for this type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegateparameters__14r3a3m" />  TypeMemberBuilder.DelegateParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Delegate parameters for delegate types



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> DelegateParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegatereturntype__10z9wvk" />  TypeMemberBuilder.DelegateReturnType Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type reference for delegate return type



```csharp
public TypeRef DelegateReturnType
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeparameters__7d95h" />  TypeMemberBuilder.TypeParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type parameters for generic types



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.allinterfacestyperefs__br2ak" />  TypeMemberBuilder.AllInterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type references for all implemented interfaces (both directly implemented and inherited)



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllInterfacesTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf" />  TypeMemberBuilder.ContentMembers Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


List of all type content members (fields, properties, methods, events)



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder> ContentMembers { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacestyperefs__3ufra9" />  TypeMemberBuilder.InterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type references for directly implemented interfaces



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> InterfacesTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.isgeneric__utg9go" />  TypeMemberBuilder.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Flag whether type is generic



```csharp
public bool IsGeneric { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.memberkind__1y10oqd" />  TypeMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typekind__qphofl" />  TypeMemberBuilder.TypeKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type kind (class, interface, ...)



```csharp
public TypeKindEnum TypeKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeref__1hwjb38" />  TypeMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</small>


Type reference for this type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w" />  TypeParameterBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc</small>


Builder for [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)



```csharp
public class TypeParameterBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.attributes__i6iqgf) | public | Type parameter attributes definition (including the parameters). | 
 | [ConstraintTypes](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.constrainttypes__1sn5icu) | public | List of type references of constraint types  when the concrete types are defined as constraints | 
 | [HasConstructorConstraint](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasconstructorconstraint__lz79dv) | public | Flag whether the type parameter has constructor constraint ( new() ) | 
 | [HasReferenceTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasreferencetypeconstraint__1c0buuo) | public | Flag whether the type parameter has reference type constraint ( class ) | 
 | [HasUnmanagedTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasunmanagedtypeconstraint__14xpe3x) | public | Flag whether the type parameter has unmanaged type constraint ( unmanaged ) | 
 | [HasValueTypeConstraint](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasvaluetypeconstraint__1ojvgf8) | public | Flag whether the type parameter has value type constraint ( struct ) | 
 | [Name](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.name__1swcen7) | public | Name of the parameter | 
 | [Variance](#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.variance__r9zbyx) | public | Variance (covariance and contravariance) modifier (in, out) for the type parameter if available. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.attributes__i6iqgf" />  TypeParameterBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Type parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.constrainttypes__1sn5icu" />  TypeParameterBuilder.ConstraintTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


List of type references of constraint types  when the concrete types are defined as constraints



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> ConstraintTypes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasconstructorconstraint__lz79dv" />  TypeParameterBuilder.HasConstructorConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Flag whether the type parameter has constructor constraint ( new() )



```csharp
public bool HasConstructorConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasreferencetypeconstraint__1c0buuo" />  TypeParameterBuilder.HasReferenceTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Flag whether the type parameter has reference type constraint ( class )



```csharp
public bool HasReferenceTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasunmanagedtypeconstraint__14xpe3x" />  TypeParameterBuilder.HasUnmanagedTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Flag whether the type parameter has unmanaged type constraint ( unmanaged )



```csharp
public bool HasUnmanagedTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasvaluetypeconstraint__1ojvgf8" />  TypeParameterBuilder.HasValueTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Flag whether the type parameter has value type constraint ( struct )



```csharp
public bool HasValueTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.name__1swcen7" />  TypeParameterBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Name of the parameter



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.variance__r9zbyx" />  TypeParameterBuilder.Variance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)</small>


Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.



```csharp
public string Variance { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.markup__1918uiv" />  net.adamec.dev.markupdoc.Markup Namespace ##
Markup composition related classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj) | public | HTML markup provider | 
 | [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9) | public | Markdown markup provider | 
 | [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys) | public | Markup output single file writer | 
 | [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36) | public | Markup generator | 
 | [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb) | public | Markup output multi file writer | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) | public abstract | Markup provider interface | 
 | [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) | public abstract | Interface of the markup output writer | 
 | [INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg) | public abstract | Non writable interface of the output writer | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj" />  HtmlMarkupProvider Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


HTML markup provider



```csharp
public class HtmlMarkupProvider : IMarkupProvider
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.markupwriter__11z2ax2) | public | Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output | 
 | [OutputOptions](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.outputoptions__dsmy12) | protected | Output configuration | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HtmlMarkupProvider(OutputOptions)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.-ctor_net.adamec.dev.markupdoc.options.outputoptions___j6fwjc) | public | CTOR with given [OutputOptions](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.outputoptions__dsmy12) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Bold(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bold_system.string___1qynapw) | public | Returns the markup for bold (strong) <strong>text</strong> | 
 | [Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b) | public | Returns the markup of the bookmark with given <strong>id</strong> | 
 | [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.code_system.string-system.boolean___juaq1h) | public | Returns the markup for multi-line code with given <strong>text</strong> | 
 | [DescriptionList(IList&lt;string&gt;)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____18u8zoh) | public | Returns the markup for the description list with the given <strong>renderedItems</strong> | 
 | [DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____1r9hw58) | public | Returns the markup for the description list with the given <strong>items</strong> | 
 | [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem_system.string-system.string___b7aaxm) | public | Returns the markup of the description list item | 
 | [DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, HtmlMarkupProvider.TItemType)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1ekkbyt) | public | Returns the markup of the description list item | 
 | [ExternalLink(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.externallink_system.string-system.string___1hcrnzo) | public | Returns the markup for the external link | 
 | [InlineCode(string, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.inlinecode_system.string-system.boolean___1fttc4c) | public | Returns the markup for inline code with given <strong>text</strong> | 
 | [Italic(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.italic_system.string___13ad6r1) | public | Returns the markup for italic (emphasized) <strong>text</strong> | 
 | [LineBreak()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.linebreak__kztdid) | public | Returns the markup for the line break | 
 | [Link(string, Member)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___1uer8n8) | public | Returns the markup for the internal link | 
 | [Link(string, string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.link_system.string-system.string-system.string___1qp7blb) | public | Returns the markup for the internal link | 
 | [List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___airw86) | public | Returns the markup for the list of the items | 
 | [Para(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.para_system.string___wojq3x) | public | Returns the markup for paragraph with given <strong>text</strong> | 
 | [Small(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.small_system.string___hgqng0) | public | Returns the markup for small <strong>text</strong> | 
 | [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablecols_system.string_____1jv7jno) | public | Returns the markup for the table row with given columns | 
 | [TableFooter()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablefooter__1vwh4nf) | public | Returns the markup for the table footer | 
 | [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tableheader_system.string_____qrpzxu) | public | Returns the markup for the table header with given columns | 
 | [Text(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.text_system.string___lqn9mc) | public | Returns the markup for the &quot;plain&quot; text | 
 | [WriteCodeAsync(string, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writecodeasync_system.string-system.boolean___pec4ge) | public | Writes the markup for multi-line code with given <strong>text</strong> | 
 | [WriteDocumentEndAsync()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writedocumentendasync__1nz8j5b) | public | Writes the markup for the end of the document (file) | 
 | [WriteDocumentStartAsync(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writedocumentstartasync_system.string___qnddpf) | public | Writes the markup for the beginning of the document (file) and level 1 header with title | 
 | [WriteH1Async(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh1async_system.string-system.string___15gnrvj) | public | Writes the level 1 <strong>header</strong> with  optional bookmark | 
 | [WriteH2Async(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh2async_system.string-system.string___lp25cg) | public | Writes the level 2 <strong>header</strong> with  optional bookmark | 
 | [WriteH3Async(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh3async_system.string-system.string___cyzxw5) | public | Writes the level 3 <strong>header</strong> with  optional bookmark | 
 | [WriteH4Async(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh4async_system.string-system.string___1q9xyx2) | public | Writes the level 4 <strong>header</strong> with  optional bookmark | 
 | [WriteHorizontalLineAsync()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writehorizontallineasync__xp579z) | public | Writes the markup for horizontal line Writes `<hr />` to the output | 
 | [WriteLineAsync(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writelineasync_system.string___77379g) | protected | Writes the line into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.markupwriter__11z2ax2) | 
 | [WriteParaAsync(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeparaasync_system.string___3tdjuo) | public | Writes the markup for paragraph with given <strong>text</strong> | 
 | [WriteTableColsAsync(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetablecolsasync_system.string_____1tr3v3b) | public | Writes the markup for the table row with given columns | 
 | [WriteTableFooterAsync()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetablefooterasync__lbdo3o) | public | Writes the markup for the table footer | 
 | [WriteTableHeaderAsync(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetableheaderasync_system.string_____9fpd8n) | public | Writes the markup for the table header with given columns | 
 | [WriteTextAsync(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetextasync_system.string___bax8hp) | public | Writes the <strong>text</strong> to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.markupwriter__11z2ax2" />  HtmlMarkupProvider.MarkupWriter Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output



```csharp
public IMarkupWriter MarkupWriter { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.outputoptions__dsmy12" />  HtmlMarkupProvider.OutputOptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Output configuration



```csharp
protected OutputOptions OutputOptions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.-ctor_net.adamec.dev.markupdoc.options.outputoptions___j6fwjc" />  HtmlMarkupProvider.HtmlMarkupProvider(OutputOptions) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


CTOR with given [OutputOptions](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.outputoptions__dsmy12)



```csharp
public HtmlMarkupProvider(OutputOptions outputOptions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) <strong>outputOptions</strong></dt><dd>Output configuration</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bold_system.string___1qynapw" />  HtmlMarkupProvider.Bold(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for bold (strong) <strong>text</strong>



```csharp
public virtual string Bold(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for bold (strong) <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<strong>{text}</strong>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b" />  HtmlMarkupProvider.Bookmark(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup of the bookmark with given <strong>id</strong>



```csharp
public virtual string Bookmark(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Bookmark id</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the bookmark with given <strong>id</strong></dd></dl>


###  Remarks ###
Writes `<a id=\"" + id + "\" ></a>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.code_system.string-system.boolean___juaq1h" />  HtmlMarkupProvider.Code(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for multi-line code with given <strong>text</strong>



```csharp
public virtual string Code(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for code with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<pre>{InlineCode(text)}</pre>` to the output


###  See Also ###
[InlineCode(string, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.inlinecode_system.string-system.boolean___1fttc4c)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____18u8zoh" />  HtmlMarkupProvider.DescriptionList(IList&lt;string&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the description list with the given <strong>renderedItems</strong>



```csharp
public virtual string DescriptionList(IList<string> renderedItems)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1" target="_blank" >IList&lt;string&gt;</a> <strong>renderedItems</strong></dt><dd>Description list items markup</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>renderedItems</strong></dd></dl>


###  Remarks ###
Writes the <strong>renderedItems</strong> between `<dl>` tags


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____1r9hw58" />  HtmlMarkupProvider.DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the description list with the given <strong>items</strong>



```csharp
public virtual string DescriptionList<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, IEnumerable<TItemType> items)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Description list items</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>items</strong></dd></dl>


###  Remarks ###
Renders the individual items using [DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, HtmlMarkupProvider.TItemType)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1ekkbyt) and then uses [DescriptionList(IList&lt;string&gt;)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____18u8zoh) to render the whole list


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem_system.string-system.string___b7aaxm" />  HtmlMarkupProvider.DescriptionListItem(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup of the description list item



```csharp
public virtual string DescriptionListItem(string itemTerm, string itemDescription)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemTerm</strong></dt><dd>Item term</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemDescription</strong></dt><dd>Item description</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


###  Remarks ###
Writes `<dt>{itemTerm}</dt><dd>{itemDescription}</dd>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1ekkbyt" />  HtmlMarkupProvider.DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, HtmlMarkupProvider.TItemType) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup of the description list item



```csharp
public virtual string DescriptionListItem<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, HtmlMarkupProvider.TItemType item)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt>net.adamec.dev.markupdoc.Markup.HtmlMarkupProvider.TItemType <strong>item</strong></dt><dd>Object to generate the description list item for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


###  Remarks ###
Uses [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.descriptionlistitem_system.string-system.string___b7aaxm) to render the individual items once the functions are evaluated


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.externallink_system.string-system.string___1hcrnzo" />  HtmlMarkupProvider.ExternalLink(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the external link



```csharp
public virtual string ExternalLink(string text, string url)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>url</strong></dt><dd>Link URL</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the external link</dd></dl>


###  Remarks ###
Writes `<a href=\"{url}\" class=\"link-external\" target=\"_blank\" >{text}</a>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.inlinecode_system.string-system.boolean___1fttc4c" />  HtmlMarkupProvider.InlineCode(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for inline code with given <strong>text</strong>



```csharp
public virtual string InlineCode(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Inline code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for inline code with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<code class="csharp">{text}</code>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.italic_system.string___13ad6r1" />  HtmlMarkupProvider.Italic(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for italic (emphasized) <strong>text</strong>



```csharp
public virtual string Italic(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for italic (emphasized) <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<em>{text}</em>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.linebreak__kztdid" />  HtmlMarkupProvider.LineBreak() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the line break



```csharp
public virtual string LineBreak()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the line break</dd></dl>


###  Remarks ###
Writes `"<br />" + Environment.NewLine` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___1uer8n8" />  HtmlMarkupProvider.Link(string, Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the internal link



```csharp
public virtual string Link(string text, Member member)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>[Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to generate the link to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


###  Remarks ###
Gets the information about <strong>member</strong> and uses [Link(string, string, string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.link_system.string-system.string-system.string___1qp7blb) to render the link


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.link_system.string-system.string-system.string___1qp7blb" />  HtmlMarkupProvider.Link(string, string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the internal link



```csharp
public virtual string Link(string text, string file, string bookmark)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>file</strong></dt><dd>Name of the file relative to the documentation root (index file)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


###  Remarks ###
Writes `<a href=\"{file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")}\" >{text}</a>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___airw86" />  HtmlMarkupProvider.List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the list of the items



```csharp
public virtual string List<TItemType>(Func<TItemType,string> itemOutput, IEnumerable<TItemType> items, bool numbered = false)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the list item entry object</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemOutput</strong></dt><dd>Function returning the markup for single item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>List items</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>numbered</strong></dt><dd>Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the list of the items</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.para_system.string___wojq3x" />  HtmlMarkupProvider.Para(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for paragraph with given <strong>text</strong>



```csharp
public virtual string Para(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for paragraph with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<p>{text}</p>` to the output when the text is provided (so no empty paragraphs are generated)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.small_system.string___hgqng0" />  HtmlMarkupProvider.Small(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for small <strong>text</strong>



```csharp
public virtual string Small(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for small <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<small>{text}</small>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablecols_system.string_____1jv7jno" />  HtmlMarkupProvider.TableCols(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the table row with given columns



```csharp
public virtual string TableCols(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table row with given columns</dd></dl>


###  Remarks ###
Writes `<tr><td>{string.Join("</td><td>", items)}</td></tr>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablefooter__1vwh4nf" />  HtmlMarkupProvider.TableFooter() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the table footer



```csharp
public virtual string TableFooter()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table footer</dd></dl>


###  Remarks ###
Writes `</table>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tableheader_system.string_____qrpzxu" />  HtmlMarkupProvider.TableHeader(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the table header with given columns



```csharp
public virtual string TableHeader(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table header with given columns</dd></dl>


###  Remarks ###
Writes `<table><tr><th>{string.Join("</th><th>", items)}</th></tr>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.text_system.string___lqn9mc" />  HtmlMarkupProvider.Text(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Returns the markup for the &quot;plain&quot; text



```csharp
public virtual string Text(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the &quot;plain&quot; text</dd></dl>


###  Remarks ###
HTML encodes the <strong>text</strong>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writecodeasync_system.string-system.boolean___pec4ge" />  HtmlMarkupProvider.WriteCodeAsync(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for multi-line code with given <strong>text</strong>



```csharp
public virtual Task WriteCodeAsync(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.code_system.string-system.boolean___juaq1h) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writedocumentendasync__1nz8j5b" />  HtmlMarkupProvider.WriteDocumentEndAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for the end of the document (file)



```csharp
public virtual Task WriteDocumentEndAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Closed the `body` and `html` tags


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writedocumentstartasync_system.string___qnddpf" />  HtmlMarkupProvider.WriteDocumentStartAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for the beginning of the document (file) and level 1 header with title



```csharp
public virtual async Task WriteDocumentStartAsync(string title = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>title</strong></dt><dd>Document title</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes the HTML header with links the CSS and Javascript for the Highlight.js and the style sheet for the documentation. Opens the `body` tag


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh1async_system.string-system.string___15gnrvj" />  HtmlMarkupProvider.WriteH1Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the level 1 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH1Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `<h1> {Bookmark(bookmark)} {header} </h1>` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh2async_system.string-system.string___lp25cg" />  HtmlMarkupProvider.WriteH2Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the level 2 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH2Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `<h2> {Bookmark(bookmark)} {header} </h2>` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh3async_system.string-system.string___cyzxw5" />  HtmlMarkupProvider.WriteH3Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the level 3 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH3Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `<h3> {Bookmark(bookmark)} {header} </h3>` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeh4async_system.string-system.string___1q9xyx2" />  HtmlMarkupProvider.WriteH4Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the level 4 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH4Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `<h4> {Bookmark(bookmark)} {header} </h4>` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.bookmark_system.string___tf3k8b)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writehorizontallineasync__xp579z" />  HtmlMarkupProvider.WriteHorizontalLineAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for horizontal line Writes `<hr />` to the output



```csharp
public virtual Task WriteHorizontalLineAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writelineasync_system.string___77379g" />  HtmlMarkupProvider.WriteLineAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the line into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.markupwriter__11z2ax2)



```csharp
protected Task WriteLineAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Line content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writeparaasync_system.string___3tdjuo" />  HtmlMarkupProvider.WriteParaAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for paragraph with given <strong>text</strong>



```csharp
public virtual Task WriteParaAsync(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [Para(string)](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.para_system.string___wojq3x) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetablecolsasync_system.string_____1tr3v3b" />  HtmlMarkupProvider.WriteTableColsAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for the table row with given columns



```csharp
public virtual Task WriteTableColsAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablecols_system.string_____1jv7jno) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetablefooterasync__lbdo3o" />  HtmlMarkupProvider.WriteTableFooterAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for the table footer



```csharp
public virtual Task WriteTableFooterAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableFooter()](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tablefooter__1vwh4nf) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetableheaderasync_system.string_____9fpd8n" />  HtmlMarkupProvider.WriteTableHeaderAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the markup for the table header with given columns



```csharp
public virtual async Task WriteTableHeaderAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.tableheader_system.string_____qrpzxu) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.htmlmarkupprovider.writetextasync_system.string___bax8hp" />  HtmlMarkupProvider.WriteTextAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [HtmlMarkupProvider](#t-net.adamec.dev.markupdoc.markup.htmlmarkupprovider__oinjfj)</small>


Writes the <strong>text</strong> to the output



```csharp
public virtual Task WriteTextAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9" />  MarkdownMarkupProvider Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Markdown markup provider



```csharp
public class MarkdownMarkupProvider : IMarkupProvider
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e) | public | Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output | 
 | [OutputOptions](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.outputoptions__1c1tmim) | protected | Output configuration | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MarkdownMarkupProvider(OutputOptions)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.-ctor_net.adamec.dev.markupdoc.options.outputoptions___1h2t4lc) | public | CTOR with given [OutputOptions](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.outputoptions__1c1tmim) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Bold(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bold_system.string___b9aa40) | public | Returns the markup for bold (strong) <strong>text</strong> | 
 | [Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l) | public | Returns the markup of the bookmark with given <strong>id</strong> | 
 | [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.code_system.string-system.boolean___k8fv7z) | public | Returns the markup for multi-line code with given <strong>text</strong> | 
 | [DescriptionList(IList&lt;string&gt;)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____1brwmlb) | public | Returns the markup for the description list with the given <strong>renderedItems</strong> | 
 | [DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____1s7b5lg) | public | Returns the markup for the description list with the given <strong>items</strong> | 
 | [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem_system.string-system.string___1av3zn6) | public | Returns the markup of the description list item | 
 | [DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, MarkdownMarkupProvider.TItemType)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1qq7hkf) | public | Returns the markup of the description list item | 
 | [ExternalLink(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.externallink_system.string-system.string___174by24) | public | Returns the markup for the external link | 
 | [InlineCode(string, bool)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.inlinecode_system.string-system.boolean___1b4extg) | public | Returns the markup for inline code with given <strong>text</strong> | 
 | [Italic(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.italic_system.string___b2vpxr) | public | Returns the markup for italic (emphasized) <strong>text</strong> | 
 | [LineBreak()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.linebreak__hs8533) | public | Returns the markup for the line break | 
 | [Link(string, Member)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___v9zov0) | public | Returns the markup for the internal link | 
 | [Link(string, string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.link_system.string-system.string-system.string___76rdyl) | public | Returns the markup for the internal link | 
 | [List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___1917ej2) | public | Returns the markup for the list of the items | 
 | [Para(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.para_system.string___132alpn) | public | Returns the markup for paragraph with given <strong>text</strong> | 
 | [Small(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.small_system.string___1lx0f04) | public | Returns the markup for small <strong>text</strong> | 
 | [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablecols_system.string_____148cz14) | public | Returns the markup for the table row with given columns | 
 | [TableFooter()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablefooter__1dlh3o5) | public | Returns the markup for the table footer | 
 | [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tableheader_system.string_____1e5alfy) | public | Returns the markup for the table header with given columns | 
 | [Text(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.text_system.string___h7ckd8) | public | Returns the markup for the &quot;plain&quot; text | 
 | [WriteAsync(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeasync_system.string___k18wdm) | protected | Writes the text into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e) | 
 | [WriteCodeAsync(string, bool)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writecodeasync_system.string-system.boolean___1jsgrs6) | public | Writes the markup for multi-line code with given <strong>text</strong> | 
 | [WriteDocumentEndAsync()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writedocumentendasync__1nr8f51) | public | Writes the markup for the end of the document (file) | 
 | [WriteDocumentStartAsync(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writedocumentstartasync_system.string___7jtt0h) | public | Writes the markup for the beginning of the document (file) and level 1 header with title | 
 | [WriteH1Async(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh1async_system.string-system.string___ya18vd) | public | Writes the level 1 <strong>header</strong> with  optional bookmark | 
 | [WriteH2Async(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh2async_system.string-system.string___lnpb08) | public | Writes the level 2 <strong>header</strong> with  optional bookmark | 
 | [WriteH3Async(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh3async_system.string-system.string___1qpmhf7) | public | Writes the level 3 <strong>header</strong> with  optional bookmark | 
 | [WriteH4Async(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh4async_system.string-system.string___npsj8a) | public | Writes the level 4 <strong>header</strong> with  optional bookmark | 
 | [WriteHorizontalLineAsync()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writehorizontallineasync__1uvqjt5) | public | Writes the markup for horizontal line Writes `----` to the output | 
 | [WriteLineAsync(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writelineasync_system.string___162wgc0) | protected | Writes the line into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e) | 
 | [WriteParaAsync(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeparaasync_system.string___j458mk) | public | Writes the markup for paragraph with given <strong>text</strong> | 
 | [WriteTableColsAsync(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetablecolsasync_system.string_____jje9d) | public | Writes the markup for the table row with given columns | 
 | [WriteTableFooterAsync()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetablefooterasync__13f0c5o) | public | Writes the markup for the table footer | 
 | [WriteTableHeaderAsync(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetableheaderasync_system.string_____xnsal9) | public | Writes the markup for the table header with given columns | 
 | [WriteTextAsync(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetextasync_system.string___1p36ub) | public | Writes the <strong>text</strong> to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e" />  MarkdownMarkupProvider.MarkupWriter Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output



```csharp
public IMarkupWriter MarkupWriter { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.outputoptions__1c1tmim" />  MarkdownMarkupProvider.OutputOptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Output configuration



```csharp
protected OutputOptions OutputOptions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.-ctor_net.adamec.dev.markupdoc.options.outputoptions___1h2t4lc" />  MarkdownMarkupProvider.MarkdownMarkupProvider(OutputOptions) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


CTOR with given [OutputOptions](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.outputoptions__1c1tmim)



```csharp
public MarkdownMarkupProvider(OutputOptions outputOptions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) <strong>outputOptions</strong></dt><dd>Output configuration</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bold_system.string___b9aa40" />  MarkdownMarkupProvider.Bold(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for bold (strong) <strong>text</strong>



```csharp
public virtual string Bold(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for bold (strong) <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<strong>{text}</strong>` to the output. There are problems when markdown &quot;tags&quot; are used within HTML tags (for example in description lists), so better to use the HTML tags for bold text as well


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l" />  MarkdownMarkupProvider.Bookmark(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup of the bookmark with given <strong>id</strong>



```csharp
public virtual string Bookmark(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Bookmark id</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the bookmark with given <strong>id</strong></dd></dl>


###  Remarks ###
Writes `<a id=\"" + id + "\" ></a>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.code_system.string-system.boolean___k8fv7z" />  MarkdownMarkupProvider.Code(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for multi-line code with given <strong>text</strong>



```csharp
public virtual string Code(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for code with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes `{Environment.NewLine}```csharp{Environment.NewLine}{text}{Environment.NewLine}```{Environment.NewLine}` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____1brwmlb" />  MarkdownMarkupProvider.DescriptionList(IList&lt;string&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the description list with the given <strong>renderedItems</strong>



```csharp
public virtual string DescriptionList(IList<string> renderedItems)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1" target="_blank" >IList&lt;string&gt;</a> <strong>renderedItems</strong></dt><dd>Description list items markup</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>renderedItems</strong></dd></dl>


###  Remarks ###
Writes the <strong>renderedItems</strong> between `<dl>` tags


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____1s7b5lg" />  MarkdownMarkupProvider.DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the description list with the given <strong>items</strong>



```csharp
public virtual string DescriptionList<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, IEnumerable<TItemType> items)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Description list items</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>items</strong></dd></dl>


###  Remarks ###
Renders the individual items using [DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, MarkdownMarkupProvider.TItemType)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1qq7hkf) and then uses [DescriptionList(IList&lt;string&gt;)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____1brwmlb) to render the whole list


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem_system.string-system.string___1av3zn6" />  MarkdownMarkupProvider.DescriptionListItem(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup of the description list item



```csharp
public virtual string DescriptionListItem(string itemTerm, string itemDescription)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemTerm</strong></dt><dd>Item term</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemDescription</strong></dt><dd>Item description</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


###  Remarks ###
Writes `<dt>{itemTerm}</dt><dd>{itemDescription}</dd>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1qq7hkf" />  MarkdownMarkupProvider.DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, MarkdownMarkupProvider.TItemType) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup of the description list item



```csharp
public virtual string DescriptionListItem<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, MarkdownMarkupProvider.TItemType item)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt>net.adamec.dev.markupdoc.Markup.MarkdownMarkupProvider.TItemType <strong>item</strong></dt><dd>Object to generate the description list item for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


###  Remarks ###
Uses [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.descriptionlistitem_system.string-system.string___1av3zn6) to render the individual items once the functions are evaluated


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.externallink_system.string-system.string___174by24" />  MarkdownMarkupProvider.ExternalLink(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the external link



```csharp
public virtual string ExternalLink(string text, string url)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>url</strong></dt><dd>Link URL</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the external link</dd></dl>


###  Remarks ###
Writes `<a href=\"{url}\" class=\"link-external\" target=\"_blank\" >{text}</a>` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.inlinecode_system.string-system.boolean___1b4extg" />  MarkdownMarkupProvider.InlineCode(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for inline code with given <strong>text</strong>



```csharp
public virtual string InlineCode(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Inline code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for inline code with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes ``{text}`` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.italic_system.string___b2vpxr" />  MarkdownMarkupProvider.Italic(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for italic (emphasized) <strong>text</strong>



```csharp
public virtual string Italic(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for italic (emphasized) <strong>text</strong></dd></dl>


###  Remarks ###
Writes `<em>{text}</em>` to the output. There are problems when markdown &quot;tags&quot; are used within HTML tags (for example in description lists), so better to use the HTML tags for italic text as well


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.linebreak__hs8533" />  MarkdownMarkupProvider.LineBreak() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the line break



```csharp
public virtual string LineBreak()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the line break</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___v9zov0" />  MarkdownMarkupProvider.Link(string, Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the internal link



```csharp
public virtual string Link(string text, Member member)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>[Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to generate the link to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


###  Remarks ###
Gets the information about <strong>member</strong> and uses [Link(string, string, string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.link_system.string-system.string-system.string___76rdyl) to render the link


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.link_system.string-system.string-system.string___76rdyl" />  MarkdownMarkupProvider.Link(string, string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the internal link



```csharp
public virtual string Link(string text, string file, string bookmark)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>file</strong></dt><dd>Name of the file relative to the documentation root (index file)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


###  Remarks ###
Writes `[{text}]({file}{(string.IsNullOrEmpty(bookmark) ? "" : $"#{bookmark}")})` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___1917ej2" />  MarkdownMarkupProvider.List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the list of the items



```csharp
public virtual string List<TItemType>(Func<TItemType,string> itemOutput, IEnumerable<TItemType> items, bool numbered = false)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the list item entry object</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemOutput</strong></dt><dd>Function returning the markup for single item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>List items</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>numbered</strong></dt><dd>Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the list of the items</dd></dl>


###  Remarks ###
Writes `{(numbered ? $"{idx}." : " -")} {itemOutput.Invoke(item)}{Environment.NewLine}` for each item with additional new lines before and after the list


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.para_system.string___132alpn" />  MarkdownMarkupProvider.Para(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for paragraph with given <strong>text</strong>



```csharp
public virtual string Para(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for paragraph with given <strong>text</strong></dd></dl>


###  Remarks ###
Writes `text + Environment.NewLine + Environment.NewLine` to the output when the text is provided (so no empty paragraphs are generated)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.small_system.string___1lx0f04" />  MarkdownMarkupProvider.Small(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for small <strong>text</strong>



```csharp
public virtual string Small(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for small <strong>text</strong></dd></dl>


###  Remarks ###
Writes `{text}` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablecols_system.string_____148cz14" />  MarkdownMarkupProvider.TableCols(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the table row with given columns



```csharp
public virtual string TableCols(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table row with given columns</dd></dl>


###  Remarks ###
Writes `| {string.Join(" | ", items)} | {Environment.NewLine}` to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablefooter__1dlh3o5" />  MarkdownMarkupProvider.TableFooter() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the table footer



```csharp
public virtual string TableFooter()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table footer</dd></dl>


###  Remarks ###
Writes just the line break to the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tableheader_system.string_____1e5alfy" />  MarkdownMarkupProvider.TableHeader(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the table header with given columns



```csharp
public virtual string TableHeader(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table header with given columns</dd></dl>


###  Remarks ###
Writes the header columns split by &quot;|&quot; and the table header row like &quot;|---|---|---|&quot; (of course with the proper number of columns


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.text_system.string___h7ckd8" />  MarkdownMarkupProvider.Text(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Returns the markup for the &quot;plain&quot; text



```csharp
public virtual string Text(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the &quot;plain&quot; text</dd></dl>


###  Remarks ###
HTML encodes the <strong>text</strong>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeasync_system.string___k18wdm" />  MarkdownMarkupProvider.WriteAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the text into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e)



```csharp
protected Task WriteAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writecodeasync_system.string-system.boolean___1jsgrs6" />  MarkdownMarkupProvider.WriteCodeAsync(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for multi-line code with given <strong>text</strong>



```csharp
public virtual Task WriteCodeAsync(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.code_system.string-system.boolean___k8fv7z) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writedocumentendasync__1nr8f51" />  MarkdownMarkupProvider.WriteDocumentEndAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for the end of the document (file)



```csharp
public virtual Task WriteDocumentEndAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writedocumentstartasync_system.string___7jtt0h" />  MarkdownMarkupProvider.WriteDocumentStartAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for the beginning of the document (file) and level 1 header with title



```csharp
public virtual async Task WriteDocumentStartAsync(string title = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>title</strong></dt><dd>Document title</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh1async_system.string-system.string___ya18vd" />  MarkdownMarkupProvider.WriteH1Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the level 1 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH1Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `# {Bookmark(bookmark)} {header} #` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh2async_system.string-system.string___lnpb08" />  MarkdownMarkupProvider.WriteH2Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the level 2 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH2Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `## {Bookmark(bookmark)} {header} ##` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh3async_system.string-system.string___1qpmhf7" />  MarkdownMarkupProvider.WriteH3Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the level 3 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH3Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `### {Bookmark(bookmark)} {header} ###` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeh4async_system.string-system.string___npsj8a" />  MarkdownMarkupProvider.WriteH4Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the level 4 <strong>header</strong> with  optional bookmark



```csharp
public virtual Task WriteH4Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes `#### {Bookmark(bookmark)} {header} ####` to the output


###  See Also ###
[Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.bookmark_system.string___1mbr35l)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writehorizontallineasync__1uvqjt5" />  MarkdownMarkupProvider.WriteHorizontalLineAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for horizontal line Writes `----` to the output



```csharp
public virtual Task WriteHorizontalLineAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writelineasync_system.string___162wgc0" />  MarkdownMarkupProvider.WriteLineAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the line into the [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.markupwriter__iogc0e)



```csharp
protected Task WriteLineAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Line content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writeparaasync_system.string___j458mk" />  MarkdownMarkupProvider.WriteParaAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for paragraph with given <strong>text</strong>



```csharp
public virtual Task WriteParaAsync(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [Para(string)](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.para_system.string___132alpn) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetablecolsasync_system.string_____jje9d" />  MarkdownMarkupProvider.WriteTableColsAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for the table row with given columns



```csharp
public virtual Task WriteTableColsAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablecols_system.string_____148cz14) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetablefooterasync__13f0c5o" />  MarkdownMarkupProvider.WriteTableFooterAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for the table footer



```csharp
public virtual Task WriteTableFooterAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableFooter()](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tablefooter__1dlh3o5) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetableheaderasync_system.string_____xnsal9" />  MarkdownMarkupProvider.WriteTableHeaderAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the markup for the table header with given columns



```csharp
public virtual async Task WriteTableHeaderAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses the [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.tableheader_system.string_____1e5alfy) function to get the markup


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markdownmarkupprovider.writetextasync_system.string___1p36ub" />  MarkdownMarkupProvider.WriteTextAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkdownMarkupProvider](#t-net.adamec.dev.markupdoc.markup.markdownmarkupprovider__189wwt9)</small>


Writes the <strong>text</strong> to the output



```csharp
public virtual Task WriteTextAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys" />  MarkupFileWriter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Markup output single file writer



```csharp
public class MarkupFileWriter : BaseDisposable, IMarkupWriter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.Utils.BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.dev.markupdoc.Markup.IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75), [net.adamec.dev.markupdoc.Markup.INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsInProgress](#p-net.adamec.dev.markupdoc.markup.markupfilewriter.isinprogress__1gxpzuq) | public | Flag whether the output is currently being generated | 
 | [Target](#p-net.adamec.dev.markupdoc.markup.markupfilewriter.target__1ulj4al) | public | Full path to the target output file | 
 | [Writer](#p-net.adamec.dev.markupdoc.markup.markupfilewriter.writer__fhot8b) | protected | Underlying <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter" target="_blank" >System.IO.StreamWriter</a> used to write the output to the file. | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DisposeManaged()](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.disposemanaged__1cklrbb) | protected | Disposes the markup writer - flush the output, close the output file and dispose the underlying stream writer | 
 | [SetTarget(string)](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.settarget_system.string___42x1bx) | public | Sets the target of the markdown writer | 
 | [Split(string)](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.split_system.string___1qu56ua) | public | Starts a new split of the output - it&#39;s ignored for the single file output | 
 | [WriteAsync(string)](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.writeasync_system.string___n2fw5x) | public | Writes the <strong>text</strong> to the output | 
 | [WriteLineAsync(string)](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.writelineasync_system.string___nhuxxz) | public | Writes the <strong>text</strong> and a new line to the output | 
 | [WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;)](#m-net.adamec.dev.markupdoc.markup.markupfilewriter.writemodelasync_system.func_system.threading.tasks.task____1cfox9p) | public | Writes the code model to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupfilewriter.isinprogress__1gxpzuq" />  MarkupFileWriter.IsInProgress Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Flag whether the output is currently being generated



```csharp
public bool IsInProgress { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupfilewriter.target__1ulj4al" />  MarkupFileWriter.Target Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Full path to the target output file



```csharp
public string Target { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupfilewriter.writer__fhot8b" />  MarkupFileWriter.Writer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Underlying <a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter" target="_blank" >System.IO.StreamWriter</a> used to write the output to the file.



```csharp
protected StreamWriter Writer { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.streamwriter" target="_blank" >System.IO.StreamWriter</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.disposemanaged__1cklrbb" />  MarkupFileWriter.DisposeManaged() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Disposes the markup writer - flush the output, close the output file and dispose the underlying stream writer



```csharp
protected override void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.settarget_system.string___42x1bx" />  MarkupFileWriter.SetTarget(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Sets the target of the markdown writer



```csharp
public virtual bool SetTarget(string fileName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Full path to the file (including the extension) to write the output to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the target has been set, otherwise false (because the output is in progress)</dd></dl>


###  Remarks ###
The [Target](#p-net.adamec.dev.markupdoc.markup.markupfilewriter.target__1ulj4al) is the full path to the output file. The target can&#39;t be set when the output is being generated


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.split_system.string___1qu56ua" />  MarkupFileWriter.Split(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Starts a new split of the output - it&#39;s ignored for the single file output



```csharp
public virtual void Split(string splitName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>splitName</strong></dt><dd>Name of the split</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.writeasync_system.string___n2fw5x" />  MarkupFileWriter.WriteAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Writes the <strong>text</strong> to the output



```csharp
public virtual async Task WriteAsync(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.writelineasync_system.string___nhuxxz" />  MarkupFileWriter.WriteLineAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Writes the <strong>text</strong> and a new line to the output



```csharp
public virtual async Task WriteLineAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupfilewriter.writemodelasync_system.func_system.threading.tasks.task____1cfox9p" />  MarkupFileWriter.WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)</small>


Writes the code model to the output



```csharp
public virtual async Task WriteModelAsync(Func<System.Threading.Tasks.Task> writeContentActionAsync)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;System.Threading.Tasks.Task&gt;</a> <strong>writeContentActionAsync</strong></dt><dd>Function rendering the model to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36" />  MarkupGenerator Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Markup generator



```csharp
public class MarkupGenerator
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Here is the overall look and feel of documentation implemented. The MarkupGenerator is the traversing the code model, building the documentation and render the output for individual parts using the [Markup](#p-net.adamec.dev.markupdoc.markup.markupgenerator.markup__1vbytfw) provider The term &quot;page&quot; used with the generator simply means the documentation for single member even if the whole documentation might be rendered into single file




###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseFileName](#p-net.adamec.dev.markupdoc.markup.markupgenerator.basefilename__gh1ccg) | protected | Name of the (main) file | 
 | [FileName](#p-net.adamec.dev.markupdoc.markup.markupgenerator.filename__13khtsz) | protected | Full path to the (main) file | 
 | [Markup](#p-net.adamec.dev.markupdoc.markup.markupgenerator.markup__1vbytfw) | protected | [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) used to render the markup | 
 | [Model](#p-net.adamec.dev.markupdoc.markup.markupgenerator.model__1co1bvp) | protected | Root of the code model | 
 | [Options](#p-net.adamec.dev.markupdoc.markup.markupgenerator.options__1s5c9s6) | protected | Output configuration | 
 | [Title](#p-net.adamec.dev.markupdoc.markup.markupgenerator.title__djkbku) | protected | Documentation title shown at the top of each page | 
 | [Writer](#p-net.adamec.dev.markupdoc.markup.markupgenerator.writer__k1ecih) | protected | Underlying output writer. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MarkupGenerator(string, RootMember, IMarkupProvider)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.-ctor_system.string-net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider___8kpdd9) | public | CTOR | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Split(string)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.split_system.string___15djmg6) | public | Initializes a new split. When splitting is not required, it&#39;s ignored (no split generated) | 
 | [TypeRefWithLink(TypeRef, bool)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.typerefwithlink_net.adamec.dev.markupdoc.codemodel.typeref-system.boolean___1i3oxay) | protected | Renders the type reference ( [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) ) with link if available | 
 | [TypRefHierarchyWithLinks(TypeRef, string, bool)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.typrefhierarchywithlinks_net.adamec.dev.markupdoc.codemodel.typeref-system.string-system.boolean___10q15vf) | protected | Renders the type hierarchy from the &quot;very base type&quot; to the type represented by given <strong>typeRef</strong> | 
 | [WriteConstantsTableAsync(string, ICollection&lt;net.adamec.dev.markupdoc.CodeModel.FieldMember&gt;)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writeconstantstableasync_system.string-system.collections.generic.icollection_net.adamec.dev.markupdoc.codemodel.fieldmember____d4difj) | protected | Writes the table with given list of constants | 
 | [WriteDocumentationExampleAsync(Member)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationexampleasync_net.adamec.dev.markupdoc.codemodel.member___1gemch6) | protected | Writes the Example documentation section for given <strong>member</strong> if available | 
 | [WriteDocumentationExceptionsAsync(Member)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationexceptionsasync_net.adamec.dev.markupdoc.codemodel.member___xz5wnq) | protected | Writes the Exceptions documentation section for given <strong>member</strong> if available | 
 | [WriteDocumentationRemarksAsync(Member)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationremarksasync_net.adamec.dev.markupdoc.codemodel.member___1kq5btp) | protected | Writes the Remarks documentation section for given <strong>member</strong> if available | 
 | [WriteDocumentationSeeAlsoAsync(Member)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationseealsoasync_net.adamec.dev.markupdoc.codemodel.member___1r791ds) | protected | Writes the See Also documentation section for given <strong>member</strong> if available | 
 | [WriteEventAsync(EventMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writeeventasync_net.adamec.dev.markupdoc.codemodel.eventmember___nfiwo0) | protected | Writes the event documentation page | 
 | [WriteFieldAsync(FieldMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writefieldasync_net.adamec.dev.markupdoc.codemodel.fieldmember___1ly8teo) | protected | Writes the field documentation page | 
 | [WriteMembersTableAsync(string, ICollection&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writememberstableasync_system.string-system.collections.generic.icollection_net.adamec.dev.markupdoc.codemodel.member____1ogbyt3) | protected | Writes the table with given list of members | 
 | [WriteMethodAsync(MethodMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writemethodasync_net.adamec.dev.markupdoc.codemodel.methodmember___2mw79k) | protected | Writes the method documentation page | 
 | [WriteModelAsync(string)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writemodelasync_system.string___zl49vu) | public | Main code model rendering public end point. Writes the model into the documentation file(s) | 
 | [WriteModelContentAsync()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writemodelcontentasync__t54h4e) | protected | Writes the code model into the output | 
 | [WriteNamespaceAsync(NamespaceMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespaceasync_net.adamec.dev.markupdoc.codemodel.namespacemember___15mn91c) | protected | Writes the namespace documentation page | 
 | [WriteNamespacesAsync()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespacesasync__11thw7o) | protected | Writes the namespaces and their members into the output | 
 | [WriteNamespacesListAsync()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespaceslistasync__17n45k8) | protected | Writes the table of all namespaces within the code model into the output | 
 | [WritePageFooter()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writepagefooter__qhunh8) | protected | Writes the page footer | 
 | [WritePropertyAsync(PropertyMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writepropertyasync_net.adamec.dev.markupdoc.codemodel.propertymember___1l6fuxk) | protected | Writes the property documentation page | 
 | [WriteTypeAsync(TypeMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeasync_net.adamec.dev.markupdoc.codemodel.typemember___e4a8de) | protected | Writes the type documentation page | 
 | [WriteTypeContentMemberHeaderAsync(TypeContentMember, string)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypecontentmemberheaderasync_net.adamec.dev.markupdoc.codemodel.typecontentmember-system.string___126xy13) | protected | Writes the header for the type member (field, method, etc.) | 
 | [WriteTypeHeaderAsync(TypeMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeheaderasync_net.adamec.dev.markupdoc.codemodel.typemember___cgai25) | protected | Writes the header for the type member (field, method, etc.) | 
 | [WriteTypesAsync(NamespaceMember)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypesasync_net.adamec.dev.markupdoc.codemodel.namespacemember___1xky7be) | protected | Writes the types and their members contained within given namespace into the output | 
 | [WriteTypesListAsync()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeslistasync__1dszey5) | protected | Writes the table of all types within the code model into the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.basefilename__gh1ccg" />  MarkupGenerator.BaseFileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Name of the (main) file



```csharp
protected string BaseFileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.filename__13khtsz" />  MarkupGenerator.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Full path to the (main) file



```csharp
protected string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.markup__1vbytfw" />  MarkupGenerator.Markup Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) used to render the markup



```csharp
protected IMarkupProvider Markup { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.model__1co1bvp" />  MarkupGenerator.Model Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Root of the code model



```csharp
protected RootMember Model { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.options__1s5c9s6" />  MarkupGenerator.Options Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Output configuration



```csharp
protected OutputOptions Options { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.title__djkbku" />  MarkupGenerator.Title Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Documentation title shown at the top of each page



```csharp
protected string Title { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupgenerator.writer__k1ecih" />  MarkupGenerator.Writer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Underlying output writer.



```csharp
protected INonWritableWriter Writer { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)</dt><dd></dd></dl>


###  Remarks ###
Used for splitting only. Never write to the output writer directly, use the [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) instead!


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.-ctor_system.string-net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider___8kpdd9" />  MarkupGenerator.MarkupGenerator(string, RootMember, IMarkupProvider) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


CTOR



```csharp
public MarkupGenerator(string fileName, RootMember model, IMarkupProvider markupProvider)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Full path to the (main) file</dd><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) <strong>model</strong></dt><dd>Root of the code model</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) used to render the markup</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.split_system.string___15djmg6" />  MarkupGenerator.Split(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Initializes a new split. When splitting is not required, it&#39;s ignored (no split generated)



```csharp
public virtual async Task Split(string splitName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>splitName</strong></dt><dd>Name of the split</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  See Also ###
[MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.typerefwithlink_net.adamec.dev.markupdoc.codemodel.typeref-system.boolean___1i3oxay" />  MarkupGenerator.TypeRefWithLink(TypeRef, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Renders the type reference ( [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) ) with link if available



```csharp
protected virtual string TypeRefWithLink(TypeRef typeRef, bool includeNamespace = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) <strong>typeRef</strong></dt><dd>Type reference to render</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespace</strong></dt><dd>Flag whether to include the namespace in the member name shown</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Async task</dd></dl>


###  Remarks ###
When the <strong>typeRef</strong> is related to a member from code model, the link to the member is created. Otherwise, the will try to resolve the link to MS API online documentation using [GetLink(TypeRef)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7) . When the link can&#39;t be built, just member&#39;s name is returned as a plain text.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.typrefhierarchywithlinks_net.adamec.dev.markupdoc.codemodel.typeref-system.string-system.boolean___10q15vf" />  MarkupGenerator.TypRefHierarchyWithLinks(TypeRef, string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Renders the type hierarchy from the &quot;very base type&quot; to the type represented by given <strong>typeRef</strong>



```csharp
protected virtual string TypRefHierarchyWithLinks(TypeRef typeRef, string separator, bool includeNamespace = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) <strong>typeRef</strong></dt><dd>Type reference to render the type hierarchy for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Inheritance separator</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespace</strong></dt><dd>Flag whether to include the namespace in the member name shown</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Uses [TypeRefWithLink(TypeRef, bool)](#m-net.adamec.dev.markupdoc.markup.markupgenerator.typerefwithlink_net.adamec.dev.markupdoc.codemodel.typeref-system.boolean___1i3oxay) to render individual parts of hierarchy


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writeconstantstableasync_system.string-system.collections.generic.icollection_net.adamec.dev.markupdoc.codemodel.fieldmember____d4difj" />  MarkupGenerator.WriteConstantsTableAsync(string, ICollection&lt;net.adamec.dev.markupdoc.CodeModel.FieldMember&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the table with given list of constants



```csharp
protected virtual async Task WriteConstantsTableAsync(string part, ICollection<net.adamec.dev.markupdoc.CodeModel.FieldMember> members)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>part</strong></dt><dd>Name of the part (kind of members) to be shown before the table</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >ICollection&lt;net.adamec.dev.markupdoc.CodeModel.FieldMember&gt;</a> <strong>members</strong></dt><dd>Members to be listed</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Table has three columns - Name, Value and Summary


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationexampleasync_net.adamec.dev.markupdoc.codemodel.member___1gemch6" />  MarkupGenerator.WriteDocumentationExampleAsync(Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the Example documentation section for given <strong>member</strong> if available



```csharp
protected virtual async Task WriteDocumentationExampleAsync(Member member)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationexceptionsasync_net.adamec.dev.markupdoc.codemodel.member___xz5wnq" />  MarkupGenerator.WriteDocumentationExceptionsAsync(Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the Exceptions documentation section for given <strong>member</strong> if available



```csharp
protected virtual async Task WriteDocumentationExceptionsAsync(Member member)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationremarksasync_net.adamec.dev.markupdoc.codemodel.member___1kq5btp" />  MarkupGenerator.WriteDocumentationRemarksAsync(Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the Remarks documentation section for given <strong>member</strong> if available



```csharp
protected virtual async Task WriteDocumentationRemarksAsync(Member member)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writedocumentationseealsoasync_net.adamec.dev.markupdoc.codemodel.member___1r791ds" />  MarkupGenerator.WriteDocumentationSeeAlsoAsync(Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the See Also documentation section for given <strong>member</strong> if available



```csharp
protected virtual async Task WriteDocumentationSeeAlsoAsync(Member member)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writeeventasync_net.adamec.dev.markupdoc.codemodel.eventmember___nfiwo0" />  MarkupGenerator.WriteEventAsync(EventMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the event documentation page



```csharp
protected virtual async Task WriteEventAsync(EventMember evt)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.EventMember](#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) <strong>evt</strong></dt><dd>Event to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writefieldasync_net.adamec.dev.markupdoc.codemodel.fieldmember___1ly8teo" />  MarkupGenerator.WriteFieldAsync(FieldMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the field documentation page



```csharp
protected virtual async Task WriteFieldAsync(FieldMember field)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.FieldMember](#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) <strong>field</strong></dt><dd>Field to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writememberstableasync_system.string-system.collections.generic.icollection_net.adamec.dev.markupdoc.codemodel.member____1ogbyt3" />  MarkupGenerator.WriteMembersTableAsync(string, ICollection&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the table with given list of members



```csharp
protected virtual async Task WriteMembersTableAsync(string part, ICollection<net.adamec.dev.markupdoc.CodeModel.Member> members)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>part</strong></dt><dd>Name of the part (kind of members) to be shown before the table</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >ICollection&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;</a> <strong>members</strong></dt><dd>Members to be listed</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Table has three columns - Name, Modifier and Summary


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writemethodasync_net.adamec.dev.markupdoc.codemodel.methodmember___2mw79k" />  MarkupGenerator.WriteMethodAsync(MethodMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the method documentation page



```csharp
protected virtual async Task WriteMethodAsync(MethodMember method)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodMember](#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) <strong>method</strong></dt><dd>Method to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writemodelasync_system.string___zl49vu" />  MarkupGenerator.WriteModelAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Main code model rendering public end point. Writes the model into the documentation file(s)



```csharp
public virtual async Task WriteModelAsync(string title)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>title</strong></dt><dd>Documentation title shown at the top of each page</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Initializes [MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys) or [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb) based on the split configuration. Executes the model rendering sequence.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writemodelcontentasync__t54h4e" />  MarkupGenerator.WriteModelContentAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the code model into the output



```csharp
protected virtual async Task WriteModelContentAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes the namespaces and types lists and calls [WriteNamespacesAsync()](#m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespacesasync__11thw7o) to walk through the code model and generate the documentation for individual members


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespaceasync_net.adamec.dev.markupdoc.codemodel.namespacemember___15mn91c" />  MarkupGenerator.WriteNamespaceAsync(NamespaceMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the namespace documentation page



```csharp
protected virtual async Task WriteNamespaceAsync(NamespaceMember ns)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) <strong>ns</strong></dt><dd>Namespace to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
The namespace XML documentation comments are not available for the namespace itself. To document the namespace, create a class `NamespaceDoc` within the namespace and add the namespace documentation to this class. It&#39;s recommended to mark the class with <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.compilergeneratedattribute" target="_blank" >System.Runtime.CompilerServices.CompilerGeneratedAttribute</a> , so it will be excluded from the documentation as a type (meaning, the documentation will be applied to namespace and the class itself will not appear in the documentation). When a split per namespace or per type is required, the new split is initialized at the beginning of the execution




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespacesasync__11thw7o" />  MarkupGenerator.WriteNamespacesAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the namespaces and their members into the output



```csharp
protected virtual async Task WriteNamespacesAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Walks through the namespaces and for each, the namespace page and namespace members&#39; pages are rendered into the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writenamespaceslistasync__17n45k8" />  MarkupGenerator.WriteNamespacesListAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the table of all namespaces within the code model into the output



```csharp
protected virtual async Task WriteNamespacesListAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writepagefooter__qhunh8" />  MarkupGenerator.WritePageFooter() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the page footer



```csharp
protected virtual async Task WritePageFooter()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Go to namespace or types links to namespaces list and types list are rendered here


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writepropertyasync_net.adamec.dev.markupdoc.codemodel.propertymember___1l6fuxk" />  MarkupGenerator.WritePropertyAsync(PropertyMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the property documentation page



```csharp
protected virtual async Task WritePropertyAsync(PropertyMember property)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.PropertyMember](#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) <strong>property</strong></dt><dd>Property to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeasync_net.adamec.dev.markupdoc.codemodel.typemember___e4a8de" />  MarkupGenerator.WriteTypeAsync(TypeMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the type documentation page



```csharp
protected virtual async Task WriteTypeAsync(TypeMember type)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) <strong>type</strong></dt><dd>Type to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
When a split per type is required, the new split is initialized at the beginning of the execution


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypecontentmemberheaderasync_net.adamec.dev.markupdoc.codemodel.typecontentmember-system.string___126xy13" />  MarkupGenerator.WriteTypeContentMemberHeaderAsync(TypeContentMember, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the header for the type member (field, method, etc.)



```csharp
protected virtual async Task WriteTypeContentMemberHeaderAsync(TypeContentMember member, string title)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeContentMember](#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) <strong>member</strong></dt><dd>Member to document</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>title</strong></dt><dd>Type of the member to be shown in title together with member&#39;s name (for example Method, Field, etc.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes the header, namespace  name and link, assembly name, type name and link


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeheaderasync_net.adamec.dev.markupdoc.codemodel.typemember___cgai25" />  MarkupGenerator.WriteTypeHeaderAsync(TypeMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the header for the type member (field, method, etc.)



```csharp
protected virtual async Task WriteTypeHeaderAsync(TypeMember type)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) <strong>type</strong></dt><dd>Type to document</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Writes the header, namespace  name and link, assembly name


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypesasync_net.adamec.dev.markupdoc.codemodel.namespacemember___1xky7be" />  MarkupGenerator.WriteTypesAsync(NamespaceMember) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the types and their members contained within given namespace into the output



```csharp
protected virtual async Task WriteTypesAsync(NamespaceMember namespaceMember)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) <strong>namespaceMember</strong></dt><dd>Document the types and their members that are contained within this namespace</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


###  Remarks ###
Walks through the types in the namespace and for each, the type page and type members&#39; pages are rendered into the output


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupgenerator.writetypeslistasync__1dszey5" />  MarkupGenerator.WriteTypesListAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupGenerator](#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36)</small>


Writes the table of all types within the code model into the output



```csharp
protected virtual async Task WriteTypesListAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb" />  MarkupMultiFileWriter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Markup output multi file writer



```csharp
public class MarkupMultiFileWriter : MarkupFileWriter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.Utils.BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9) -&gt; [net.adamec.dev.markupdoc.Markup.MarkupFileWriter](#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>, [net.adamec.dev.markupdoc.Markup.IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75), [net.adamec.dev.markupdoc.Markup.INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [CurrentFile](#p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.currentfile__1yrfj36) | public | Full path of the file the output is currently being written to | 
 | [Extension](#p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.extension__ij1g4s) | public | Extension of the output files | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetTarget(string)](#m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.settarget_system.string___1t4u7ve) | public | Sets the target directory of the markdown writer (directory of index file provided in <strong>indexFileName</strong> ) | 
 | [Split(string)](#m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.split_system.string___12nvaw1) | public | Starts a new split of the output - closes the current file and opens a new one having the <strong>splitName</strong> and [Extension](#p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.extension__ij1g4s) | 
 | [WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;)](#m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.writemodelasync_system.func_system.threading.tasks.task____pvlhm2) | public | Writes the code model to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.currentfile__1yrfj36" />  MarkupMultiFileWriter.CurrentFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)</small>


Full path of the file the output is currently being written to



```csharp
public string CurrentFile { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.extension__ij1g4s" />  MarkupMultiFileWriter.Extension Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)</small>


Extension of the output files



```csharp
public string Extension { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.settarget_system.string___1t4u7ve" />  MarkupMultiFileWriter.SetTarget(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)</small>


Sets the target directory of the markdown writer (directory of index file provided in <strong>indexFileName</strong> )



```csharp
public override bool SetTarget(string indexFileName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>indexFileName</strong></dt><dd>Full path to the index file (including the extension) to write the output to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the target has been set, otherwise false (because the output is in progress)</dd></dl>


###  Remarks ###
The [Target](#p-net.adamec.dev.markupdoc.markup.markupfilewriter.target__1ulj4al) is the full path to the directory to write the output files to Clears the files having the same extension as the given <strong>indexFileName</strong> from the target directory The target can&#39;t be set when the output is being generated.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.split_system.string___12nvaw1" />  MarkupMultiFileWriter.Split(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)</small>


Starts a new split of the output - closes the current file and opens a new one having the <strong>splitName</strong> and [Extension](#p-net.adamec.dev.markupdoc.markup.markupmultifilewriter.extension__ij1g4s)



```csharp
public override void Split(string splitName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>splitName</strong></dt><dd>Name of the split</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.markupmultifilewriter.writemodelasync_system.func_system.threading.tasks.task____pvlhm2" />  MarkupMultiFileWriter.WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [MarkupMultiFileWriter](#t-net.adamec.dev.markupdoc.markup.markupmultifilewriter__1vc7asb)</small>


Writes the code model to the output



```csharp
public override async Task WriteModelAsync(Func<System.Threading.Tasks.Task> writeContentActionAsync)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;System.Threading.Tasks.Task&gt;</a> <strong>writeContentActionAsync</strong></dt><dd>Function rendering the model to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr" />  IMarkupProvider Interface ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Markup provider interface



```csharp
public interface IMarkupProvider
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MarkupWriter](#p-net.adamec.dev.markupdoc.markup.imarkupprovider.markupwriter__ko0cve) | public abstract | Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Bold(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.bold_system.string___17tar4q) | public abstract | Returns the markup for bold (strong) <strong>text</strong> | 
 | [Bookmark(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.bookmark_system.string___1wc4cmn) | public abstract | Returns the markup of the bookmark with given <strong>id</strong> | 
 | [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.code_system.string-system.boolean___185qr7p) | public abstract | Returns the markup for multi-line code with given <strong>text</strong> | 
 | [DescriptionList(IList&lt;string&gt;)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____1pqryk1) | public abstract | Returns the markup for the description list with the given <strong>renderedItems</strong> | 
 | [DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____kr2fi2) | public abstract | Returns the markup for the description list with the given <strong>items</strong> | 
 | [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlistitem_system.string-system.string___185r8jg) | public abstract | Returns the markup of the description list item | 
 | [DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IMarkupProvider.TItemType)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1d21q1x) | public abstract | Returns the markup of the description list item | 
 | [ExternalLink(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.externallink_system.string-system.string___76ohd6) | public abstract | Returns the markup for the external link | 
 | [InlineCode(string, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.inlinecode_system.string-system.boolean___70e1uy) | public abstract | Returns the markup for inline code with given <strong>text</strong> | 
 | [Italic(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.italic_system.string___txs4xh) | public abstract | Returns the markup for italic (emphasized) <strong>text</strong> | 
 | [LineBreak()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.linebreak__bcasm5) | public abstract | Returns the markup for the line break | 
 | [Link(string, Member)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___kz8auq) | public abstract | Returns the markup for the internal link | 
 | [Link(string, string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-system.string-system.string___fpfsg3) | public abstract | Returns the markup for the internal link | 
 | [List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___1gcvzmw) | public abstract | Returns the markup for the list of the items | 
 | [Para(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.para_system.string___1n5d79p) | public abstract | Returns the markup for paragraph with given <strong>text</strong> | 
 | [Small(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.small_system.string___16hyku) | public abstract | Returns the markup for small <strong>text</strong> | 
 | [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablecols_system.string_____9o05ka) | public abstract | Returns the markup for the table row with given columns | 
 | [TableFooter()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablefooter__8xrzfr) | public abstract | Returns the markup for the table footer | 
 | [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tableheader_system.string_____1id0rx8) | public abstract | Returns the markup for the table header with given columns | 
 | [Text(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.text_system.string___1c1xx56) | public abstract | Returns the markup for the &quot;plain&quot; text | 
 | [WriteCodeAsync(string, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writecodeasync_system.string-system.boolean___13eqprk) | public abstract | Writes the markup for multi-line code with given <strong>text</strong> | 
 | [WriteDocumentEndAsync()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writedocumentendasync__wnyzbn) | public abstract | Writes the markup for the end of the document (file) | 
 | [WriteDocumentStartAsync(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writedocumentstartasync_system.string___1c7fdif) | public abstract | Writes the markup for the beginning of the document (file) | 
 | [WriteH1Async(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh1async_system.string-system.string___12a3vxn) | public abstract | Writes the level 1 <strong>header</strong> with  optional bookmark | 
 | [WriteH2Async(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh2async_system.string-system.string___cb64y6) | public abstract | Writes the level 2 <strong>header</strong> with  optional bookmark | 
 | [WriteH3Async(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh3async_system.string-system.string___b45e7h) | public abstract | Writes the level 3 <strong>header</strong> with  optional bookmark | 
 | [WriteH4Async(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh4async_system.string-system.string___c9u6hc) | public abstract | Writes the level 4 <strong>header</strong> with  optional bookmark | 
 | [WriteHorizontalLineAsync()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writehorizontallineasync__ovb1ir) | public abstract | Writes the markup for horizontal line | 
 | [WriteParaAsync(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeparaasync_system.string___1jgyfl2) | public abstract | Writes the markup for paragraph with given <strong>text</strong> | 
 | [WriteTableColsAsync(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetablecolsasync_system.string_____isipmj) | public abstract | Writes the markup for the table row with given columns | 
 | [WriteTableFooterAsync()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetablefooterasync__1ht3gvm) | public abstract | Writes the markup for the table footer | 
 | [WriteTableHeaderAsync(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetableheaderasync_system.string_____1ifrlmz) | public abstract | Writes the markup for the table header with given columns | 
 | [WriteTextAsync(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetextasync_system.string___hugpid) | public abstract | Writes the <strong>text</strong> to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.markup.imarkupprovider.markupwriter__ko0cve" />  IMarkupProvider.MarkupWriter Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Gets or sets the [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75) used for the markup output



```csharp
public abstract IMarkupWriter MarkupWriter { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.bold_system.string___17tar4q" />  IMarkupProvider.Bold(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for bold (strong) <strong>text</strong>



```csharp
public abstract string Bold(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for bold (strong) <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.bookmark_system.string___1wc4cmn" />  IMarkupProvider.Bookmark(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup of the bookmark with given <strong>id</strong>



```csharp
public abstract string Bookmark(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Bookmark id</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the bookmark with given <strong>id</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.code_system.string-system.boolean___185qr7p" />  IMarkupProvider.Code(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for multi-line code with given <strong>text</strong>



```csharp
public abstract string Code(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for code with given <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlist_system.collections.generic.ilist_system.string____1pqryk1" />  IMarkupProvider.DescriptionList(IList&lt;string&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the description list with the given <strong>renderedItems</strong>



```csharp
public abstract string DescriptionList(IList<string> renderedItems)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1" target="_blank" >IList&lt;string&gt;</a> <strong>renderedItems</strong></dt><dd>Description list items markup</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>renderedItems</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlist--1_system.func_--0-system.string_-system.func_--0-system.string_-system.collections.generic.ienumerable_--0____kr2fi2" />  IMarkupProvider.DescriptionList&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the description list with the given <strong>items</strong>



```csharp
public abstract string DescriptionList<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, IEnumerable<TItemType> items)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Description list items</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the description list with the given <strong>items</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlistitem_system.string-system.string___185r8jg" />  IMarkupProvider.DescriptionListItem(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup of the description list item



```csharp
public abstract string DescriptionListItem(string itemTerm, string itemDescription)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemTerm</strong></dt><dd>Item term</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>itemDescription</strong></dt><dd>Item description</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlistitem--1_system.func_--0-system.string_-system.func_--0-system.string_---0___1d21q1x" />  IMarkupProvider.DescriptionListItem&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, Func&lt;TItemType,string&gt;, IMarkupProvider.TItemType) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup of the description list item



```csharp
public abstract string DescriptionListItem<TItemType>(Func<TItemType,string> itemTerm, Func<TItemType,string> itemDescription, IMarkupProvider.TItemType item)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the object to generate the description list item for</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemTerm</strong></dt><dd>Function to get the term for given item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemDescription</strong></dt><dd>Function to get the description for given item</dd><dt>net.adamec.dev.markupdoc.Markup.IMarkupProvider.TItemType <strong>item</strong></dt><dd>Object to generate the description list item for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup of the description list item</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.externallink_system.string-system.string___76ohd6" />  IMarkupProvider.ExternalLink(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the external link



```csharp
public abstract string ExternalLink(string text, string url)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>url</strong></dt><dd>Link URL</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the external link</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.inlinecode_system.string-system.boolean___70e1uy" />  IMarkupProvider.InlineCode(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for inline code with given <strong>text</strong>



```csharp
public abstract string InlineCode(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Inline code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for inline code with given <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.italic_system.string___txs4xh" />  IMarkupProvider.Italic(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for italic (emphasized) <strong>text</strong>



```csharp
public abstract string Italic(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for italic (emphasized) <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.linebreak__bcasm5" />  IMarkupProvider.LineBreak() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the line break



```csharp
public abstract string LineBreak()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the line break</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___kz8auq" />  IMarkupProvider.Link(string, Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the internal link



```csharp
public abstract string Link(string text, Member member)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>[Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to generate the link to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-system.string-system.string___fpfsg3" />  IMarkupProvider.Link(string, string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the internal link



```csharp
public abstract string Link(string text, string file, string bookmark)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>file</strong></dt><dd>Name of the file relative to the documentation root (index file)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the internal link</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___1gcvzmw" />  IMarkupProvider.List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the list of the items



```csharp
public abstract string List<TItemType>(Func<TItemType,string> itemOutput, IEnumerable<TItemType> items, bool numbered = false)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd>Type of the list item entry object</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>itemOutput</strong></dt><dd>Function returning the markup for single item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>List items</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>numbered</strong></dt><dd>Flag whether the list is to be numbered (ordered). If false bullet list (unordered) will be generated</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the list of the items</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.para_system.string___1n5d79p" />  IMarkupProvider.Para(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for paragraph with given <strong>text</strong>



```csharp
public abstract string Para(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for paragraph with given <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.small_system.string___16hyku" />  IMarkupProvider.Small(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for small <strong>text</strong>



```csharp
public abstract string Small(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for small <strong>text</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablecols_system.string_____9o05ka" />  IMarkupProvider.TableCols(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the table row with given columns



```csharp
public abstract string TableCols(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table row with given columns</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablefooter__8xrzfr" />  IMarkupProvider.TableFooter() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the table footer



```csharp
public abstract string TableFooter()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table footer</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.tableheader_system.string_____1id0rx8" />  IMarkupProvider.TableHeader(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the table header with given columns



```csharp
public abstract string TableHeader(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the table header with given columns</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.text_system.string___1c1xx56" />  IMarkupProvider.Text(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Returns the markup for the &quot;plain&quot; text



```csharp
public abstract string Text(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup for the &quot;plain&quot; text</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writecodeasync_system.string-system.boolean___13eqprk" />  IMarkupProvider.WriteCodeAsync(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for multi-line code with given <strong>text</strong>



```csharp
public abstract Task WriteCodeAsync(string text, bool encodeNeeded = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Code</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>encodeNeeded</strong></dt><dd>Flag whether it&#39;s the <strong>text</strong> needs the HTML encoding (the code from XML documentation comments should already be encoded, the code from generator needs encoding)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writedocumentendasync__wnyzbn" />  IMarkupProvider.WriteDocumentEndAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for the end of the document (file)



```csharp
public abstract Task WriteDocumentEndAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writedocumentstartasync_system.string___1c7fdif" />  IMarkupProvider.WriteDocumentStartAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for the beginning of the document (file)



```csharp
public abstract Task WriteDocumentStartAsync(string title = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>title</strong></dt><dd>Document title</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh1async_system.string-system.string___12a3vxn" />  IMarkupProvider.WriteH1Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the level 1 <strong>header</strong> with  optional bookmark



```csharp
public abstract Task WriteH1Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh2async_system.string-system.string___cb64y6" />  IMarkupProvider.WriteH2Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the level 2 <strong>header</strong> with  optional bookmark



```csharp
public abstract Task WriteH2Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh3async_system.string-system.string___b45e7h" />  IMarkupProvider.WriteH3Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the level 3 <strong>header</strong> with  optional bookmark



```csharp
public abstract Task WriteH3Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeh4async_system.string-system.string___c9u6hc" />  IMarkupProvider.WriteH4Async(string, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the level 4 <strong>header</strong> with  optional bookmark



```csharp
public abstract Task WriteH4Async(string header, string bookmark = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>header</strong></dt><dd>Header content</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>bookmark</strong></dt><dd>Optional bookmark ID</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writehorizontallineasync__ovb1ir" />  IMarkupProvider.WriteHorizontalLineAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for horizontal line



```csharp
public abstract Task WriteHorizontalLineAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writeparaasync_system.string___1jgyfl2" />  IMarkupProvider.WriteParaAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for paragraph with given <strong>text</strong>



```csharp
public abstract Task WriteParaAsync(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Content of the paragraph</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetablecolsasync_system.string_____isipmj" />  IMarkupProvider.WriteTableColsAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for the table row with given columns



```csharp
public abstract Task WriteTableColsAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetablefooterasync__1ht3gvm" />  IMarkupProvider.WriteTableFooterAsync() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for the table footer



```csharp
public abstract Task WriteTableFooterAsync()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetableheaderasync_system.string_____1ifrlmz" />  IMarkupProvider.WriteTableHeaderAsync(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the markup for the table header with given columns



```csharp
public abstract Task WriteTableHeaderAsync(params string[] items)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>items</strong></dt><dd>Content of individual header columns</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupprovider.writetextasync_system.string___hugpid" />  IMarkupProvider.WriteTextAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr)</small>


Writes the <strong>text</strong> to the output



```csharp
public abstract Task WriteTextAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75" />  IMarkupWriter Interface ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Interface of the markup output writer



```csharp
public interface IMarkupWriter : INonWritableWriter
```

Implements: [net.adamec.dev.markupdoc.Markup.INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [WriteAsync(string)](#m-net.adamec.dev.markupdoc.markup.imarkupwriter.writeasync_system.string___aeq6ei) | public abstract | Writes the <strong>text</strong> to the output | 
 | [WriteLineAsync(string)](#m-net.adamec.dev.markupdoc.markup.imarkupwriter.writelineasync_system.string___9m03pw) | public abstract | Writes the <strong>text</strong> and a new line to the output | 
 | [WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;)](#m-net.adamec.dev.markupdoc.markup.imarkupwriter.writemodelasync_system.func_system.threading.tasks.task____10tqrtq) | public abstract | Writes the code model to the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupwriter.writeasync_system.string___aeq6ei" />  IMarkupWriter.WriteAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</small>


Writes the <strong>text</strong> to the output



```csharp
public abstract Task WriteAsync(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupwriter.writelineasync_system.string___9m03pw" />  IMarkupWriter.WriteLineAsync(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</small>


Writes the <strong>text</strong> and a new line to the output



```csharp
public abstract Task WriteLineAsync(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to write</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.imarkupwriter.writemodelasync_system.func_system.threading.tasks.task____10tqrtq" />  IMarkupWriter.WriteModelAsync(Func&lt;System.Threading.Tasks.Task&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [IMarkupWriter](#t-net.adamec.dev.markupdoc.markup.imarkupwriter__14znp75)</small>


Writes the code model to the output



```csharp
public abstract Task WriteModelAsync(Func<System.Threading.Tasks.Task> writeContentActionAsync)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;System.Threading.Tasks.Task&gt;</a> <strong>writeContentActionAsync</strong></dt><dd>Function rendering the model to the output</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg" />  INonWritableWriter Interface ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc</small>


Non writable interface of the output writer



```csharp
public interface INonWritableWriter
```

###  Remarks ###
This interface is used when the direct writing to the output is not allowed


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetTarget(string)](#m-net.adamec.dev.markupdoc.markup.inonwritablewriter.settarget_system.string___gdnbq7) | public abstract | Sets the initial target of the markdown writer | 
 | [Split(string)](#m-net.adamec.dev.markupdoc.markup.inonwritablewriter.split_system.string___hrmauu) | public abstract | Starts a new split of the output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.inonwritablewriter.settarget_system.string___gdnbq7" />  INonWritableWriter.SetTarget(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)</small>


Sets the initial target of the markdown writer



```csharp
public abstract bool SetTarget(string fileName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Full path to the file (including the extension) to write the output to</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the target has been set, otherwise false (because the output is in progress)</dd></dl>


###  Remarks ###
The target can&#39;t be set when the output is being generated


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.markup.inonwritablewriter.split_system.string___hrmauu" />  INonWritableWriter.Split(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Markup](#n-net.adamec.dev.markupdoc.markup__1918uiv)           
Assembly: MarkupDoc           
Type: [INonWritableWriter](#t-net.adamec.dev.markupdoc.markup.inonwritablewriter__1ortihg)</small>


Starts a new split of the output



```csharp
public abstract void Split(string splitName)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>splitName</strong></dt><dd>Name of the split</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.msapidoc__4u9w4l" />  net.adamec.dev.markupdoc.MsApiDoc Namespace ##
MS online API links helper classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | public | Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members. | 
 | [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn) | public | Configuration class for [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx" />  MsApiDocEngine Class ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc</small>


Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members.



```csharp
public class MsApiDocEngine
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
The Roslyn compiler uses the member ID in <em>Microsoft.CodeAnalysis.ISymbol.GetDocumentationCommentId</em> , (even if there is no documentation), so it&#39;s possible to use such ID as member identifier for types, properties, methods, etc. Method [ReadLocalDoc()](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5) uses  the local clone of .NET API documentation (https://github.com/dotnet/dotnet-api-docs) and checks for the framework index file containing the list of available IDs. It generates the links for each ID and store it in the internal dictionary(ID,link) telling &quot;these IDs are documented at MS site and these are the links&quot; . The links can be retrieved using the static methods [GetLink(string)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj) by ID or [GetLink(TypeRef)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7) by [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) . It checks, whether the ID exists in local MS documentation clone and if positive, it uses the generated link stored in internal dictionary. When the local clone is not available (or it&#39;s use is suppressed), the engine will try to build the links based on the namespace and name of member for limited set of members.

 Note: The links are created based on the &quot;observation&quot; how they are composed at the MS API site, so it&#39;s best effort approach and the links are not granted to be hundred percent correct. Also the API Browser don&#39;t have the pages/anchors for constants (including the enum items), so the generated links will not work in this case.

 The behavior of engine can be configured using the [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn) configuration class

 To get the best results, clone the .NET API documentation from https://github.com/dotnet/dotnet-api-docs to local directory. And configure the engine

 


 - <strong>LinkToApi</strong> - Set to `true` , to allow the links to MS Api (if false, no links will be created at all)
 - <strong>ApiBaseUrl</strong> - It&#39;s set to https://docs.microsoft.com/en-us/dotnet/api/. As far as there is no change at MS side, no need to configure. Note: The URL must end with &quot;/&quot;.
 - <strong>RequireLocalDoc</strong> - Set to `true` to minimize the false links. Note: set to `false` allowing the engine to try to create the links even if not found in local documentation
 - <strong>LocalDocDir</strong> - Path to the local clone of MS documentation (directory must contain `xml\FrameworksIndex` subdirectory
           





###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseUrl](#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.baseurl__mfwodh) | public static |  | 
 | [IdToLinkDictionary](#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionary__ij5vc1) | public static | ID to Link read-only dictionary for items read from local clone of MS .NET API documentation | 
 | [IdToLinkDictionaryPrivate](#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionaryprivate__1qh58ay) | private static | Internal ID to Link dictionary for items read from local clone of MS .NET API documentation | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetLink(string)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj) | public static | Retrieves the link to MS API online documentation based on the member <strong>id</strong> (documentation ID) | 
 | [GetLink(TypeRef)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7) | public static | Retrieves the link to MS API online documentation based on the <strong>typeRef</strong> . | 
 | [ReadLocalDoc()](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5) | public static | Reads the local clone of MS .NET API documentation and builds the internal dictionary of member IDs and links to MS online API documentation | 
 | [TypeMemberBaseName(string)](#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.typememberbasename_system.string___1akr6b7) | private static | Extracts the base name for the type member. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.baseurl__mfwodh" />  MsApiDocEngine.BaseUrl Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>



```csharp
public static string BaseUrl { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionary__ij5vc1" />  MsApiDocEngine.IdToLinkDictionary Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


ID to Link read-only dictionary for items read from local clone of MS .NET API documentation



```csharp
public static IReadOnlyDictionary<string,string> IdToLinkDictionary { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionaryprivate__1qh58ay" />  MsApiDocEngine.IdToLinkDictionaryPrivate Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


Internal ID to Link dictionary for items read from local clone of MS .NET API documentation



```csharp
private static Dictionary<string,string> IdToLinkDictionaryPrivate { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj" />  MsApiDocEngine.GetLink(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


Retrieves the link to MS API online documentation based on the member <strong>id</strong> (documentation ID)



```csharp
public static string GetLink(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Member (type, method, property, etc.) ID as used in documentation comments</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7" />  MsApiDocEngine.GetLink(TypeRef) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


Retrieves the link to MS API online documentation based on the <strong>typeRef</strong> .



```csharp
public static string GetLink(TypeRef typeRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) <strong>typeRef</strong></dt><dd>Type reference to get the link for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</dd></dl>


###  Remarks ###
As the query is based on the [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) , it&#39;s applicable to types only (the meaning of &quot;type&quot; includes interfaces, structures, delegates, etc.). In this case, the links can be also created based on the namespace and name when the local doc is not available or the item has not been found  in the internal dictionary. This can be suppressed by setting the configuration option `RequireLocalDoc` to true.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5" />  MsApiDocEngine.ReadLocalDoc() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


Reads the local clone of MS .NET API documentation and builds the internal dictionary of member IDs and links to MS online API documentation



```csharp
public static bool ReadLocalDoc()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the local documentation has been read, otherwise false (the errors are &quot;soft&quot; - provided to console standard output as warnings)</dd></dl>


###  Remarks ###
Path to the local clone od MS documentation is taken from configuration [LocalDocDir](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f) . Directory must contain `xml\FrameworksIndex` subdirectory. This directory contains the indexes for different frameworks (.NET frameworks, .NET standard, ...). For the simplicity, the biggest index (XML) file is used as a source. The index file contains records like 
```csharp
     <Namespace Name="Microsoft.CSharp">
         <Type Name = "Microsoft.CSharp.CSharpCodeProvider" Id="T:Microsoft.CSharp.CSharpCodeProvider">
            <Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.#ctor" />
            <Member Id="M:Microsoft.CSharp.CSharpCodeProvider.#ctor(System.Collections.Generic.IDictionary{System.String,System.String})" />
            <Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.CreateCompiler" />
            <Member Id="M:Microsoft.CSharp.CSharpCodeProvider.CreateGenerator" />
            <Member Id = "M:Microsoft.CSharp.CSharpCodeProvider.GenerateCodeFromMember(System.CodeDom.CodeTypeMember,System.IO.TextWriter,System.CodeDom.Compiler.CodeGeneratorOptions)" />
            <Member Id="M:Microsoft.CSharp.CSharpCodeProvider.GetConverter(System.Type)" />
            <Member Id = "P:Microsoft.CSharp.CSharpCodeProvider.FileExtension" />
         </Type >
     </Namespace >
```
 The method gets all type and (type) member ID and generates the links for them. The links are created based on the &quot;observation&quot; how they are composed at the MS API site, so it&#39;s best effort approach and the links are not granted to be hundred percent correct. The base URL is set in [ApiBaseUrl](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) (the base URL must end with &quot;/&quot;).


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.typememberbasename_system.string___1akr6b7" />  MsApiDocEngine.TypeMemberBaseName(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)</small>


Extracts the base name for the type member.



```csharp
private static string TypeMemberBaseName(string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>Name of the type member</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Base name for the type member</dd></dl>


###  Remarks ###
Single member page can contain multiple overloads, so it&#39;s necessary to extract the base name that will be used as a part of the link. The particular overload is then identified by anchor.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn" />  MsApiDocOptions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc</small>


Configuration class for [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)



```csharp
public class MsApiDocOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ApiBaseUrl](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) | public | Base URL of MS .NET API Browser (must end with &quot;/&quot;) If [LinkToApi](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) is set, missing [ApiBaseUrl](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) throws the exception while building the link | 
 | [LinkToApi](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) | public | Flag whether to generate the links to MS .NET API Browser | 
 | [LocalDocDir](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f) | public | Local clone of .NET API Documentation root directory | 
 | [RequireLocalDoc](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.requirelocaldoc__10og155) | public | Flag whether to build the links based on the local close of .NET API Documentation only. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb" />  MsApiDocOptions.ApiBaseUrl Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)</small>


Base URL of MS .NET API Browser (must end with &quot;/&quot;) If [LinkToApi](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) is set, missing [ApiBaseUrl](#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) throws the exception while building the link



```csharp
public string ApiBaseUrl { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4" />  MsApiDocOptions.LinkToApi Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)</small>


Flag whether to generate the links to MS .NET API Browser



```csharp
public bool LinkToApi { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f" />  MsApiDocOptions.LocalDocDir Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)</small>


Local clone of .NET API Documentation root directory



```csharp
public string LocalDocDir { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.requirelocaldoc__10og155" />  MsApiDocOptions.RequireLocalDoc Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)</small>


Flag whether to build the links based on the local close of .NET API Documentation only.



```csharp
public bool RequireLocalDoc { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
If not set (is false), [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) will try to build the links for [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) , the links based on documentation ID will not be created

 Note: This will not suppress reading/using the links based on the local clone of the documentation, just the &quot;fallback&quot; will be disabled




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.options__g1tahn" />  net.adamec.dev.markupdoc.Options Namespace ##
Configuration container and output options classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) | public | Singleton holding the application configuration (options) | 
 | [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) | public | Configuration builder providing the methods for adding the configuration items from individual sources | 
 | [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) | public | Output configuration | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.options.configuration__110r0mb" />  Configuration Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc</small>


Singleton holding the application configuration (options)



```csharp
public sealed class Configuration
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
This is the simple configuration container in case DI with more sophisticated containers is not used The configuration is stored as the key-value dictionary, supporting hierarchy using the dot separator and arrays.The arrays can contain values or another objects. Actually, mixed arrays of values and objects can be stored, but they are not supported for binding. For example `section1.option1` means the option1 available in section1, `section1.subSection2.option1` means the option1 available in section1.subSection2. `section1.option1[0]` means, that the option1 is array of values or objects (sections) within the section1. For arrays, the keys are like `OtherSection.SimpleArray[0]` or `OtherSection.ComplexObjectArray[0].Name`

 [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) class provides a singleton instance, however the key functionality is provided via static functions, so no need to touch the [Instance](#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) at all. The items can be retrieved by key using the [Get(string)](#m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h) and [Get&lt;TValueType&gt;(string, Configuration.TValueType)](#m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho) methods. The first one returns null when the key is not found, the other one allow to define the default value to be returned, when the item is not found.

 The inner class [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) provides the methods to build the configuration from JSON config files, commandline arguments, environment values and/or direct entries. The static method [Builder()](#m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x) clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) allowing to build a configuration from scratch. The configuration is updated directly during the calls to builder methods, the existing items (keys) are updated, so it&#39;s possible to manage the priority of individual sources and the overrides if needed. The method [Build()](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt) returns the configuration instance, breaking the fluent design of builder methods, however there is no other functionality within the method, so it&#39;s more the convention than need to use it at the end of configuration build.

 Configuration binding it the way, how to access the configuration using the configuration objects instead of querying the individual items by key. When the method [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) is used, it creates a new instance of given type and tries to map the public properties with public setter to the keys (using the &quot;dot notation&quot;) within the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . It&#39;s possible to bind the object to  to the root  of the configuration to provide the whole configuration at once or bind it to the particular section to provide a configuration sub-tree. In general, the nested objects and both value and object arrays are supported. There are some rules when binding the arrays: The index must start with zero and must be in sequence (the first non-existing index stops the evaluation). The array should not mix the array or values and array of objects. The decision is made at the first item (index=0) whether it&#39;s value or object.

 The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true. This is useful when the command line arguments are used like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.

 As the binding uses the reflection, it&#39;s quite expensive operation, so by default, the bound objects are cached (the cache key is the type of bound object, so binding the same type to different sections is not recommended ). It&#39;s possible to force the binding using the parameter of [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) method. In general, the recommended pattern is to [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) the configuration  object after the configuration is built and then [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) it from the cache when needed.




###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [bindingsCache](#f-net.adamec.dev.markupdoc.options.configuration.bindingscache__oj0pqx) | private | Cache for bindings. Dictionary of type bound as a key and the bound object as value. | 
 | [instance](#f-net.adamec.dev.markupdoc.options.configuration.instance__5kocls) | private static | Instance of the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) created when the singleton is first touched | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Instance](#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) | public static | Public [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) instance | 
 | [Items](#p-net.adamec.dev.markupdoc.options.configuration.items__10m50f7) | private | Configuration items stored as key-value pairs | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration()](#m-net.adamec.dev.markupdoc.options.configuration.-cctor__1angiqa) | private static | Static constructor | 
 | [Configuration()](#m-net.adamec.dev.markupdoc.options.configuration.-ctor__12l16zd) | private | Private constructor used to build the singleton instance | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddOrUpdateItem(string, object)](#m-net.adamec.dev.markupdoc.options.configuration.addorupdateitem_system.string-system.object___gf6021) | private | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [Bind(Type, string)](#m-net.adamec.dev.markupdoc.options.configuration.bind_system.type-system.string___y5tird) | private static | Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible. | 
 | [Bind&lt;TOptionsContainer&gt;(string, bool)](#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) | public static | Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) | 
 | [Builder()](#m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x) | public static | Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) | 
 | [Get(string)](#m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h) | public static | Gets the configuration item by <strong>key</strong> | 
 | [Get&lt;TValueType&gt;(string, Configuration.TValueType)](#m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho) | public static | Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned. | 
 | [GetSection(string)](#m-net.adamec.dev.markupdoc.options.configuration.getsection_system.string___h5pqqc) | private static | Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned. | 
 | [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) | public static | Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache | 
 | [TryConvertValue(Type, object, object)](#m-net.adamec.dev.markupdoc.options.configuration.tryconvertvalue_system.type-system.object-system.object-___1em2of1) | private static | Tries to convert <strong>sourceValue</strong> to <strong>targetType</strong> . The converted values is returned in <strong>targetValue</strong> out parameter, the result of conversion is the function return value. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.options.configuration.bindingscache__oj0pqx" />  Configuration.bindingsCache Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Cache for bindings. Dictionary of type bound as a key and the bound object as value.



```csharp
private readonly ConcurrentDictionary<System.Type,object> bindingsCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;System.Type,object&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Cache is used to prevent the &quot;expensive&quot; binding operation in case there is no need to refresh the bound configuration object


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.options.configuration.instance__5kocls" />  Configuration.instance Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Instance of the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) created when the singleton is first touched



```csharp
private static readonly Configuration instance
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd></dd></dl>


###  Remarks ###
Not using the auto-property to have better control, when the instance is created


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa" />  Configuration.Instance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Public [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) instance



```csharp
public static Configuration Instance { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.configuration.items__10m50f7" />  Configuration.Items Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Configuration items stored as key-value pairs



```csharp
private ConcurrentDictionary<string,object> Items { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;string,object&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.-cctor__1angiqa" />  Configuration.Configuration() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Static constructor



```csharp
private static Configuration()
```

###  Remarks ###
Explicit static constructor to tell C# compiler not to mark type as beforefieldinit


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.-ctor__12l16zd" />  Configuration.Configuration() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Private constructor used to build the singleton instance



```csharp
private Configuration()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.addorupdateitem_system.string-system.object___gf6021" />  Configuration.AddOrUpdateItem(string, object) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
private void AddOrUpdateItem(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.bind_system.type-system.string___y5tird" />  Configuration.Bind(Type, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible.



```csharp
private static object Bind(Type type, string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to bind the configuration to</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The instance of <strong>type</strong> bound to the configuration</dd></dl>


###  Remarks ###
This method doesn&#39;t use the binding cache


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6" />  Configuration.Bind&lt;TOptionsContainer&gt;(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n)



```csharp
public static Configuration.TOptionsContainer Bind<TOptionsContainer>(string sectionName = null, bool allowCached = true) where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type to bind the configuration to</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>allowCached</strong></dt><dd>True if the cache of bindings can be used to retrieve existing binding with the same <strong>TOptionsContainer</strong> and <strong>sectionName</strong></dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x" />  Configuration.Builder() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)



```csharp
public static Configuration.ConfigurationBuilder Builder()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The instance of [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h" />  Configuration.Get(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Gets the configuration item by <strong>key</strong>



```csharp
public static object Get(string key)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Retrieved configuration item value or null if not found (or the configuration item is null itself)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho" />  Configuration.Get&lt;TValueType&gt;(string, Configuration.TValueType) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned.



```csharp
public static Configuration.TValueType Get<TValueType>(string key, Configuration.TValueType defaultValue = null)
```

<strong>Type parameters</strong><dl><dt><strong>TValueType</strong></dt><dd>The type the value is to be retrieved in</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd><dt>net.adamec.dev.markupdoc.Options.Configuration.TValueType <strong>defaultValue</strong></dt><dd>Optional default value to be returned when the value can&#39;t be retrieved of converted</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TValueType</dt><dd>Retrieved configuration item value or <strong>defaultValue</strong> when it can&#39;t be retrieved or converted</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.getsection_system.string___h5pqqc" />  Configuration.GetSection(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned.



```csharp
private static Dictionary<string,object> GetSection(string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional name of the section.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a></dt><dd>The configuration items that belong to the section with <strong>sectionName</strong> . The keys in returned dictionary are relative to given section!</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n" />  Configuration.Retrieve&lt;TOptionsContainer&gt;() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache



```csharp
public static Configuration.TOptionsContainer Retrieve<TOptionsContainer>() where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type of the configuration class to retrieve from cache</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration or a new instance if not found</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.tryconvertvalue_system.type-system.object-system.object-___1em2of1" />  Configuration.TryConvertValue(Type, object, object) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</small>


Tries to convert <strong>sourceValue</strong> to <strong>targetType</strong> . The converted values is returned in <strong>targetValue</strong> out parameter, the result of conversion is the function return value.



```csharp
private static bool TryConvertValue(Type targetType, object sourceValue, out object targetValue)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>targetType</strong></dt><dd>Target (property) type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sourceValue</strong></dt><dd>Source value as stored in configuration item</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>targetValue</strong></dt><dd><strong>sourceValue</strong> converted to <strong>targetType</strong> when the conversion succeeded (return value is true) or source value otherwise</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>The result or conversion. If true, the <strong>targetValue</strong> can be set to property having <strong>targetType</strong></dd></dl>


###  Remarks ###
The implementation treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc" />  Configuration.ConfigurationBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc</small>


Configuration builder providing the methods for adding the configuration items from individual sources



```csharp
public class Configuration.ConfigurationBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(string, object)](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.add_system.string-system.object___c4hvdf) | public | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [AddCommandLineArguments(string[])](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addcommandlinearguments_system.string_____1xz90ae) | public | Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated. | 
 | [AddEnvironmentVariables()](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addenvironmentvariables__1lp30f0) | public | Adds all environment variables into the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated. | 
 | [AddJsonFile(string, bool, bool)](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___1s8rjnj) | public | Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated. | 
 | [Build()](#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt) | public | Finishes the configuration building and returns the [Instance](#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.add_system.string-system.object___c4hvdf" />  Configuration.ConfigurationBuilder.Add(string, object) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
public Configuration.ConfigurationBuilder Add(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addcommandlinearguments_system.string_____1xz90ae" />  Configuration.ConfigurationBuilder.AddCommandLineArguments(string[]) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</small>


Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddCommandLineArguments(params string[] prefixes)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>prefixes</strong></dt><dd>Optional list of prefixes marking the command line arguments to be the configuration items</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


###  Remarks ###
The command line arguments have the syntax `key=value` (for example `Key1=Option1` or `prefixkey=value` (for example `-p:Key1=Option1` where `-p:` is the prefix). When the prefixes are not provided, all command line arguments are added to the configuration. When the prefixes are provided,the prefix is not a part of the key. The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true, allowing to use the parameters like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addenvironmentvariables__1lp30f0" />  Configuration.ConfigurationBuilder.AddEnvironmentVariables() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</small>


Adds all environment variables into the [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddEnvironmentVariables()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


###  Remarks ###
The name of the environment variable is used as a key to the configuration item. Use the &quot;dot notation&quot; in variable names to support the configuration hierarchy.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___1s8rjnj" />  Configuration.ConfigurationBuilder.AddJsonFile(string, bool, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</small>


Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddJsonFile(string fileName, bool ignoreNullOrEmptyFileName = false, bool ignoreIfNotExist = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Name of the JSON file with configuration</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreNullOrEmptyFileName</strong></dt><dd>If true, the missing file name will not throw the exception and the method just &quot;silently&quot; ends.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreIfNotExist</strong></dt><dd>If true, the non existing file will not throw the exception and the method just &quot;silently&quot; ends.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt" />  Configuration.ConfigurationBuilder.Build() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</small>


Finishes the configuration building and returns the [Instance](#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa)



```csharp
public Configuration Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd>The [Configuration](#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) singleton</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6" />  OutputOptions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc</small>


Output configuration



```csharp
public class OutputOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Html](#p-net.adamec.dev.markupdoc.options.outputoptions.html__cl135b) | public | Flag whether to generate the HTML output | 
 | [HtmlExtension](#p-net.adamec.dev.markupdoc.options.outputoptions.htmlextension__17720ly) | public | Extension of generated HTML file | 
 | [Markdown](#p-net.adamec.dev.markupdoc.options.outputoptions.markdown__1glxj0d) | public | Flag whether to generate the Markdown output | 
 | [MarkdownExtension](#p-net.adamec.dev.markupdoc.options.outputoptions.markdownextension__1nkg7o6) | public | Extension of generated Markdown file | 
 | [SplitNs](#p-net.adamec.dev.markupdoc.options.outputoptions.splitns__11lojtx) | public | Flag whether to split the output per namespace | 
 | [SplitType](#p-net.adamec.dev.markupdoc.options.outputoptions.splittype__1nl0vhs) | public | Flag whether to split the output per type. In this case, the split per namespace will also be applied. | 
 | [Target](#p-net.adamec.dev.markupdoc.options.outputoptions.target__1v9mv9v) | public | Output target - full path including file name without extension for single file output, index file without extension for multi-file output | 
 | [Title](#p-net.adamec.dev.markupdoc.options.outputoptions.title__aav6cy) | public | Title of documentation show at the top of each page | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.html__cl135b" />  OutputOptions.Html Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Flag whether to generate the HTML output



```csharp
public bool Html { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.htmlextension__17720ly" />  OutputOptions.HtmlExtension Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Extension of generated HTML file



```csharp
public string HtmlExtension { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.markdown__1glxj0d" />  OutputOptions.Markdown Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Flag whether to generate the Markdown output



```csharp
public bool Markdown { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.markdownextension__1nkg7o6" />  OutputOptions.MarkdownExtension Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Extension of generated Markdown file



```csharp
public string MarkdownExtension { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.splitns__11lojtx" />  OutputOptions.SplitNs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Flag whether to split the output per namespace



```csharp
public bool SplitNs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.splittype__1nl0vhs" />  OutputOptions.SplitType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Flag whether to split the output per type. In this case, the split per namespace will also be applied.



```csharp
public bool SplitType { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.target__1v9mv9v" />  OutputOptions.Target Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Output target - full path including file name without extension for single file output, index file without extension for multi-file output



```csharp
public string Target { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.title__aav6cy" />  OutputOptions.Title Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</small>


Title of documentation show at the top of each page



```csharp
public string Title { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.utils__m327rs" />  net.adamec.dev.markupdoc.Utils Namespace ##
Utility classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9) | public abstract | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2) | public static | Console output helpers | 
 | [IsNewUtils](#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x) | public static | Helpers to get the access to internal ISymbol.IsNew property | 
 | [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) | public | Text builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9" />  BaseDisposable Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc</small>


Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types



```csharp
public abstract class BaseDisposable : IDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposed](#p-net.adamec.dev.markupdoc.utils.basedisposable.disposed__18556iw) | public | Flag whether the object is fully disposed | 
 | [DisposedManaged](#p-net.adamec.dev.markupdoc.utils.basedisposable.disposedmanaged__2sgag1) | public | Flag whether the managed resources are disposed | 
 | [DisposedNative](#p-net.adamec.dev.markupdoc.utils.basedisposable.disposednative__5yjrj1) | public | Flag whether the native resources are disposed | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~BaseDisposable()](#m-net.adamec.dev.markupdoc.utils.basedisposable.finalize__18kxll4) | protected |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Dispose()](#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5) | public | Dispose the object | 
 | [Dispose(bool)](#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose_system.boolean___1n6qg2z) | protected | Internal implementation of dispose - free the managed and native resources using the respective methods | 
 | [DisposeManaged()](#m-net.adamec.dev.markupdoc.utils.basedisposable.disposemanaged__1oz4q8k) | protected | Dispose any disposable managed fields or properties. | 
 | [DisposeNative()](#m-net.adamec.dev.markupdoc.utils.basedisposable.disposenative__dinlio) | protected | Dispose of COM objects, Handles, etc. Then set those objects to null. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposed__18556iw" />  BaseDisposable.Disposed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Flag whether the object is fully disposed



```csharp
public bool Disposed { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposedmanaged__2sgag1" />  BaseDisposable.DisposedManaged Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Flag whether the managed resources are disposed



```csharp
public bool DisposedManaged { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposednative__5yjrj1" />  BaseDisposable.DisposedNative Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Flag whether the native resources are disposed



```csharp
public bool DisposedNative { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.finalize__18kxll4" />  BaseDisposable.~BaseDisposable() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>



```csharp
 ~BaseDisposable()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5" />  BaseDisposable.Dispose() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Dispose the object



```csharp
public void Dispose()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.dispose_system.boolean___1n6qg2z" />  BaseDisposable.Dispose(bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Internal implementation of dispose - free the managed and native resources using the respective methods



```csharp
protected virtual void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>Flag whether the object is disposing (called from [Dispose()](#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5) method). False if called from destructor</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.disposemanaged__1oz4q8k" />  BaseDisposable.DisposeManaged() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Dispose any disposable managed fields or properties.



```csharp
protected virtual void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.disposenative__dinlio" />  BaseDisposable.DisposeNative() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)</small>


Dispose of COM objects, Handles, etc. Then set those objects to null.



```csharp
protected virtual void DisposeNative()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2" />  ConsoleUtils Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc</small>


Console output helpers



```csharp
public static class ConsoleUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ColorErr](#f-net.adamec.dev.markupdoc.utils.consoleutils.colorerr__a9iigc) | public static | Error text color (red) | 
 | [ColorWarn](#f-net.adamec.dev.markupdoc.utils.consoleutils.colorwarn__1afyv2z) | public static | Warning text color (yellow) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [WriteErr(string)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writeerr_system.string___1azpq0y) | public static | Writes error <strong>line</strong> to console error output | 
 | [WriteErrWarn(string)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writeerrwarn_system.string___2xtvma) | public static | Writes warning <strong>line</strong> to console error output | 
 | [WriteInfo(string)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writeinfo_system.string___3r76tf) | public static | Writes info <strong>line</strong> to console standard output | 
 | [WriteLine(string, ConsoleColor)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.string-system.consolecolor___11tj0l2) | public static | Writes colored <strong>line</strong> to console standard output | 
 | [WriteLine(TextWriter, string, ConsoleColor)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___31kixv) | private static | Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong> | 
 | [WriteWarn(string)](#m-net.adamec.dev.markupdoc.utils.consoleutils.writewarn_system.string___xnztmn) | public static | Writes warning <strong>line</strong> to console standard output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.consoleutils.colorerr__a9iigc" />  ConsoleUtils.ColorErr Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Error text color (red)



```csharp
public static ConsoleColor ColorErr
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.consoleutils.colorwarn__1afyv2z" />  ConsoleUtils.ColorWarn Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Warning text color (yellow)



```csharp
public static ConsoleColor ColorWarn
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeerr_system.string___1azpq0y" />  ConsoleUtils.WriteErr(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes error <strong>line</strong> to console error output



```csharp
public static void WriteErr(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeerrwarn_system.string___2xtvma" />  ConsoleUtils.WriteErrWarn(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes warning <strong>line</strong> to console error output



```csharp
public static void WriteErrWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeinfo_system.string___3r76tf" />  ConsoleUtils.WriteInfo(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes info <strong>line</strong> to console standard output



```csharp
public static void WriteInfo(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.string-system.consolecolor___11tj0l2" />  ConsoleUtils.WriteLine(string, ConsoleColor) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes colored <strong>line</strong> to console standard output



```csharp
public static void WriteLine(string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___31kixv" />  ConsoleUtils.WriteLine(TextWriter, string, ConsoleColor) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong>



```csharp
private static void WriteLine(TextWriter writer, string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter" target="_blank" >System.IO.TextWriter</a> <strong>writer</strong></dt><dd>Console&#39;s writer (standard or error output)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writewarn_system.string___xnztmn" />  ConsoleUtils.WriteWarn(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)</small>


Writes warning <strong>line</strong> to console standard output



```csharp
public static void WriteWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x" />  IsNewUtils Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc</small>


Helpers to get the access to internal ISymbol.IsNew property



```csharp
public static class IsNewUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsNewPropertyCache](#f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva) | private static | Cache of the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> s for IsNew properties for individual <em>Microsoft.CodeAnalysis.ISymbol</em> s (types) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetIsNew(ISymbol)](#m-net.adamec.dev.markupdoc.utils.isnewutils.getisnew_microsoft.codeanalysis.isymbol___1eu6ykb) | public static | Gets the value of internal IsNew property of given <strong>symbol</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva" />  IsNewUtils.IsNewPropertyCache Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [IsNewUtils](#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x)</small>


Cache of the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> s for IsNew properties for individual <em>Microsoft.CodeAnalysis.ISymbol</em> s (types)



```csharp
private static readonly Dictionary<System.Type,System.Reflection.PropertyInfo> IsNewPropertyCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;System.Type,System.Reflection.PropertyInfo&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.isnewutils.getisnew_microsoft.codeanalysis.isymbol___1eu6ykb" />  IsNewUtils.GetIsNew(ISymbol) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [IsNewUtils](#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x)</small>


Gets the value of internal IsNew property of given <strong>symbol</strong>



```csharp
public static bool GetIsNew(this ISymbol symbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a> <strong>symbol</strong></dt><dd>Symbol to get the value from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Value of internal IsNew property of given <strong>symbol</strong> or `false` when the property can&#39;t be retrieved</dd></dl>


###  Remarks ###
Uses the reflection to get the access to the internal property IsNew. The retrieved <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> is cached in [IsNewPropertyCache](#f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva) to minimize the performance impacts.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.txt__ptyt6s" />  Txt Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc</small>


Text builder



```csharp
public class Txt
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [builder](#f-net.adamec.dev.markupdoc.utils.txt.builder__g52n25) | private | Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a> | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Txt()](#m-net.adamec.dev.markupdoc.utils.txt.-ctor__gsw7a4) | public | Creates a new empty text builder | 
 | [Txt(string)](#m-net.adamec.dev.markupdoc.utils.txt.-ctor_system.string___1a0kui5) | public | Creates a new text builder with initial <strong>text</strong> | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Func&lt;string&gt;)](#m-net.adamec.dev.markupdoc.utils.txt.add_system.func_system.string____1qdiz0q) | public | Adds the text returned from <strong>textFunc</strong> to the text builder | 
 | [Add(string)](#m-net.adamec.dev.markupdoc.utils.txt.add_system.string___1b5phwl) | public | Adds the <strong>text</strong> to the text builder | 
 | [AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string)](#m-net.adamec.dev.markupdoc.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1ef8yye) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder. | 
 | [AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string)](#m-net.adamec.dev.markupdoc.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___cg39re) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(Func&lt;string&gt;, bool)](#m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k) | public | Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(string, bool)](#m-net.adamec.dev.markupdoc.utils.txt.addif_system.string-system.boolean___1hv0ppx) | public | Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [Clear()](#m-net.adamec.dev.markupdoc.utils.txt.clear__1gpgbxi) | public | Clear the text builder | 
 | [Start(string)](#m-net.adamec.dev.markupdoc.utils.txt.start_system.string___dpjsla) | public static | Creates a new instance ot [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong> | 
 | [ToString()](#m-net.adamec.dev.markupdoc.utils.txt.tostring__19rvzdx) | public | Returns the text content of the text builder | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Txt, Txt)](#m-net.adamec.dev.markupdoc.utils.txt.op_addition_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___e5mhzq) | public static | Concatenates the contents of two text builders | 
 | [BitwiseOr(Txt, Txt)](#m-net.adamec.dev.markupdoc.utils.txt.op_bitwiseor_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___1fjrb02) | public static | Concatenates the contents of two text builders | 
 | [From(string)](#m-net.adamec.dev.markupdoc.utils.txt.op_implicit_system.string_dtornet.adamec.dev.markupdoc.utils.txt__1mjf3e7) | public static | Creates a new instance ot [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong> | 
 | [ToString(Txt)](#m-net.adamec.dev.markupdoc.utils.txt.op_implicit_net.adamec.dev.markupdoc.utils.txt_dtorsystem.string__1dl24tf) | public static | Converts the text builder to string containing its content | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.txt.builder__g52n25" />  Txt.builder Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a>



```csharp
private readonly StringBuilder builder
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.-ctor__gsw7a4" />  Txt.Txt() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Creates a new empty text builder



```csharp
public Txt()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.-ctor_system.string___1a0kui5" />  Txt.Txt(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Creates a new text builder with initial <strong>text</strong>



```csharp
public Txt(string text)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd></dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.add_system.func_system.string____1qdiz0q" />  Txt.Add(Func&lt;string&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the text returned from <strong>textFunc</strong> to the text builder



```csharp
public Txt Add(Func<string> textFunc)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.add_system.string___1b5phwl" />  Txt.Add(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the <strong>text</strong> to the text builder



```csharp
public Txt Add(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1ef8yye" />  Txt.AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder.



```csharp
public Txt AddEach<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___cg39re" />  Txt.AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddEachIf<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, bool condition, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


###  Remarks ###
The <strong>condition</strong> is evaluated once at the beginning of method execution, not for each item.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k" />  Txt.AddIf(Func&lt;string&gt;, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(Func<string> textFunc, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addif_system.string-system.boolean___1hv0ppx" />  Txt.AddIf(string, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(string text, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>text</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


###  Remarks ###
If using some code/variable to generate the <strong>text</strong> (for example `AddIf(obj.Container.Text, obj.Container != null)` , the parameter will be evaluated even if the condition is not true ! So the example here will throw NPE when the `obj.Container` is null. Use [AddIf(Func&lt;string&gt;, bool)](#m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k) ( `AddIf(()=>obj.Container.Text, obj.Container != null)` ) when the function should not be evaluated. Of course `AddIf(obj?.Container?.Text, obj?.Container != null)` null checks are also valid solution.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.clear__1gpgbxi" />  Txt.Clear() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Clear the text builder



```csharp
public Txt Clear()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.start_system.string___dpjsla" />  Txt.Start(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Creates a new instance ot [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong>



```csharp
public static Txt Start(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>A new instance of [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.tostring__19rvzdx" />  Txt.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Returns the text content of the text builder



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The text content of the text builder</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_addition_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___e5mhzq" />  Txt.Add(Txt, Txt) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator +(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_bitwiseor_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___1fjrb02" />  Txt.BitwiseOr(Txt, Txt) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator |(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_implicit_system.string_dtornet.adamec.dev.markupdoc.utils.txt__1mjf3e7" />  Txt.From(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Creates a new instance ot [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong>



```csharp
public static Txt op_Implicit(string text)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>A new instance of [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_implicit_net.adamec.dev.markupdoc.utils.txt_dtorsystem.string__1dl24tf" />  Txt.ToString(Txt) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</small>


Converts the text builder to string containing its content



```csharp
public static string op_Implicit(Txt txt)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt</strong></dt><dd>Text builder</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw" />  net.adamec.dev.markupdoc.Utils.Extensions Namespace ##
Extension classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AttributeDataExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y) | public static | Extension methods for <em>Microsoft.CodeAnalysis.AttributeData</em> | 
 | [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0) | public static | Extension methods for <em>Microsoft.CodeAnalysis.IMethodSymbol</em> related to the operators | 
 | [ListOfParametersExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r) | public static | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >System.Collections.Generic.ICollection`1</a> of [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) and [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [ModifierEnumExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re) | public static | Extension methods and factory for [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | 
 | [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz) | public static | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> | 
 | [TypeKindExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0) | public static | Extension methods for <em>Microsoft.CodeAnalysis.TypeKind</em> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y" />  AttributeDataExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods for <em>Microsoft.CodeAnalysis.AttributeData</em>



```csharp
public static class AttributeDataExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AttributeClassString(AttributeData)](#m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.attributeclassstring_microsoft.codeanalysis.attributedata___2jr23i) | public static | Returns the full name of the attribute class | 
 | [ToCodeString(AttributeData)](#m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.tocodestring_microsoft.codeanalysis.attributedata___yqrz7u) | public static | Gets the string representing the attribute definition in code - class (constructor params, named params) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.attributeclassstring_microsoft.codeanalysis.attributedata___2jr23i" />  AttributeDataExtensions.AttributeClassString(AttributeData) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [AttributeDataExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y)</small>


Returns the full name of the attribute class



```csharp
public static string AttributeClassString(this AttributeData attributeData)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata" target="_blank" >Microsoft.CodeAnalysis.AttributeData</a> <strong>attributeData</strong></dt><dd>Attribute data to get the class from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Full name of the attribute class</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.tocodestring_microsoft.codeanalysis.attributedata___yqrz7u" />  AttributeDataExtensions.ToCodeString(AttributeData) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [AttributeDataExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y)</small>


Gets the string representing the attribute definition in code - class (constructor params, named params)



```csharp
public static string ToCodeString(this AttributeData attributeData)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata" target="_blank" >Microsoft.CodeAnalysis.AttributeData</a> <strong>attributeData</strong></dt><dd>Attribute data to create the code from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String representing the attribute definition as in code (without [ ] brackets)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0" />  IMethodSymbolExtensionsForOperators Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods for <em>Microsoft.CodeAnalysis.IMethodSymbol</em> related to the operators



```csharp
public static class IMethodSymbolExtensionsForOperators
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [OperatorMethodAliases](#f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatormethodaliases__ji0szx) | private static | Dictionary with translation of operator &quot;internal&quot; method name to operator alias (for example op_Addition to Add) | 
 | [OperatorSymbols](#f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatorsymbols__6tjcmn) | private static | Dictionary with translation of operator &quot;internal&quot; method name to operator symbol (for example op_Addition to +) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IMethodSymbolExtensionsForOperators()](#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.-cctor__2vkqjv) | private static | Static CTOR - init operator translation dictionaries | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetOperatorCSharpSymbol(IMethodSymbol)](#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatorcsharpsymbol_microsoft.codeanalysis.imethodsymbol___1x1ipu) | public static | Get&#39;s the operator symbol for the method representing the operator | 
 | [GetOperatorMethodAliasOrOriginalName(IMethodSymbol)](#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatormethodaliasororiginalname_microsoft.codeanalysis.imethodsymbol___1e4ys9f) | public static | Get&#39;s the operator alias for the method representing the operator | 
 | [InitOperators()](#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.initoperators__1bpzsju) | private static | Initializes operator translation dictionaries (symbols and aliases) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatormethodaliases__ji0szx" />  IMethodSymbolExtensionsForOperators.OperatorMethodAliases Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Dictionary with translation of operator &quot;internal&quot; method name to operator alias (for example op_Addition to Add)



```csharp
private static readonly Dictionary<string,string> OperatorMethodAliases
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatorsymbols__6tjcmn" />  IMethodSymbolExtensionsForOperators.OperatorSymbols Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Dictionary with translation of operator &quot;internal&quot; method name to operator symbol (for example op_Addition to +)



```csharp
private static readonly Dictionary<string,string> OperatorSymbols
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.-cctor__2vkqjv" />  IMethodSymbolExtensionsForOperators.IMethodSymbolExtensionsForOperators() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Static CTOR - init operator translation dictionaries



```csharp
private static IMethodSymbolExtensionsForOperators()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatorcsharpsymbol_microsoft.codeanalysis.imethodsymbol___1x1ipu" />  IMethodSymbolExtensionsForOperators.GetOperatorCSharpSymbol(IMethodSymbol) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Get&#39;s the operator symbol for the method representing the operator



```csharp
public static string GetOperatorCSharpSymbol(this IMethodSymbol methodSymbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>methodSymbol</strong></dt><dd>Method symbol</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Operator symbol for the method representing the operator or null when unknown or not a user operator method</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatormethodaliasororiginalname_microsoft.codeanalysis.imethodsymbol___1e4ys9f" />  IMethodSymbolExtensionsForOperators.GetOperatorMethodAliasOrOriginalName(IMethodSymbol) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Get&#39;s the operator alias for the method representing the operator



```csharp
public static string GetOperatorMethodAliasOrOriginalName(this IMethodSymbol methodSymbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>methodSymbol</strong></dt><dd>Method symbol</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Operator alias for the method representing the operator or original method name when unknown or not a user operator method</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.initoperators__1bpzsju" />  IMethodSymbolExtensionsForOperators.InitOperators() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)</small>


Initializes operator translation dictionaries (symbols and aliases)



```csharp
private static void InitOperators()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r" />  ListOfParametersExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >System.Collections.Generic.ICollection`1</a> of [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) and [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)



```csharp
public static class ListOfParametersExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetIndexerParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;)](#m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.getindexerparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.methodparameter____1igu6yg) | public static | Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of indexer parameters ( [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) ) to the string as used in code. | 
 | [GetTypeParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;)](#m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.gettypeparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.typeparameter____n8wb9c) | public static | Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) s to the string as used in code. Used for typed parameters with attributes and parameters with variance (variance is at generic interfaces and delegates only) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.getindexerparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.methodparameter____1igu6yg" />  ListOfParametersExtensions.GetIndexerParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ListOfParametersExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r)</small>


Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of indexer parameters ( [MethodParameter](#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) ) to the string as used in code.



```csharp
public static string GetIndexerParametersCode(this IEnumerable<net.adamec.dev.markupdoc.CodeModel.MethodParameter> methodParameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a> <strong>methodParameters</strong></dt><dd>List of indexer method parameters</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Code string representation of the list of indexer parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.gettypeparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.typeparameter____n8wb9c" />  ListOfParametersExtensions.GetTypeParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ListOfParametersExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r)</small>


Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of [TypeParameter](#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) s to the string as used in code. Used for typed parameters with attributes and parameters with variance (variance is at generic interfaces and delegates only)



```csharp
public static string GetTypeParametersCode(this IEnumerable<net.adamec.dev.markupdoc.CodeModel.TypeParameter> typeParameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a> <strong>typeParameters</strong></dt><dd>List of type parameters</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Code string representation of the list of type parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re" />  ModifierEnumExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods and factory for [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)



```csharp
public static class ModifierEnumExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Modifier(Accessibility)](#m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.modifier_microsoft.codeanalysis.accessibility___adiiyc) | public static | Creates the modifier from given <strong>accessibility</strong> | 
 | [ToModifierString(ModifierEnum)](#m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.tomodifierstring_net.adamec.dev.markupdoc.codemodel.modifierenum___hgk62q) | public static | Converts the [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) to string that can be used in code | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.modifier_microsoft.codeanalysis.accessibility___adiiyc" />  ModifierEnumExtensions.Modifier(Accessibility) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ModifierEnumExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re)</small>


Creates the modifier from given <strong>accessibility</strong>



```csharp
public static ModifierEnum Modifier(Accessibility accessibility)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.accessibility" target="_blank" >Microsoft.CodeAnalysis.Accessibility</a> <strong>accessibility</strong></dt><dd>Accessibility to create the [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd>[ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) from given <strong>accessibility</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.tomodifierstring_net.adamec.dev.markupdoc.codemodel.modifierenum___hgk62q" />  ModifierEnumExtensions.ToModifierString(ModifierEnum) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ModifierEnumExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re)</small>


Converts the [ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) to string that can be used in code



```csharp
public static string ToModifierString(this ModifierEnum modifierEnum)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) <strong>modifierEnum</strong></dt><dd>Modifier to convert</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>&quot;Code compatible&quot; modifier string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz" />  StringExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a>



```csharp
public static class StringExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FirstLetterToUpper(string)](#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.firstlettertoupper_system.string___j3gt9g) | public static | Converts the first letter of string to upper case | 
 | [HtmlDecode(string)](#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmldecode_system.string___j83xey) | public static | HTML decodes the string | 
 | [HtmlEncode(string)](#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmlencode_system.string___1lb4xh2) | public static | HTML encodes the string | 
 | [TrimAndMergeLines(string)](#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.trimandmergelines_system.string___85g233) | public static | &quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.firstlettertoupper_system.string___j3gt9g" />  StringExtensions.FirstLetterToUpper(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)</small>


Converts the first letter of string to upper case



```csharp
public static string FirstLetterToUpper(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to convert</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String with the first letter in upper case</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmldecode_system.string___j83xey" />  StringExtensions.HtmlDecode(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)</small>


HTML decodes the string



```csharp
public static string HtmlDecode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to decode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML decoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmlencode_system.string___1lb4xh2" />  StringExtensions.HtmlEncode(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)</small>


HTML encodes the string



```csharp
public static string HtmlEncode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to encode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML encoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.trimandmergelines_system.string___85g233" />  StringExtensions.TrimAndMergeLines(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)</small>


&quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)



```csharp
public static string TrimAndMergeLines(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to full trim</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>&quot;Fully&quot; trimmed string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0" />  TypeKindExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc</small>


Extension methods for <em>Microsoft.CodeAnalysis.TypeKind</em>



```csharp
public static class TypeKindExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToTypeKindEnum(TypeKind)](#m-net.adamec.dev.markupdoc.utils.extensions.typekindextensions.totypekindenum_microsoft.codeanalysis.typekind___b5txcz) | public static | Converts the <em>Microsoft.CodeAnalysis.TypeKind</em> to [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.typekindextensions.totypekindenum_microsoft.codeanalysis.typekind___b5txcz" />  TypeKindExtensions.ToTypeKindEnum(TypeKind) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [TypeKindExtensions](#t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0)</small>


Converts the <em>Microsoft.CodeAnalysis.TypeKind</em> to [TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)



```csharp
public static TypeKindEnum ToTypeKindEnum(this TypeKind typeKind)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.typekind" target="_blank" >Microsoft.CodeAnalysis.TypeKind</a> <strong>typeKind</strong></dt><dd>TypeKind to convert</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd>TypeKindEnum from the TypeKind</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6" />  net.adamec.dev.markupdoc.XmlDocumentation Namespace ##
XML Comment Documentation DTO classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) | public | Class representing &lt;c&gt; element of XML Documentation Comments | 
 | [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) | public | Class representing &lt;code&gt; element of XML Documentation Comments | 
 | [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) | public | Class representing (internal) &lt;member&gt; element of XML Documentation Comments. Used as a root documentation object for the code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | 
 | [Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54) | public | Class representing &lt;example&gt; element of XML Documentation Comments | 
 | [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) | public | Class representing &lt;exception&gt; element of XML Documentation  Comments | 
 | [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) | public | Class representing &lt;list&gt; element of XML Documentation  Comments | 
 | [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) | public | Class representing &lt;item&gt; and &lt;listheader&gt; elements of XML Documentation Comments | 
 | [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) | public | Base class for the XML Documentation Comments elements and nodes It&#39;s inherited by &quot;known&quot; nodes/elements, itself instanciated when the node/element is not recognized (known). | 
 | [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) | public abstract | Abstract class representing the element of XML Documentation Comments that have the `cref` attribute | 
 | [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3) | public abstract | Abstract class representing the element of XML Documentation Comments that have the `cref` attribute and simple rendering logic - just the link and/or content | 
 | [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe) | public abstract | Abstract class representing the element of XML Documentation Comments that have the `name` attribute | 
 | [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) | public | Class representing &lt;para&gt; element of XML Documentation Comments | 
 | [Param](#t-net.adamec.dev.markupdoc.xmldocumentation.param__7q99qf) | public | Class representing &lt;param&gt; element of XML Documentation  Comments | 
 | [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) | public | Class representing &lt;paramref&gt; element of XML Documentation Comments | 
 | [Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45) | public | Class representing &lt;remarks&gt; element of XML Documentation Comments | 
 | [Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401) | public | Class representing &lt;returns&gt; element of XML Documentation Comments | 
 | [See](#t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun) | public | Class representing &lt;see&gt; element of XML Documentation Comments | 
 | [SeeAlso](#t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46) | public | Class representing &lt;seealso&gt; element of XML Documentation Comments | 
 | [Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy) | public | Class representing &lt;summary&gt; element of XML Documentation Comments | 
 | [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) | public | Class representing text node (content) of XML Documentation Comments | 
 | [TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z) | public | Class representing &lt;typeparam&gt; element of XML Documentation Comments | 
 | [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo) | public | Class representing &lt;typeparamref&gt; element of XML Documentation Comments | 
 | [Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn) | public | Class representing &lt;value&gt; element of XML Documentation  Comments | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725) | public | List rendering type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz" />  C Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;c&gt; element of XML Documentation Comments



```csharp
public class C : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [C(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.c.-ctor_system.xml.linq.xnode___1sxo5vo) | public | Initialize [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.c.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___hlj6ry) | protected | Renders the [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.c.-ctor_system.xml.linq.xnode___1sxo5vo" />  C.C(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz)</small>


Initialize [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) instance from XML Documentation Comments element



```csharp
public C(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.c.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___hlj6ry" />  C.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz)</small>


Renders the [C](#t-net.adamec.dev.markupdoc.xmldocumentation.c__2ehmsz) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;c&gt; element of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets (fully) trimmed content of the tag and renders it using [InlineCode(string, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.inlinecode_system.string-system.boolean___70e1uy)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1" />  Code Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;code&gt; element of XML Documentation Comments



```csharp
public class Code : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Code(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.code.-ctor_system.xml.linq.xnode___13j5k3y) | public | Initialize [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.code.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___1ofxyz8) | protected | Renders the [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.code.-ctor_system.xml.linq.xnode___13j5k3y" />  Code.Code(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1)</small>


Initialize [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) instance from XML Documentation Comments element



```csharp
public Code(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.code.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___1ofxyz8" />  Code.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1)</small>


Renders the [Code](#t-net.adamec.dev.markupdoc.xmldocumentation.code__1ow82f1) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;code&gt; element of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets not-trimmed content of the tag and renders it using [Code(string, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.code_system.string-system.boolean___185qr7p) . Replaces the line breaks within the output with [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) pseudo-tag and spaces with [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) pseudo-tag to preserve the whitespace when the parent element is to be rendered (and its content trimmed)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg" />  Documentation Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing (internal) &lt;member&gt; element of XML Documentation Comments. Used as a root documentation object for the code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)



```csharp
public class Documentation : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Remarks ###
The [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) class provides the &quot;alias&quot; properties to access the common elements like [Summary](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.summary__1reflp6) , [Remarks](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.remarks__14i5fd5) , [Exceptions](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.exceptions__12srzfs) , etc.


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Example](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.example__15r3944) | public | Returns the first `example` documentation element or null if not available | 
 | [Exceptions](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.exceptions__12srzfs) | public | Returns the `exception` documentation elements or null if not available | 
 | [OwnRef](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.ownref__ps4lhn) | public | Content of `name` attribute of `member` element | 
 | [Remarks](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.remarks__14i5fd5) | public | Returns the first `remarks` documentation element or null if not available | 
 | [Returns](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.returns__5tixf9) | public | Returns the first `returns` documentation element or null if not available | 
 | [SeeAlso](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.seealso__11yd846) | public | Returns the `seealso` documentation elements or null if not available | 
 | [Summary](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.summary__1reflp6) | public | Returns the first `summary` documentation element or null if not available | 
 | [Value](#p-net.adamec.dev.markupdoc.xmldocumentation.documentation.value__ncvu3) | public | Returns the first `value` documentation element or null if not available | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Documentation(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.documentation.-ctor_system.xml.linq.xelement___gbnnaf) | public | Initialize [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Param(string)](#m-net.adamec.dev.markupdoc.xmldocumentation.documentation.param_system.string___1ymn6yp) | public | Returns the first `param` documentation element with given <strong>name</strong> or null if not available | 
 | [Read(string)](#m-net.adamec.dev.markupdoc.xmldocumentation.documentation.read_system.string___1el00ia) | public static | Reads the XML Documentation Comments from given <em>xml</em> string | 
 | [TypeParam(string)](#m-net.adamec.dev.markupdoc.xmldocumentation.documentation.typeparam_system.string___vwk25d) | public | Returns the first `typeparam` documentation element with given <strong>name</strong> or null if not available | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.example__15r3944" />  Documentation.Example Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `example` documentation element or null if not available



```csharp
public Example Example { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.exceptions__12srzfs" />  Documentation.Exceptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the `exception` documentation elements or null if not available



```csharp
public IList<net.adamec.dev.markupdoc.XmlDocumentation.ExceptionDoc> Exceptions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1" target="_blank" >IList&lt;net.adamec.dev.markupdoc.XmlDocumentation.ExceptionDoc&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.ownref__ps4lhn" />  Documentation.OwnRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Content of `name` attribute of `member` element



```csharp
public string OwnRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.remarks__14i5fd5" />  Documentation.Remarks Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `remarks` documentation element or null if not available



```csharp
public Remarks Remarks { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.returns__5tixf9" />  Documentation.Returns Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `returns` documentation element or null if not available



```csharp
public Returns Returns { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.seealso__11yd846" />  Documentation.SeeAlso Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the `seealso` documentation elements or null if not available



```csharp
public IList<net.adamec.dev.markupdoc.XmlDocumentation.SeeAlso> SeeAlso { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1" target="_blank" >IList&lt;net.adamec.dev.markupdoc.XmlDocumentation.SeeAlso&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.summary__1reflp6" />  Documentation.Summary Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `summary` documentation element or null if not available



```csharp
public Summary Summary { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.documentation.value__ncvu3" />  Documentation.Value Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `value` documentation element or null if not available



```csharp
public Value Value { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.documentation.-ctor_system.xml.linq.xelement___gbnnaf" />  Documentation.Documentation(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Initialize [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) instance from XML Documentation Comments element



```csharp
public Documentation(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.documentation.param_system.string___1ymn6yp" />  Documentation.Param(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `param` documentation element with given <strong>name</strong> or null if not available



```csharp
public Param Param(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the parameter to get the documentation for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Param](#t-net.adamec.dev.markupdoc.xmldocumentation.param__7q99qf)</dt><dd>The first `param` documentation element with given <strong>name</strong> or null if not available</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.documentation.read_system.string___1el00ia" />  Documentation.Read(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Reads the XML Documentation Comments from given <em>xml</em> string



```csharp
public static Documentation Read(string xml)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>xml</strong></dt><dd>XML with documentation comments to parse</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</dt><dd>The new instance of [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg) class with XML Documentation Comments parsed from given <strong>xml</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.documentation.typeparam_system.string___vwk25d" />  Documentation.TypeParam(string) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Documentation](#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</small>


Returns the first `typeparam` documentation element with given <strong>name</strong> or null if not available



```csharp
public TypeParam TypeParam(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the parameter to get the documentation for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z)</dt><dd>The first `typeparam` documentation element with given <strong>name</strong> or null if not available</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54" />  Example Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;example&gt; element of XML Documentation Comments



```csharp
public class Example : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Example(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.example.-ctor_system.xml.linq.xnode___9jvitb) | public | Initialize [Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.example.-ctor_system.xml.linq.xnode___9jvitb" />  Example.Example(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54)</small>


Initialize [Example](#t-net.adamec.dev.markupdoc.xmldocumentation.example__k71z54) instance from XML Documentation Comments element



```csharp
public Example(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb" />  ExceptionDoc Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;exception&gt; element of XML Documentation  Comments



```csharp
public class ExceptionDoc : ModelElementWithCref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExceptionDoc(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc.-ctor_system.xml.linq.xelement___mv5s5c) | public | Initialize [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___9qruzs) | protected | Renders the [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) element  to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc.-ctor_system.xml.linq.xelement___mv5s5c" />  ExceptionDoc.ExceptionDoc(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb)</small>


Initialize [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) instance from XML Documentation Comments element



```csharp
public ExceptionDoc(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___9qruzs" />  ExceptionDoc.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb)</small>


Renders the [ExceptionDoc](#t-net.adamec.dev.markupdoc.xmldocumentation.exceptiondoc__isvpmb) element  to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;exception&gt; element of XML Documentation Comments. Important: it returns description list item, so must be encapsulated on higher level !!!</dd></dl>


###  Remarks ###
Builds the link with the reference according to the `cref` attribute value. The value represents the Documentation ID that can be matched to the information got during the code analysis or to build the link to MS API reference for the &quot;MS objects&quot;. First, it tries to resolve the [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) in code being documented (internal link). If not successful, tries to look for the `cref` (Documentation ID) in the MS API documentation if allowed/available (see [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) for details) The link text is the the name of linked entity when using internal [Link(string, Member)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___kz8auq) or the `cref` without the leading type information when rendering . When the link is not constructed (&quot;target unknown&quot;), the `cref` value without the leading type information is rendered in italic

 The &lt;exception&gt; element is then rendered as [DescriptionListItem(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.descriptionlistitem_system.string-system.string___185r8jg) where `Term` is the link and `Description` is the fully trimmed element content. Important: it returns description list item, so must be encapsulated on higher level !!!




###  See Also ###
[MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
[MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a" />  List Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;list&gt; element of XML Documentation  Comments



```csharp
public class List : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ListType](#p-net.adamec.dev.markupdoc.xmldocumentation.list.listtype__19a59bg) | public | Required type of the list rendering | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [List(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.list.-ctor_system.xml.linq.xelement___177htrf) | public | Initialize [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) instance from XML Documentation Comments element. Extracts the `type` attribute | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.list.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___19s1ed) | protected | Renders the [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.list.listtype__19a59bg" />  List.ListType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a)</small>


Required type of the list rendering



```csharp
public List.ListTypeEnum ListType { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.list.-ctor_system.xml.linq.xelement___177htrf" />  List.List(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a)</small>


Initialize [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) instance from XML Documentation Comments element. Extracts the `type` attribute



```csharp
public List(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.list.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___19s1ed" />  List.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a)</small>


Renders the [List](#t-net.adamec.dev.markupdoc.xmldocumentation.list__zvsh5a) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered list element of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets content of the all child [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) elements and renders them into the list of required [ListType](#p-net.adamec.dev.markupdoc.xmldocumentation.list.listtype__19a59bg) . 


 - <strong>Bullet list</strong> - Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional. This includes the list header item if present, however, there is no special handling for such item.
 - <strong>Numbered list</strong> - Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional. This includes the list header item if present, however, there is no special handling for such item.
 - <strong>Table</strong> - Rendered as two column table (term and description). Both parts are optional. Header item should be provided to define the table header (&quot;Term&quot; and &quot;Description&quot; are used as defaults)
           


 The rendering uses [List&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.list--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean___1gcvzmw) to render the lists and [TableHeader(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tableheader_system.string_____1id0rx8) , [TableCols(string[])](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablecols_system.string_____9o05ka) and [TableFooter()](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.tablefooter__8xrzfr) for table rendering. Pseudo-tags [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) and [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) are used in the rendering output, to preserve the whitespaces when the parent element is to be rendered (and its content trimmed)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn" />  ListItem Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;item&gt; and &lt;listheader&gt; elements of XML Documentation Comments



```csharp
public class ListItem : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Description](#p-net.adamec.dev.markupdoc.xmldocumentation.listitem.description__1mzbxvn) | public | [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) representing &lt;description&gt; child element of list item | 
 | [IsHeader](#p-net.adamec.dev.markupdoc.xmldocumentation.listitem.isheader__k82st4) | public | Flag whether the [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) is a list header (represents the &lt;listheader&gt; tag) | 
 | [Term](#p-net.adamec.dev.markupdoc.xmldocumentation.listitem.term__xeq7bv) | public | [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) representing &lt;term&gt; child element of list item | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ListItem(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.listitem.-ctor_system.xml.linq.xelement___1isw2x6) | public | Initialize [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.listitem.description__1mzbxvn" />  ListItem.Description Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn)</small>


[ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) representing &lt;description&gt; child element of list item



```csharp
public ModelElement Description { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.listitem.isheader__k82st4" />  ListItem.IsHeader Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn)</small>


Flag whether the [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) is a list header (represents the &lt;listheader&gt; tag)



```csharp
public bool IsHeader { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.listitem.term__xeq7bv" />  ListItem.Term Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn)</small>


[ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) representing &lt;term&gt; child element of list item



```csharp
public ModelElement Term { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.listitem.-ctor_system.xml.linq.xelement___1isw2x6" />  ListItem.ListItem(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn)</small>


Initialize [ListItem](#t-net.adamec.dev.markupdoc.xmldocumentation.listitem__bk21cn) instance from XML Documentation Comments element



```csharp
public ListItem(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1" />  ModelElement Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Base class for the XML Documentation Comments elements and nodes It&#39;s inherited by &quot;known&quot; nodes/elements, itself instanciated when the node/element is not recognized (known).



```csharp
public class ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) | protected static | Pseudo-tag used to keep the line break in [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) output | 
 | [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) | protected static | Pseudo-tag used to keep the space in [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) output | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) | public | List of  child elements | 
 | [ElementsProtected](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elementsprotected__2vi256) | protected | Internal list of child elements | 
 | [Kind](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.kind__190l3cr) | public | Element name (tag) or &quot;Text&quot; for the [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) node | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ModelElement(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.-ctor_system.xml.linq.xnode___1neqw34) | protected | Initialize [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) instance from XML Documentation Comments node. Sets the [Kind](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.kind__190l3cr) property from the element&#39;s tag (for elements only) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Read(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.read_system.xml.linq.xnode___o84441) | public static | Reads the node from XML - checks the node type (text node + named elements) and calls the appropriate constructor of derived classes. When the element is &quot;unknown&quot;, the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) is created. The method is recursively called for all child nodes and the created child objects are inserted into [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) list. This keeps the hierarchy of elements as in XML. | 
 | [Render(IMarkupProvider, Member)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.render_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member___pvi91j) | public | Renders the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) and its content to string containing the markup provided by <strong>markupProvider</strong> . This is the public &quot;entry point&quot; to [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) that does the final adjustment of the whitespaces. | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) | protected | Renders the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) and its content to string containing the markup provided by <strong>markupProvider</strong> | 
 | [ToString()](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tostring__d0syr2) | public | Returns the element content as string. It gets the content of all child [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) , merges into single line and trims (full trim) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5" />  ModelElement.TagKeepLineBreak Field ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Pseudo-tag used to keep the line break in [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) output



```csharp
protected static string TagKeepLineBreak
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m" />  ModelElement.TagKeepSpace Field ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Pseudo-tag used to keep the space in [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) output



```csharp
protected static string TagKeepSpace
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw" />  ModelElement.Elements Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


List of  child elements



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.XmlDocumentation.ModelElement> Elements { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.XmlDocumentation.ModelElement&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elementsprotected__2vi256" />  ModelElement.ElementsProtected Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Internal list of child elements



```csharp
protected List<net.adamec.dev.markupdoc.XmlDocumentation.ModelElement> ElementsProtected { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.XmlDocumentation.ModelElement&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.kind__190l3cr" />  ModelElement.Kind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Element name (tag) or &quot;Text&quot; for the [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) node



```csharp
public string Kind { get; protected set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.-ctor_system.xml.linq.xnode___1neqw34" />  ModelElement.ModelElement(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Initialize [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) instance from XML Documentation Comments node. Sets the [Kind](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.kind__190l3cr) property from the element&#39;s tag (for elements only)



```csharp
protected ModelElement(XNode node)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>node</strong></dt><dd>XML node of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.read_system.xml.linq.xnode___o84441" />  ModelElement.Read(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Reads the node from XML - checks the node type (text node + named elements) and calls the appropriate constructor of derived classes. When the element is &quot;unknown&quot;, the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) is created. The method is recursively called for all child nodes and the created child objects are inserted into [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) list. This keeps the hierarchy of elements as in XML.



```csharp
public static ModelElement Read(XNode node)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>node</strong></dt><dd>XML Documentation  Comments node to read</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</dt><dd>The element/node class read from XML containing the children in [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) list.</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.render_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member___pvi91j" />  ModelElement.Render(IMarkupProvider, Member) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Renders the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) and its content to string containing the markup provided by <strong>markupProvider</strong> . This is the public &quot;entry point&quot; to [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) that does the final adjustment of the whitespaces.



```csharp
public virtual string Render(IMarkupProvider markupProvider, Member member)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of element/node of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets content of the all child [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) and merges it together with a space as a separator. The result is &quot;fully&quot; trimmed - the line breaks are replaced by spaces and leading/ending spaces are removed. Use [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) and [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) in derived classes&#39; [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2) to preserve the whitespaces. The [Render(IMarkupProvider, Member)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.render_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member___pvi91j) method replaces [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) and [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) pseudo-tags back to line breaks and spaces to preserve the &quot;hard&quot; whitespace required by the rendering method


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ut2gg2" />  ModelElement.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Renders the [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected virtual string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of element/node of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets content of the all child [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) and merges it together with a space as a separator. If <strong>trim</strong> parameter is set, the result is &quot;fully&quot; trimmed - the line breaks are replaced by spaces and leading/ending spaces are removed. The parameter is also propagated to child&#39;s RenderElement function when getting the content. Use [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) and [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) in derived classes to preserve the whitespaces. when the parent element is to be rendered (and its content trimmed)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tostring__d0syr2" />  ModelElement.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)</small>


Returns the element content as string. It gets the content of all child [Elements](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelement.elements__15a04qw) , merges into single line and trims (full trim)



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The element content as string</dd></dl>


###  Remarks ###
Use [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) and [TagKeepSpace](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeepspace__clhu5m) in derived classes to preserve the whitespaces.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t" />  ModelElementWithCref Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Abstract class representing the element of XML Documentation Comments that have the `cref` attribute



```csharp
public abstract class ModelElementWithCref : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) | public | cref attribute value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ModelElementWithCref(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.-ctor_system.xml.linq.xelement___pbe7xs) | protected | Initialize [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) instance from XML Documentation Comments element Extracts the cref attribute | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.tostring__eru888) | public | Returns the element content as string if [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg" />  ModelElementWithCref.Ref Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t)</small>


cref attribute value



```csharp
public string Ref { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.-ctor_system.xml.linq.xelement___pbe7xs" />  ModelElementWithCref.ModelElementWithCref(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t)</small>


Initialize [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) instance from XML Documentation Comments element Extracts the cref attribute



```csharp
protected ModelElementWithCref(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.tostring__eru888" />  ModelElementWithCref.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t)</small>


Returns the element content as string if [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The element content as string if [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3" />  ModelElementWithCrefSimple Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Abstract class representing the element of XML Documentation Comments that have the `cref` attribute and simple rendering logic - just the link and/or content



```csharp
public abstract class ModelElementWithCrefSimple : ModelElementWithCref
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ModelElementWithCrefSimple(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.-ctor_system.xml.linq.xelement___la0cia) | protected | Initialize [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3) instance from XML Documentation Comments element No logic here | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___isgepe) | protected | Renders the element having the `cref` attribute to string containing the markup provided by <strong>markupProvider</strong> | 
 | [ToString()](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.tostring__d884lm) | public | Returns the element content as string or [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.-ctor_system.xml.linq.xelement___la0cia" />  ModelElementWithCrefSimple.ModelElementWithCrefSimple(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3)</small>


Initialize [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3) instance from XML Documentation Comments element No logic here



```csharp
protected ModelElementWithCrefSimple(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___isgepe" />  ModelElementWithCrefSimple.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3)</small>


Renders the element having the `cref` attribute to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of element of XML Documentation Comments</dd></dl>


###  Remarks ###
Builds the link with the reference according to the `cref` attribute value. The value represents the Documentation ID that can be matched to the information got during the code analysis or to build the link to MS API reference for the &quot;MS objects&quot;. First, it tries to resolve the [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) in code being documented (internal link). If not successful, tries to look for the `cref` (Documentation ID) in the MS API documentation if allowed/available (see [MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) for details) The link text is the rendered trimmed content of the tag if available, the name of linked entity when using internal [Link(string, Member)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.link_system.string-net.adamec.dev.markupdoc.codemodel.member___kz8auq) or the `cref` without the leading type information when rendering [ExternalLink(string, string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.externallink_system.string-system.string___76ohd6) . When the link is not constructed (&quot;target unknown&quot;), the `cref` value without the leading type information is rendered in italic




###  See Also ###
[MsApiDocEngine](#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
[MsApiDocOptions](#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple.tostring__d884lm" />  ModelElementWithCrefSimple.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3)</small>


Returns the element content as string or [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The element content as string or [Ref](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref.ref__37qgpg) when there is no content</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe" />  ModelElementWithName Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Abstract class representing the element of XML Documentation Comments that have the `name` attribute



```csharp
public abstract class ModelElementWithName : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](#p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname.name__p60max) | public | name attribute value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ModelElementWithName(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname.-ctor_system.xml.linq.xelement___tksc91) | protected | Initialize [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe) instance from XML Documentation Comments element Extracts the name attribute | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname.name__p60max" />  ModelElementWithName.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)</small>


name attribute value



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname.-ctor_system.xml.linq.xelement___tksc91" />  ModelElementWithName.ModelElementWithName(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)</small>


Initialize [ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe) instance from XML Documentation Comments element Extracts the name attribute



```csharp
protected ModelElementWithName(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es" />  Para Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;para&gt; element of XML Documentation Comments



```csharp
public class Para : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Para(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.para.-ctor_system.xml.linq.xnode___s8cbsh) | public | Initialize [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.para.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___1mik5qp) | protected | Renders the [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.para.-ctor_system.xml.linq.xnode___s8cbsh" />  Para.Para(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es)</small>


Initialize [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) instance from XML Documentation Comments element



```csharp
public Para(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.para.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___1mik5qp" />  Para.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es)</small>


Renders the [Para](#t-net.adamec.dev.markupdoc.xmldocumentation.para__1no80es) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;para&gt; element of XML Documentation Comments</dd></dl>


###  Remarks ###
Gets trimmed content of the tag and renders it using [Para(string)](#m-net.adamec.dev.markupdoc.markup.imarkupprovider.para_system.string___1n5d79p) . Replaces the line breaks within the output with [TagKeepLineBreak](#f-net.adamec.dev.markupdoc.xmldocumentation.modelelement.tagkeeplinebreak__73j6k5) pseudo-tag to preserve the line breaks in the markup when the parent element is to be rendered (and its content trimmed)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.param__7q99qf" />  Param Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;param&gt; element of XML Documentation  Comments



```csharp
public class Param : ModelElementWithName
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Param(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.param.-ctor_system.xml.linq.xelement___1e6okoa) | public |  | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.param.-ctor_system.xml.linq.xelement___1e6okoa" />  Param.Param(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Param](#t-net.adamec.dev.markupdoc.xmldocumentation.param__7q99qf)</small>



```csharp
public Param(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd></dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8" />  ParamRef Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;paramref&gt; element of XML Documentation Comments



```csharp
public class ParamRef : ModelElementWithName
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ParamRef(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.paramref.-ctor_system.xml.linq.xelement___1ayymr) | public | Initialize [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.paramref.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___mgskzh) | protected | Renders the [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.paramref.-ctor_system.xml.linq.xelement___1ayymr" />  ParamRef.ParamRef(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8)</small>


Initialize [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) instance from XML Documentation Comments element



```csharp
public ParamRef(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.paramref.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___mgskzh" />  ParamRef.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8)</small>


Renders the [ParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.paramref__1goure8) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;paramref&gt; element of XML Documentation Comments</dd></dl>


###  Remarks ###
When the element has the content (text), the content is rendered, otherwise the `name` attribute value in bold is rendered.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45" />  Remarks Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;remarks&gt; element of XML Documentation Comments



```csharp
public class Remarks : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Remarks(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.remarks.-ctor_system.xml.linq.xnode___clibig) | public | Initialize [Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.remarks.-ctor_system.xml.linq.xnode___clibig" />  Remarks.Remarks(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45)</small>


Initialize [Remarks](#t-net.adamec.dev.markupdoc.xmldocumentation.remarks__1swka45) instance from XML Documentation Comments element



```csharp
public Remarks(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401" />  Returns Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;returns&gt; element of XML Documentation Comments



```csharp
public class Returns : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Returns(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.returns.-ctor_system.xml.linq.xnode___1yg122) | public | Initialize [Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.returns.-ctor_system.xml.linq.xnode___1yg122" />  Returns.Returns(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401)</small>


Initialize [Returns](#t-net.adamec.dev.markupdoc.xmldocumentation.returns__9bt401) instance from XML Documentation Comments element



```csharp
public Returns(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun" />  See Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;see&gt; element of XML Documentation Comments



```csharp
public class See : ModelElementWithCrefSimple
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [See(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.see.-ctor_system.xml.linq.xelement___veyfmk) | public | Initialize [See](#t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.see.-ctor_system.xml.linq.xelement___veyfmk" />  See.See(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [See](#t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun)</small>


Initialize [See](#t-net.adamec.dev.markupdoc.xmldocumentation.see__12himun) instance from XML Documentation Comments element



```csharp
public See(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46" />  SeeAlso Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;seealso&gt; element of XML Documentation Comments



```csharp
public class SeeAlso : ModelElementWithCrefSimple
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCref](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcref__1u5bu3t) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithCrefSimple](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithcrefsimple__1tvmen3)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SeeAlso(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.seealso.-ctor_system.xml.linq.xelement___12boalv) | public | Initialize [SeeAlso](#t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.seealso.-ctor_system.xml.linq.xelement___12boalv" />  SeeAlso.SeeAlso(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [SeeAlso](#t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46)</small>


Initialize [SeeAlso](#t-net.adamec.dev.markupdoc.xmldocumentation.seealso__1fkiu46) instance from XML Documentation Comments element



```csharp
public SeeAlso(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy" />  Summary Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;summary&gt; element of XML Documentation Comments



```csharp
public class Summary : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Summary(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.summary.-ctor_system.xml.linq.xnode___1p8n2fr) | public | Initialize [Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.summary.-ctor_system.xml.linq.xnode___1p8n2fr" />  Summary.Summary(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy)</small>


Initialize [Summary](#t-net.adamec.dev.markupdoc.xmldocumentation.summary__mrutjy) instance from XML Documentation Comments element



```csharp
public Summary(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h" />  Text Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing text node (content) of XML Documentation Comments



```csharp
public class Text : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Content](#p-net.adamec.dev.markupdoc.xmldocumentation.text.content__dyov3e) | public |  | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Text(XText)](#m-net.adamec.dev.markupdoc.xmldocumentation.text.-ctor_system.xml.linq.xtext___shkeaj) | public | Initialize [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) instance from XML Documentation Comments node (element content or it&#39;s part when child elements are in place) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.text.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___30ojk6) | protected | Renders the [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) content to string | 
 | [ToString()](#m-net.adamec.dev.markupdoc.xmldocumentation.text.tostring__1ob5x3q) | public | Gets the fully trimmed text content (part) of the XML Documentation Comment | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.xmldocumentation.text.content__dyov3e" />  Text.Content Property ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h)</small>



```csharp
public string Content { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.text.-ctor_system.xml.linq.xtext___shkeaj" />  Text.Text(XText) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h)</small>


Initialize [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) instance from XML Documentation Comments node (element content or it&#39;s part when child elements are in place)



```csharp
public Text(XText text)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xtext" target="_blank" >System.Xml.Linq.XText</a> <strong>text</strong></dt><dd><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xtext" target="_blank" >System.Xml.Linq.XText</a> node of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.text.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___30ojk6" />  Text.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h)</small>


Renders the [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h) content to string



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered text content of element in XML Documentation Comments</dd></dl>


###  Remarks ###
The text content is by default fully trimmed meaning that the inner line breaks are replaced by spaces and leading and ending spaces and line breaks are cut out.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.text.tostring__1ob5x3q" />  Text.ToString() Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Text](#t-net.adamec.dev.markupdoc.xmldocumentation.text__1xsey9h)</small>


Gets the fully trimmed text content (part) of the XML Documentation Comment



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Fully trimmed text content (part) of the XML Documentation Comment</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z" />  TypeParam Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;typeparam&gt; element of XML Documentation Comments



```csharp
public class TypeParam : ModelElementWithName
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeParam(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.typeparam.-ctor_system.xml.linq.xelement___1q1mduy) | public | Initialize [TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.typeparam.-ctor_system.xml.linq.xelement___1q1mduy" />  TypeParam.TypeParam(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z)</small>


Initialize [TypeParam](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparam__1cm275z) instance from XML Documentation Comments element



```csharp
public TypeParam(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo" />  TypeParamRef Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;typeparamref&gt; element of XML Documentation Comments



```csharp
public class TypeParamRef : ModelElementWithName
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1) -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElementWithName](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelementwithname__wsyfwe)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeParamRef(XElement)](#m-net.adamec.dev.markupdoc.xmldocumentation.typeparamref.-ctor_system.xml.linq.xelement___1misv2r) | public | Initialize [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) instance from XML Documentation Comments element | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RenderElement(IMarkupProvider, Member, bool)](#m-net.adamec.dev.markupdoc.xmldocumentation.typeparamref.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ym1br9) | protected | Renders the [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo) and its content to string containing the markup provided by <strong>markupProvider</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.typeparamref.-ctor_system.xml.linq.xelement___1misv2r" />  TypeParamRef.TypeParamRef(XElement) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo)</small>


Initialize [TypeRef](#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) instance from XML Documentation Comments element



```csharp
public TypeParamRef(XElement element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xelement" target="_blank" >System.Xml.Linq.XElement</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.typeparamref.renderelement_net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.codemodel.member-system.boolean___ym1br9" />  TypeParamRef.RenderElement(IMarkupProvider, Member, bool) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo)</small>


Renders the [TypeParamRef](#t-net.adamec.dev.markupdoc.xmldocumentation.typeparamref__qcu1eo) and its content to string containing the markup provided by <strong>markupProvider</strong>



```csharp
protected override string RenderElement(IMarkupProvider markupProvider, Member member, bool trim = true)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markupProvider</strong></dt><dd>[IMarkupProvider](#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) allowing using the markup within the rendered content</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Code model [Member](#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) to render the XML Documentation Comment for</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>trim</strong></dt><dd>Flag whether to (full) trim the rendered content</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Rendered content of &lt;typeparamref&gt; element of XML Documentation Comments</dd></dl>


###  Remarks ###
When the element has the content (text), the content is rendered, otherwise the `name` attribute value in bold is rendered.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn" />  Value Class ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


Class representing &lt;value&gt; element of XML Documentation  Comments



```csharp
public class Value : ModelElement
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.XmlDocumentation.ModelElement](#t-net.adamec.dev.markupdoc.xmldocumentation.modelelement__1j8k6p1)           



###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Value(XNode)](#m-net.adamec.dev.markupdoc.xmldocumentation.value.-ctor_system.xml.linq.xnode___vva4ec) | public | Initialize [Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn) instance from XML Documentation Comments element | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.xmldocumentation.value.-ctor_system.xml.linq.xnode___vva4ec" />  Value.Value(XNode) Title ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn)</small>


Initialize [Value](#t-net.adamec.dev.markupdoc.xmldocumentation.value__sil3tn) instance from XML Documentation Comments element



```csharp
public Value(XNode element)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.xml.linq.xnode" target="_blank" >System.Xml.Linq.XNode</a> <strong>element</strong></dt><dd>XML element of XML Documentation Comments</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725" />  List.ListTypeEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc</small>


List rendering type



```csharp
public enum List.ListTypeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Bullet](#f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.bullet__1tsu4x7) | 0 | Render as bullet list. Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional. | 
 | [Number](#f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.number__n830ti) | 1 | Render as numbered list. Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional. | 
 | [Table](#f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.table__s1bzk3) | 2 | Render as two column table (term and description). Header item should be provided to define the table header (&quot;Term&quot; and &quot;Description&quot; are used as defaults) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.bullet__1tsu4x7" />  List.ListTypeEnum.Bullet Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</small>


Render as bullet list. Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional.



```csharp
 Bullet = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.number__n830ti" />  List.ListTypeEnum.Number Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</small>


Render as numbered list. Each item contains &quot;Term&quot; in bold and &quot;Description&quot; (separated by dash). Both parts are optional.



```csharp
 Number = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum.table__s1bzk3" />  List.ListTypeEnum.Table Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.XmlDocumentation](#n-net.adamec.dev.markupdoc.xmldocumentation__1ter1y6)           
Assembly: MarkupDoc           
Type: [List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</small>


Render as two column table (term and description). Header item should be provided to define the table header (&quot;Term&quot; and &quot;Description&quot; are used as defaults)



```csharp
 Table = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.List.ListTypeEnum](#t-net.adamec.dev.markupdoc.xmldocumentation.list.listtypeenum__455725)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


