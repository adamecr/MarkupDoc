#  Sample documentation #
##  <a id="n-sampletodocument.classes.generic__1rg3wn7" />  SampleToDocument.classes.generic Namespace ##
Namespace for checking the generic classes documentation


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867) | public | Simple generic class | 
 | [TestGenClass10&lt;K,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass10-2__1yiv7o2) | internal | Internal generic class with complex constraints | 
 | [TestGenClass2](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2__14ihr7d) | public | Non generic class with the same name as generic one | 
 | [TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb) | public | Empty generic class | 
 | [TestGenClass2A&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2a-2__1cyipd2) | public | Empty generic class inheriting from [TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb) | 
 | [TestGenClass2B&lt;X,Y&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2b-2__1cyipah) | public | Empty generic class inheriting from [TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb) using different type parameter names | 
 | [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves) | public | Generic class with multiple constraints | 
 | [TestGenClass3&lt;T,U&gt;.TestGenClass3Inner](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner__1fxuu35) | public | Nested class inheriting from [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867) | 
 | [TestGenClass4&lt;X&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass4-1__yltets) | public | Empty generic class inheriting from [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves) where one type is kept generic with different type name, the other type is assigned with the concrete type | 
 | [TestGenClass5&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass5-2__fpjlru) | public | Generic class with simple inheritance | 
 | [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) | public | Test generic class with two type parameters: <strong>U</strong> and <strong>V</strong> | 
 | [TestGenClass7&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass7-1__dpj0t1) | internal | Internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment | 
 | [TestGenClass8&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass8-1__1qmcn0s) | internal | Another internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment | 
 | [TestGenClass9&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass9-1__111z1mv) | internal | Third internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass1-1__idm867" />  TestGenClass1&lt;T&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Simple generic class



```csharp
public class TestGenClass1<T> where T: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter with constraint class, new()</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Prop1](SampleToDocument.classes.generic__1rg3wn7.md#p-sampletodocument.classes.generic.testgenclass1-1.prop1__1fhlxud) | public | Generic property | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GenMethod&lt;T&gt;(TestGenClass1&lt;T&gt;.T, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass1-1.genmethod--1_--0-system.string___1eh4lrx) | public | Virtual generic method | 
 | [GenMethod2(TestGenClass1&lt;T&gt;.T, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass1-1.genmethod2_-0-system.string___46xuxk) | public | Virtual method returning generic type | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.classes.generic.testgenclass1-1.prop1__1fhlxud" />  TestGenClass1&lt;T&gt;.Prop1 Property ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867)</small>


Generic property



```csharp
public TestGenClass1<T>.T Prop1 { get; }
```

<strong>Property value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass1&lt;T&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass1-1.genmethod--1_--0-system.string___1eh4lrx" />  TestGenClass1&lt;T&gt;.GenMethod&lt;T&gt;(TestGenClass1&lt;T&gt;.T, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867)</small>


Virtual generic method



```csharp
public virtual TestGenClass1<T>.T GenMethod<T>(TestGenClass1<T>.T v, string a)
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass1&lt;T&gt;.T <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass1&lt;T&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass1-1.genmethod2_-0-system.string___46xuxk" />  TestGenClass1&lt;T&gt;.GenMethod2(TestGenClass1&lt;T&gt;.T, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867)</small>


Virtual method returning generic type



```csharp
public virtual TestGenClass1<T>.T GenMethod2(TestGenClass1<T>.T v, string a)
```

<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass1&lt;T&gt;.T <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass1&lt;T&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass10-2__1yiv7o2" />  TestGenClass10&lt;K,V&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Internal generic class with complex constraints



```csharp
internal class TestGenClass10<K, V>
 where K: IComparable<K>
 where V: ICloneable, IEnumerable<K>, new()
```

<strong>Type parameters</strong><dl><dt><strong>K</strong></dt><dd>Type parameter with constraint IComparable&lt;K&gt;&gt;</dd><dt><strong>V</strong></dt><dd>Type parameter with constraint ICloneable, IEnumerable&lt;K&gt;, new()</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass2__14ihr7d" />  TestGenClass2 Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Non generic class with the same name as generic one



