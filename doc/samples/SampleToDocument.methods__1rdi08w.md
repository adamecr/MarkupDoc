#  Sample documentation #
##  <a id="n-sampletodocument.methods__1rdi08w" />  SampleToDocument.methods Namespace ##
Namespace for checking the methods (incl. events and operators) documentation


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestCrossNs](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testcrossns__1uxgtm1) | public | Class to check the cross namespace links | 
 | [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c) | public | Class containing the events with different types of event handler delegates | 
 | [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb) | public abstract | Abstract class containing the events | 
 | [TestEvents3](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents3__h2xqfm) | public abstract | Class containing the events, inheriting [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb) | 
 | [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63) | public | Class with methods with complex params, also having CTOR and destructor | 
 | [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | public | Class to check hiding (new keyword) | 
 | [TestMethods2Ext](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2ext__14jmomd) | public static | Extensions class for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 
 | [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) | public | Class containing the bunch of the operators | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc) | public |  | 

 


###  Delegates ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestEvents1.Event2EventHandler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event2eventhandler__f9px58) | public |  | 
 | [TestEvents1.Event3Handler&lt;TEventArgs&gt;](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event3handler-1__15qd1e6) | public |  | 
 | [TestEvents1.Event4Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event4handler__1dmpg0m) | public |  | 
 | [TestEvents1.Event5Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event5handler__1dmorhz) | protected |  | 
 | [TestEvents2.Event4Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2.event4handler__1q0ijad) | protected | Protected delegate | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testcrossns__1uxgtm1" />  TestCrossNs Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class to check the cross namespace links



```csharp
public class TestCrossNs : PropertyContainer1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.property.PropertyContainer1](SampleToDocument.property__izv70z.md#t-sampletodocument.property.propertycontainer1__memkkq)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Property1](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testcrossns.property1__mpv6v1) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Something()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testcrossns.something__c5h40o) | public | Just try to cross ns link [PropertyContainer1](SampleToDocument.property__izv70z.md#t-sampletodocument.property.propertycontainer1__memkkq) | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testcrossns.property1__mpv6v1" />  TestCrossNs.Property1 Property ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestCrossNs](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testcrossns__1uxgtm1)</small>



```csharp
public override string Property1 { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testcrossns.something__c5h40o" />  TestCrossNs.Something() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestCrossNs](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testcrossns__1uxgtm1)</small>


Just try to cross ns link [PropertyContainer1](SampleToDocument.property__izv70z.md#t-sampletodocument.property.propertycontainer1__memkkq)



```csharp
public void Something()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


###  Exceptions ###
<dl><dt>[PropertyContainer1](SampleToDocument.property__izv70z.md#t-sampletodocument.property.propertycontainer1__memkkq)</dt><dd>Well, not an exception, but the link should work</dd></dl>


###  See Also ###
[PropertyContainer1](SampleToDocument.property__izv70z.md#t-sampletodocument.property.propertycontainer1__memkkq)


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents1__10b8k7c" />  TestEvents1 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class containing the events with different types of event handler delegates



```csharp
public class TestEvents1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Events ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Event1](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event1__1pa2iea) | public |  | 
 | [Event2](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event2__1pa2ie9) | public |  | 
 | [Event3](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event3__1pa2ie8) | public |  | 
 | [Event4](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event4__1pa2ie7) | protected |  | 
 | [Event5](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event5__1pa2ie6) | private |  | 
 | [Event6](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents1.event6__1pa2ie5) | protected |  | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event1__1pa2iea" />  TestEvents1.Event1 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
public EventHandler Event1
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event2__1pa2ie9" />  TestEvents1.Event2 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
public TestEvents1.Event2EventHandler Event2
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents1.Event2EventHandler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event2eventhandler__f9px58)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event3__1pa2ie8" />  TestEvents1.Event3 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
public TestEvents1.Event3Handler<System.EventArgs> Event3
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents1.Event3Handler&lt;System.EventArgs&gt;](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event3handler-1__15qd1e6)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event4__1pa2ie7" />  TestEvents1.Event4 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
protected TestEvents1.Event4Handler Event4
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents1.Event4Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event4handler__1dmpg0m)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event5__1pa2ie6" />  TestEvents1.Event5 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
private TestEvents1.Event5Handler Event5
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents1.Event5Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event5handler__1dmorhz)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents1.event6__1pa2ie5" />  TestEvents1.Event6 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1__10b8k7c)</small>



