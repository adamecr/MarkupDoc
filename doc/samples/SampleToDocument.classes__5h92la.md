#  Sample documentation #
##  <a id="n-sampletodocument.classes__5h92la" />  SampleToDocument.classes Namespace ##
Namespace for checking the classes documentation


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1) | public | Basic test class | 
 | [TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) | public | Class with inner classes | 
 | [TestClass2.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2.testinnerclass__4s3772) | public | Nested class | 
 | [TestClass2.TestInnerProtectedClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2.testinnerprotectedclass__mk9dbs) | protected | Nested protected class | 
 | [TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz) | public | Class inheriting from [TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) | 
 | [TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f) | public | Nested class with new | 
 | [TestClass3.TestSealedInner](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testsealedinner__1uhxpkr) | protected | Protected sealed nested class | 
 | [TestClass4](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass4__dhztiy) | public | Class inheriting from nested class [TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f) | 
 | [TestClass5](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5__dhztix) | public | Class inheriting from [TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz) | 
 | [TestClass5.Test5InnerClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass1__saj6gl) | public | Nested class inheriting from [TestClass2.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2.testinnerclass__4s3772) | 
 | [TestClass5.Test5InnerClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass2__lmfe4m) | public | Nested class inheriting from [TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f) | 
 | [TestClass5.Test5InnerClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass3__1biu08b) | public | Nested class inheriting from [TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz) | 
 | [TestInternalClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testinternalclass__1q1aqqf) | internal | Internal class inheriting from [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1) | 
 | [TestPartialClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testpartialclass__w5xcuv) | public | Partial class - part 1 | 
 | [TestSealedClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testsealedclass__1tby6cm) | public | Sealed class | 
 | [TestStaticClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.teststaticclass__t01750) | internal static | Static class | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass1__dhztj1" />  TestClass1 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Basic test class



```csharp
public class TestClass1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [SampleToDocument.classes.TestInternalClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testinternalclass__1q1aqqf)           



###  Example ###
It&#39;s possible to use the class anywhere 
```csharp
     var a=new Test1();
     var b= new Test1();
```



###  Remarks ###
The [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1) is just a class for testing as well as [TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) . It has a <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> field [Str](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testclass1.str__1usyqzu) . Maybe also [custom text for link to Test2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) can be provided. And also try to nest it [meaning that it could contain maybe inner [link to test3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz) or to &lt;a href=&quot;https://docs.microsoft.com/en-us/dotnet/api/system.string.clone#System_String_Clone&quot; target=&quot;_blank&quot; &gt;System.String.Clone&lt;/a&gt; for example](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0)


###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [dyn1](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testclass1.dyn1__1mursbj) | private | Readonly dynamic field with default value (not a constant) | 
 | [Dyn2](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testclass1.dyn2__dq2bok) | public | Dynamic field with default value | 
 | [Str](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testclass1.str__1usyqzu) | public |  | 

 


###  See Also ###
[TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0)           
[TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)           
[TestClass5](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5__dhztix)           
[TestClass4](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass4__dhztiy)           
<a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.classes.testclass1.dyn1__1mursbj" />  TestClass1.dyn1 Field ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Type: [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1)           
Sources: classes\Samples.cs</small>


Readonly dynamic field with default value (not a constant)



```csharp
private readonly dynamic dyn1
```

<strong>Field value</strong><dl><dt>dynamic</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.classes.testclass1.dyn2__dq2bok" />  TestClass1.Dyn2 Field ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Type: [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1)           
Sources: classes\Samples.cs</small>


Dynamic field with default value



```csharp
public dynamic Dyn2
```

<strong>Field value</strong><dl><dt>dynamic</dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.classes.testclass1.str__1usyqzu" />  TestClass1.Str Field ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Type: [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1)           
Sources: classes\Samples.cs</small>



```csharp
public string Str
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass2__dhztj0" />  TestClass2 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Class with inner classes



```csharp
public class TestClass2
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [SampleToDocument.classes.TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass2.testinnerclass__4s3772" />  TestClass2.TestInnerClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested class



```csharp
public class TestClass2.TestInnerClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [SampleToDocument.classes.TestClass5.Test5InnerClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass1__saj6gl)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass2.testinnerprotectedclass__mk9dbs" />  TestClass2.TestInnerProtectedClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested protected class



