#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc" />  net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages Namespace ##
###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc) | public | Output generator add-on for documenting the source-only packages | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc" />  SourceOnlyPackagesAddOn Class ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Output generator add-on for documenting the source-only packages



```csharp
public class SourceOnlyPackagesAddOn : IAddOn
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [net.adamec.dev.markupdoc.AddOns.IAddOn](net.adamec.dev.markupdoc.AddOns__16pxlok.md#t-net.adamec.dev.markupdoc.addons.iaddon__1hardyt)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MembersBySourceOnlyPackage](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.membersbysourceonlypackage__1adzoi3) | public | Dictionary of members by source-only package | 
 | [OutputOptions](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.outputoptions__m9qdcv) | public | Output configuration | 
 | [PriorityIndexPage](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityindexpage__cb2qij) | public | Add-on priority for generating the add-on output to the (main) index page. SourceOnlyPackagesAddOn priority is 1 | 
 | [PriorityOwnPages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityownpages__1oy009u) | public | Add-on priority for generating the add-on output pages. SourceOnlyPackagesAddOn priority is 1 | 
 | [PriorityPageBody](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagebody__16j72yl) | public | Add-on priority for generating the add-on output to header of code model member page body. SourceOnlyPackagesAddOn priority is 0, so no output will be generator to member page body | 
 | [PriorityPageFooter](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagefooter__fitshq) | public | Add-on priority for generating the add-on output to header of code model member page footer. SourceOnlyPackagesAddOn priority is 1 | 
 | [PriorityPageHeader](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypageheader__1mg3vbo) | public | Add-on priority for generating the add-on output to header of code model member page header. SourceOnlyPackagesAddOn priority is 1 | 
 | [PriorityRootData](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityrootdata__2mehaa) | public | Add-on priority for processing the add-on data as a part of [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) constructor. SourceOnlyPackagesAddOn priority is 1 | 
 | [SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.sourceonlypackages__1f513zg) | public | List of source-only packages&#39; properties | 
 | [SourceOnlyPackagesByMember](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.sourceonlypackagesbymember__1r7c7w7) | public | Dictionary of source-only packages by member | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SourceOnlyPackagesAddOn(OutputOptions)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.-ctor_net.adamec.dev.markupdoc.options.outputoptions___1q1qldr) | public | CTOR - initialize add-on | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetPackageAnchor(NuProps)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackageanchor_net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops___1yt89gd) | private | Returns the anchor for given <em>package</em> within the package page(s) file. | 
 | [GetPackagePageFileName(NuProps)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackagepagefilename_net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops___1qi6ozu) | private | Returns the name of the generated file (without extension) for <em>package</em> when the split by type is set, so the all package pages are generated into dedicated files. | 
 | [GetPackagePagesFileName()](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackagepagesfilename__mn773q) | private | Returns the name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into single file. | 
 | [Link(string, NuProps, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.link_system.string-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops-net.adamec.dev.markupdoc.markup.imarkupprovider___l32orz) | private | Creates the link to the <em>package</em> page | 
 | [ProcessRootData(RootMember, RootMemberBuilder)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.processrootdata_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___1p5upxv) | public | Let the add-on to prepare it&#39;s own data as a part of [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) constructor. | 
 | [WriteIndexAsync(RootMember, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writeindexasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider___o6kmu1) | public | Writes the table of all source-only packages within the code model into the output | 
 | [WriteOwnPagesAsync(RootMember, IMarkupProvider, MarkupGenerator)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writeownpagesasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.markup.markupgenerator___1vx2jwv) | public | Writes the source-only packages pages into the output | 
 | [WritePageBodyAsync(Member, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepagebodyasync_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1dohgqa) | public | Writes the body fro the code model member | 
 | [WritePageFooter(string, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepagefooter_system.string-net.adamec.dev.markupdoc.markup.imarkupprovider___1lzl24g) | public | Writes to the footer for the code model member page | 
 | [WritePageHeader(Member, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepageheader_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1jqz5xb) | public | Writes the header for the code model member | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.membersbysourceonlypackage__1adzoi3" />  SourceOnlyPackagesAddOn.MembersBySourceOnlyPackage Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Dictionary of members by source-only package



```csharp
public IReadOnlyDictionary<net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps,List<net.adamec.dev.markupdoc.CodeModel.Member>> MembersBySourceOnlyPackage { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps,List&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.outputoptions__m9qdcv" />  SourceOnlyPackagesAddOn.OutputOptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Output configuration



```csharp
public OutputOptions OutputOptions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityindexpage__cb2qij" />  SourceOnlyPackagesAddOn.PriorityIndexPage Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for generating the add-on output to the (main) index page. SourceOnlyPackagesAddOn priority is 1



```csharp
public int PriorityIndexPage { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityIndexPage](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.priorityindexpage__fkoqdy)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityownpages__1oy009u" />  SourceOnlyPackagesAddOn.PriorityOwnPages Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for generating the add-on output pages. SourceOnlyPackagesAddOn priority is 1



```csharp
public int PriorityOwnPages { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityOwnPages](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.priorityownpages__1169buv)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagebody__16j72yl" />  SourceOnlyPackagesAddOn.PriorityPageBody Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for generating the add-on output to header of code model member page body. SourceOnlyPackagesAddOn priority is 0, so no output will be generator to member page body



```csharp
public int PriorityPageBody { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityPageBody](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.prioritypagebody__18im5wk)


###  Remarks ###
[WritePageBodyAsync(Member, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepagebodyasync_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1dohgqa) method is used as a sample only. It&#39;s not called as the [PriorityPageBody](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagebody__16j72yl) is zero


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagefooter__fitshq" />  SourceOnlyPackagesAddOn.PriorityPageFooter Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for generating the add-on output to header of code model member page footer. SourceOnlyPackagesAddOn priority is 1



```csharp
public int PriorityPageFooter { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityPageFooter](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.prioritypagefooter__1l39gdz)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypageheader__1mg3vbo" />  SourceOnlyPackagesAddOn.PriorityPageHeader Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for generating the add-on output to header of code model member page header. SourceOnlyPackagesAddOn priority is 1



```csharp
public int PriorityPageHeader { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityPageHeader](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.prioritypageheader__szfdw1)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.priorityrootdata__2mehaa" />  SourceOnlyPackagesAddOn.PriorityRootData Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Add-on priority for processing the add-on data as a part of [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) constructor. SourceOnlyPackagesAddOn priority is 1



```csharp
public int PriorityRootData { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>Implements: [IAddOn.PriorityRootData](net.adamec.dev.markupdoc.AddOns__16pxlok.md#p-net.adamec.dev.markupdoc.addons.iaddon.priorityrootdata__4lkjzb)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.sourceonlypackages__1f513zg" />  SourceOnlyPackagesAddOn.SourceOnlyPackages Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


List of source-only packages&#39; properties



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps> SourceOnlyPackages { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.sourceonlypackagesbymember__1r7c7w7" />  SourceOnlyPackagesAddOn.SourceOnlyPackagesByMember Property ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Dictionary of source-only packages by member



```csharp
public IReadOnlyDictionary<net.adamec.dev.markupdoc.CodeModel.Member,List<net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps>> SourceOnlyPackagesByMember { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;net.adamec.dev.markupdoc.CodeModel.Member,List&lt;net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.-ctor_net.adamec.dev.markupdoc.options.outputoptions___1q1qldr" />  SourceOnlyPackagesAddOn.SourceOnlyPackagesAddOn(OutputOptions) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


CTOR - initialize add-on



```csharp
public SourceOnlyPackagesAddOn(OutputOptions outputOptions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) <strong>outputOptions</strong></dt><dd>Output options</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackageanchor_net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops___1yt89gd" />  SourceOnlyPackagesAddOn.GetPackageAnchor(NuProps) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Returns the anchor for given <em>package</em> within the package page(s) file.



```csharp
private string GetPackageAnchor(NuProps package)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) <strong>package</strong></dt><dd>Package metadata</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Anchor for given <em>package</em> within the package page(s) file</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackagepagefilename_net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops___1qi6ozu" />  SourceOnlyPackagesAddOn.GetPackagePageFileName(NuProps) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Returns the name of the generated file (without extension) for <em>package</em> when the split by type is set, so the all package pages are generated into dedicated files.



```csharp
private string GetPackagePageFileName(NuProps package)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) <strong>package</strong></dt><dd>Package metadata</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into dedicated files</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.getpackagepagesfilename__mn773q" />  SourceOnlyPackagesAddOn.GetPackagePagesFileName() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Returns the name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into single file.



```csharp
private string GetPackagePagesFileName()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The name of the generated file (without extension) when the split by namespace is set, so the all package pages are generated into single file</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.link_system.string-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops-net.adamec.dev.markupdoc.markup.imarkupprovider___l32orz" />  SourceOnlyPackagesAddOn.Link(string, NuProps, IMarkupProvider) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Creates the link to the <em>package</em> page



```csharp
private string Link(string text, NuProps package, IMarkupProvider markup)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Link text</dd><dt>[net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model.NuProps](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages.Model__gb4dfb.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.model.nuprops__4yj5ni) <strong>package</strong></dt><dd>Package metadata</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Markup with the link to the</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.processrootdata_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___1p5upxv" />  SourceOnlyPackagesAddOn.ProcessRootData(RootMember, RootMemberBuilder) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Let the add-on to prepare it&#39;s own data as a part of [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) constructor.



```csharp
public void ProcessRootData(RootMember root, RootMemberBuilder builder)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) <strong>root</strong></dt><dd>Code model root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>builder</strong></dt><dd>Code model buildel root</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: [IAddOn.ProcessRootData(RootMember, RootMemberBuilder)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.processrootdata_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___1jgzllk)


###  Remarks ###
The add-on checks all compilation files for the &lt;NuProp.xxx&gt; comments with source-only package metadata and builds the list of source-only packages and the indexes between the packages and code model members.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writeindexasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider___o6kmu1" />  SourceOnlyPackagesAddOn.WriteIndexAsync(RootMember, IMarkupProvider) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Writes the table of all source-only packages within the code model into the output



```csharp
public async Task<bool> WriteIndexAsync(RootMember root, IMarkupProvider markup)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) <strong>root</strong></dt><dd>Code model root</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;bool&gt;</a></dt><dd>True when any output has been generated</dd></dl>Implements: [IAddOn.WriteIndexAsync(RootMember, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.writeindexasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider___14kxt04)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writeownpagesasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.markup.markupgenerator___1vx2jwv" />  SourceOnlyPackagesAddOn.WriteOwnPagesAsync(RootMember, IMarkupProvider, MarkupGenerator) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Writes the source-only packages pages into the output



```csharp
public async Task WriteOwnPagesAsync(RootMember root, IMarkupProvider markup, MarkupGenerator generator)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) <strong>root</strong></dt><dd>Code model root</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd><dt>[net.adamec.dev.markupdoc.Markup.MarkupGenerator](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.markupgenerator__t0fm36) <strong>generator</strong></dt><dd>Markup generator</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>Implements: [IAddOn.WriteOwnPagesAsync(RootMember, IMarkupProvider, MarkupGenerator)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.writeownpagesasync_net.adamec.dev.markupdoc.codemodel.rootmember-net.adamec.dev.markupdoc.markup.imarkupprovider-net.adamec.dev.markupdoc.markup.markupgenerator___ybiauk)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepagebodyasync_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1dohgqa" />  SourceOnlyPackagesAddOn.WritePageBodyAsync(Member, IMarkupProvider) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Writes the body fro the code model member



