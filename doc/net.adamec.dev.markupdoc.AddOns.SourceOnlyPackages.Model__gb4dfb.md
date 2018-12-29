#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb" />  net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) | public | Metadata defining the source-only NuGet packages generated from the source code using the customized build process | 
 | [NuProps.NuPropUsing](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing__oshg6w) | public | Metadata from &lt;NuProp.Using id = &quot;&quot; version=&quot;&quot;/&gt; XML documentation comment | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg) | public | Definition of the additional files to include into the source-only package | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni" />  NuProps Class ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Metadata defining the source-only NuGet packages generated from the source code using the customized build process



```csharp
public class NuProps
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Source-only NuGet packages contain just the source code that is added to the project the package is added to. The package is created from the (partial) class or classes in the project folder based on the metadata provided as special XML Documentation Comments. 


 - <strong>&lt;NuProp.Id&gt;&lt;/NuProp.Id&gt;</strong> - package ID (mandatory)
 - <strong>&lt;NuProp.Version&gt;&lt;/NuProp.Version&gt;</strong> - package version base (major.minor.patch) - optional
 - <strong>&lt;NuProp.Description&gt;&lt;/NuProp.Description&gt;</strong> - package description (optional)
 - <strong>&lt;NuProp.Tags&gt;&lt;/NuProp.Tags&gt;</strong> - package tags (optional)
 - <strong>&lt;NuProp.Includes type = &quot;&quot;  /&gt;</strong> - file includes (optional). If type=&quot;Folder&quot;, the package will include all compile files in folder, if type=&quot;FolderRecursive&quot; the subfolders will be also included
 - <strong>&lt;NuProp.Using id = &quot;&quot; version=&quot;&quot;/&gt;</strong> - package imports (optional). Version is optional
 - <strong>&lt;NuProp.Needs id=&quot;&quot; /&gt;</strong> - &quot;external&quot; imports needed (optional) - not included in package, just info when consuming!!!
           





###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DeclaringFile](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.declaringfile__11s348v) | public | Full path to the file declaring the source-only package (containing the package metadata as &lt;NuProp.xxxx/&gt; XML documentation comments | 
 | [ExternalReferences](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.externalreferences__1cpn3h1) | public | List of external references (NuGet package dependencies) that are not declared in the package, but the consumer has to include | 
 | [HasNuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.hasnuprops__17gaag3) | public | Master flag whether the [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) class containts the valid metadata for source-only package | 
 | [IncludesType](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestype__zb9t6r) | public | Definition of the additional files to include into the source-only package | 
 | [PackageDescription](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagedescription__o0pb0m) | public | Optional description of the package | 
 | [PackageFiles](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagefiles__deuupz) | public | List of all files to be included into the source-only package | 
 | [PackageId](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packageid__4tnxdb) | public | Unique ID of the package | 
 | [PackageTags](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagetags__ioqk03) | public | Optional package tags divided by space | 
 | [PackageVersion](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packageversion__fcxdho) | public | Optional version of the package. | 
 | [Usings](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.usings__f9kpil) | public | List of the dependencied that are to be declared within the package | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NuProps(string, IReadOnlyCollection&lt;string&gt;)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.-ctor_system.string-system.collections.generic.ireadonlycollection_system.string____c21w85) | public | CTOR - Checks the compilation file with given <strong>fileName</strong> for the source-only package metadata. When the metadata are present and valid, the [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) object is initialized and [HasNuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.hasnuprops__17gaag3) property is set to true | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.declaringfile__11s348v" />  NuProps.DeclaringFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Full path to the file declaring the source-only package (containing the package metadata as &lt;NuProp.xxxx/&gt; XML documentation comments



```csharp
public string DeclaringFile { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.externalreferences__1cpn3h1" />  NuProps.ExternalReferences Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


List of external references (NuGet package dependencies) that are not declared in the package, but the consumer has to include



```csharp
public IReadOnlyList<string> ExternalReferences { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.hasnuprops__17gaag3" />  NuProps.HasNuProps Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Master flag whether the [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) class containts the valid metadata for source-only package



```csharp
public bool HasNuProps { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestype__zb9t6r" />  NuProps.IncludesType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Definition of the additional files to include into the source-only package



```csharp
public NuProps.IncludesTypeEnum IncludesType { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagedescription__o0pb0m" />  NuProps.PackageDescription Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Optional description of the package



```csharp
public string PackageDescription { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
If not defined, the custom build process uses the default generic description


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagefiles__deuupz" />  NuProps.PackageFiles Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


List of all files to be included into the source-only package



```csharp
public IReadOnlyList<string> PackageFiles { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packageid__4tnxdb" />  NuProps.PackageId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Unique ID of the package



```csharp
public string PackageId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packagetags__ioqk03" />  NuProps.PackageTags Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Optional package tags divided by space



```csharp
public string PackageTags { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.packageversion__fcxdho" />  NuProps.PackageVersion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Optional version of the package.



```csharp
public string PackageVersion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
If not defined, the custom build process uses the solution version information


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.usings__f9kpil" />  NuProps.Usings Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


List of the dependencied that are to be declared within the package



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.NuPropUsing> Usings { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.NuPropUsing&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.-ctor_system.string-system.collections.generic.ireadonlycollection_system.string____c21w85" />  NuProps.NuProps(string, IReadOnlyCollection&lt;string&gt;) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


CTOR - Checks the compilation file with given <strong>fileName</strong> for the source-only package metadata. When the metadata are present and valid, the [NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) object is initialized and [HasNuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.hasnuprops__17gaag3) property is set to true



```csharp
public NuProps(string fileName, IReadOnlyCollection<string> allFiles)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Full path to the compliation file</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlycollection-1" target="_blank" >IReadOnlyCollection&lt;string&gt;</a> <strong>allFiles</strong></dt><dd>List of all files in compilation, used to resolve the includes (Folder, FolderRecursive) when needed</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing__oshg6w" />  NuProps.NuPropUsing Class ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Metadata from &lt;NuProp.Using id = &quot;&quot; version=&quot;&quot;/&gt; XML documentation comment



```csharp
public class NuProps.NuPropUsing
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [PackageId](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.packageid__eu5x7p) | public | Unique ID of the package | 
 | [PackageVersion](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.packageversion__1yv6qpe) | public | Optional version of the package | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NuProps.NuPropUsing(string, string)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.-ctor_system.string-system.string___15m1paf) | public | CTOR | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.packageid__eu5x7p" />  NuProps.NuPropUsing.PackageId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.NuPropUsing](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing__oshg6w)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Unique ID of the package



```csharp
public string PackageId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.packageversion__1yv6qpe" />  NuProps.NuPropUsing.PackageVersion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.NuPropUsing](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing__oshg6w)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Optional version of the package



```csharp
public string PackageVersion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing.-ctor_system.string-system.string___15m1paf" />  NuProps.NuPropUsing.NuProps.NuPropUsing(string, string) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.NuPropUsing](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.nupropusing__oshg6w)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


CTOR



```csharp
public NuProps.NuPropUsing(string packageId, string packageVersion)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>packageId</strong></dt><dd>Unique ID of the package</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>packageVersion</strong></dt><dd>Optional version of the package</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg" />  NuProps.IncludesTypeEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Definition of the additional files to include into the source-only package



```csharp
public enum NuProps.IncludesTypeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.none__86bq96) | 0 | Don&#39;t include any other files (only the file defining the source-only package will be included) | 
 | [Folder](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.folder__1fxd0xg) | 1 | Include all compilation files from the same folder where the file defining the source-only package is stored | 
 | [FolderRecursive](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.folderrecursive__b1w9ag) | 2 | Include all compilation files from the same folder where the file defining the source-only package is stored and the subfolders | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.folder__1fxd0xg" />  NuProps.IncludesTypeEnum.Folder Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Include all compilation files from the same folder where the file defining the source-only package is stored



```csharp
 Folder = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.folderrecursive__b1w9ag" />  NuProps.IncludesTypeEnum.FolderRecursive Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Include all compilation files from the same folder where the file defining the source-only package is stored and the subfolders



```csharp
 FolderRecursive = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum.none__86bq96" />  NuProps.IncludesTypeEnum.None Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages.model__gb4dfb)           
Assembly: MarkupDoc           
Type: [NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)           
Sources: AddOns\SourceOnlyPackages\Model\NuProps.cs</small>


Don&#39;t include any other files (only the file defining the source-only package will be included)



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps.IncludesTypeEnum](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops.includestypeenum__10jptjg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



