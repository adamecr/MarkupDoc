#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc__1d9f9qh" />  net.adamec.dev.markupdoc Namespace ##
Main application namespace. Contains [Program](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.program__cagybt) and [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn) classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn) | public | Main application class - encapsulates the documentation building logic | 
 | [Program](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.program__cagybt) | internal | Main program entry class | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.application__s1pcmn" />  Application Class ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Sources: Application.cs</small>


Main application class - encapsulates the documentation building logic



```csharp
public class Application
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [OutputOptions](net.adamec.dev.markupdoc__1d9f9qh.md#p-net.adamec.dev.markupdoc.application.outputoptions__66qbpi) | public | Output configuration | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Application(OutputOptions)](net.adamec.dev.markupdoc__1d9f9qh.md#m-net.adamec.dev.markupdoc.application.-ctor_net.adamec.dev.markupdoc.options.outputoptions___7a5mu0) | public | CTOR with output configuration | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetAddOns()](net.adamec.dev.markupdoc__1d9f9qh.md#m-net.adamec.dev.markupdoc.application.getaddons__koi41d) | protected | Initialize add-ons | 
 | [RunAsync(string)](net.adamec.dev.markupdoc__1d9f9qh.md#m-net.adamec.dev.markupdoc.application.runasync_system.string___1ym8d3g) | public | Runs the documentation building logic | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.application.outputoptions__66qbpi" />  Application.OutputOptions Property ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn)           
Sources: Application.cs</small>


Output configuration



```csharp
public OutputOptions OutputOptions { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.application.-ctor_net.adamec.dev.markupdoc.options.outputoptions___7a5mu0" />  Application.Application(OutputOptions) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn)           
Sources: Application.cs</small>


CTOR with output configuration



```csharp
public Application(OutputOptions outputOptions)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Options.OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) <strong>outputOptions</strong></dt><dd>Output configuration</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.application.getaddons__koi41d" />  Application.GetAddOns() Method ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn)           
Sources: Application.cs</small>


Initialize add-ons



```csharp
protected virtual IEnumerable<net.adamec.dev.markupdoc.AddOns.IAddOn> GetAddOns()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;</a></dt><dd>List of add-ons to be used</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.application.runasync_system.string___1ym8d3g" />  Application.RunAsync(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Application](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.application__s1pcmn)           
Sources: Application.cs</small>


Runs the documentation building logic



```csharp
public async Task RunAsync(string projectFile)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>projectFile</strong></dt><dd>Project file of C# project to build the documentation for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task" target="_blank" >System.Threading.Tasks.Task</a></dt><dd>Async task</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.program__cagybt" />  Program Class ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Sources: Program.cs</small>


Main program entry class



```csharp
internal class Program
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [DefaultConfigFile](net.adamec.dev.markupdoc__1d9f9qh.md#f-net.adamec.dev.markupdoc.program.defaultconfigfile__1hwhxfi) | markupdoc.json | Default configuration file name | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Help()](net.adamec.dev.markupdoc__1d9f9qh.md#m-net.adamec.dev.markupdoc.program.help__hbeo67) | public static | Writes the help to console | 
 | [Main(string[])](net.adamec.dev.markupdoc__1d9f9qh.md#m-net.adamec.dev.markupdoc.program.main_system.string_____1nu6hy8) | private static | Main console application entry point | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.program.defaultconfigfile__1hwhxfi" />  Program.DefaultConfigFile Constant ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.program__cagybt)           
Sources: Program.cs</small>


Default configuration file name



```csharp
private const string DefaultConfigFile = "markupdoc.json"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.program.help__hbeo67" />  Program.Help() Method ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.program__cagybt)           
Sources: Program.cs</small>


Writes the help to console



```csharp
public static void Help()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.program.main_system.string_____1nu6hy8" />  Program.Main(string[]) Method ##
<small>Namespace: [net.adamec.dev.markupdoc](net.adamec.dev.markupdoc__1d9f9qh.md#n-net.adamec.dev.markupdoc__1d9f9qh)           
Assembly: MarkupDoc           
Type: [Program](net.adamec.dev.markupdoc__1d9f9qh.md#t-net.adamec.dev.markupdoc.program__cagybt)           
Sources: Program.cs</small>


Main console application entry point



```csharp
private static async Task<int> Main(string[] args)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>args</strong></dt><dd>Command line arguments</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;int&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