```csharp
public async Task WritePageBodyAsync(Member member, IMarkupProvider markup)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member being documented</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>Implements: [IAddOn.WritePageBodyAsync(Member, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.writepagebodyasync_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___2dwln1)


###  Remarks ###
This method is used as a sample only. It&#39;s not called as the [PriorityPageBody](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#p-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.prioritypagebody__16j72yl) is zero


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepagefooter_system.string-net.adamec.dev.markupdoc.markup.imarkupprovider___1lzl24g" />  SourceOnlyPackagesAddOn.WritePageFooter(string, IMarkupProvider) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Writes to the footer for the code model member page



```csharp
public string WritePageFooter(string baseFileName, IMarkupProvider markup)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>baseFileName</strong></dt><dd>Name of the main file</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String to be added to the footer</dd></dl>Implements: [IAddOn.WritePageFooter(string, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.writepagefooter_system.string-net.adamec.dev.markupdoc.markup.imarkupprovider___osl86z)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon.writepageheader_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1jqz5xb" />  SourceOnlyPackagesAddOn.WritePageHeader(Member, IMarkupProvider) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#n-net.adamec.dev.markupdoc.addons.sourceonlypackages__vacqgc)           
Assembly: MarkupDoc           
Type: [SourceOnlyPackagesAddOn](net.adamec.dev.markupdoc.AddOns.SourceOnlyPackages__vacqgc.md#t-net.adamec.dev.markupdoc.addons.sourceonlypackages.sourceonlypackagesaddon__1yu43nc)           
Sources: AddOns\SourceOnlyPackages\SourceOnlyPackagesAddOn.cs</small>


Writes the header for the code model member



```csharp
public string WritePageHeader(Member member, IMarkupProvider markup)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) <strong>member</strong></dt><dd>Member being documented</dd><dt>[net.adamec.dev.markupdoc.Markup.IMarkupProvider](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.imarkupprovider__kb3njr) <strong>markup</strong></dt><dd>Markup provider</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String to be added to the header text builder</dd></dl>Implements: [IAddOn.WritePageHeader(Member, IMarkupProvider)](net.adamec.dev.markupdoc.AddOns__16pxlok.md#m-net.adamec.dev.markupdoc.addons.iaddon.writepageheader_net.adamec.dev.markupdoc.codemodel.member-net.adamec.dev.markupdoc.markup.imarkupprovider___1ml9iti)


###  Remarks ###
Writes source-only packages list if available


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



