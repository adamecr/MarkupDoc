#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw" />  net.adamec.dev.markupdoc.Utils.Extensions Namespace ##
Extension classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AttributeDataExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y) | public static | Extension methods for <em>Microsoft.CodeAnalysis.AttributeData</em> | 
 | [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0) | public static | Extension methods for <em>Microsoft.CodeAnalysis.IMethodSymbol</em> related to the operators | 
 | [ListOfParametersExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r) | public static | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >System.Collections.Generic.ICollection`1</a> of [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) and [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [ModifierEnumExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re) | public static | Extension methods and factory for [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | 
 | [StringExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz) | public static | Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a> | 
 | [TypeKindExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0) | public static | Extension methods for <em>Microsoft.CodeAnalysis.TypeKind</em> | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y" />  AttributeDataExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\AttributeDataExtensions.cs</small>


Extension methods for <em>Microsoft.CodeAnalysis.AttributeData</em>



```csharp
public static class AttributeDataExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AttributeClassString(AttributeData)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.attributeclassstring_microsoft.codeanalysis.attributedata___2jr23i) | public static | Returns the full name of the attribute class | 
 | [ToCodeString(AttributeData)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.tocodestring_microsoft.codeanalysis.attributedata___yqrz7u) | public static | Gets the string representing the attribute definition in code - class (constructor params, named params) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.attributeclassstring_microsoft.codeanalysis.attributedata___2jr23i" />  AttributeDataExtensions.AttributeClassString(AttributeData) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [AttributeDataExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y)           
Sources: Utils\Extensions\AttributeDataExtensions.cs</small>


Returns the full name of the attribute class



```csharp
public static string AttributeClassString(this AttributeData attributeData)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata" target="_blank" >Microsoft.CodeAnalysis.AttributeData</a> <strong>attributeData</strong></dt><dd>Attribute data to get the class from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Full name of the attribute class</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions.tocodestring_microsoft.codeanalysis.attributedata___yqrz7u" />  AttributeDataExtensions.ToCodeString(AttributeData) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [AttributeDataExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.attributedataextensions__ohfc2y)           
Sources: Utils\Extensions\AttributeDataExtensions.cs</small>


Gets the string representing the attribute definition in code - class (constructor params, named params)



```csharp
public static string ToCodeString(this AttributeData attributeData)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.attributedata" target="_blank" >Microsoft.CodeAnalysis.AttributeData</a> <strong>attributeData</strong></dt><dd>Attribute data to create the code from</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String representing the attribute definition as in code (without [ ] brackets)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0" />  IMethodSymbolExtensionsForOperators Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Extension methods for <em>Microsoft.CodeAnalysis.IMethodSymbol</em> related to the operators



```csharp
public static class IMethodSymbolExtensionsForOperators
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [OperatorMethodAliases](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatormethodaliases__ji0szx) | private static | Dictionary with translation of operator &quot;internal&quot; method name to operator alias (for example op_Addition to Add) | 
 | [OperatorSymbols](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatorsymbols__6tjcmn) | private static | Dictionary with translation of operator &quot;internal&quot; method name to operator symbol (for example op_Addition to +) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IMethodSymbolExtensionsForOperators()](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.-cctor__2vkqjv) | private static | Static CTOR - init operator translation dictionaries | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetOperatorCSharpSymbol(IMethodSymbol)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatorcsharpsymbol_microsoft.codeanalysis.imethodsymbol___1x1ipu) | public static | Get&#39;s the operator symbol for the method representing the operator | 
 | [GetOperatorMethodAliasOrOriginalName(IMethodSymbol)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatormethodaliasororiginalname_microsoft.codeanalysis.imethodsymbol___1e4ys9f) | public static | Get&#39;s the operator alias for the method representing the operator | 
 | [InitOperators()](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.initoperators__1bpzsju) | private static | Initializes operator translation dictionaries (symbols and aliases) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatormethodaliases__ji0szx" />  IMethodSymbolExtensionsForOperators.OperatorMethodAliases Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Dictionary with translation of operator &quot;internal&quot; method name to operator alias (for example op_Addition to Add)



```csharp
private static readonly Dictionary<string,string> OperatorMethodAliases
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.operatorsymbols__6tjcmn" />  IMethodSymbolExtensionsForOperators.OperatorSymbols Field ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Dictionary with translation of operator &quot;internal&quot; method name to operator symbol (for example op_Addition to +)



