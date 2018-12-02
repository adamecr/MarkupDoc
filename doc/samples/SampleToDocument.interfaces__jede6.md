#  Sample documentation #
##  <a id="n-sampletodocument.interfaces__jede6" />  SampleToDocument.interfaces Namespace ##
Namespace for checking the interface documentation


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [InterfaceContainer](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer__131wgyo) | public | Class containing nested interfaces | 
 | [InterfaceContainer2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer2__1hzrrci) | public | Class containing nested interfaces with hiding | 
 | [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77) | public | Class implementing [IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora) and [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9) . As there are the members with same signature, the explicit implementation must be used. | 

 


###  Interfaces ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf) | internal abstract | Empty interface to be &quot;inherited&quot; elsewhere | 
 | [IInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface2__yh7ore) | internal abstract | Another empty interface to be &quot;inherited&quot; elsewhere | 
 | [IInterface3](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface3__yh7ord) | internal abstract | Interface &quot;inheriting&quot; [IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf) | 
 | [IInterface4&lt;X,Y,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface4-3__1m9u4l) | public abstract | Generic interface with variant type parameters | 
 | [IInterface5&lt;X,Y,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface5-3__1m9u5i) | public abstract | Generic interface  with variant type parameters &quot;inheriting&quot; from [IInterface4&lt;X,Y,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface4-3__1m9u4l) . The interface also has the attributes | 
 | [IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora) | internal abstract | Interface &quot;inheriting&quot; from [IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf) and [IInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface2__yh7ore) . It declares property [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface6.name__10x4aa5) and method [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd) | 
 | [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9) | internal abstract | Interface declares property [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface7.name__10x49ce) and methods [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a) and [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437) | 
 | [InterfaceContainer.INestedInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer.inestedinterface1__60nqlw) | private abstract | Private nested interface | 
 | [InterfaceContainer.INestedInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer.inestedinterface2__1ydo091) | protected abstract | Protected nested interface | 
 | [InterfaceContainer.INestedInterface3](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer.inestedinterface3__p8ykdm) | public abstract | Public nested interface | 
 | [InterfaceContainer.INestedInterface4](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer.inestedinterface4__ikus1n) | internal abstract | Internal nested interface | 
 | [InterfaceContainer2.INestedInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer2.inestedinterface1__1xr0rtm) | private abstract | Private nested interface | 
 | [InterfaceContainer2.INestedInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer2.inestedinterface2__1xr0rtn) | protected abstract | Protected nested interface with new | 
 | [InterfaceContainer2.INestedInterface3](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer2.inestedinterface3__1xr0rto) | public abstract | Public nested interface with new | 
 | [InterfaceContainer2.INestedInterface4](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer2.inestedinterface4__1xr0rth) | internal abstract | Internal nested interface with new | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer__131wgyo" />  InterfaceContainer Class ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Class containing nested interfaces



```csharp
public class InterfaceContainer
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer2__1hzrrci" />  InterfaceContainer2 Class ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Class containing nested interfaces with hiding



```csharp
public class InterfaceContainer2 : InterfaceContainer
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.interfaces.InterfaceContainer](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.interfacecontainer__131wgyo)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.withi6and7__t2wi77" />  WithI6And7 Class ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Class implementing [IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora) and [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9) . As there are the members with same signature, the explicit implementation must be used.



```csharp
public class WithI6And7 : IInterface6, IInterface7
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Implements: [SampleToDocument.interfaces.IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora), [SampleToDocument.interfaces.IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf), [SampleToDocument.interfaces.IInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface2__yh7ore), [SampleToDocument.interfaces.IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SampleToDocument.interfaces.IInterface6.Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface6-name__9npr8j) | private | Explicit implementation of [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface6.name__10x4aa5) | 
 | [SampleToDocument.interfaces.IInterface7.Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface7-name__1ax31oo) | private | Explicit implementation of [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface7.name__10x49ce) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.withi6and7.clearname_system.string___8os06p) | public | Implicit implementation of [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437) | 
 | [SampleToDocument.interfaces.IInterface6.SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface6-setname_system.string___1oc7c13) | private | Explicit implementation of [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd) | 
 | [SampleToDocument.interfaces.IInterface7.SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface7-setname_system.string___1l4bcte) | private | Explicit implementation of [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a) | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface6-name__9npr8j" />  WithI6And7.SampleToDocument.interfaces.IInterface6.Name Property ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77)</small>


Explicit implementation of [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface6.name__10x4aa5)



```csharp
private string SampleToDocument.interfaces.IInterface6.Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface7-name__1ax31oo" />  WithI6And7.SampleToDocument.interfaces.IInterface7.Name Property ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77)</small>


Explicit implementation of [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface7.name__10x49ce)



```csharp
private string SampleToDocument.interfaces.IInterface7.Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.withi6and7.clearname_system.string___8os06p" />  WithI6And7.ClearName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77)</small>


Implicit implementation of [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437)



```csharp
public void ClearName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface6-setname_system.string___1oc7c13" />  WithI6And7.SampleToDocument.interfaces.IInterface6.SetName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77)</small>


Explicit implementation of [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd)



```csharp
private void SampleToDocument.interfaces.IInterface6.SetName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.withi6and7.sampletodocument-interfaces-iinterface7-setname_system.string___1l4bcte" />  WithI6And7.SampleToDocument.interfaces.IInterface7.SetName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [WithI6And7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.withi6and7__t2wi77)</small>


Explicit implementation of [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a)



```csharp
private void SampleToDocument.interfaces.IInterface7.SetName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface1__yh7orf" />  IInterface1 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Empty interface to be &quot;inherited&quot; elsewhere



