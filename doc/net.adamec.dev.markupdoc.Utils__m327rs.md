#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.utils__m327rs" />  net.adamec.dev.markupdoc.Utils Namespace ##
Utility classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9) | public abstract | Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types | 
 | [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2) | public static | Console output helpers | 
 | [IsNewUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x) | public static | Helpers to get the access to internal ISymbol.IsNew property | 
 | [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) | public | Text builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9" />  BaseDisposable Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Sources: Utils\BaseDisposable.cs</small>


Helper class for implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >System.IDisposable</a> types



```csharp
public abstract class BaseDisposable : IDisposable
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.dev.markupdoc.Markup.MarkupFileWriter](net.adamec.dev.markupdoc.Markup__1918uiv.md#t-net.adamec.dev.markupdoc.markup.markupfilewriter__1xoedys)           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable" target="_blank" >IDisposable</a>


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Disposed](net.adamec.dev.markupdoc.Utils__m327rs.md#p-net.adamec.dev.markupdoc.utils.basedisposable.disposed__18556iw) | public | Flag whether the object is fully disposed | 
 | [DisposedManaged](net.adamec.dev.markupdoc.Utils__m327rs.md#p-net.adamec.dev.markupdoc.utils.basedisposable.disposedmanaged__2sgag1) | public | Flag whether the managed resources are disposed | 
 | [DisposedNative](net.adamec.dev.markupdoc.Utils__m327rs.md#p-net.adamec.dev.markupdoc.utils.basedisposable.disposednative__5yjrj1) | public | Flag whether the native resources are disposed | 

 


###  Destructor ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [~BaseDisposable()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.finalize__18kxll4) | protected |  | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Dispose()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5) | public | Dispose the object | 
 | [Dispose(bool)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose_system.boolean___1n6qg2z) | protected | Internal implementation of dispose - free the managed and native resources using the respective methods | 
 | [DisposeManaged()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.disposemanaged__1oz4q8k) | protected | Dispose any disposable managed fields or properties. | 
 | [DisposeNative()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.disposenative__dinlio) | protected | Dispose of COM objects, Handles, etc. Then set those objects to null. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposed__18556iw" />  BaseDisposable.Disposed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Flag whether the object is fully disposed



```csharp
public bool Disposed { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposedmanaged__2sgag1" />  BaseDisposable.DisposedManaged Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Flag whether the managed resources are disposed



```csharp
public bool DisposedManaged { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.utils.basedisposable.disposednative__5yjrj1" />  BaseDisposable.DisposedNative Property ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Flag whether the native resources are disposed



```csharp
public bool DisposedNative { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.finalize__18kxll4" />  BaseDisposable.~BaseDisposable() Destructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>



```csharp
 ~BaseDisposable()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5" />  BaseDisposable.Dispose() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Dispose the object



```csharp
public void Dispose()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose#System_IDisposable_Dispose" target="_blank" >IDisposable.Dispose</a>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.dispose_system.boolean___1n6qg2z" />  BaseDisposable.Dispose(bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Internal implementation of dispose - free the managed and native resources using the respective methods



```csharp
protected virtual void Dispose(bool disposing)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>disposing</strong></dt><dd>Flag whether the object is disposing (called from [Dispose()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.basedisposable.dispose__xrg0b5) method). False if called from destructor</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.disposemanaged__1oz4q8k" />  BaseDisposable.DisposeManaged() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Dispose any disposable managed fields or properties.



```csharp
protected virtual void DisposeManaged()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.basedisposable.disposenative__dinlio" />  BaseDisposable.DisposeNative() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [BaseDisposable](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.basedisposable__1niv1i9)           
Sources: Utils\BaseDisposable.cs</small>


Dispose of COM objects, Handles, etc. Then set those objects to null.



```csharp
protected virtual void DisposeNative()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2" />  ConsoleUtils Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Sources: Utils\ConsoleUtils.cs</small>


Console output helpers



```csharp
public static class ConsoleUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ColorErr](net.adamec.dev.markupdoc.Utils__m327rs.md#f-net.adamec.dev.markupdoc.utils.consoleutils.colorerr__a9iigc) | public static | Error text color (red) | 
 | [ColorWarn](net.adamec.dev.markupdoc.Utils__m327rs.md#f-net.adamec.dev.markupdoc.utils.consoleutils.colorwarn__1afyv2z) | public static | Warning text color (yellow) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [WriteErr(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writeerr_system.string___1azpq0y) | public static | Writes error <strong>line</strong> to console error output | 
 | [WriteErrWarn(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writeerrwarn_system.string___2xtvma) | public static | Writes warning <strong>line</strong> to console error output | 
 | [WriteInfo(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writeinfo_system.string___3r76tf) | public static | Writes info <strong>line</strong> to console standard output | 
 | [WriteLine(string, ConsoleColor)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.string-system.consolecolor___11tj0l2) | public static | Writes colored <strong>line</strong> to console standard output | 
 | [WriteLine(TextWriter, string, ConsoleColor)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___31kixv) | private static | Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong> | 
 | [WriteWarn(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.consoleutils.writewarn_system.string___xnztmn) | public static | Writes warning <strong>line</strong> to console standard output | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.consoleutils.colorerr__a9iigc" />  ConsoleUtils.ColorErr Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Error text color (red)



```csharp
public static ConsoleColor ColorErr
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.consoleutils.colorwarn__1afyv2z" />  ConsoleUtils.ColorWarn Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Warning text color (yellow)



```csharp
public static ConsoleColor ColorWarn
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeerr_system.string___1azpq0y" />  ConsoleUtils.WriteErr(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes error <strong>line</strong> to console error output



```csharp
public static void WriteErr(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeerrwarn_system.string___2xtvma" />  ConsoleUtils.WriteErrWarn(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes warning <strong>line</strong> to console error output



```csharp
public static void WriteErrWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeinfo_system.string___3r76tf" />  ConsoleUtils.WriteInfo(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes info <strong>line</strong> to console standard output



```csharp
public static void WriteInfo(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.string-system.consolecolor___11tj0l2" />  ConsoleUtils.WriteLine(string, ConsoleColor) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes colored <strong>line</strong> to console standard output



```csharp
public static void WriteLine(string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writeline_system.io.textwriter-system.string-system.consolecolor___31kixv" />  ConsoleUtils.WriteLine(TextWriter, string, ConsoleColor) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes a <strong>line</strong> to (console&#39;s) <strong>writer</strong> with given text <strong>color</strong>



```csharp
private static void WriteLine(TextWriter writer, string line, ConsoleColor color)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.io.textwriter" target="_blank" >System.IO.TextWriter</a> <strong>writer</strong></dt><dd>Console&#39;s writer (standard or error output)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.consolecolor" target="_blank" >System.ConsoleColor</a> <strong>color</strong></dt><dd>Text color to use</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.consoleutils.writewarn_system.string___xnztmn" />  ConsoleUtils.WriteWarn(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [ConsoleUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.consoleutils__xyngj2)           
Sources: Utils\ConsoleUtils.cs</small>


Writes warning <strong>line</strong> to console standard output



```csharp
public static void WriteWarn(string line)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>line</strong></dt><dd>Line to write to console</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x" />  IsNewUtils Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Sources: Utils\IsNewUtils.cs</small>


Helpers to get the access to internal ISymbol.IsNew property



```csharp
public static class IsNewUtils
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsNewPropertyCache](net.adamec.dev.markupdoc.Utils__m327rs.md#f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva) | private static | Cache of the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> s for IsNew properties for individual <em>Microsoft.CodeAnalysis.ISymbol</em> s (types) | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetIsNew(ISymbol)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.isnewutils.getisnew_microsoft.codeanalysis.isymbol___1eu6ykb) | public static | Gets the value of internal IsNew property of given <strong>symbol</strong> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva" />  IsNewUtils.IsNewPropertyCache Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [IsNewUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x)           
Sources: Utils\IsNewUtils.cs</small>


Cache of the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> s for IsNew properties for individual <em>Microsoft.CodeAnalysis.ISymbol</em> s (types)



```csharp
private static readonly Dictionary<System.Type,System.Reflection.PropertyInfo> IsNewPropertyCache
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;System.Type,System.Reflection.PropertyInfo&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.isnewutils.getisnew_microsoft.codeanalysis.isymbol___1eu6ykb" />  IsNewUtils.GetIsNew(ISymbol) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [IsNewUtils](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.isnewutils__slf3x)           
Sources: Utils\IsNewUtils.cs</small>


Gets the value of internal IsNew property of given <strong>symbol</strong>



```csharp
public static bool GetIsNew(this ISymbol symbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a> <strong>symbol</strong></dt><dd>Symbol to get the value from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd>Value of internal IsNew property of given <strong>symbol</strong> or `false` when the property can&#39;t be retrieved</dd></dl>


###  Remarks ###
Uses the reflection to get the access to the internal property IsNew. The retrieved <a href="https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo" target="_blank" >System.Reflection.PropertyInfo</a> is cached in [IsNewPropertyCache](net.adamec.dev.markupdoc.Utils__m327rs.md#f-net.adamec.dev.markupdoc.utils.isnewutils.isnewpropertycache__fi6gva) to minimize the performance impacts.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.txt__ptyt6s" />  Txt Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Sources: Utils\Txt.cs</small>


Text builder



```csharp
public class Txt
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [builder](net.adamec.dev.markupdoc.Utils__m327rs.md#f-net.adamec.dev.markupdoc.utils.txt.builder__g52n25) | private | Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a> | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Txt()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.-ctor__gsw7a4) | public | Creates a new empty text builder | 
 | [Txt(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.-ctor_system.string___1a0kui5) | public | Creates a new text builder with initial <strong>text</strong> | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Func&lt;string&gt;)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.add_system.func_system.string____1qdiz0q) | public | Adds the text returned from <strong>textFunc</strong> to the text builder | 
 | [Add(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.add_system.string___1b5phwl) | public | Adds the <strong>text</strong> to the text builder | 
 | [AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1ef8yye) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder. | 
 | [AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___cg39re) | public | Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(Func&lt;string&gt;, bool)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k) | public | Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [AddIf(string, bool)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.addif_system.string-system.boolean___1hv0ppx) | public | Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true. | 
 | [Clear()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.clear__1gpgbxi) | public | Clear the text builder | 
 | [Start(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.start_system.string___dpjsla) | public static | Creates a new instance ot [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong> | 
 | [ToString()](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.tostring__19rvzdx) | public | Returns the text content of the text builder | 

 


###  Operators and Conversions ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Add(Txt, Txt)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.op_addition_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___e5mhzq) | public static | Concatenates the contents of two text builders | 
 | [BitwiseOr(Txt, Txt)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.op_bitwiseor_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___1fjrb02) | public static | Concatenates the contents of two text builders | 
 | [From(string)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.op_implicit_system.string_dtornet.adamec.dev.markupdoc.utils.txt__1mjf3e7) | public static | Creates a new instance ot [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong> | 
 | [ToString(Txt)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.op_implicit_net.adamec.dev.markupdoc.utils.txt_dtorsystem.string__1dl24tf) | public static | Converts the text builder to string containing its content | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.txt.builder__g52n25" />  Txt.builder Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Internal <a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a>



```csharp
private readonly StringBuilder builder
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder" target="_blank" >System.Text.StringBuilder</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.-ctor__gsw7a4" />  Txt.Txt() Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Creates a new empty text builder



```csharp
public Txt()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.-ctor_system.string___1a0kui5" />  Txt.Txt(string) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Creates a new text builder with initial <strong>text</strong>



```csharp
public Txt(string text)
```

<strong>Constructor parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd></dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.add_system.func_system.string____1qdiz0q" />  Txt.Add(Func&lt;string&gt;) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the text returned from <strong>textFunc</strong> to the text builder



```csharp
public Txt Add(Func<string> textFunc)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.add_system.string___1b5phwl" />  Txt.Add(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the <strong>text</strong> to the text builder



```csharp
public Txt Add(string text)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addeach--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.string___1ef8yye" />  Txt.AddEach&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder.



```csharp
public Txt AddEach<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addeachif--1_system.func_--0-system.string_-system.collections.generic.ienumerable_--0_-system.boolean-system.string___cg39re" />  Txt.AddEachIf&lt;TItemType&gt;(Func&lt;TItemType,string&gt;, IEnumerable&lt;TItemType&gt;, bool, string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the returned from <strong>textFunc</strong> for each items from <strong>items</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddEachIf<TItemType>(Func<TItemType,string> textFunc, IEnumerable<TItemType> items, bool condition, string separator = null)
```

<strong>Type parameters</strong><dl><dt><strong>TItemType</strong></dt><dd></dd></dl>
<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;TItemType,string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;TItemType&gt;</a> <strong>items</strong></dt><dd>Items to generate the output for via <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>separator</strong></dt><dd>Optional separator</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


###  Remarks ###
The <strong>condition</strong> is evaluated once at the beginning of method execution, not for each item.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k" />  Txt.AddIf(Func&lt;string&gt;, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the text returned from <strong>textFunc</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(Func<string> textFunc, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-1" target="_blank" >System.Func&lt;string&gt;</a> <strong>textFunc</strong></dt><dd>Function generating the text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>textFunc</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.addif_system.string-system.boolean___1hv0ppx" />  Txt.AddIf(string, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Adds the <strong>text</strong> to the text builder when the <strong>condition</strong> is true.



```csharp
public Txt AddIf(string text, bool condition)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Text to add</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>condition</strong></dt><dd>Condition that must be true to add the <strong>text</strong></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


###  Remarks ###
If using some code/variable to generate the <strong>text</strong> (for example `AddIf(obj.Container.Text, obj.Container != null)` , the parameter will be evaluated even if the condition is not true ! So the example here will throw NPE when the `obj.Container` is null. Use [AddIf(Func&lt;string&gt;, bool)](net.adamec.dev.markupdoc.Utils__m327rs.md#m-net.adamec.dev.markupdoc.utils.txt.addif_system.func_system.string_-system.boolean___spc04k) ( `AddIf(()=>obj.Container.Text, obj.Container != null)` ) when the function should not be evaluated. Of course `AddIf(obj?.Container?.Text, obj?.Container != null)` null checks are also valid solution.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.clear__1gpgbxi" />  Txt.Clear() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Clear the text builder



```csharp
public Txt Clear()
```

<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>Itself</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.start_system.string___dpjsla" />  Txt.Start(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Creates a new instance ot [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong>



```csharp
public static Txt Start(string text = null)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>A new instance of [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.tostring__19rvzdx" />  Txt.ToString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Returns the text content of the text builder



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The text content of the text builder</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_addition_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___e5mhzq" />  Txt.Add(Txt, Txt) Operator ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator +(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_bitwiseor_net.adamec.dev.markupdoc.utils.txt-net.adamec.dev.markupdoc.utils.txt___1fjrb02" />  Txt.BitwiseOr(Txt, Txt) Operator ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Concatenates the contents of two text builders



```csharp
public static Txt operator |(Txt txt1, Txt txt2)
```

<strong>Operator parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt1</strong></dt><dd></dd><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt2</strong></dt><dd></dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>The first text builder ( <strong>txt1</strong> ) with added text when <strong>txt1</strong> is not null. The second text builder ( <strong>txt2</strong> ) when <strong>txt1</strong> is null. New empty text builder instance when both operands are null</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_implicit_system.string_dtornet.adamec.dev.markupdoc.utils.txt__1mjf3e7" />  Txt.From(string) Conversion ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Creates a new instance ot [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder with optional initial <strong>text</strong>



```csharp
public static Txt op_Implicit(string text)
```

<strong>Conversion parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>text</strong></dt><dd>Optional initial text</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)</dt><dd>A new instance of [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) text builder</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.txt.op_implicit_net.adamec.dev.markupdoc.utils.txt_dtorsystem.string__1dl24tf" />  Txt.ToString(Txt) Conversion ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils](net.adamec.dev.markupdoc.Utils__m327rs.md#n-net.adamec.dev.markupdoc.utils__m327rs)           
Assembly: MarkupDoc           
Type: [Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s)           
Sources: Utils\Txt.cs</small>


Converts the text builder to string containing its content



```csharp
public static string op_Implicit(Txt txt)
```

<strong>Conversion parameters</strong><dl><dt>[net.adamec.dev.markupdoc.Utils.Txt](net.adamec.dev.markupdoc.Utils__m327rs.md#t-net.adamec.dev.markupdoc.utils.txt__ptyt6s) <strong>txt</strong></dt><dd>Text builder</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