```csharp
private static readonly Dictionary<string,string> OperatorSymbols
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;string,string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.-cctor__2vkqjv" />  IMethodSymbolExtensionsForOperators.IMethodSymbolExtensionsForOperators() Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Static CTOR - init operator translation dictionaries



```csharp
private static IMethodSymbolExtensionsForOperators()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatorcsharpsymbol_microsoft.codeanalysis.imethodsymbol___1x1ipu" />  IMethodSymbolExtensionsForOperators.GetOperatorCSharpSymbol(IMethodSymbol) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Get&#39;s the operator symbol for the method representing the operator



```csharp
public static string GetOperatorCSharpSymbol(this IMethodSymbol methodSymbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>methodSymbol</strong></dt><dd>Method symbol</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Operator symbol for the method representing the operator or null when unknown or not a user operator method</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.getoperatormethodaliasororiginalname_microsoft.codeanalysis.imethodsymbol___1e4ys9f" />  IMethodSymbolExtensionsForOperators.GetOperatorMethodAliasOrOriginalName(IMethodSymbol) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Get&#39;s the operator alias for the method representing the operator



```csharp
public static string GetOperatorMethodAliasOrOriginalName(this IMethodSymbol methodSymbol)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>methodSymbol</strong></dt><dd>Method symbol</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Operator alias for the method representing the operator or original method name when unknown or not a user operator method</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators.initoperators__1bpzsju" />  IMethodSymbolExtensionsForOperators.InitOperators() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [IMethodSymbolExtensionsForOperators](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.imethodsymbolextensionsforoperators__8jmpz0)           
Sources: Utils\Extensions\IMethodSymbolExtensionsForOperators.cs</small>


Initializes operator translation dictionaries (symbols and aliases)



```csharp
private static void InitOperators()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r" />  ListOfParametersExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\ListOfParametersExtensions.cs</small>


Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1" target="_blank" >System.Collections.Generic.ICollection`1</a> of [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) and [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)



```csharp
public static class ListOfParametersExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetIndexerParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.getindexerparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.methodparameter____1igu6yg) | public static | Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of indexer parameters ( [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) ) to the string as used in code. | 
 | [GetTypeParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.gettypeparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.typeparameter____n8wb9c) | public static | Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) s to the string as used in code. Used for typed parameters with attributes and parameters with variance (variance is at generic interfaces and delegates only) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.getindexerparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.methodparameter____1igu6yg" />  ListOfParametersExtensions.GetIndexerParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ListOfParametersExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r)           
Sources: Utils\Extensions\ListOfParametersExtensions.cs</small>


Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of indexer parameters ( [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) ) to the string as used in code.



```csharp
public static string GetIndexerParametersCode(this IEnumerable<net.adamec.dev.markupdoc.CodeModel.MethodParameter> methodParameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a> <strong>methodParameters</strong></dt><dd>List of indexer method parameters</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Code string representation of the list of indexer parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions.gettypeparameterscode_system.collections.generic.ienumerable_net.adamec.dev.markupdoc.codemodel.typeparameter____n8wb9c" />  ListOfParametersExtensions.GetTypeParametersCode(IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ListOfParametersExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.listofparametersextensions__exfx5r)           
Sources: Utils\Extensions\ListOfParametersExtensions.cs</small>


Converts the <a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >System.Collections.Generic.IEnumerable`1</a> of [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) s to the string as used in code. Used for typed parameters with attributes and parameters with variance (variance is at generic interfaces and delegates only)



```csharp
public static string GetTypeParametersCode(this IEnumerable<net.adamec.dev.markupdoc.CodeModel.TypeParameter> typeParameters)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a> <strong>typeParameters</strong></dt><dd>List of type parameters</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Code string representation of the list of type parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re" />  ModifierEnumExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\ModifierEnumExtensions.cs</small>


Extension methods and factory for [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)



```csharp
public static class ModifierEnumExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Modifier(Accessibility)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.modifier_microsoft.codeanalysis.accessibility___adiiyc) | public static | Creates the modifier from given <strong>accessibility</strong> | 
 | [ToModifierString(ModifierEnum)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.tomodifierstring_net.adamec.dev.markupdoc.codemodel.modifierenum___hgk62q) | public static | Converts the [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) to string that can be used in code | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.modifier_microsoft.codeanalysis.accessibility___adiiyc" />  ModifierEnumExtensions.Modifier(Accessibility) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ModifierEnumExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re)           
Sources: Utils\Extensions\ModifierEnumExtensions.cs</small>


Creates the modifier from given <strong>accessibility</strong>



```csharp
public static ModifierEnum Modifier(Accessibility accessibility)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.accessibility" target="_blank" >Microsoft.CodeAnalysis.Accessibility</a> <strong>accessibility</strong></dt><dd>Accessibility to create the [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) from</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd>[ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) from given <strong>accessibility</strong></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions.tomodifierstring_net.adamec.dev.markupdoc.codemodel.modifierenum___hgk62q" />  ModifierEnumExtensions.ToModifierString(ModifierEnum) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [ModifierEnumExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.modifierenumextensions__1vu62re)           
Sources: Utils\Extensions\ModifierEnumExtensions.cs</small>


Converts the [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) to string that can be used in code



```csharp
public static string ToModifierString(this ModifierEnum modifierEnum)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) <strong>modifierEnum</strong></dt><dd>Modifier to convert</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>&quot;Code compatible&quot; modifier string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz" />  StringExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\StringExtensions.cs</small>


Extension methods for <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >System.String</a>



```csharp
public static class StringExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FirstLetterToUpper(string)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.firstlettertoupper_system.string___j3gt9g) | public static | Converts the first letter of string to upper case | 
 | [HtmlDecode(string)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmldecode_system.string___j83xey) | public static | HTML decodes the string | 
 | [HtmlEncode(string)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmlencode_system.string___1lb4xh2) | public static | HTML encodes the string | 
 | [TrimAndMergeLines(string)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.trimandmergelines_system.string___85g233) | public static | &quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.firstlettertoupper_system.string___j3gt9g" />  StringExtensions.FirstLetterToUpper(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)           
