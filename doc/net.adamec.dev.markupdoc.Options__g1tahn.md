#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.options__g1tahn" />  net.adamec.dev.markupdoc.Options Namespace ##
Configuration container and output options classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) | public | Singleton holding the application configuration (options) | 
 | [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) | public | Configuration builder providing the methods for adding the configuration items from individual sources | 
 | [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6) | public | Output configuration | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.options.configuration__110r0mb" />  Configuration Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Sources: Options\Configuration.cs</small>


Singleton holding the application configuration (options)



```csharp
public sealed class Configuration
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
This is the simple configuration container in case DI with more sophisticated containers is not used The configuration is stored as the key-value dictionary, supporting hierarchy using the dot separator and arrays.The arrays can contain values or another objects. Actually, mixed arrays of values and objects can be stored, but they are not supported for binding. For example `section1.option1` means the option1 available in section1, `section1.subSection2.option1` means the option1 available in section1.subSection2. `section1.option1[0]` means, that the option1 is array of values or objects (sections) within the section1. For arrays, the keys are like `OtherSection.SimpleArray[0]` or `OtherSection.ComplexObjectArray[0].Name`

 [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) class provides a singleton instance, however the key functionality is provided via static functions, so no need to touch the [Instance](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) at all. The items can be retrieved by key using the [Get(string)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h) and [Get&lt;TValueType&gt;(string, Configuration.TValueType)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho) methods. The first one returns null when the key is not found, the other one allow to define the default value to be returned, when the item is not found.

 The inner class [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) provides the methods to build the configuration from JSON config files, commandline arguments, environment values and/or direct entries. The static method [Builder()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x) clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) allowing to build a configuration from scratch. The configuration is updated directly during the calls to builder methods, the existing items (keys) are updated, so it&#39;s possible to manage the priority of individual sources and the overrides if needed. The method [Build()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt) returns the configuration instance, breaking the fluent design of builder methods, however there is no other functionality within the method, so it&#39;s more the convention than need to use it at the end of configuration build.

 Configuration binding it the way, how to access the configuration using the configuration objects instead of querying the individual items by key. When the method [Bind&lt;TOptionsContainer&gt;(string, bool)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) is used, it creates a new instance of given type and tries to map the public properties with public setter to the keys (using the &quot;dot notation&quot;) within the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . It&#39;s possible to bind the object to  to the root  of the configuration to provide the whole configuration at once or bind it to the particular section to provide a configuration sub-tree. In general, the nested objects and both value and object arrays are supported. There are some rules when binding the arrays: The index must start with zero and must be in sequence (the first non-existing index stops the evaluation). The array should not mix the array or values and array of objects. The decision is made at the first item (index=0) whether it&#39;s value or object.

 The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true. This is useful when the command line arguments are used like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.

 As the binding uses the reflection, it&#39;s quite expensive operation, so by default, the bound objects are cached (the cache key is the type of bound object, so binding the same type to different sections is not recommended ). It&#39;s possible to force the binding using the parameter of [Bind&lt;TOptionsContainer&gt;(string, bool)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) method. In general, the recommended pattern is to [Bind&lt;TOptionsContainer&gt;(string, bool)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) the configuration  object after the configuration is built and then [Retrieve&lt;TOptionsContainer&gt;()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) it from the cache when needed.




###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [bindingsCache](net.adamec.dev.markupdoc.Options__g1tahn.md#f-net.adamec.dev.markupdoc.options.configuration.bindingscache__oj0pqx) | private | Cache for bindings. Dictionary of type bound as a key and the bound object as value. | 
 | [instance](net.adamec.dev.markupdoc.Options__g1tahn.md#f-net.adamec.dev.markupdoc.options.configuration.instance__5kocls) | private static | Instance of the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) created when the singleton is first touched | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Instance](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) | public static | Public [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) instance | 
 | [Items](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.configuration.items__10m50f7) | private | Configuration items stored as key-value pairs | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Configuration()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.-cctor__1angiqa) | private static | Static constructor | 
 | [Configuration()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.-ctor__12l16zd) | private | Private constructor used to build the singleton instance | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddOrUpdateItem(string, object)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.addorupdateitem_system.string-system.object___gf6021) | private | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [Bind(Type, string)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.bind_system.type-system.string___y5tird) | private static | Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible. | 
 | [Bind&lt;TOptionsContainer&gt;(string, bool)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6) | public static | Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) | 
 | [Builder()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x) | public static | Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc) | 
 | [Get(string)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h) | public static | Gets the configuration item by <strong>key</strong> | 
 | [Get&lt;TValueType&gt;(string, Configuration.TValueType)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho) | public static | Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned. | 
 | [GetSection(string)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.getsection_system.string___h5pqqc) | private static | Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned. | 
 | [Retrieve&lt;TOptionsContainer&gt;()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n) | public static | Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache | 
 | [TryConvertValue(Type, object, object)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.tryconvertvalue_system.type-system.object-system.object-___1em2of1) | private static | Tries to convert <strong>sourceValue</strong> to <strong>targetType</strong> . The converted values is returned in <strong>targetValue</strong> out parameter, the result of conversion is the function return value. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.options.configuration.bindingscache__oj0pqx" />  Configuration.bindingsCache Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Cache for bindings. Dictionary of type bound as a key and the bound object as value.



```csharp
private readonly ConcurrentDictionary<System.Type,object> bindingsCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;System.Type,object&gt;</a></dt><dd></dd></dl>