```csharp
internal interface IInterface1
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface2__yh7ore" />  IInterface2 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Another empty interface to be &quot;inherited&quot; elsewhere



```csharp
internal interface IInterface2
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface3__yh7ord" />  IInterface3 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Interface &quot;inheriting&quot; [IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf)



```csharp
internal interface IInterface3 : IInterface1
```

Implements: [SampleToDocument.interfaces.IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf)


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface4-3__1m9u4l" />  IInterface4&lt;X,Y,Z&gt; Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Generic interface with variant type parameters



```csharp
public interface IInterface4<out X, in Y, Z>
```

<strong>Type parameters</strong><dl><dt><strong>X</strong></dt><dd>This is the &quot;out&quot; type parameter</dd><dt><strong>Y</strong></dt><dd>This is the &quot;in&quot; type parameter</dd><dt><strong>Z</strong></dt><dd>This is the type parameter without variance</dd></dl>
Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface5-3__1m9u5i" />  IInterface5&lt;X,Y,Z&gt; Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Generic interface  with variant type parameters &quot;inheriting&quot; from [IInterface4&lt;X,Y,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface4-3__1m9u4l) . The interface also has the attributes



```csharp
[Category("Interface")]
[Browsable(false)]
[TypeConverter(typeof(string))]
public interface IInterface5<out X, [Category("TypeParam")] in Y, Z> : IInterface4<Z,Z,Z>
```

<strong>Type parameters</strong><dl><dt><strong>X</strong></dt><dd>This is the &quot;out&quot; type parameter</dd><dt><strong>Y</strong></dt><dd>This is the &quot;in&quot; type parameter. Has the attribute</dd><dt><strong>Z</strong></dt><dd>This is the type parameter without variance</dd></dl>
Attributes: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.categoryattribute" target="_blank" >System.ComponentModel.CategoryAttribute</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.browsableattribute" target="_blank" >System.ComponentModel.BrowsableAttribute</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.typeconverterattribute" target="_blank" >System.ComponentModel.TypeConverterAttribute</a>           
Implements: [SampleToDocument.interfaces.IInterface4&lt;Z,Z,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface4-3__1m9u4l)


###  Remarks ###
The <strong>Z</strong> type parameter is mapped to all type parameters if [IInterface4&lt;X,Y,Z&gt;](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface4-3__1m9u4l)


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface6__yh7ora" />  IInterface6 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Interface &quot;inheriting&quot; from [IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf) and [IInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface2__yh7ore) . It declares property [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface6.name__10x4aa5) and method [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd)



```csharp
internal interface IInterface6 : IInterface1, IInterface2
```

Implements: [SampleToDocument.interfaces.IInterface1](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface1__yh7orf), [SampleToDocument.interfaces.IInterface2](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface2__yh7ore)


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface6.name__10x4aa5) | public abstract |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd) | public abstract |  | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.interfaces.iinterface6.name__10x4aa5" />  IInterface6.Name Property ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora)</small>



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.iinterface6.setname_system.string___1nc7icd" />  IInterface6.SetName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [IInterface6](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface6__yh7ora)</small>



```csharp
public abstract void SetName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.iinterface7__yh7or9" />  IInterface7 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Interface declares property [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface7.name__10x49ce) and methods [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a) and [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437)



```csharp
internal interface IInterface7
```

###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Name](SampleToDocument.interfaces__jede6.md#p-sampletodocument.interfaces.iinterface7.name__10x49ce) | public abstract |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ClearName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437) | public abstract |  | 
 | [SetName(string)](SampleToDocument.interfaces__jede6.md#m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a) | public abstract |  | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.interfaces.iinterface7.name__10x49ce" />  IInterface7.Name Property ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9)</small>



```csharp
public abstract string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.iinterface7.clearname_system.string___12s0437" />  IInterface7.ClearName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9)</small>



```csharp
public abstract void ClearName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.interfaces.iinterface7.setname_system.string___28gg5a" />  IInterface7.SetName(string) Title ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument           
Type: [IInterface7](SampleToDocument.interfaces__jede6.md#t-sampletodocument.interfaces.iinterface7__yh7or9)</small>



```csharp
public abstract void SetName(string name)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer.inestedinterface1__60nqlw" />  InterfaceContainer.INestedInterface1 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Private nested interface



```csharp
private interface InterfaceContainer.INestedInterface1
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer.inestedinterface2__1ydo091" />  InterfaceContainer.INestedInterface2 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Protected nested interface



```csharp
protected interface InterfaceContainer.INestedInterface2
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer.inestedinterface3__p8ykdm" />  InterfaceContainer.INestedInterface3 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Public nested interface



```csharp
public interface InterfaceContainer.INestedInterface3
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer.inestedinterface4__ikus1n" />  InterfaceContainer.INestedInterface4 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Internal nested interface



```csharp
internal interface InterfaceContainer.INestedInterface4
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer2.inestedinterface1__1xr0rtm" />  InterfaceContainer2.INestedInterface1 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Private nested interface



```csharp
private interface InterfaceContainer2.INestedInterface1
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer2.inestedinterface2__1xr0rtn" />  InterfaceContainer2.INestedInterface2 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Protected nested interface with new



```csharp
protected new interface InterfaceContainer2.INestedInterface2
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer2.inestedinterface3__1xr0rto" />  InterfaceContainer2.INestedInterface3 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Public nested interface with new



```csharp
public new interface InterfaceContainer2.INestedInterface3
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.interfaces.interfacecontainer2.inestedinterface4__1xr0rth" />  InterfaceContainer2.INestedInterface4 Interface ##
<small>Namespace: [SampleToDocument.interfaces](SampleToDocument.interfaces__jede6.md#n-sampletodocument.interfaces__jede6)           
Assembly: SampleToDocument</small>


Internal nested interface with new



```csharp
internal new interface InterfaceContainer2.INestedInterface4
```

Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 