```csharp
protected virtual TestEvents1.Event5Handler Event6
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents1.Event5Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents1.event5handler__1dmorhz)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents2__16zccjb" />  TestEvents2 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Abstract class containing the events



```csharp
public abstract class TestEvents2
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Events ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Event1](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents2.event1__xj2wdt) | internal abstract | Internal abstract event | 
 | [Event2](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents2.event2__xj2wds) | protected abstract | Protected abstract event | 
 | [Event3](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents2.event3__xj2wdr) | protected | Protected virtual event | 
 | [Event4](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents2.event4__xj2wdq) | protected | Protected event | 
 | [Event5](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents2.event5__xj2wdp) | protected static | Protected static event | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents2.event1__xj2wdt" />  TestEvents2.Event1 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)</small>


Internal abstract event



```csharp
internal abstract EventHandler Event1
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents2.event2__xj2wds" />  TestEvents2.Event2 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)</small>


Protected abstract event



```csharp
protected abstract EventHandler Event2
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents2.event3__xj2wdr" />  TestEvents2.Event3 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)</small>


Protected virtual event



```csharp
protected virtual EventHandler Event3
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents2.event4__xj2wdq" />  TestEvents2.Event4 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)</small>


Protected event



```csharp
protected TestEvents2.Event4Handler Event4
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents2.Event4Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2.event4handler__1q0ijad)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents2.event5__xj2wdp" />  TestEvents2.Event5 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)</small>


Protected static event



```csharp
protected static EventHandler Event5
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents3__h2xqfm" />  TestEvents3 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class containing the events, inheriting [TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)



```csharp
public abstract class TestEvents3 : TestEvents2
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.methods.TestEvents2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2__16zccjb)           