###  Remarks ###
Cache is used to prevent the &quot;expensive&quot; binding operation in case there is no need to refresh the bound configuration object


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.options.configuration.instance__5kocls" />  Configuration.instance Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Instance of the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) created when the singleton is first touched



```csharp
private static readonly Configuration instance
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd></dd></dl>


###  Remarks ###
Not using the auto-property to have better control, when the instance is created


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa" />  Configuration.Instance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Public [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) instance



```csharp
public static Configuration Instance { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.configuration.items__10m50f7" />  Configuration.Items Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Configuration items stored as key-value pairs



```csharp
private ConcurrentDictionary<string,object> Items { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentdictionary-2" target="_blank" >System.Collections.Concurrent.ConcurrentDictionary&lt;string,object&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.-cctor__1angiqa" />  Configuration.Configuration() Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Static constructor



```csharp
private static Configuration()
```

###  Remarks ###
Explicit static constructor to tell C# compiler not to mark type as beforefieldinit


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.-ctor__12l16zd" />  Configuration.Configuration() Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Private constructor used to build the singleton instance



```csharp
private Configuration()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.addorupdateitem_system.string-system.object___gf6021" />  Configuration.AddOrUpdateItem(string, object) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
private void AddOrUpdateItem(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.bind_system.type-system.string___y5tird" />  Configuration.Bind(Type, string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Creates a  new object with given <strong>type</strong> and binds the configuration to its public properties where possible.



```csharp
private static object Bind(Type type, string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.type" target="_blank" >System.Type</a> <strong>type</strong></dt><dd>Type to bind the configuration to</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>The instance of <strong>type</strong> bound to the configuration</dd></dl>


###  Remarks ###
This method doesn&#39;t use the binding cache


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.bind--1_system.string-system.boolean___181qnd6" />  Configuration.Bind&lt;TOptionsContainer&gt;(string, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Binds the configuration to given <strong>TOptionsContainer</strong> type and returns the bound object of such type. The resulting configuration object is stored to the cache and can be later on retrieved using [Retrieve&lt;TOptionsContainer&gt;()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n)



```csharp
public static Configuration.TOptionsContainer Bind<TOptionsContainer>(string sectionName = null, bool allowCached = true) where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type to bind the configuration to</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional section to bind</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>allowCached</strong></dt><dd>True if the cache of bindings can be used to retrieve existing binding with the same <strong>TOptionsContainer</strong> and <strong>sectionName</strong></dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.builder__orgv4x" />  Configuration.Builder() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Clears the configuration items and binding cache and creates a new instance of [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)



```csharp
public static Configuration.ConfigurationBuilder Builder()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The instance of [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.get_system.string___1i40j4h" />  Configuration.Get(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Gets the configuration item by <strong>key</strong>



```csharp
public static object Get(string key)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd>Retrieved configuration item value or null if not found (or the configuration item is null itself)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.get--1_system.string---0___snj5ho" />  Configuration.Get&lt;TValueType&gt;(string, Configuration.TValueType) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Gets the typed configuration item by <strong>key</strong> . Returns the default value, that can be provided or is default to given <strong>TValueType</strong> The function tries to convert the value to <strong>TValueType</strong> using <a href="https://docs.microsoft.com/en-us/dotnet/api/system.convert.changetype#System_Convert_ChangeType_System_Object_System_Type_" target="_blank" >System.Convert.ChangeType(System.Object,System.Type)</a> if the conversion is not successful, the default is returned.



```csharp
public static Configuration.TValueType Get<TValueType>(string key, Configuration.TValueType defaultValue = null)
```

<strong>Type parameters</strong><dl><dt><strong>TValueType</strong></dt><dd>The type the value is to be retrieved in</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Key of the configuration item</dd><dt>net.adamec.dev.markupdoc.Options.Configuration.TValueType <strong>defaultValue</strong></dt><dd>Optional default value to be returned when the value can&#39;t be retrieved of converted</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TValueType</dt><dd>Retrieved configuration item value or <strong>defaultValue</strong> when it can&#39;t be retrieved or converted</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.getsection_system.string___h5pqqc" />  Configuration.GetSection(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Gets the configuration sub-tree that belongs to given section. The keys returned are relative to given section! When the section is not provided, the whole configuration tree is returned.



```csharp
private static Dictionary<string,object> GetSection(string sectionName = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>sectionName</strong></dt><dd>Optional name of the section.</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,object&gt;</a></dt><dd>The configuration items that belong to the section with <strong>sectionName</strong> . The keys in returned dictionary are relative to given section!</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.retrieve--1__nuzv9n" />  Configuration.Retrieve&lt;TOptionsContainer&gt;() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


Retrieves the configuration object of given <strong>TOptionsContainer</strong> that has been bound and cached before. The new instance of <strong>TOptionsContainer</strong> is created when the type not found in cache



```csharp
public static Configuration.TOptionsContainer Retrieve<TOptionsContainer>() where TOptionsContainer: new()
```

<strong>Type parameters</strong><dl><dt><strong>TOptionsContainer</strong></dt><dd>Type of the configuration class to retrieve from cache</dd></dl>
<strong>Return value</strong><dl><dt>net.adamec.dev.markupdoc.Options.Configuration.TOptionsContainer</dt><dd>The instance of <strong>TOptionsContainer</strong> bound to the configuration or a new instance if not found</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.tryconvertvalue_system.type-system.object-system.object-___1em2of1" />  Configuration.TryConvertValue(Type, object, object) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)           
Sources: Options\Configuration.cs</small>


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
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Sources: Options\Configuration.cs</small>


Configuration builder providing the methods for adding the configuration items from individual sources



```csharp
public class Configuration.ConfigurationBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(string, object)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.add_system.string-system.object___c4hvdf) | public | Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists. | 
 | [AddCommandLineArguments(string[])](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addcommandlinearguments_system.string_____1xz90ae) | public | Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated. | 
 | [AddEnvironmentVariables()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addenvironmentvariables__1lp30f0) | public | Adds all environment variables into the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated. | 
 | [AddJsonFile(string, bool, bool)](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___1s8rjnj) | public | Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated. | 
 | [Build()](net.adamec.dev.markupdoc.Options__g1tahn.md#m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt) | public | Finishes the configuration building and returns the [Instance](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.add_system.string-system.object___c4hvdf" />  Configuration.ConfigurationBuilder.Add(string, object) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)           
Sources: Options\Configuration.cs</small>


Add a new configuration item with given <strong>value</strong> or updates its value if the <strong>key</strong> already exists.



```csharp
public Configuration.ConfigurationBuilder Add(string key, object value)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>key</strong></dt><dd>Configuration item key</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>value</strong></dt><dd>The value to be set for the configuration item</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addcommandlinearguments_system.string_____1xz90ae" />  Configuration.ConfigurationBuilder.AddCommandLineArguments(string[]) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)           
Sources: Options\Configuration.cs</small>


Adds the command line arguments starting with <strong>prefixes</strong> into the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddCommandLineArguments(params string[] prefixes)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string[]</a> <strong>prefixes</strong></dt><dd>Optional list of prefixes marking the command line arguments to be the configuration items</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


###  Remarks ###
The command line arguments have the syntax `key=value` (for example `Key1=Option1` or `prefixkey=value` (for example `-p:Key1=Option1` where `-p:` is the prefix). When the prefixes are not provided, all command line arguments are added to the configuration. When the prefixes are provided,the prefix is not a part of the key. The implementation  of binding treats the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> values the special way - if there is no value, but existing key, the value is converted to true, allowing to use the parameters like flags. For example having the argument `-p:SkipStep1` and prefix `-p:` , the binding a bool property `SkipStep1` will set the value of the property to `true` (doesn&#39;t change the configuration item itself). Of course, it&#39;s still possible to use the syntax `-p:SkipStep1=true` or `-p:SkipStep1=false` even in this case.




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addenvironmentvariables__1lp30f0" />  Configuration.ConfigurationBuilder.AddEnvironmentVariables() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)           
Sources: Options\Configuration.cs</small>


Adds all environment variables into the [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) . When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddEnvironmentVariables()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


###  Remarks ###
The name of the environment variable is used as a key to the configuration item. Use the &quot;dot notation&quot; in variable names to support the configuration hierarchy.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.addjsonfile_system.string-system.boolean-system.boolean___1s8rjnj" />  Configuration.ConfigurationBuilder.AddJsonFile(string, bool, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)           
Sources: Options\Configuration.cs</small>


Loads the configuration items from JSON file, keeping the hierarchy of JSON objects (and arrays) When a configuration item exists, the value is updated.



```csharp
public Configuration.ConfigurationBuilder AddJsonFile(string fileName, bool ignoreNullOrEmptyFileName = false, bool ignoreIfNotExist = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>fileName</strong></dt><dd>Name of the JSON file with configuration</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreNullOrEmptyFileName</strong></dt><dd>If true, the missing file name will not throw the exception and the method just &quot;silently&quot; ends.</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>ignoreIfNotExist</strong></dt><dd>If true, the non existing file will not throw the exception and the method just &quot;silently&quot; ends.</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dt><dd>The current [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.options.configuration.configurationbuilder.build__ubyzgt" />  Configuration.ConfigurationBuilder.Build() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [Configuration.ConfigurationBuilder](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration.configurationbuilder__vv30sc)           
Sources: Options\Configuration.cs</small>


Finishes the configuration building and returns the [Instance](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.configuration.instance__1ginlaa)



```csharp
public Configuration Build()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Options.Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb)</dt><dd>The [Configuration](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.configuration__110r0mb) singleton</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6" />  OutputOptions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Sources: Options\OutputOptions.cs</small>


Output configuration



```csharp
public class OutputOptions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EnableAddOns](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.enableaddons__1ysvrps) | public | Flag whether to enable AddOns (false by default) | 
 | [Html](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.html__cl135b) | public | Flag whether to generate the HTML output | 
 | [HtmlExtension](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.htmlextension__17720ly) | public | Extension of generated HTML file | 
 | [Markdown](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.markdown__1glxj0d) | public | Flag whether to generate the Markdown output | 
 | [MarkdownExtension](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.markdownextension__1nkg7o6) | public | Extension of generated Markdown file | 
 | [SplitNs](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.splitns__11lojtx) | public | Flag whether to split the output per namespace | 
 | [SplitType](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.splittype__1nl0vhs) | public | Flag whether to split the output per type. In this case, the split per namespace will also be applied. | 
 | [Target](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.target__1v9mv9v) | public | Output target - full path including file name without extension for single file output, index file without extension for multi-file output | 
 | [Title](net.adamec.dev.markupdoc.Options__g1tahn.md#p-net.adamec.dev.markupdoc.options.outputoptions.title__aav6cy) | public | Title of documentation show at the top of each page | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.enableaddons__1ysvrps" />  OutputOptions.EnableAddOns Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Flag whether to enable AddOns (false by default)



```csharp
public bool EnableAddOns { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.html__cl135b" />  OutputOptions.Html Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Flag whether to generate the HTML output



```csharp
public bool Html { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.htmlextension__17720ly" />  OutputOptions.HtmlExtension Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Extension of generated HTML file



```csharp
public string HtmlExtension { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.markdown__1glxj0d" />  OutputOptions.Markdown Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Flag whether to generate the Markdown output



```csharp
public bool Markdown { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.markdownextension__1nkg7o6" />  OutputOptions.MarkdownExtension Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Extension of generated Markdown file



```csharp
public string MarkdownExtension { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.splitns__11lojtx" />  OutputOptions.SplitNs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Flag whether to split the output per namespace



```csharp
public bool SplitNs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.splittype__1nl0vhs" />  OutputOptions.SplitType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Flag whether to split the output per type. In this case, the split per namespace will also be applied.



```csharp
public bool SplitType { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.target__1v9mv9v" />  OutputOptions.Target Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Output target - full path including file name without extension for single file output, index file without extension for multi-file output



```csharp
public string Target { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.options.outputoptions.title__aav6cy" />  OutputOptions.Title Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Options](net.adamec.dev.markupdoc.Options__g1tahn.md#n-net.adamec.dev.markupdoc.options__g1tahn)           
Assembly: MarkupDoc           
Type: [OutputOptions](net.adamec.dev.markupdoc.Options__g1tahn.md#t-net.adamec.dev.markupdoc.options.outputoptions__kezzp6)           
Sources: Options\OutputOptions.cs</small>


Title of documentation show at the top of each page



```csharp
public string Title { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