```csharp
protected class TestClass2.TestInnerProtectedClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass3__dhztiz" />  TestClass3 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Class inheriting from [TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0)



```csharp
public class TestClass3 : TestClass2
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0)           
Derived: [SampleToDocument.classes.TestClass5](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5__dhztix), [SampleToDocument.classes.TestClass5.Test5InnerClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass3__1biu08b)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass3.testinnerclass__n90o0f" />  TestClass3.TestInnerClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested class with new



```csharp
public new class TestClass3.TestInnerClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [SampleToDocument.classes.TestClass4](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass4__dhztiy), [SampleToDocument.classes.TestClass5.Test5InnerClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass5.test5innerclass2__lmfe4m)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass3.testsealedinner__1uhxpkr" />  TestClass3.TestSealedInner Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Protected sealed nested class



```csharp
protected sealed class TestClass3.TestSealedInner
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass4__dhztiy" />  TestClass4 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Class inheriting from nested class [TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f)



```csharp
public class TestClass4 : TestClass3.TestInnerClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass5__dhztix" />  TestClass5 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Class inheriting from [TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)



```csharp
public class TestClass5 : TestClass3
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) -&gt; [SampleToDocument.classes.TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass5.test5innerclass1__saj6gl" />  TestClass5.Test5InnerClass1 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested class inheriting from [TestClass2.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2.testinnerclass__4s3772)



```csharp
public class TestClass5.Test5InnerClass1 : TestClass2.TestInnerClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass2.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2.testinnerclass__4s3772)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass5.test5innerclass2__lmfe4m" />  TestClass5.Test5InnerClass2 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested class inheriting from [TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f)



```csharp
public class TestClass5.Test5InnerClass2 : TestClass3.TestInnerClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass3.TestInnerClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3.testinnerclass__n90o0f)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testclass5.test5innerclass3__1biu08b" />  TestClass5.Test5InnerClass3 Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Nested class inheriting from [TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)



```csharp
public class TestClass5.Test5InnerClass3 : TestClass3
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass2](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass2__dhztj0) -&gt; [SampleToDocument.classes.TestClass3](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass3__dhztiz)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testinternalclass__1q1aqqf" />  TestInternalClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Internal class inheriting from [TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1)



```csharp
internal class TestInternalClass : TestClass1
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [SampleToDocument.classes.TestClass1](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testclass1__dhztj1)           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testpartialclass__w5xcuv" />  TestPartialClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs, classes\Samples.cs</small>


Partial class - part 1



```csharp
public class TestPartialClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [a](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testpartialclass.a__nrxgyi) | private |  | 
 | [b](SampleToDocument.classes__5h92la.md#f-sampletodocument.classes.testpartialclass.b__nrxgyh) | private |  | 

 


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.classes.testpartialclass.a__nrxgyi" />  TestPartialClass.a Field ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Type: [TestPartialClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testpartialclass__w5xcuv)           
Sources: classes\Samples.cs</small>



```csharp
private string a
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="f-sampletodocument.classes.testpartialclass.b__nrxgyh" />  TestPartialClass.b Field ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Type: [TestPartialClass](SampleToDocument.classes__5h92la.md#t-sampletodocument.classes.testpartialclass__w5xcuv)           
Sources: classes\Samples.cs</small>



```csharp
private string b
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.testsealedclass__1tby6cm" />  TestSealedClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Sealed class



```csharp
public sealed class TestSealedClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 


##  <a id="t-sampletodocument.classes.teststaticclass__t01750" />  TestStaticClass Class ##
<small>Namespace: [SampleToDocument.classes](SampleToDocument.classes__5h92la.md#n-sampletodocument.classes__5h92la)           
Assembly: SampleToDocument           
Sources: classes\Samples.cs</small>


Static class



```csharp
internal static class TestStaticClass
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



Go to [namespaces](SampleToDocument.md#namespace-list) or [types](SampleToDocument.md#type-list)


 