```csharp
public class TestGenClass2
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb" />  TestGenClass2&lt;T,U&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Empty generic class



```csharp
public class TestGenClass2<T, [Test] [Test("a")] [Test] U>
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter</dd><dt><strong>U</strong></dt><dd>Type parameter with custom attributes. Multiple same attributes - 2x w/o param, once with param</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass2a-2__1cyipd2" />  TestGenClass2A&lt;T,U&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Empty generic class inheriting from [TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb)



```csharp
public class TestGenClass2A<T, U> : TestGenClass2<T,U>
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd><dt><strong>U</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass2b-2__1cyipah" />  TestGenClass2B&lt;X,Y&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Empty generic class inheriting from [TestGenClass2&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb) using different type parameter names



```csharp
public class TestGenClass2B<X, Y> : TestGenClass2<X,Y>
```

<strong>Type parameters</strong><dl><dt><strong>X</strong></dt><dd></dd><dt><strong>Y</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass2&lt;X,Y&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass2-2__15xz8lb)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass3-2__1w6eves" />  TestGenClass3&lt;T,U&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Generic class with multiple constraints



```csharp
public class TestGenClass3<T, U>
 where T: struct
 where U: Attribute, new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter with struct constraint</dd><dt><strong>U</strong></dt><dd>Type parameter with Attribute and  new() constraints</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Prop1](SampleToDocument.classes.generic__1rg3wn7.md#p-sampletodocument.classes.generic.testgenclass3-2.prop1__f317a2) | public |  | 
 | [Prop2](SampleToDocument.classes.generic__1rg3wn7.md#p-sampletodocument.classes.generic.testgenclass3-2.prop2__8exey3) | public |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GenMethod(TestGenClass3&lt;T,U&gt;.T, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass3-2.genmethod_-0-system.string___mcatch) | public | Simple method | 
 | [GenMethod&lt;T&gt;(TestGenClass3&lt;T,U&gt;.T, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass3-2.genmethod--1_--0-system.string___k4m4v6) | public | Generic method with constraints | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.classes.generic.testgenclass3-2.prop1__f317a2" />  TestGenClass3&lt;T,U&gt;.Prop1 Property ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)</small>



```csharp
public TestGenClass3<T,U>.T Prop1 { get; }
```

<strong>Property value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="p-sampletodocument.classes.generic.testgenclass3-2.prop2__8exey3" />  TestGenClass3&lt;T,U&gt;.Prop2 Property ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)</small>



```csharp
public TestGenClass3<T,U>.U Prop2 { get; }
```

<strong>Property value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.U</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass3-2.genmethod_-0-system.string___mcatch" />  TestGenClass3&lt;T,U&gt;.GenMethod(TestGenClass3&lt;T,U&gt;.T, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)</small>


Simple method



```csharp
public TestGenClass3<T,U>.T GenMethod(TestGenClass3<T,U>.T v, string a)
```

<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.T <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass3-2.genmethod--1_--0-system.string___k4m4v6" />  TestGenClass3&lt;T,U&gt;.GenMethod&lt;T&gt;(TestGenClass3&lt;T,U&gt;.T, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)</small>


Generic method with constraints



```csharp
public TestGenClass3<T,U>.T GenMethod<T>(TestGenClass3<T,U>.T v, string a) where T: class, new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd>Type parameter with constraint class, new()</dd></dl>
<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.T <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner__1fxuu35" />  TestGenClass3&lt;T,U&gt;.TestGenClass3Inner Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Nested class inheriting from [TestGenClass1&lt;T&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867)



```csharp
public class TestGenClass3<T,U>.TestGenClass3Inner : TestGenClass1<object>
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass1&lt;object&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass1-1__idm867)           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GenMethod&lt;T&gt;(TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.T, bool)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod--1_--0-system.boolean___8ah7um) | public | Generic methods with constraint | 
 | [GenMethod&lt;U&gt;(TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.U, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod--1_--0-system.string___adtacz) | public | Override generic method with different type parameter names | 
 | [GenMethod2(object, string)](SampleToDocument.classes.generic__1rg3wn7.md#m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod2_system.object-system.string___1tqzgbe) | public | Override the method where the type parameter is assigned by concrete type (the same as in class inheritance) | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod--1_--0-system.boolean___8ah7um" />  TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.GenMethod&lt;T&gt;(TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.T, bool) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;.TestGenClass3Inner](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner__1fxuu35)</small>


Generic methods with constraint



```csharp
public TestGenClass3<T,U>.TestGenClass3Inner.T GenMethod<T>(TestGenClass3<T,U>.TestGenClass3Inner.T v, bool a) where T: new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.T <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.T</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod--1_--0-system.string___adtacz" />  TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.GenMethod&lt;U&gt;(TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.U, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;.TestGenClass3Inner](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner__1fxuu35)</small>


Override generic method with different type parameter names



```csharp
public override TestGenClass3<T,U>.TestGenClass3Inner.U GenMethod<U>(TestGenClass3<T,U>.TestGenClass3Inner.U v, string a)
```

<strong>Type parameters</strong><dl><dt><strong>U</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.U <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.U</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="m-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner.genmethod2_system.object-system.string___1tqzgbe" />  TestGenClass3&lt;T,U&gt;.TestGenClass3Inner.GenMethod2(object, string) Title ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument           
Type: [TestGenClass3&lt;T,U&gt;.TestGenClass3Inner](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2.testgenclass3inner__1fxuu35)</small>


Override the method where the type parameter is assigned by concrete type (the same as in class inheritance)



```csharp
public override object GenMethod2(object v, string a)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> <strong>v</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>a</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass4-1__yltets" />  TestGenClass4&lt;X&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Empty generic class inheriting from [TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves) where one type is kept generic with different type name, the other type is assigned with the concrete type



```csharp
public class TestGenClass4<X> : TestGenClass3<X,System.ComponentModel.DisplayNameAttribute> where X: struct
```

<strong>Type parameters</strong><dl><dt><strong>X</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass3&lt;X,System.ComponentModel.DisplayNameAttribute&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass5-2__fpjlru" />  TestGenClass5&lt;T,U&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Generic class with simple inheritance



```csharp
public class TestGenClass5<T, U> : TestGenClass3<T,U>
 where T: struct
 where U: Attribute, new()
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd><dt><strong>U</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass3&lt;T,U&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass3-2__1w6eves)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass6-2__wlstuz" />  TestGenClass6&lt;U,V&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Test generic class with two type parameters: <strong>U</strong> and <strong>V</strong>



```csharp
public class TestGenClass6<U, V>
```

<strong>Type parameters</strong><dl><dt><strong>U</strong></dt><dd>The first type parameter</dd><dt><strong>V</strong></dt><dd>The second type parameter</dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass7-1__dpj0t1" />  TestGenClass7&lt;T&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment



```csharp
internal class TestGenClass7<T> : TestGenClass6<string,T[]>
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass6&lt;string,T[]&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass8-1__1qmcn0s" />  TestGenClass8&lt;T&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Another internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment



```csharp
internal class TestGenClass8<T> : TestGenClass6<string,string[]>
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass6&lt;string,string[]&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.generic.testgenclass9-1__111z1mv" />  TestGenClass9&lt;T&gt; Class ##
<small>Namespace: [SampleToDocument.classes.generic](SampleToDocument.classes.generic__1rg3wn7.md#n-sampletodocument.classes.generic__1rg3wn7)           
Assembly: SampleToDocument</small>


Third internal generic class inheriting from [TestGenClass6&lt;U,V&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz) with bit complex type parameter assignment



```csharp
internal class TestGenClass9<T> : TestGenClass6<SampleToDocument.classes.TestClass5.Test5InnerClass2,SampleToDocument.classes.TestClass3.TestInnerClass[]>
```

<strong>Type parameters</strong><dl><dt><strong>T</strong></dt><dd></dd></dl>
Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.generic.TestGenClass6&lt;SampleToDocument.classes.TestClass5.Test5InnerClass2,SampleToDocument.classes.TestClass3.TestInnerClass[]&gt;](SampleToDocument.classes.generic__1rg3wn7.md#t-sampletodocument.classes.generic.testgenclass6-2__wlstuz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 