###  Events ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Event1](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents3.event1__16wkv1o) | internal | Override of abstract event. Custom accessors (add and remove) | 
 | [Event2](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents3.event2__16wkv1n) | protected | Override of abstract event | 
 | [Event3](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents3.event3__16wkv1m) | protected | Override of virtual event | 
 | [Event4](SampleToDocument.methods__1rdi08w.md#e-sampletodocument.methods.testevents3.event4__16wkv1l) | protected | Event with new | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents3.event1__16wkv1o" />  TestEvents3.Event1 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents3](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents3__h2xqfm)</small>


Override of abstract event. Custom accessors (add and remove)



```csharp
internal override EventHandler Event1 { add; remove; }
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents3.event2__16wkv1n" />  TestEvents3.Event2 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents3](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents3__h2xqfm)</small>


Override of abstract event



```csharp
protected override EventHandler Event2
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents3.event3__16wkv1m" />  TestEvents3.Event3 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents3](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents3__h2xqfm)</small>


Override of virtual event



```csharp
protected override EventHandler Event3
```

<strong>Event handler</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventhandler" target="_blank" >System.EventHandler</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="e-sampletodocument.methods.testevents3.event4__16wkv1l" />  TestEvents3.Event4 Event ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestEvents3](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents3__h2xqfm)</small>


Event with new



```csharp
protected new TestEvents2.Event4Handler Event4
```

<strong>Event handler</strong><dl><dt>[SampleToDocument.methods.TestEvents2.Event4Handler](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testevents2.event4handler__1q0ijad)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testmethods1__99zc63" />  TestMethods1 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class with methods with complex params, also having CTOR and destructor



```csharp
public class TestMethods1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Ci](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.ci__6ss31) | 3 |  | 

 


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Field5](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.field5__1lqfrh0) | public | Simple field to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 
 | [StaticFld](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.staticfld__1p149b9) | public static | Some static field | 
 | [x](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.x__1ocn8tz) | private | Just some private field | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Property5](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testmethods1.property5__1svwbg7) | public | Simple property to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 

 


###  Indexers ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [this[int]](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testmethods1.item_system.int32-___17no23m) | public | Indexer | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestMethods1()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.-ctor__1nz4td) | protected | Protected CTOR | 
 | [TestMethods1()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.-cctor__1it0xkk) | private static | Static CTOR | 
 | [TestMethods1(int, string, string)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.-ctor_system.int32-system.string-system.string___glklwx) | public | CTOR with parameters | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~TestMethods1()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.finalize__1vwh4f2) | protected | Destructor | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Method1&lt;T&gt;(int, int, int, int, decimal, bool, bool?, string, object, TestMethods1.T, int[])](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.method1--1_system.int32--system.int32--system.int32--system.int32--system.decimal-system.boolean-system.nullable_system.boolean_-system.string-system.object---0-system.int32_____9yghh) | public | Generic method with different kind of parameters | 
 | [Method2&lt;T&gt;(int, double, double, decimal, float, int, int, bool, bool?, string, TestMethods1.TestEnum, TestMethods1, object, object, List&lt;T&gt;, TestMethods1.T)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.method2--1_system.int32-system.double-system.double-system.decimal-system.single-system.int32-system.int32-system.boolean-system.nullable_system.boolean_-system.string-sampletodocument.methods.testmethods1.testenum-sampletodocument.methods.testmethods1-system.object-system.object-system.collections.generic.list_--0_---0___1wbkwoz) | public | Generic method with different kind of parameters with default values | 
 | [Method3()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.method3__2nl9ju) | public | Method with `ref readonly` return type | 
 | [Method4()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.method4__2nl9jn) | public | Method with `ref` return type | 
 | [Method5()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods1.method5__2nl9jo) | public | Simple method to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.ci__6ss31" />  TestMethods1.Ci Constant ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>



```csharp
public const int Ci = 3
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.field5__1lqfrh0" />  TestMethods1.Field5 Field ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Simple field to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public string Field5
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.staticfld__1p149b9" />  TestMethods1.StaticFld Field ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Some static field



```csharp
public static int StaticFld
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.x__1ocn8tz" />  TestMethods1.x Field ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Just some private field



```csharp
private int x
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testmethods1.property5__1svwbg7" />  TestMethods1.Property5 Property ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Simple property to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public int Property5 { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testmethods1.item_system.int32-___17no23m" />  TestMethods1.this[int] Indexer ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Indexer



```csharp
public int this[in int a] { get; }
```

<strong>Indexer parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <em>a</em></dt><dd>Param with `in` modifier</dd></dl>
<strong>Indexer value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.-ctor__1nz4td" />  TestMethods1.TestMethods1() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Protected CTOR



```csharp
protected TestMethods1()
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.-cctor__1it0xkk" />  TestMethods1.TestMethods1() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Static CTOR



```csharp
private static TestMethods1()
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.-ctor_system.int32-system.string-system.string___glklwx" />  TestMethods1.TestMethods1(int, string, string) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


CTOR with parameters



```csharp
public TestMethods1(int a, string b, string c = null)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>a</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>b</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>c</strong></dt><dd>Parameter with default value (null)</dd></dl>
Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.finalize__1vwh4f2" />  TestMethods1.~TestMethods1() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Destructor



```csharp
 ~TestMethods1()
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.method1--1_system.int32--system.int32--system.int32--system.int32--system.decimal-system.boolean-system.nullable_system.boolean_-system.string-system.object---0-system.int32_____9yghh" />  TestMethods1.Method1&lt;T&gt;(int, int, int, int, decimal, bool, bool?, string, object, TestMethods1.T, int[]) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Generic method with different kind of parameters



```csharp
public void Method1<[Category("a")] T>(in int i0, ref int i, out int io, [Category("cat")] ref int rio, [Category("cat")] [Browsable(false)] decimal d, bool b = false, bool? n = false, [Browsable(true)] string s = "Hello", object o = null, TestMethods1.T t = null, params int[] a) where T: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter with attribute and constraints</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i0</strong></dt><dd>Parameter with `in` modifier</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i</strong></dt><dd>Parameter with `ref` modifier</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>io</strong></dt><dd>Parameter with `out` modifier</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>rio</strong></dt><dd>Parameter with `ref` modifier and attribute</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.decimal" target="_blank" >decimal</a> <strong>d</strong></dt><dd>Parameter with multiple attributes</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>b</strong></dt><dd>Parameter with default value (false)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >bool?</a> <strong>n</strong></dt><dd>Parameter with default value (false)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>Parameter with default value (&quot;Hello&quot;) and attribute</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>o</strong></dt><dd>Parameter with default value (null)</dd><dt>SampleToDocument.methods.TestMethods1.T <strong>t</strong></dt><dd>Generic parameter with default value ( `default(T)` )</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int[]</a> <strong>a</strong></dt><dd>Array parameter (params)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.method2--1_system.int32-system.double-system.double-system.decimal-system.single-system.int32-system.int32-system.boolean-system.nullable_system.boolean_-system.string-sampletodocument.methods.testmethods1.testenum-sampletodocument.methods.testmethods1-system.object-system.object-system.collections.generic.list_--0_---0___1wbkwoz" />  TestMethods1.Method2&lt;T&gt;(int, double, double, decimal, float, int, int, bool, bool?, string, TestMethods1.TestEnum, TestMethods1, object, object, List&lt;T&gt;, TestMethods1.T) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Generic method with different kind of parameters with default values



```csharp
public void Method2<T>(int i = -5, double d1 = 5.456d, double d2 = -5.456d, decimal m = 234.5678m, float f = -345.67f, int i2 = 7, int i3 = 15, bool b = false, bool? n = null, string s = "Hello", TestMethods1.TestEnum e = 1, TestMethods1 me = null, object o = null, object o2 = null, List<T> l = null, TestMethods1.T t = null)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter</dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i</strong></dt><dd>Parameter with default value -5</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>d1</strong></dt><dd>Parameter with default value 5.456d</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.double" target="_blank" >double</a> <strong>d2</strong></dt><dd>Parameter with default value -5.456d</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.decimal" target="_blank" >decimal</a> <strong>m</strong></dt><dd>Parameter with default value 234.5678m</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.single" target="_blank" >float</a> <strong>f</strong></dt><dd>Parameter with default value -345.67f</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i2</strong></dt><dd>Parameter with default value 7</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i3</strong></dt><dd>Parameter with default value Ci * 5</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>b</strong></dt><dd>Parameter with default value false</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.nullable-1" target="_blank" >bool?</a> <strong>n</strong></dt><dd>Parameter with default value null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>Parameter with default value &quot;Hello&quot;</dd><dt>[SampleToDocument.methods.TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc) <strong>e</strong></dt><dd>Parameter with default value TestEnum.Second</dd><dt>[SampleToDocument.methods.TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63) <strong>me</strong></dt><dd>Parameter with default value `default(TestMethods1)`</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>o</strong></dt><dd>Parameter with default value null</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>o2</strong></dt><dd>Parameter with default value `default(List<T>)`</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;T&gt;</a> <strong>l</strong></dt><dd>Parameter with default value `default(List<T>)`</dd><dt>SampleToDocument.methods.TestMethods1.T <strong>t</strong></dt><dd>Parameter with default value `default(T)`</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.method3__2nl9ju" />  TestMethods1.Method3() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Method with `ref readonly` return type



```csharp
public ref readonly int Method3()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.method4__2nl9jn" />  TestMethods1.Method4() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Method with `ref` return type



```csharp
public ref int Method4()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods1.method5__2nl9jo" />  TestMethods1.Method5() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)</small>


Simple method to check hiding in [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public void Method5()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testmethods2__99zc60" />  TestMethods2 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class to check hiding (new keyword)



```csharp
public class TestMethods2 : TestMethods1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.methods.TestMethods1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1__99zc63)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Field5](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods2.field5__1lqgj3n) | public | Simple field with hide | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Property5](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testmethods2.property5__1r0tkgq) | public | Simple property with hide | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Method5()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods2.method5__2k3o7p) | public | Simple method with hide | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods2.field5__1lqgj3n" />  TestMethods2.Field5 Field ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)</small>


Simple field with hide



```csharp
public new string Field5
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testmethods2.property5__1r0tkgq" />  TestMethods2.Property5 Property ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)</small>


Simple property with hide



```csharp
public new int Property5 { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods2.method5__2k3o7p" />  TestMethods2.Method5() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)</small>


Simple method with hide



```csharp
public new void Method5()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testmethods2ext__14jmomd" />  TestMethods2Ext Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Extensions class for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public static class TestMethods2Ext
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExtensionMethod1(TestMethods2)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods2ext.extensionmethod1_sampletodocument.methods.testmethods2___2n8zny) | public static | Extension method for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 
 | [ExtensionMethod2(TestMethods2, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testmethods2ext.extensionmethod2_sampletodocument.methods.testmethods2-system.int32___ss4ht4) | public static | Extension method for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods2ext.extensionmethod1_sampletodocument.methods.testmethods2___2n8zny" />  TestMethods2Ext.ExtensionMethod1(TestMethods2) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods2Ext](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2ext__14jmomd)</small>


Extension method for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public static int ExtensionMethod1(this TestMethods2 this)
```

<strong>Method parameters</strong><dl><dt>[SampleToDocument.methods.TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) <strong>this</strong></dt><dd>Param with `@this` name</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testmethods2ext.extensionmethod2_sampletodocument.methods.testmethods2-system.int32___ss4ht4" />  TestMethods2Ext.ExtensionMethod2(TestMethods2, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods2Ext](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2ext__14jmomd)</small>


Extension method for [TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60)



```csharp
public static int ExtensionMethod2(this TestMethods2 e1, int i1)
```

<strong>Method parameters</strong><dl><dt>[SampleToDocument.methods.TestMethods2](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods2__99zc60) <strong>e1</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>i1</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testoperators1__rwo9k0" />  TestOperators1 Class ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Class containing the bunch of the operators



```csharp
public class TestOperators1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testoperators1.name__1mqtaq1) | public | Property `Name` - to check the correct links for the &quot;same&quot; name just with different case | 
 | [NaMe](SampleToDocument.methods__1rdi08w.md#p-sampletodocument.methods.testoperators1.name__1mqtap5) | public | Property `NaMe` - to check the correct links for the &quot;same&quot; name just with different case | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NamE&lt;T&gt;()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.name--1__glw9qd) | public | Method `NamE<T>` - to check the correct links for the &quot;same&quot; name just with different case | 
 | [NAme&lt;T&gt;()](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.name--1__11fugsl) | public | Method `NAme<T>` - to check the correct links for the &quot;same&quot; name just with different case | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BitwiseOr(TestOperators1, TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_bitwiseor_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___1pigfro) | public static | Binary OR operator | 
 | [Equals(TestOperators1, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_equality_sampletodocument.methods.testoperators1-system.int32___1qwgzf5) | public static | Equal operator with different signature | 
 | [Equals(TestOperators1, TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_equality_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___180e7q4) | public static | Equal operator | 
 | [False(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_false_sampletodocument.methods.testoperators1___12v9r5h) | public static | False operator | 
 | [GreaterThanOrEqual(TestOperators1, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_greaterthanorequal_sampletodocument.methods.testoperators1-system.int32___odjjex) | public static | Greater of equal operator | 
 | [Increment(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_increment_sampletodocument.methods.testoperators1___1exsd5h) | public static | &quot;Plus plus&quot; operator | 
 | [LessThanOrEqual(TestOperators1, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_lessthanorequal_sampletodocument.methods.testoperators1-system.int32___1jncnpo) | public static | Less or equal operator | 
 | [Negate(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_unarynegation_sampletodocument.methods.testoperators1___5mg8t2) | public static | Unary minus operator | 
 | [NotEquals(TestOperators1, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_inequality_sampletodocument.methods.testoperators1-system.int32___1q5qdsw) | public static | Not equal operator with different signature | 
 | [NotEquals(TestOperators1, TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_inequality_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___1b6i9y9) | public static | Not equal operator | 
 | [Plus(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_unaryplus_sampletodocument.methods.testoperators1___1nra96v) | public static | Plus operator | 
 | [Subtract(TestOperators1, int)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_subtraction_sampletodocument.methods.testoperators1-system.int32___nidxsx) | public static | Binary minus operator | 
 | [True(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_true_sampletodocument.methods.testoperators1___oft4t0) | public static | True operator | 
 | [From(bool)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_implicit_system.boolean_dtorsampletodocument.methods.testoperators1__q06r12) | public static | Implicit conversion <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> to [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) | 
 | [From(Exception)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_system.exception_dtorsampletodocument.methods.testoperators1__1cdfgce) | public static | Explicit conversion <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> to [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) | 
 | [ToBool(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.boolean__xs3j9r) | public static | Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> | 
 | [ToException(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.exception__1snedqk) | public static | Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> | 
 | [ToChar(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_implicit_sampletodocument.methods.testoperators1_dtorsystem.char__ukjxve) | public static | Implicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.char" target="_blank" >System.Char</a> | 
 | [ToInt(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.int32__1n4t6t5) | public static | Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >System.Int32</a> | 
 | [ToList(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.collections.generic.list_system.string___1bs9b5h) | public static | Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a> | 
 | [ToList(TestOperators1)](SampleToDocument.methods__1rdi08w.md#m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.collections.generic.list_system.int32___90hpbm) | public static | Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a> | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testoperators1.name__1mqtaq1" />  TestOperators1.Name Property ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Property `Name` - to check the correct links for the &quot;same&quot; name just with different case



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.methods.testoperators1.name__1mqtap5" />  TestOperators1.NaMe Property ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Property `NaMe` - to check the correct links for the &quot;same&quot; name just with different case



```csharp
public string NaMe { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.name--1__glw9qd" />  TestOperators1.NamE&lt;T&gt;() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Method `NamE<T>` - to check the correct links for the &quot;same&quot; name just with different case



```csharp
public void NamE<T>()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.name--1__11fugsl" />  TestOperators1.NAme&lt;T&gt;() Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Method `NAme<T>` - to check the correct links for the &quot;same&quot; name just with different case



```csharp
public void NAme<T>()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_bitwiseor_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___1pigfro" />  TestOperators1.BitwiseOr(TestOperators1, TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Binary OR operator



```csharp
public static TestOperators1 operator |(TestOperators1 a, TestOperators1 b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_equality_sampletodocument.methods.testoperators1-system.int32___1qwgzf5" />  TestOperators1.Equals(TestOperators1, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Equal operator with different signature



```csharp
public static int operator ==(TestOperators1 a, int b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_equality_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___180e7q4" />  TestOperators1.Equals(TestOperators1, TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Equal operator



```csharp
public static bool operator ==(TestOperators1 a, TestOperators1 b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_false_sampletodocument.methods.testoperators1___12v9r5h" />  TestOperators1.False(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


False operator



```csharp
public static bool operator false(TestOperators1 a)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_greaterthanorequal_sampletodocument.methods.testoperators1-system.int32___odjjex" />  TestOperators1.GreaterThanOrEqual(TestOperators1, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Greater of equal operator



```csharp
public static bool operator >=(TestOperators1 a, int b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_increment_sampletodocument.methods.testoperators1___1exsd5h" />  TestOperators1.Increment(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


&quot;Plus plus&quot; operator



```csharp
public static TestOperators1 operator ++(TestOperators1 a)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_lessthanorequal_sampletodocument.methods.testoperators1-system.int32___1jncnpo" />  TestOperators1.LessThanOrEqual(TestOperators1, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Less or equal operator



```csharp
public static bool operator <=(TestOperators1 a, int b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_unarynegation_sampletodocument.methods.testoperators1___5mg8t2" />  TestOperators1.Negate(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Unary minus operator



```csharp
public static int operator -(TestOperators1 b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_inequality_sampletodocument.methods.testoperators1-system.int32___1q5qdsw" />  TestOperators1.NotEquals(TestOperators1, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Not equal operator with different signature



```csharp
public static int operator !=(TestOperators1 a, int b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_inequality_sampletodocument.methods.testoperators1-sampletodocument.methods.testoperators1___1b6i9y9" />  TestOperators1.NotEquals(TestOperators1, TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Not equal operator



```csharp
public static bool operator !=(TestOperators1 a, TestOperators1 b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_unaryplus_sampletodocument.methods.testoperators1___1nra96v" />  TestOperators1.Plus(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Plus operator



```csharp
public static TestOperators1 operator +(TestOperators1 b)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_subtraction_sampletodocument.methods.testoperators1-system.int32___nidxsx" />  TestOperators1.Subtract(TestOperators1, int) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Binary minus operator



```csharp
public static int operator -(TestOperators1 b, int a)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>b</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_true_sampletodocument.methods.testoperators1___oft4t0" />  TestOperators1.True(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


True operator



```csharp
public static bool operator true(TestOperators1 a)
```

<strong>Operator parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_implicit_system.boolean_dtorsampletodocument.methods.testoperators1__q06r12" />  TestOperators1.From(bool) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Implicit conversion <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a> to [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)



```csharp
public static TestOperators1 op_Implicit(bool x)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_system.exception_dtorsampletodocument.methods.testoperators1__1cdfgce" />  TestOperators1.From(Exception) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> to [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)



```csharp
public static TestOperators1 op_Explicit(Exception x)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a> <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.boolean__xs3j9r" />  TestOperators1.ToBool(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >System.Boolean</a>



```csharp
public static bool op_Explicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.exception__1snedqk" />  TestOperators1.ToException(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a>



```csharp
public static Exception op_Explicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.exception" target="_blank" >System.Exception</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_implicit_sampletodocument.methods.testoperators1_dtorsystem.char__ukjxve" />  TestOperators1.ToChar(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Implicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.char" target="_blank" >System.Char</a>



```csharp
public static char op_Implicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.char" target="_blank" >char</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.int32__1n4t6t5" />  TestOperators1.ToInt(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >System.Int32</a>



```csharp
public static int op_Explicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.collections.generic.list_system.string___1bs9b5h" />  TestOperators1.ToList(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a>



```csharp
public static List<string> op_Explicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.methods.testoperators1.op_explicit_sampletodocument.methods.testoperators1_dtorsystem.collections.generic.list_system.int32___90hpbm" />  TestOperators1.ToList(TestOperators1) Title ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0)</small>


Explicit conversion [TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) to <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >System.Collections.Generic.List`1</a>



```csharp
public static List<int> op_Explicit(TestOperators1 x)
```

<strong>Conversion parameters</strong><dl><dt>[SampleToDocument.methods.TestOperators1](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testoperators1__rwo9k0) <strong>x</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;int&gt;</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents1.event2eventhandler__f9px58" />  TestEvents1.Event2EventHandler Delegate ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>



```csharp
public delegate void TestEvents1.Event2EventHandler(object sender, EventArgs e)
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


<strong>Delegate parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.eventargs" target="_blank" >System.EventArgs</a> <strong>e</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents1.event3handler-1__15qd1e6" />  TestEvents1.Event3Handler&lt;TEventArgs&gt; Delegate ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>



```csharp
public delegate void TestEvents1.Event3Handler<in TEventArgs>(object sender, TestEvents1.Event3Handler<TEventArgs>.TEventArgs e)
```

<strong>Type parameters</strong><dl><dt><strong>TEventArgs</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


<strong>Delegate parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>sender</strong></dt><dd></dd><dt>SampleToDocument.methods.TestEvents1.Event3Handler&lt;TEventArgs&gt;.TEventArgs <strong>e</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents1.event4handler__1dmpg0m" />  TestEvents1.Event4Handler Delegate ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>



```csharp
public delegate void TestEvents1.Event4Handler()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents1.event5handler__1dmorhz" />  TestEvents1.Event5Handler Delegate ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>



```csharp
protected delegate int TestEvents1.Event5Handler()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testevents2.event4handler__1q0ijad" />  TestEvents2.Event4Handler Delegate ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>


Protected delegate



```csharp
protected delegate void TestEvents2.Event4Handler()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.delegate" target="_blank" >Delegate</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.multicastdelegate" target="_blank" >MulticastDelegate</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icloneable" target="_blank" >System.ICloneable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.runtime.serialization.iserializable" target="_blank" >System.Runtime.Serialization.ISerializable</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.methods.testmethods1.testenum__10kckfc" />  TestMethods1.TestEnum Enum ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument</small>



```csharp
public enum TestMethods1.TestEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [First](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.testenum.first__5it2li) | 0 |  | 
 | [Second](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.testenum.second__u4llu0) | 1 |  | 
 | [Third](SampleToDocument.methods__1rdi08w.md#f-sampletodocument.methods.testmethods1.testenum.third__1ge19sz) | 2 |  | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.testenum.first__5it2li" />  TestMethods1.TestEnum.First Constant ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</small>



```csharp
 First = 0
```

<strong>Field value</strong><dl><dt>[SampleToDocument.methods.TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.testenum.second__u4llu0" />  TestMethods1.TestEnum.Second Constant ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</small>



```csharp
 Second = 1
```

<strong>Field value</strong><dl><dt>[SampleToDocument.methods.TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.methods.testmethods1.testenum.third__1ge19sz" />  TestMethods1.TestEnum.Third Constant ##
<small>Namespace: [SampleToDocument.methods](SampleToDocument.methods__1rdi08w.md#n-sampletodocument.methods__1rdi08w)           
Assembly: SampleToDocument           
Type: [TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</small>



```csharp
 Third = 2
```

<strong>Field value</strong><dl><dt>[SampleToDocument.methods.TestMethods1.TestEnum](SampleToDocument.methods__1rdi08w.md#t-sampletodocument.methods.testmethods1.testenum__10kckfc)</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 



