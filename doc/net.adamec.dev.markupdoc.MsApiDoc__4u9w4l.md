#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.msapidoc__4u9w4l" />  net.adamec.dev.markupdoc.MsApiDoc Namespace ##
MS online API links helper classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | public | Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members. | 
 | [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn) | public | Configuration class for [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx" />  MsApiDocEngine Class ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


Provides the links to MS API browser (https://docs.microsoft.com/en-us/dotnet/api/) for .NET API types and their members.



```csharp
public class MsApiDocEngine
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
The Roslyn compiler uses the member ID in <em>Microsoft.CodeAnalysis.ISymbol.GetDocumentationCommentId</em> , (even if there is no documentation), so it&#39;s possible to use such ID as member identifier for types, properties, methods, etc. Method [ReadLocalDoc()](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5) uses  the local clone of .NET API documentation (https://github.com/dotnet/dotnet-api-docs) and checks for the framework index file containing the list of available IDs. It generates the links for each ID and store it in the internal dictionary(ID,link) telling &quot;these IDs are documented at MS site and these are the links&quot; . The links can be retrieved using the static methods [GetLink(string)](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj) by ID or [GetLink(TypeRef)](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7) by [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) . It checks, whether the ID exists in local MS documentation clone and if positive, it uses the generated link stored in internal dictionary. When the local clone is not available (or it&#39;s use is suppressed), the engine will try to build the links based on the namespace and name of member for limited set of members.

 Note: The links are created based on the &quot;observation&quot; how they are composed at the MS API site, so it&#39;s best effort approach and the links are not granted to be hundred percent correct. Also the API Browser don&#39;t have the pages/anchors for constants (including the enum items), so the generated links will not work in this case.

 The behavior of engine can be configured using the [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn) configuration class

 To get the best results, clone the .NET API documentation from https://github.com/dotnet/dotnet-api-docs to local directory. And configure the engine

 


 - <strong>LinkToApi</strong> - Set to `true` , to allow the links to MS Api (if false, no links will be created at all)
 - <strong>ApiBaseUrl</strong> - It&#39;s set to https://docs.microsoft.com/en-us/dotnet/api/. As far as there is no change at MS side, no need to configure. Note: The URL must end with &quot;/&quot;.
 - <strong>RequireLocalDoc</strong> - Set to `true` to minimize the false links. Note: set to `false` allowing the engine to try to create the links even if not found in local documentation
 - <strong>LocalDocDir</strong> - Path to the local clone of MS documentation (directory must contain `xml\FrameworksIndex` subdirectory
           





###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseUrl](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.baseurl__mfwodh) | public static |  | 
 | [IdToLinkDictionary](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionary__ij5vc1) | public static | ID to Link read-only dictionary for items read from local clone of MS .NET API documentation | 
 | [IdToLinkDictionaryPrivate](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionaryprivate__1qh58ay) | private static | Internal ID to Link dictionary for items read from local clone of MS .NET API documentation | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetLink(string)](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj) | public static | Retrieves the link to MS API online documentation based on the member <strong>id</strong> (documentation ID) | 
 | [GetLink(TypeRef)](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7) | public static | Retrieves the link to MS API online documentation based on the <strong>typeRef</strong> . | 
 | [ReadLocalDoc()](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5) | public static | Reads the local clone of MS .NET API documentation and builds the internal dictionary of member IDs and links to MS online API documentation | 
 | [TypeMemberBaseName(string)](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.typememberbasename_system.string___1akr6b7) | private static | Extracts the base name for the type member. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.baseurl__mfwodh" />  MsApiDocEngine.BaseUrl Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>



```csharp
public static string BaseUrl { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionary__ij5vc1" />  MsApiDocEngine.IdToLinkDictionary Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


ID to Link read-only dictionary for items read from local clone of MS .NET API documentation



```csharp
public static IReadOnlyDictionary<string,string> IdToLinkDictionary { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocengine.idtolinkdictionaryprivate__1qh58ay" />  MsApiDocEngine.IdToLinkDictionaryPrivate Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


Internal ID to Link dictionary for items read from local clone of MS .NET API documentation



```csharp
private static Dictionary<string,string> IdToLinkDictionaryPrivate { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_system.string___c42uyj" />  MsApiDocEngine.GetLink(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


Retrieves the link to MS API online documentation based on the member <strong>id</strong> (documentation ID)



```csharp
public static string GetLink(string id)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>id</strong></dt><dd>Member (type, method, property, etc.) ID as used in documentation comments</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.getlink_net.adamec.dev.markupdoc.codemodel.typeref___iigjs7" />  MsApiDocEngine.GetLink(TypeRef) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


Retrieves the link to MS API online documentation based on the <strong>typeRef</strong> .



```csharp
public static string GetLink(TypeRef typeRef)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) <strong>typeRef</strong></dt><dd>Type reference to get the link for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The link to online MS documentation when the link is available and such links are allowed in configuration. Otherwise, return null</dd></dl>


###  Remarks ###
As the query is based on the [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) , it&#39;s applicable to types only (the meaning of &quot;type&quot; includes interfaces, structures, delegates, etc.). In this case, the links can be also created based on the namespace and name when the local doc is not available or the item has not been found  in the internal dictionary. This can be suppressed by setting the configuration option `RequireLocalDoc` to true.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.readlocaldoc__ned6d5" />  MsApiDocEngine.ReadLocalDoc() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


Reads the local clone of MS .NET API documentation and builds the internal dictionary of member IDs and links to MS online API documentation



```csharp
public static bool ReadLocalDoc()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>True when the local documentation has been read, otherwise false (the errors are &quot;soft&quot; - provided to console standard output as warnings)</dd></dl>


###  Remarks ###
Path to the local clone od MS documentation is taken from configuration [LocalDocDir](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f) . Directory must contain `xml\FrameworksIndex` subdirectory. This directory contains the indexes for different frameworks (.NET frameworks, .NET standard, ...). For the simplicity, the biggest index (XML) file is used as a source. The index file contains records like 
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
 The method gets all type and (type) member ID and generates the links for them. The links are created based on the &quot;observation&quot; how they are composed at the MS API site, so it&#39;s best effort approach and the links are not granted to be hundred percent correct. The base URL is set in [ApiBaseUrl](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) (the base URL must end with &quot;/&quot;).


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.msapidoc.msapidocengine.typememberbasename_system.string___1akr6b7" />  MsApiDocEngine.TypeMemberBaseName(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)           
Sources: MsApiDoc\MsApiDocEngine.cs</small>


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
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Sources: MsApiDoc\MsApiDocOptions.cs</small>


Configuration class for [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx)



```csharp
public class MsApiDocOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ApiBaseUrl](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) | public | Base URL of MS .NET API Browser (must end with &quot;/&quot;) If [LinkToApi](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) is set, missing [ApiBaseUrl](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) throws the exception while building the link | 
 | [LinkToApi](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) | public | Flag whether to generate the links to MS .NET API Browser | 
 | [LocalDocDir](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f) | public | Local clone of .NET API Documentation root directory | 
 | [RequireLocalDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.requirelocaldoc__10og155) | public | Flag whether to build the links based on the local close of .NET API Documentation only. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb" />  MsApiDocOptions.ApiBaseUrl Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)           
Sources: MsApiDoc\MsApiDocOptions.cs</small>


Base URL of MS .NET API Browser (must end with &quot;/&quot;) If [LinkToApi](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4) is set, missing [ApiBaseUrl](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.apibaseurl__p6wemb) throws the exception while building the link



```csharp
public string ApiBaseUrl { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.linktoapi__1tvqqu4" />  MsApiDocOptions.LinkToApi Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)           
Sources: MsApiDoc\MsApiDocOptions.cs</small>


Flag whether to generate the links to MS .NET API Browser



```csharp
public bool LinkToApi { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.localdocdir__1lcfz8f" />  MsApiDocOptions.LocalDocDir Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)           
Sources: MsApiDoc\MsApiDocOptions.cs</small>


Local clone of .NET API Documentation root directory



```csharp
public string LocalDocDir { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.msapidoc.msapidocoptions.requirelocaldoc__10og155" />  MsApiDocOptions.RequireLocalDoc Property ##
<small>Namespace: [net.adamec.dev.markupdoc.MsApiDoc](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#n-net.adamec.dev.markupdoc.msapidoc__4u9w4l)           
Assembly: MarkupDoc           
Type: [MsApiDocOptions](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocoptions__19hrssn)           
Sources: MsApiDoc\MsApiDocOptions.cs</small>


Flag whether to build the links based on the local close of .NET API Documentation only.



```csharp
public bool RequireLocalDoc { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


###  Remarks ###
If not set (is false), [MsApiDocEngine](net.adamec.dev.markupdoc.MsApiDoc__4u9w4l.md#t-net.adamec.dev.markupdoc.msapidoc.msapidocengine__kprqgx) will try to build the links for [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) , the links based on documentation ID will not be created

 Note: This will not suppress reading/using the links based on the local clone of the documentation, just the &quot;fallback&quot; will be disabled




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