Sources: Utils\Extensions\StringExtensions.cs</small>


Converts the first letter of string to upper case



```csharp
public static string FirstLetterToUpper(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to convert</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String with the first letter in upper case</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmldecode_system.string___j83xey" />  StringExtensions.HtmlDecode(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)           
Sources: Utils\Extensions\StringExtensions.cs</small>


HTML decodes the string



```csharp
public static string HtmlDecode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to decode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML decoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.htmlencode_system.string___1lb4xh2" />  StringExtensions.HtmlEncode(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)           
Sources: Utils\Extensions\StringExtensions.cs</small>


HTML encodes the string



```csharp
public static string HtmlEncode(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to encode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>HTML encoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.stringextensions.trimandmergelines_system.string___85g233" />  StringExtensions.TrimAndMergeLines(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [StringExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.stringextensions__1jm6pgz)           
Sources: Utils\Extensions\StringExtensions.cs</small>


&quot;Full&quot; trim of the string - the lines within the string are trimmed and then the lines are merged with the space as a separator (instead of the line break)



```csharp
public static string TrimAndMergeLines(this string str)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>str</strong></dt><dd>String to full trim</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>&quot;Fully&quot; trimmed string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0" />  TypeKindExtensions Class ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Sources: Utils\Extensions\TypeKindExtensions.cs</small>


Extension methods for <em>Microsoft.CodeAnalysis.TypeKind</em>



```csharp
public static class TypeKindExtensions
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToTypeKindEnum(TypeKind)](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#m-net.adamec.dev.markupdoc.utils.extensions.typekindextensions.totypekindenum_microsoft.codeanalysis.typekind___b5txcz) | public static | Converts the <em>Microsoft.CodeAnalysis.TypeKind</em> to [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.utils.extensions.typekindextensions.totypekindenum_microsoft.codeanalysis.typekind___b5txcz" />  TypeKindExtensions.ToTypeKindEnum(TypeKind) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.Utils.Extensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#n-net.adamec.dev.markupdoc.utils.extensions__1a7eavw)           
Assembly: MarkupDoc           
Type: [TypeKindExtensions](net.adamec.dev.markupdoc.Utils.Extensions__1a7eavw.md#t-net.adamec.dev.markupdoc.utils.extensions.typekindextensions__1hqh8t0)           
Sources: Utils\Extensions\TypeKindExtensions.cs</small>


Converts the <em>Microsoft.CodeAnalysis.TypeKind</em> to [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)



```csharp
public static TypeKindEnum ToTypeKindEnum(this TypeKind typeKind)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.typekind" target="_blank" >Microsoft.CodeAnalysis.TypeKind</a> <strong>typeKind</strong></dt><dd>TypeKind to convert</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd>TypeKindEnum from the TypeKind</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



