#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.codemodel__1f8sg55" />  net.adamec.dev.markupdoc.CodeModel Namespace ##
Code model related classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | public | Represents an assembly within the code model | 
 | [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | public | Represents an event within the code model | 
 | [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | public | Represents a field within the code model | 
 | [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | public abstract | Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc. | 
 | [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | public | Represents a method within the code model | 
 | [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | public | Represents a method parameter within the code model | 
 | [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | public | Represents a namespace within the code model | 
 | [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | public | Represents a property within the code model | 
 | [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | public | Represents a root of the code model | 
 | [RootMember.ProcessingInfoContainer](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn) | public | Processing information | 
 | [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | public abstract | Abstract class for type members (fields, properties, etc.) within the code model | 
 | [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | public | Represents a type within the code model | 
 | [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | public | Represents a type parameter within the code model | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) | public | Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types. There is only single TypeRef for a type even if used on multiple &quot;places&quot; | 

 


###  Enums ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0) | public | Possible member kinds | 
 | [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9) | public | Possible kinds of method symbols | 
 | [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel) | public | Possible access modifiers | 
 | [RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7) | public | Possible reference parameter kinds | 
 | [SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km) | public | Possible split definitions | 
 | [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm) | public | Possible kinds of type symbol | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j" />  AssemblyMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\AssemblyMember.cs</small>


Represents an assembly within the code model



```csharp
public class AssemblyMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllTypes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.assemblymember.alltypes__4kuzf7) | public | List of all types (including interfaces, delegates, etc.) defined within the assembly | 
 | [Namespaces](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.assemblymember.namespaces__88sxjl) | public | List of namespaces within the assembly | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMember(AssemblyMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.assemblymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder___nqmg6r) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.assemblymember.alltypes__4kuzf7" />  AssemblyMember.AllTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)           
Sources: CodeModel\AssemblyMember.cs</small>


List of all types (including interfaces, delegates, etc.) defined within the assembly



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> AllTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.assemblymember.namespaces__88sxjl" />  AssemblyMember.Namespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)           
Sources: CodeModel\AssemblyMember.cs</small>


List of namespaces within the assembly



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.NamespaceMember> Namespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.NamespaceMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.assemblymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder___nqmg6r" />  AssemblyMember.AssemblyMember(AssemblyMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)           
Sources: CodeModel\AssemblyMember.cs</small>


CTOR - from builder



```csharp
public AssemblyMember(AssemblyMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l" />  EventMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\EventMember.cs</small>


Represents an event within the code model



```csharp
public class EventMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasExplicitAddAndRemove](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.eventmember.hasexplicitaddandremove__1jois6b) | public | Flag whether the event has explicit implementation of add and remove accessors | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.eventmember.typeref__1klwzm2) | public | Delegate type (type reference) of the event handler | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [EventMember(EventMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.eventmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder___ggrb3b) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.eventmember.hasexplicitaddandremove__1jois6b" />  EventMember.HasExplicitAddAndRemove Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)           
Sources: CodeModel\EventMember.cs</small>


Flag whether the event has explicit implementation of add and remove accessors



```csharp
public bool HasExplicitAddAndRemove { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.eventmember.typeref__1klwzm2" />  EventMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)           
Sources: CodeModel\EventMember.cs</small>


Delegate type (type reference) of the event handler



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.eventmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder___ggrb3b" />  EventMember.EventMember(EventMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)           
Sources: CodeModel\EventMember.cs</small>


CTOR - from builder



```csharp
public EventMember(EventMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z" />  FieldMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\FieldMember.cs</small>


Represents a field within the code model



```csharp
public class FieldMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConstantValue](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.fieldmember.constantvalue__16xaw06) | public | The constant value of the field | 
 | [IsConst](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isconst__ynfeu8) | public | Flag whether the field is constant | 
 | [IsReadOnly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isreadonly__wmv1mh) | public | Flag whether the field is read only | 
 | [IsVolatile](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.fieldmember.isvolatile__b4otyf) | public | Flag whether the field is volatile | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.fieldmember.typeref__167hm5u) | public | Type (type reference) of the field value | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [FieldMember(FieldMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.fieldmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder___1fpgncf) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetConstantValueString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.fieldmember.getconstantvaluestring__10j93v2) | public | Gets the constant value as string with &quot;code syntax&quot; (meaning how would be the value defined in the code) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.constantvalue__16xaw06" />  FieldMember.ConstantValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


The constant value of the field



```csharp
public object ConstantValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Remarks ###
The ConstantValue is not the definition (for example &quot;2+customId&quot;) but the value is evaluated to the target type (for example 1002 if the customId in previous example is constant 1000). It&#39;s also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isconst__ynfeu8" />  FieldMember.IsConst Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


Flag whether the field is constant



```csharp
public bool IsConst { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isreadonly__wmv1mh" />  FieldMember.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


Flag whether the field is read only



```csharp
public bool IsReadOnly { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.isvolatile__b4otyf" />  FieldMember.IsVolatile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


Flag whether the field is volatile



```csharp
public bool IsVolatile { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.fieldmember.typeref__167hm5u" />  FieldMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


Type (type reference) of the field value



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.fieldmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder___1fpgncf" />  FieldMember.FieldMember(FieldMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


CTOR - from builder



```csharp
public FieldMember(FieldMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.fieldmember.getconstantvaluestring__10j93v2" />  FieldMember.GetConstantValueString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)           
Sources: CodeModel\FieldMember.cs</small>


Gets the constant value as string with &quot;code syntax&quot; (meaning how would be the value defined in the code)



```csharp
public string GetConstantValueString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The constant value constant</dd></dl>


###  Remarks ###
The constant value is stored as the object, so it&#39;s necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh" />  Member Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Member.cs</small>


Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc.



```csharp
public abstract class Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.dev.markupdoc.CodeModel.AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j), [net.adamec.dev.markupdoc.CodeModel.NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li), [net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj), [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw), [net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           



###  Remarks ###
The code model should not be manipulated (changed) once built, however for the sake of the simplicity, the setters are currently kept public. This might change in future when (if) the MarkupDoc will come with greater extensibility


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Base36Chars](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.member.base36chars__l4rdpm) | 0123456789abcdefghijklmnopqrstuvwxyz | Characters allowed in Base36 encoding | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllMembers](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.allmembers__19b310x) | public | All child members, for example types for namespace; fields, properties, methods, etc. for types | 
 | [Anchor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.anchor__18l6dou) | public | Anchor to the member to point the links  (FileName.extension#Anchor) to proper part of generated output file. | 
 | [Assembly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.assembly__qc3fud) | public | Reference to the containing assembly member | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.attributes__rcsj8a) | public | Member&#39;s attributes definition (including the parameters). | 
 | [AttributeTypeRefs](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.attributetyperefs__1fb8l8x) | public | Types (type references) of the member attributes | 
 | [Documentation](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) | public | Parsed XML documentation comments. [Documentation](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) is the root element of the parsed XML documentation comments | 
 | [DocumentationId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) | public | Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod) | 
 | [DocumentationXml](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentationxml__4przj0) | public | XML documentation comments | 
 | [FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq) | public | File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor) | 
 | [Id](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq) | public | Member id, used to distinguish between the names when building the &quot;internal&quot; links (for example when ti difference is in case only) | 
 | [IsAbstract](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isabstract__1gf9bb1) | public | Flag whether the member is abstract | 
 | [IsExtern](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isextern__1tt02ct) | public | Flag whether the member is extern | 
 | [IsNew](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isnew__1y68kz9) | public | Flag whether the member hides member with the same name in base class | 
 | [IsOverride](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isoverride__hfq1uh) | public | Flag whether the member overrides the member in the base class | 
 | [IsSealed](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.issealed__f7nzi7) | public | Flag whether the member is sealed | 
 | [IsStatic](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isstatic__5j9jyt) | public | Flag whether the member is static | 
 | [IsVirtual](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.isvirtual__1ha2d4u) | public | Flag whether the member is virtual (can be overriden) | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.memberkind__vd33lr) | public | Kind (type) of the member | 
 | [Modifier](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.modifier__11o4ay6) | public | Member modifier (public, private, etc.) | 
 | [Name](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w) | public | Name of the member as presented in generated output | 
 | [NameBase](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.namebase__j1nvad) | public | Name of the member without type params, indexer params, operator params, etc. | 
 | [Namespace](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.namespace__1asgr92) | public | Reference to the containing namespace member | 
 | [Root](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.root__gg0v8x) | public | Reference to the root of the code model | 
 | [SourceFiles](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.sourcefiles__dplo3j) | public | Source file defining the member | 
 | [Symbol](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.symbol__t0bfa1) | public | Roslyn semantic analysis symbol of the member | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Member(MemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.-ctor_net.adamec.dev.markupdoc.codemodel.builder.memberbuilder___z47b5f) | protected | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Base36(uint)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.base36_system.uint32___1qf9alr) | public static | Encodes the <strong>input</strong> number to Base36 encoded string | 
 | [FormatAnchor()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.formatanchor__17xjba4) | protected | Creates and format the anchor based on the [DocumentationId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) . In general, it gets the DocumentationID, trims is, converts it to lower case and replaces the &quot;special&quot; characters with &#39;_&#39; or &#39;-&#39; | 
 | [StableHash(string)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.stablehash_system.string___1fyn53c) | public static | Hashing function for strings that generates the sting hash as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >System.UInt32</a> | 
 | [ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm) | public | Returns the brief description of the member | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.member.base36chars__l4rdpm" />  Member.Base36Chars Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Characters allowed in Base36 encoding



```csharp
private const string Base36Chars = "0123456789abcdefghijklmnopqrstuvwxyz"
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.allmembers__19b310x" />  Member.AllMembers Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


All child members, for example types for namespace; fields, properties, methods, etc. for types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.Member> AllMembers { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.anchor__18l6dou" />  Member.Anchor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Anchor to the member to point the links  (FileName.extension#Anchor) to proper part of generated output file.



```csharp
public virtual string Anchor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.assembly__qc3fud" />  Member.Assembly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Reference to the containing assembly member



```csharp
public AssemblyMember Assembly { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.attributes__rcsj8a" />  Member.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Member&#39;s attributes definition (including the parameters).



```csharp
public IReadOnlyList<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.attributetyperefs__1fb8l8x" />  Member.AttributeTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Types (type references) of the member attributes



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AttributeTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl" />  Member.Documentation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Parsed XML documentation comments. [Documentation](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentation__6xwakl) is the root element of the parsed XML documentation comments



```csharp
public Documentation Documentation { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Documentation](net.adamec.dev.markupdoc.XmlDocumentation__1ter1y6.md#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi" />  Member.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)



```csharp
public string DocumentationId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.documentationxml__4przj0" />  Member.DocumentationXml Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


XML documentation comments



```csharp
public string DocumentationXml { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq" />  Member.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor)



```csharp
public virtual string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq" />  Member.Id Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Member id, used to distinguish between the names when building the &quot;internal&quot; links (for example when ti difference is in case only)



```csharp
public string Id { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
Id is not necessary unique across all members, but the combination [Name](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w) + [Id](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.id__1m648yq) is believed to be unique. The Id is created/updated when the [DocumentationId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) is set and it&#39;s calculated as Base36 encoded hash of the DocumentationId




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isabstract__1gf9bb1" />  Member.IsAbstract Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member is abstract



```csharp
public bool IsAbstract { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isextern__1tt02ct" />  Member.IsExtern Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member is extern



```csharp
public bool IsExtern { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isnew__1y68kz9" />  Member.IsNew Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member hides member with the same name in base class



```csharp
public bool IsNew { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isoverride__hfq1uh" />  Member.IsOverride Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member overrides the member in the base class



```csharp
public bool IsOverride { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.issealed__f7nzi7" />  Member.IsSealed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member is sealed



```csharp
public bool IsSealed { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isstatic__5j9jyt" />  Member.IsStatic Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member is static



```csharp
public bool IsStatic { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.isvirtual__1ha2d4u" />  Member.IsVirtual Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Flag whether the member is virtual (can be overriden)



```csharp
public bool IsVirtual { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.memberkind__vd33lr" />  Member.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Kind (type) of the member



```csharp
public MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.modifier__11o4ay6" />  Member.Modifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Member modifier (public, private, etc.)



```csharp
public ModifierEnum Modifier { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.name__1cwkr6w" />  Member.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Name of the member as presented in generated output



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.namebase__j1nvad" />  Member.NameBase Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Name of the member without type params, indexer params, operator params, etc.



```csharp
public string NameBase { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.namespace__1asgr92" />  Member.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Reference to the containing namespace member



```csharp
public NamespaceMember Namespace { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.root__gg0v8x" />  Member.Root Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Reference to the root of the code model



```csharp
public RootMember Root { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.sourcefiles__dplo3j" />  Member.SourceFiles Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Source file defining the member



```csharp
public IReadOnlyList<string> SourceFiles { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.member.symbol__t0bfa1" />  Member.Symbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Roslyn semantic analysis symbol of the member



```csharp
public ISymbol Symbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.-ctor_net.adamec.dev.markupdoc.codemodel.builder.memberbuilder___z47b5f" />  Member.Member(MemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


CTOR - from builder



```csharp
protected Member(MemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.base36_system.uint32___1qf9alr" />  Member.Base36(uint) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Encodes the <strong>input</strong> number to Base36 encoded string



```csharp
public static string Base36(uint input)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >uint</a> <strong>input</strong></dt><dd>Number to encode</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Base36 encoded string</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.formatanchor__17xjba4" />  Member.FormatAnchor() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Creates and format the anchor based on the [DocumentationId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.documentationid__nvdczi) . In general, it gets the DocumentationID, trims is, converts it to lower case and replaces the &quot;special&quot; characters with &#39;_&#39; or &#39;-&#39;



```csharp
protected string FormatAnchor()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The anchor for the member</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.stablehash_system.string___1fyn53c" />  Member.StableHash(string) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Hashing function for strings that generates the sting hash as <a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >System.UInt32</a>



```csharp
public static uint StableHash(string s)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>s</strong></dt><dd>String to hash</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.uint32" target="_blank" >uint</a></dt><dd>Hash of given string</dd></dl>


###  Remarks ###
The hash function is based on the .NET implementation of <a href="https://docs.microsoft.com/en-us/dotnet/api/system.string.gethashcode#System_String_GetHashCode" target="_blank" >System.String.GetHashCode</a> optimized for 64bit processors. The reason for the explicit hash function is that the .NET implementation is not granted to be stable across versions and/or frameworks. The stability is needed as the Base36 encoded hash is a part of the file name and may be used in perma links


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm" />  Member.ToString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Sources: CodeModel\Member.cs</small>


Returns the brief description of the member



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the member</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq" />  MethodMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\MethodMember.cs</small>


Represents a method within the code model



```csharp
public class MethodMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasParameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.hasparameters__1rxkvrw) | public | Flag whether the method has parameters | 
 | [IsAsync](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isasync__ytfsx0) | public | Flag whether the method is async | 
 | [IsConstructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isconstructor__ywn7v4) | public | Flag whether the method is construction | 
 | [IsConversion](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isconversion__b8j9og) | public | Flag whether the method is conversion | 
 | [IsDestructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isdestructor__ju36r5) | public | Flag whether the method is destructor | 
 | [IsExtensionMethod](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isextensionmethod__18y7t40) | public | Flag whether the method is extension method | 
 | [IsGeneric](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isgeneric__8ey4iz) | public | Flag whether method is generic | 
 | [IsOperator](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperator__1wwd9so) | public | Flag whether the method is operator | 
 | [IsOperatorOrConversion](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperatororconversion__1csdo8z) | public | Flag whether the method is operator or conversion | 
 | [MethodKind](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.methodkind__1xifuon) | public | Kind of the method (constructor, getter, regular method ...) | 
 | [OperatorCSharpSymbol](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.operatorcsharpsymbol__1q138b9) | public | C# operator symbol for operator method | 
 | [Parameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.parameters__17bkuxc) | public | Method parameters | 
 | [RefKind](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.refkind__2zcm51) | public | Method&#39;s return ref kind (none, ref) | 
 | [ReturnsByRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyref__vlkvqj) | public | Flag whether the methods returns by reference | 
 | [ReturnsByRefReadonly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyrefreadonly__1dy3n4d) | public | Flag whether the methods returns by read only reference (ref readonly) | 
 | [ReturnsVoid](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsvoid__1x5yr6t) | public | Flags whether the method returns void | 
 | [ReturnTypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.returntyperef__1kqintr) | public | Type reference of the method return type | 
 | [TypeParameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodmember.typeparameters__ceqh5s) | public | Type parameters for generic methods | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MethodMember(MethodMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.methodmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder___brj243) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.hasparameters__1rxkvrw" />  MethodMember.HasParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method has parameters



```csharp
public bool HasParameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isasync__ytfsx0" />  MethodMember.IsAsync Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is async



```csharp
public bool IsAsync { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isconstructor__ywn7v4" />  MethodMember.IsConstructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is construction



```csharp
public bool IsConstructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isconversion__b8j9og" />  MethodMember.IsConversion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is conversion



```csharp
public bool IsConversion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isdestructor__ju36r5" />  MethodMember.IsDestructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is destructor



```csharp
public bool IsDestructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isextensionmethod__18y7t40" />  MethodMember.IsExtensionMethod Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is extension method



```csharp
public bool IsExtensionMethod { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isgeneric__8ey4iz" />  MethodMember.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether method is generic



```csharp
public bool IsGeneric { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperator__1wwd9so" />  MethodMember.IsOperator Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is operator



```csharp
public bool IsOperator { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.isoperatororconversion__1csdo8z" />  MethodMember.IsOperatorOrConversion Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the method is operator or conversion



```csharp
public bool IsOperatorOrConversion { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.methodkind__1xifuon" />  MethodMember.MethodKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Kind of the method (constructor, getter, regular method ...)



```csharp
public MethodKindEnum MethodKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.operatorcsharpsymbol__1q138b9" />  MethodMember.OperatorCSharpSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


C# operator symbol for operator method



```csharp
public string OperatorCSharpSymbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.parameters__17bkuxc" />  MethodMember.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Method parameters



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.refkind__2zcm51" />  MethodMember.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Method&#39;s return ref kind (none, ref)



```csharp
public RefKindEnum RefKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyref__vlkvqj" />  MethodMember.ReturnsByRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the methods returns by reference



```csharp
public bool ReturnsByRef { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsbyrefreadonly__1dy3n4d" />  MethodMember.ReturnsByRefReadonly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flag whether the methods returns by read only reference (ref readonly)



```csharp
public bool ReturnsByRefReadonly { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returnsvoid__1x5yr6t" />  MethodMember.ReturnsVoid Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Flags whether the method returns void



```csharp
public bool ReturnsVoid { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.returntyperef__1kqintr" />  MethodMember.ReturnTypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Type reference of the method return type



```csharp
public TypeRef ReturnTypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodmember.typeparameters__ceqh5s" />  MethodMember.TypeParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


Type parameters for generic methods



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder___brj243" />  MethodMember.MethodMember(MethodMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)           
Sources: CodeModel\MethodMember.cs</small>


CTOR - from builder



```csharp
public MethodMember(MethodMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483" />  MethodParameter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\MethodParameter.cs</small>


Represents a method parameter within the code model



```csharp
public class MethodParameter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.attributes__njhgum) | public | Parameter attributes definition (including the parameters). | 
 | [ExplicitDefaultValue](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.explicitdefaultvalue__1tgn3en) | public | Parameter&#39;s explicitly defined default value (when available) | 
 | [HasExplicitDefaultValue](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.hasexplicitdefaultvalue__163byvx) | public | Flag whether the parameter has explicitly defined default value | 
 | [IsOptional](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isoptional__k07gdx) | public | Flag whether the parameter is optional | 
 | [IsParams](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isparams__1r0stz3) | public | Flag whether the parameter is with `params` modifier | 
 | [IsThis](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65) | public | Flag whether the parameter is with `this` modifier | 
 | [Name](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.name__1wzjmfo) | public | Name of the parameter | 
 | [RefKind](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.refkind__1vi47va) | public | Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In) | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.typeref__1j0ijds) | public | Type reference for the parameter&#39;s type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MethodParameter(MethodParameterBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.methodparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder___bbc2rj) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetDefaultValueString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.methodparameter.getdefaultvaluestring__1q0k02v) | public | Gets the default value for the parameter as string with &quot;code syntax&quot; (meaning how would be the value defined in the code) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.attributes__njhgum" />  MethodParameter.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Parameter attributes definition (including the parameters).



```csharp
public IReadOnlyList<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.explicitdefaultvalue__1tgn3en" />  MethodParameter.ExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Parameter&#39;s explicitly defined default value (when available)



```csharp
public object ExplicitDefaultValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.hasexplicitdefaultvalue__163byvx" />  MethodParameter.HasExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Flag whether the parameter has explicitly defined default value



```csharp
public bool HasExplicitDefaultValue { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isoptional__k07gdx" />  MethodParameter.IsOptional Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Flag whether the parameter is optional



```csharp
public bool IsOptional { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isparams__1r0stz3" />  MethodParameter.IsParams Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Flag whether the parameter is with `params` modifier



```csharp
public bool IsParams { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65" />  MethodParameter.IsThis Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Flag whether the parameter is with `this` modifier



```csharp
public bool IsThis { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.name__1wzjmfo" />  MethodParameter.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Name of the parameter



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.refkind__1vi47va" />  MethodParameter.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In)



```csharp
public RefKindEnum RefKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.methodparameter.typeref__1j0ijds" />  MethodParameter.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Type reference for the parameter&#39;s type



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder___bbc2rj" />  MethodParameter.MethodParameter(MethodParameterBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


CTOR - from builder



```csharp
public MethodParameter(MethodParameterBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.methodparameter.getdefaultvaluestring__1q0k02v" />  MethodParameter.GetDefaultValueString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)           
Sources: CodeModel\MethodParameter.cs</small>


Gets the default value for the parameter as string with &quot;code syntax&quot; (meaning how would be the value defined in the code)



```csharp
public string GetDefaultValueString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The default value for the parameter or empty string if not defined</dd></dl>


###  Remarks ###
The default value is stored as the object, so it&#39;s necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li" />  NamespaceMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\NamespaceMember.cs</small>


Represents a namespace within the code model



```csharp
public class NamespaceMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsGlobalNamespace](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.namespacemember.isglobalnamespace__1q6idri) | public | Flag whether the namespace is global | 
 | [Types](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.namespacemember.types__16yd0zn) | public | List of all types (including interfaces, delegates, etc.) defined within the namespace | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [NamespaceMember(NamespaceMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.namespacemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder___1wmw5ar) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.namespacemember.tostring__pk2xyj) | public | Returns the brief description of the namespace | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.namespacemember.isglobalnamespace__1q6idri" />  NamespaceMember.IsGlobalNamespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)           
Sources: CodeModel\NamespaceMember.cs</small>


Flag whether the namespace is global



```csharp
public bool IsGlobalNamespace { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.namespacemember.types__16yd0zn" />  NamespaceMember.Types Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)           
Sources: CodeModel\NamespaceMember.cs</small>


List of all types (including interfaces, delegates, etc.) defined within the namespace



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> Types { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.namespacemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder___1wmw5ar" />  NamespaceMember.NamespaceMember(NamespaceMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)           
Sources: CodeModel\NamespaceMember.cs</small>


CTOR - from builder



```csharp
public NamespaceMember(NamespaceMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.namespacemember.tostring__pk2xyj" />  NamespaceMember.ToString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)           
Sources: CodeModel\NamespaceMember.cs</small>


Returns the brief description of the namespace



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the namespace</dd></dl>Overrides: [Member.ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu" />  PropertyMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\PropertyMember.cs</small>


Represents a property within the code model



```csharp
public class PropertyMember : TypeContentMember
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) -&gt; [net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetterModifier](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.gettermodifier__17x8k4y) | public | Getter access modifier if it&#39;s different than the property one | 
 | [IsIndexer](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.isindexer__mmbewf) | public | Flag whether the property is indexer; | 
 | [IsReadOnly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.isreadonly__10ggxbi) | public | Flag whether the property is read only | 
 | [IsWriteOnly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.iswriteonly__s5y7lf) | public | Flag whether the property is write only | 
 | [Parameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.parameters__j2iqt4) | public | List of property parameters (if any). Just the indexers may have the parameters | 
 | [SetterModifier](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.settermodifier__j66486) | public | Setter access modifier if it&#39;s different than the property one | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.propertymember.typeref__3apeoh) | public | Type reference of property type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [PropertyMember(PropertyMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.propertymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder___1x2uhir) | public | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.gettermodifier__17x8k4y" />  PropertyMember.GetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Getter access modifier if it&#39;s different than the property one



```csharp
public string GetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.isindexer__mmbewf" />  PropertyMember.IsIndexer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Flag whether the property is indexer;



```csharp
public bool IsIndexer { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.isreadonly__10ggxbi" />  PropertyMember.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Flag whether the property is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.iswriteonly__s5y7lf" />  PropertyMember.IsWriteOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Flag whether the property is write only



```csharp
public bool IsWriteOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.parameters__j2iqt4" />  PropertyMember.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


List of property parameters (if any). Just the indexers may have the parameters



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.settermodifier__j66486" />  PropertyMember.SetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Setter access modifier if it&#39;s different than the property one



```csharp
public string SetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.propertymember.typeref__3apeoh" />  PropertyMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


Type reference of property type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.propertymember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder___1x2uhir" />  PropertyMember.PropertyMember(PropertyMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           
Sources: CodeModel\PropertyMember.cs</small>


CTOR - from builder



```csharp
public PropertyMember(PropertyMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj" />  RootMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\RootMember.cs</small>


Represents a root of the code model



```csharp
public class RootMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddOns](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.addons__1j9odmo) | public | Optional list of add-ons | 
 | [AllMembersByDocId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbydocid__lvh671) | public | Dictionary of all members by their documentation ID | 
 | [AllMembersBySourceFile](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbysourcefile__1dx754b) | public | Dictionary of all members by their source file | 
 | [AllMembersBySymbol](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbysymbol__5nme1w) | public | Dictionary of all members by their Roslyn <em>Microsoft.CodeAnalysis.ISymbol</em> | 
 | [AllNamespaces](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.allnamespaces__uj34ta) | public | List of namespaces within the code model | 
 | [AllTypeRefs](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.alltyperefs__loe4tc) | public | List of all type references used within the code model | 
 | [AllTypes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.alltypes__1vf7rd7) | public | List of all types (including interfaces, delegates, etc.) defined within the code model | 
 | [Assemblies](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih) | public | List of all assemblies defined within the code model | 
 | [ProcessingInfo](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfo__1h25pqs) | public | Processing information. This is the only part that can be modified after the code model is built as it&#39;s used to adjust the behavior during the processing within markup generator | 
 | [ProjectRootDir](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.projectrootdir__iedlt) | public | Full path to the project root directory | 
 | [TypeImplementsInterfaceList](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.typeimplementsinterfacelist__1xj5fc) | public | List of all direct and indirect interface-implementation type pairs | 
 | [TypeInheritsFromTypeList](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.typeinheritsfromtypelist__1mluucj) | public | List of all inheritance pairs (member, parent) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RootMember(RootMemberBuilder, IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.rootmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.collections.generic.ienumerable_net.adamec.dev.markupdoc.addons.iaddon____js8pq6) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AddOnsSelector(Func&lt;net.adamec.dev.markupdoc.AddOns.IAddOn,int&gt;)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.rootmember.addonsselector_system.func_net.adamec.dev.markupdoc.addons.iaddon-system.int32____4fhqxg) | public | Return list of add-ons having the <strong>prioritySelector</strong> &gt; 0 ordered by the priority. When  no add-ons applies, the empty list is returned | 
 | [GetDerivedTypeMembers(TypeMember)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.rootmember.getderivedtypemembers_net.adamec.dev.markupdoc.codemodel.typemember___1daom5o) | public | Gets the inherited (children) [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong> | 
 | [GetParentTypeMember(TypeMember)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.rootmember.getparenttypemember_net.adamec.dev.markupdoc.codemodel.typemember___1wu79xm) | public | Gets the parent [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong> | 
 | [GetTypeMembersImplementingInterface(TypeMember)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.rootmember.gettypemembersimplementinginterface_net.adamec.dev.markupdoc.codemodel.typemember___678kix) | public | Gets the [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) implementing <strong>type</strong> (interface) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.addons__1j9odmo" />  RootMember.AddOns Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Optional list of add-ons



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.AddOns.IAddOn> AddOns { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbydocid__lvh671" />  RootMember.AllMembersByDocId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Dictionary of all members by their documentation ID



```csharp
public IReadOnlyDictionary<string,net.adamec.dev.markupdoc.CodeModel.Member> AllMembersByDocId { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,net.adamec.dev.markupdoc.CodeModel.Member&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbysourcefile__1dx754b" />  RootMember.AllMembersBySourceFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Dictionary of all members by their source file



```csharp
public IReadOnlyDictionary<string,IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.Member>> AllMembersBySourceFile { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;string,IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.Member&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allmembersbysymbol__5nme1w" />  RootMember.AllMembersBySymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Dictionary of all members by their Roslyn <em>Microsoft.CodeAnalysis.ISymbol</em>



```csharp
public IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol,net.adamec.dev.markupdoc.CodeModel.Member> AllMembersBySymbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;Microsoft.CodeAnalysis.ISymbol,net.adamec.dev.markupdoc.CodeModel.Member&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.allnamespaces__uj34ta" />  RootMember.AllNamespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of namespaces within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.NamespaceMember> AllNamespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.NamespaceMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.alltyperefs__loe4tc" />  RootMember.AllTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of all type references used within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.alltypes__1vf7rd7" />  RootMember.AllTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of all types (including interfaces, delegates, etc.) defined within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> AllTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih" />  RootMember.Assemblies Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of all assemblies defined within the code model



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.AssemblyMember> Assemblies { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.AssemblyMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfo__1h25pqs" />  RootMember.ProcessingInfo Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Processing information. This is the only part that can be modified after the code model is built as it&#39;s used to adjust the behavior during the processing within markup generator



```csharp
public RootMember.ProcessingInfoContainer ProcessingInfo { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember.ProcessingInfoContainer](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.projectrootdir__iedlt" />  RootMember.ProjectRootDir Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Full path to the project root directory



```csharp
public string ProjectRootDir { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.typeimplementsinterfacelist__1xj5fc" />  RootMember.TypeImplementsInterfaceList Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of all direct and indirect interface-implementation type pairs



```csharp
public IReadOnlyList<System.Collections.Generic.KeyValuePair<net.adamec.dev.markupdoc.CodeModel.TypeMember,net.adamec.dev.markupdoc.CodeModel.TypeMember>> TypeImplementsInterfaceList { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;System.Collections.Generic.KeyValuePair&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember,net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.typeinheritsfromtypelist__1mluucj" />  RootMember.TypeInheritsFromTypeList Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


List of all inheritance pairs (member, parent)



```csharp
public IReadOnlyList<System.Collections.Generic.KeyValuePair<net.adamec.dev.markupdoc.CodeModel.TypeMember,net.adamec.dev.markupdoc.CodeModel.TypeMember>> TypeInheritsFromTypeList { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;System.Collections.Generic.KeyValuePair&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember,net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.collections.generic.ienumerable_net.adamec.dev.markupdoc.addons.iaddon____js8pq6" />  RootMember.RootMember(RootMemberBuilder, IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


CTOR - from builder



```csharp
public RootMember(RootMemberBuilder builder, IEnumerable<net.adamec.dev.markupdoc.AddOns.IAddOn> addOns)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>builder</strong></dt><dd>Builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;</a> <strong>addOns</strong></dt><dd>Optional list of add-ons</dd></dl>
###  Remarks ###
Use the [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) to build the whole code model hierarchy from the [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) that contains such hierarchy and the details about individual entities


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.addonsselector_system.func_net.adamec.dev.markupdoc.addons.iaddon-system.int32____4fhqxg" />  RootMember.AddOnsSelector(Func&lt;net.adamec.dev.markupdoc.AddOns.IAddOn,int&gt;) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Return list of add-ons having the <strong>prioritySelector</strong> &gt; 0 ordered by the priority. When  no add-ons applies, the empty list is returned



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.AddOns.IAddOn> AddOnsSelector(Func<net.adamec.dev.markupdoc.AddOns.IAddOn,int> prioritySelector)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.func-2" target="_blank" >System.Func&lt;net.adamec.dev.markupdoc.AddOns.IAddOn,int&gt;</a> <strong>prioritySelector</strong></dt><dd>Priority selector</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;</a></dt><dd>List of add-ons having the <strong>prioritySelector</strong> &gt; 0 ordered by the priority</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.getderivedtypemembers_net.adamec.dev.markupdoc.codemodel.typemember___1daom5o" />  RootMember.GetDerivedTypeMembers(TypeMember) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Gets the inherited (children) [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong>



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> GetDerivedTypeMembers(TypeMember type)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) <strong>type</strong></dt><dd>Type to get the parent for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd>List of inherited (children) [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong></dd></dl>


###  Remarks ###
This method should not be used to generic check for the inheritance. It&#39;s intended to get the children existing within the project being documented! When the child of <strong>type</strong> is not defined within project, there is no corresponding [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) and such inheritance info will not be part of the list returned


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.getparenttypemember_net.adamec.dev.markupdoc.codemodel.typemember___1wu79xm" />  RootMember.GetParentTypeMember(TypeMember) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Gets the parent [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong>



```csharp
public TypeMember GetParentTypeMember(TypeMember type)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) <strong>type</strong></dt><dd>Type to get the parent for</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd>The parent [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) of given <strong>type</strong> or null</dd></dl>


###  Remarks ###
This method should not be used to generic check for the inheritance. It&#39;s intended to get the parent existing within the project being documented! When the parent of <strong>type</strong> is not defined within project, there is no [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) for the parent and the returned value will be null.


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.rootmember.gettypemembersimplementinginterface_net.adamec.dev.markupdoc.codemodel.typemember___678kix" />  RootMember.GetTypeMembersImplementingInterface(TypeMember) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)           
Sources: CodeModel\RootMember.cs</small>


Gets the [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) implementing <strong>type</strong> (interface)



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeMember> GetTypeMembersImplementingInterface(TypeMember type)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) <strong>type</strong></dt><dd>Interface to get the implementations for</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeMember&gt;</a></dt><dd>List of [type members](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) implementing <strong>type</strong> (interface)</dd></dl>


###  Remarks ###
This method should not be used to generic check for the interface implementation. It&#39;s intended to get the &quot;in-project&quot; type members implementing given interface. When the interface is implemented by type that is not defined within project, there is no corresponding [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) and such implemented interface info will not be part of the list returned


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn" />  RootMember.ProcessingInfoContainer Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\RootMember.cs</small>


Processing information



```csharp
public class RootMember.ProcessingInfoContainer
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [BaseMainFile](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.basemainfile__t5z7wx) | public | Name of the main (index) file without the path and extension | 
 | [SplitFileType](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.splitfiletype__gcnbr9) | public | Information whether and how to split the output (none, per namespace, per type) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.basemainfile__t5z7wx" />  RootMember.ProcessingInfoContainer.BaseMainFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember.ProcessingInfoContainer](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)           
Sources: CodeModel\RootMember.cs</small>


Name of the main (index) file without the path and extension



```csharp
public string BaseMainFile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer.splitfiletype__gcnbr9" />  RootMember.ProcessingInfoContainer.SplitFileType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RootMember.ProcessingInfoContainer](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember.processinginfocontainer__2hw0vn)           
Sources: CodeModel\RootMember.cs</small>


Information whether and how to split the output (none, per namespace, per type)



```csharp
public SplitTypeEnum SplitFileType { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw" />  TypeContentMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\TypeContentMember.cs</small>


Abstract class for type members (fields, properties, etc.) within the code model



```csharp
public abstract class TypeContentMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           
Derived: [net.adamec.dev.markupdoc.CodeModel.EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l), [net.adamec.dev.markupdoc.CodeModel.FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z), [net.adamec.dev.markupdoc.CodeModel.MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq), [net.adamec.dev.markupdoc.CodeModel.PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExplicitInterfaceImplementationMemberSymbol](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.explicitinterfaceimplementationmembersymbol__1vjakud) | public | Symbol of explicitly implemented interface member | 
 | [FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7) | public | File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor) | 
 | [ImplementsMembers](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.implementsmembers__1m1r4w5) | public | Members implemented by this member (if any) | 
 | [ImplementsSymbols](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.implementssymbols__9hzrj7) | public | Symbols of members implemented by this member (if any) | 
 | [OverridesMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.overridesmember__1o4qx21) | public | Member overriden by this member (if any) | 
 | [OverridesSymbol](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.overridessymbol__1xa3vrj) | public | Symbol of member overriden by this member (if any) | 
 | [Type](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2) | public | Type containing the content member | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeContentMember(TypeContentMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typecontentmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder___180rpzv) | protected | CTOR - from builder | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.explicitinterfaceimplementationmembersymbol__1vjakud" />  TypeContentMember.ExplicitInterfaceImplementationMemberSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Symbol of explicitly implemented interface member



```csharp
public ISymbol ExplicitInterfaceImplementationMemberSymbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7" />  TypeContentMember.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is also used when building the links to the member (FileName.extension#Anchor)



```csharp
public override string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: [Member.FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq)


###  Remarks ###
Type content is rendered together with type, so the [FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.filename__1agakr7) is taken from [Type](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.implementsmembers__1m1r4w5" />  TypeContentMember.ImplementsMembers Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Members implemented by this member (if any)



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeContentMember> ImplementsMembers { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeContentMember&gt;</a></dt><dd></dd></dl>


###  Remarks ###
ImplementsMembers contain the same number of elements as [ImplementsSymbols](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typecontentmember.implementssymbols__9hzrj7) . When there is not member corresponding to the symbol, the ImplementsMembers item is null


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.implementssymbols__9hzrj7" />  TypeContentMember.ImplementsSymbols Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Symbols of members implemented by this member (if any)



```csharp
public IReadOnlyList<Microsoft.CodeAnalysis.ISymbol> ImplementsSymbols { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;Microsoft.CodeAnalysis.ISymbol&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.overridesmember__1o4qx21" />  TypeContentMember.OverridesMember Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Member overriden by this member (if any)



```csharp
public TypeContentMember OverridesMember { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.overridessymbol__1xa3vrj" />  TypeContentMember.OverridesSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Symbol of member overriden by this member (if any)



```csharp
public ISymbol OverridesSymbol { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typecontentmember.type__lnqvp2" />  TypeContentMember.Type Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


Type containing the content member



```csharp
public TypeMember Type { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typecontentmember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder___180rpzv" />  TypeContentMember.TypeContentMember(TypeContentMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)           
Sources: CodeModel\TypeContentMember.cs</small>


CTOR - from builder



```csharp
protected TypeContentMember(TypeContentMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp" />  TypeMember Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\TypeMember.cs</small>


Represents a type within the code model



```csharp
public class TypeMember : Member
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DelegateParameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typemember.delegateparameters__1qbjoam) | public | Delegate parameters for delegate types | 
 | [DelegateReturnType](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typemember.delegatereturntype__bzbjz4) | public | Type reference for delegate return type | 
 | [TypeParameters](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typemember.typeparameters__994fx3) | public | Type parameters for generic types | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllInterfacesTypeRefs](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.allinterfacestyperefs__glhkkw) | public | Type references for all implemented interfaces (both directly implemented and inherited) | 
 | [Constructors](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.constructors__r1xvmy) | public | All constructors defined within the type | 
 | [Conversions](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.conversions__1u10dmc) | public | All conversions defined within the type | 
 | [Destructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.destructor__xpqlhc) | public | Destructor defined within the type or null if none | 
 | [Events](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.events__13nod8q) | public | All events defined within the type | 
 | [Fields](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.fields__1mn3d06) | public | All fields defined within the type | 
 | [FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.filename__t0861a) | public | File name (without extension !!!) where the type should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is used when building the links to the member (FileName.extension#Anchor) | 
 | [FullName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.fullname__1f38d4f) | public | Type full name (namespace.type) | 
 | [ImplementsAnyInterface](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.implementsanyinterface__1kg40n4) | public | Flag whether the type implements any (at least one) interface | 
 | [InterfaceImplementationsByInterfaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.interfaceimplementationsbyinterfacemember__1gc7a5l) | public | Dictionary of  interface member implementation by interface member (key=interface member symbol, value=implementation member symbol) | 
 | [InterfaceMembersByInterfaceImplementation](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.interfacemembersbyinterfaceimplementation__bc5ap5) | public | Dictionary of implemented interface members by implementation member (key=implementation member symbol, value=interface member symbol) | 
 | [InterfacesTypeRefs](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.interfacestyperefs__11tpv8v) | public | Type references for directly implemented interfaces | 
 | [IsDelegate](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.isdelegate__1w85a6g) | public | Flag whether type is delegate | 
 | [IsGeneric](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.isgeneric__1l3ysmo) | public | Flag whether type is generic | 
 | [IsInherited](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.isinherited__17xrtn5) | public | Flag whether the type is inherited (applicable to classes only) | 
 | [Methods](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.methods__5f6ltb) | public | All methods defined within the type | 
 | [Operators](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.operators__li6pd8) | public | All operators defined within the type | 
 | [OperatorsAndConversions](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.operatorsandconversions__g20s4y) | public | All operators and conversions defined within the type | 
 | [Properties](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.properties__148da3a) | public | All properties defined within the type | 
 | [TypeKind](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.typekind__1eer5mr) | public | Type kind (class, interface, ...) | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typemember.typeref__12qbfl8) | public | Type reference for this type | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeMember(TypeMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder___1xi7kkz) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typemember.tostring__19326cy) | public | Returns the brief description of the type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.delegateparameters__1qbjoam" />  TypeMember.DelegateParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Delegate parameters for delegate types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodParameter> DelegateParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.delegatereturntype__bzbjz4" />  TypeMember.DelegateReturnType Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type reference for delegate return type



```csharp
public TypeRef DelegateReturnType
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typemember.typeparameters__994fx3" />  TypeMember.TypeParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type parameters for generic types



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.allinterfacestyperefs__glhkkw" />  TypeMember.AllInterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type references for all implemented interfaces (both directly implemented and inherited)



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllInterfacesTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.constructors__r1xvmy" />  TypeMember.Constructors Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All constructors defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Constructors { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.conversions__1u10dmc" />  TypeMember.Conversions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All conversions defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Conversions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.destructor__xpqlhc" />  TypeMember.Destructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Destructor defined within the type or null if none



```csharp
public MethodMember Destructor { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.events__13nod8q" />  TypeMember.Events Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All events defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.EventMember> Events { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.EventMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.fields__1mn3d06" />  TypeMember.Fields Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All fields defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.FieldMember> Fields { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.FieldMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.filename__t0861a" />  TypeMember.FileName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


File name (without extension !!!) where the type should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string. This is used when building the links to the member (FileName.extension#Anchor)



```csharp
public override string FileName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>Overrides: [Member.FileName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.member.filename__1u5e2zq)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.fullname__1f38d4f" />  TypeMember.FullName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type full name (namespace.type)



```csharp
public string FullName { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.implementsanyinterface__1kg40n4" />  TypeMember.ImplementsAnyInterface Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Flag whether the type implements any (at least one) interface



```csharp
public bool ImplementsAnyInterface { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.interfaceimplementationsbyinterfacemember__1gc7a5l" />  TypeMember.InterfaceImplementationsByInterfaceMember Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Dictionary of  interface member implementation by interface member (key=interface member symbol, value=implementation member symbol)



```csharp
public IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.ISymbol> InterfaceImplementationsByInterfaceMember { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.ISymbol&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.interfacemembersbyinterfaceimplementation__bc5ap5" />  TypeMember.InterfaceMembersByInterfaceImplementation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Dictionary of implemented interface members by implementation member (key=implementation member symbol, value=interface member symbol)



```csharp
public IReadOnlyDictionary<Microsoft.CodeAnalysis.ISymbol,IReadOnlyList<Microsoft.CodeAnalysis.ISymbol>> InterfaceMembersByInterfaceImplementation { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2" target="_blank" >System.Collections.Generic.IReadOnlyDictionary&lt;Microsoft.CodeAnalysis.ISymbol,IReadOnlyList&lt;Microsoft.CodeAnalysis.ISymbol&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.interfacestyperefs__11tpv8v" />  TypeMember.InterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type references for directly implemented interfaces



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.TypeRef> InterfacesTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isdelegate__1w85a6g" />  TypeMember.IsDelegate Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Flag whether type is delegate



```csharp
public bool IsDelegate { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isgeneric__1l3ysmo" />  TypeMember.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Flag whether type is generic



```csharp
public bool IsGeneric { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.isinherited__17xrtn5" />  TypeMember.IsInherited Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Flag whether the type is inherited (applicable to classes only)



```csharp
public bool IsInherited { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.methods__5f6ltb" />  TypeMember.Methods Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All methods defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Methods { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.operators__li6pd8" />  TypeMember.Operators Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All operators defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> Operators { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.operatorsandconversions__g20s4y" />  TypeMember.OperatorsAndConversions Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All operators and conversions defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.MethodMember> OperatorsAndConversions { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.MethodMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.properties__148da3a" />  TypeMember.Properties Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


All properties defined within the type



```csharp
public IReadOnlyList<net.adamec.dev.markupdoc.CodeModel.PropertyMember> Properties { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlylist-1" target="_blank" >IReadOnlyList&lt;net.adamec.dev.markupdoc.CodeModel.PropertyMember&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.typekind__1eer5mr" />  TypeMember.TypeKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type kind (class, interface, ...)



```csharp
public TypeKindEnum TypeKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typemember.typeref__12qbfl8" />  TypeMember.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Type reference for this type



```csharp
public TypeRef TypeRef { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typemember.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder___1xi7kkz" />  TypeMember.TypeMember(TypeMemberBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


CTOR - from builder



```csharp
public TypeMember(TypeMemberBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typemember.tostring__19326cy" />  TypeMember.ToString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)           
Sources: CodeModel\TypeMember.cs</small>


Returns the brief description of the type



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>The brief description of the type</dd></dl>Overrides: [Member.ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.member.tostring__zfv5tm)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408" />  TypeParameter Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\TypeParameter.cs</small>


Represents a type parameter within the code model



```csharp
public class TypeParameter
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.attributes__inz4tx) | public | Type parameter attributes definition (including the parameters). | 
 | [ConstraintTypes](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.constrainttypes__z92o1e) | public | List of type references of constraint types  when the concrete types are defined as constraints | 
 | [HasAnyConstraint](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasanyconstraint__1iy1zr7) | public | Flag whether the type parameter has any constraint | 
 | [HasConstructorConstraint](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasconstructorconstraint__wqv9qt) | public | Flag whether the type parameter has constructor constraint ( new() ) | 
 | [HasReferenceTypeConstraint](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasreferencetypeconstraint__143rl1s) | public | Flag whether the type parameter has reference type constraint ( class ) | 
 | [HasUnmanagedTypeConstraint](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasunmanagedtypeconstraint__nm7zzj) | public | Flag whether the type parameter has unmanaged type constraint ( unmanaged ) | 
 | [HasValueTypeConstraint](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasvaluetypeconstraint__1ukksns) | public | Flag whether the type parameter has value type constraint ( struct ) | 
 | [Name](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.name__1h5j7x) | public | Name of the parameter | 
 | [Variance](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeparameter.variance__a30lyr) | public | Variance (covariance and contravariance) modifier (in, out) for the type parameter if available. | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [TypeParameter(TypeParameterBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder___nocdp7) | public | CTOR - from builder | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetConstraintsString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeparameter.getconstraintsstring__iddb2s) | public | Returns the string with all constraints as defined in code | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.attributes__inz4tx" />  TypeParameter.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Type parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.constrainttypes__z92o1e" />  TypeParameter.ConstraintTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


List of type references of constraint types  when the concrete types are defined as constraints



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> ConstraintTypes { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasanyconstraint__1iy1zr7" />  TypeParameter.HasAnyConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Flag whether the type parameter has any constraint



```csharp
public bool HasAnyConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasconstructorconstraint__wqv9qt" />  TypeParameter.HasConstructorConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Flag whether the type parameter has constructor constraint ( new() )



```csharp
public bool HasConstructorConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasreferencetypeconstraint__143rl1s" />  TypeParameter.HasReferenceTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Flag whether the type parameter has reference type constraint ( class )



```csharp
public bool HasReferenceTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasunmanagedtypeconstraint__nm7zzj" />  TypeParameter.HasUnmanagedTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Flag whether the type parameter has unmanaged type constraint ( unmanaged )



```csharp
public bool HasUnmanagedTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.hasvaluetypeconstraint__1ukksns" />  TypeParameter.HasValueTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Flag whether the type parameter has value type constraint ( struct )



```csharp
public bool HasValueTypeConstraint { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.name__1h5j7x" />  TypeParameter.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Name of the parameter



```csharp
public string Name { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeparameter.variance__a30lyr" />  TypeParameter.Variance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.



```csharp
public string Variance { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeparameter.-ctor_net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder___nocdp7" />  TypeParameter.TypeParameter(TypeParameterBuilder) Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


CTOR - from builder



```csharp
public TypeParameter(TypeParameterBuilder builder)
```

<strong>Constructor parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w) <strong>builder</strong></dt><dd>Builder</dd></dl>
Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeparameter.getconstraintsstring__iddb2s" />  TypeParameter.GetConstraintsString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)           
Sources: CodeModel\TypeParameter.cs</small>


Returns the string with all constraints as defined in code



```csharp
public string GetConstraintsString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>String with all constraints as defined in code</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm" />  TypeRef Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\TypeRef.cs</small>


Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types. There is only single TypeRef for a type even if used on multiple &quot;places&quot;



```csharp
public class TypeRef
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ArrayElementType](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.arrayelementtype__byw1yl) | public | Type reference of array element type when available | 
 | [Base](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.base__9jxpo3) | public | Base (parent) type when available | 
 | [BaseExclObject](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.baseexclobject__uyu8rc) | public | Base (parent) type excluding the System.Object, when available | 
 | [DocumentationId](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.documentationid__1fruy65) | public | Documentation ID of type when available | 
 | [EnumValueType](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.enumvaluetype__1wygike) | public | Underlying value type name for enums | 
 | [GenericArity](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.genericarity__1yz9ryu) | public | Generic type arity (number of type parameters) when available | 
 | [GenericBaseName](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.genericbasename__iwu9kd) | public | Base name (without the type parameters) for generic types | 
 | [GenericDefinition](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.genericdefinition__7s13og) | public | Base generic type when available - used for the types that have applied generic parameters. In such case, GenericDefinition refers to the &quot;original&quot; type | 
 | [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.member__nc9l46) | public | Corresponding type member from the code model when available | 
 | [Name](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.name__ic643d) | public | Name of the type | 
 | [Namespace](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.typeref.namespace__1oofukd) | public | Containing namespace of type | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ApplySpecialName(bool)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.boolean___1blwydr) | public | Applies the type special name for the current type reference | 
 | [ApplySpecialName(ITypeSymbol, bool)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_microsoft.codeanalysis.itypesymbol-system.boolean___fzp5cf) | public static | Applies the type special name for given <strong>typeSymbol</strong> | 
 | [ApplySpecialName(string, string, bool)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) | private static | Applies the type special name for given type described by namespace and <strong>name</strong> | 
 | [GetOrCreate(ITypeSymbol, RootMemberBuilder)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.getorcreate_microsoft.codeanalysis.itypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___dytfda) | public static | Gets the [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) from the <em>Microsoft.CodeAnalysis.ITypeSymbol</em> . When such TypeRef doesn&#39;t exist yet, it&#39;s created. | 
 | [ToString()](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.tostring__ql1z7x) | public | Gets the brief description - name - of the type reference | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.arrayelementtype__byw1yl" />  TypeRef.ArrayElementType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Type reference of array element type when available



```csharp
public TypeRef ArrayElementType { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.base__9jxpo3" />  TypeRef.Base Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Base (parent) type when available



```csharp
public TypeRef Base { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.baseexclobject__uyu8rc" />  TypeRef.BaseExclObject Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Base (parent) type excluding the System.Object, when available



```csharp
public TypeRef BaseExclObject { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.documentationid__1fruy65" />  TypeRef.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Documentation ID of type when available



```csharp
public string DocumentationId { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.enumvaluetype__1wygike" />  TypeRef.EnumValueType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Underlying value type name for enums



```csharp
public string EnumValueType { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericarity__1yz9ryu" />  TypeRef.GenericArity Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Generic type arity (number of type parameters) when available



```csharp
public int GenericArity { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericbasename__iwu9kd" />  TypeRef.GenericBaseName Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Base name (without the type parameters) for generic types



```csharp
public string GenericBaseName { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.genericdefinition__7s13og" />  TypeRef.GenericDefinition Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Base generic type when available - used for the types that have applied generic parameters. In such case, GenericDefinition refers to the &quot;original&quot; type



```csharp
public TypeRef GenericDefinition { get; private set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.member__nc9l46" />  TypeRef.Member Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Corresponding type member from the code model when available



```csharp
public TypeMember Member { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.name__ic643d" />  TypeRef.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Name of the type



```csharp
public string Name { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.typeref.namespace__1oofukd" />  TypeRef.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Containing namespace of type



```csharp
public string Namespace { get; private set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.boolean___1blwydr" />  TypeRef.ApplySpecialName(bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Applies the type special name for the current type reference



```csharp
public string ApplySpecialName(bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
See [ApplySpecialName(string, string, bool)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_microsoft.codeanalysis.itypesymbol-system.boolean___fzp5cf" />  TypeRef.ApplySpecialName(ITypeSymbol, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Applies the type special name for given <strong>typeSymbol</strong>



```csharp
public static string ApplySpecialName(ITypeSymbol typeSymbol, bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol" target="_blank" >Microsoft.CodeAnalysis.ITypeSymbol</a> <strong>typeSymbol</strong></dt><dd></dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
See [ApplySpecialName(string, string, bool)](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv) for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.applyspecialname_system.string-system.string-system.boolean___1q0wvwv" />  TypeRef.ApplySpecialName(string, string, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Applies the type special name for given type described by namespace and <strong>name</strong>



```csharp
private static string ApplySpecialName(string ns, string name, bool includeNamespaceIfNotSpecial = true)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>ns</strong></dt><dd>Namespace containing the type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>name</strong></dt><dd>Name of the type</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>includeNamespaceIfNotSpecial</strong></dt><dd>Include the namespace to the output in case that the special name is not applicable</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Special name of the type or original name (with or without namespace as defined by <strong>includeNamespaceIfNotSpecial</strong> ) when the special name is not applicable</dd></dl>


###  Remarks ###
Special name is actually the simplified and/or common name for selected types. For example &quot;string&quot; for &quot;System.String&quot;, &quot;bool&quot; for &quot;System.Boolean&quot;, &quot;int&quot; for &quot;System.Int32&quot;. The simplification means removing the well known namespace (System, System.Collections, ...), using the common name for some types (bool, int, double, ...), replacing Nullable&lt;T&gt; with &quot;T?&quot; syntax. Special names for System namespace: bool, byte, char, DateTime, decimal, double, Enum, IAsyncResult, IDisposable, short, int, long, object, sbyte, float, string, ushort, uint, ulong, void, Delegate, MulticastDelegate, ValueType, Attribute.

 Special names for System.Collections.Generic namespace: ICollection, IDictionary, IEnumerable, IEnumerator, IList, IReadOnlyCollection, IReadOnlyList, List, Dictionary, HashSet, Queue, Stack (all as generics).

 Special names for System.Collections namespace: ICollection, IDictionary, IEnumerable, IDictionary, IEnumerator, IList, Hashtable, Queue, Stack, ArrayList, SortedList.




Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.getorcreate_microsoft.codeanalysis.itypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___dytfda" />  TypeRef.GetOrCreate(ITypeSymbol, RootMemberBuilder) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Gets the [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) from the <em>Microsoft.CodeAnalysis.ITypeSymbol</em> . When such TypeRef doesn&#39;t exist yet, it&#39;s created.



```csharp
public static TypeRef GetOrCreate(ITypeSymbol symbol, RootMemberBuilder root)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.itypesymbol" target="_blank" >Microsoft.CodeAnalysis.ITypeSymbol</a> <strong>symbol</strong></dt><dd>Type symbol to get the TypeRef for</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder keeping the list of all type references</dd></dl>
<strong>Return value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd>[TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm) corresponding to the <strong>symbol</strong></dd></dl>


###  Remarks ###
The list of existing type references is held by [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) .


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.typeref.tostring__ql1z7x" />  TypeRef.ToString() Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)           
Sources: CodeModel\TypeRef.cs</small>


Gets the brief description - name - of the type reference



```csharp
public override string ToString()
```

<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd>Brief description - name - of the type reference</dd></dl>Overrides: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object.tostring#System_Object_ToString" target="_blank" >object.ToString</a>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0" />  MemberKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible member kinds



```csharp
public enum MemberKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Unknown](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.unknown__1t9t5bu) | 0 | Member type is unknown or not set | 
 | [Root](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.root__boynuw) | 1 | Member is the root | 
 | [Assembly](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.assembly__195rcdw) | 2 | Member is assembly | 
 | [Namespace](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.namespace__1nsxwyd) | 3 | Member is namespace | 
 | [Type](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.type__m8zl20) | 4 | Member is type | 
 | [Event](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.event__kroq58) | 5 | Member is event | 
 | [Field](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.field__1rsexl4) | 6 | Members is field | 
 | [Property](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.property__1p6vnkt) | 7 | Member is property | 
 | [Method](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.memberkindenum.method__1yfg25h) | 8 | Member is method | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.assembly__195rcdw" />  MemberKindEnum.Assembly Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is assembly



```csharp
 Assembly = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.event__kroq58" />  MemberKindEnum.Event Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is event



```csharp
 Event = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.field__1rsexl4" />  MemberKindEnum.Field Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Members is field



```csharp
 Field = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.method__1yfg25h" />  MemberKindEnum.Method Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is method



```csharp
 Method = 8
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.namespace__1nsxwyd" />  MemberKindEnum.Namespace Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is namespace



```csharp
 Namespace = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.property__1p6vnkt" />  MemberKindEnum.Property Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is property



```csharp
 Property = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.root__boynuw" />  MemberKindEnum.Root Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is the root



```csharp
 Root = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.type__m8zl20" />  MemberKindEnum.Type Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member is type



```csharp
 Type = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.memberkindenum.unknown__1t9t5bu" />  MemberKindEnum.Unknown Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)           
Sources: CodeModel\Enums.cs</small>


Member type is unknown or not set



```csharp
 Unknown = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9" />  MethodKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible kinds of method symbols



```csharp
public enum MethodKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [AnonymousFunction](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.anonymousfunction__1oee5xm) | 0 | An anonymous method or lambda expression | 
 | [LambdaMethod](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.lambdamethod__9dx2i9) | 0 |  | 
 | [Constructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.constructor__1nz33wd) | 1 | Method is a constructor. | 
 | [Conversion](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.conversion__y33wax) | 2 | Method is a conversion. | 
 | [DelegateInvoke](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.delegateinvoke__11hlzmy) | 3 | Method is a delegate invoke. | 
 | [Destructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.destructor__uituse) | 4 | Method is a destructor. | 
 | [EventAdd](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventadd__jebxkq) | 5 | Method is an event add. | 
 | [EventRaise](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventraise__mzxxud) | 6 | Method is an event raise. | 
 | [EventRemove](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventremove__1n75nqj) | 7 | Method is an event remove. | 
 | [ExplicitInterfaceImplementation](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.explicitinterfaceimplementation__16hqzay) | 8 | Method is an explicit interface implementation. | 
 | [UserDefinedOperator](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.userdefinedoperator__11f8k5d) | 9 | Method is an operator. | 
 | [Ordinary](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.ordinary__owbfct) | 10 | Method is an ordinary method. | 
 | [PropertyGet](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyget__1jgaww0) | 11 | Method is a property get. | 
 | [PropertySet](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyset__1jgaxd8) | 12 | Method is a property set. | 
 | [ReducedExtension](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.reducedextension__7k1du2) | 13 | An extension method with the &quot;this&quot; parameter removed. | 
 | [SharedConstructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.sharedconstructor__j724eo) | 14 |  | 
 | [StaticConstructor](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.staticconstructor__6rfcqt) | 14 | Method is a static constructor. | 
 | [BuiltinOperator](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.builtinoperator__2mxmg0) | 15 | A built-in operator. | 
 | [DeclareMethod](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.declaremethod__cyhzzk) | 16 | Declare Sub or Function. | 
 | [LocalFunction](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.methodkindenum.localfunction__1o14ddk) | 17 | Method is declared inside of another method. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.anonymousfunction__1oee5xm" />  MethodKindEnum.AnonymousFunction Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


An anonymous method or lambda expression



```csharp
 AnonymousFunction = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.builtinoperator__2mxmg0" />  MethodKindEnum.BuiltinOperator Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


A built-in operator.



```csharp
 BuiltinOperator = 15
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.constructor__1nz33wd" />  MethodKindEnum.Constructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a constructor.



```csharp
 Constructor = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.conversion__y33wax" />  MethodKindEnum.Conversion Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a conversion.



```csharp
 Conversion = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.declaremethod__cyhzzk" />  MethodKindEnum.DeclareMethod Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Declare Sub or Function.



```csharp
 DeclareMethod = 16
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.delegateinvoke__11hlzmy" />  MethodKindEnum.DelegateInvoke Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a delegate invoke.



```csharp
 DelegateInvoke = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.destructor__uituse" />  MethodKindEnum.Destructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a destructor.



```csharp
 Destructor = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventadd__jebxkq" />  MethodKindEnum.EventAdd Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an event add.



```csharp
 EventAdd = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventraise__mzxxud" />  MethodKindEnum.EventRaise Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an event raise.



```csharp
 EventRaise = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.eventremove__1n75nqj" />  MethodKindEnum.EventRemove Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an event remove.



```csharp
 EventRemove = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.explicitinterfaceimplementation__16hqzay" />  MethodKindEnum.ExplicitInterfaceImplementation Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an explicit interface implementation.



```csharp
 ExplicitInterfaceImplementation = 8
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.lambdamethod__9dx2i9" />  MethodKindEnum.LambdaMethod Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>



```csharp
 LambdaMethod = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.localfunction__1o14ddk" />  MethodKindEnum.LocalFunction Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is declared inside of another method.



```csharp
 LocalFunction = 17
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.ordinary__owbfct" />  MethodKindEnum.Ordinary Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an ordinary method.



```csharp
 Ordinary = 10
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyget__1jgaww0" />  MethodKindEnum.PropertyGet Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a property get.



```csharp
 PropertyGet = 11
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.propertyset__1jgaxd8" />  MethodKindEnum.PropertySet Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a property set.



```csharp
 PropertySet = 12
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.reducedextension__7k1du2" />  MethodKindEnum.ReducedExtension Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


An extension method with the &quot;this&quot; parameter removed.



```csharp
 ReducedExtension = 13
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.sharedconstructor__j724eo" />  MethodKindEnum.SharedConstructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>



```csharp
 SharedConstructor = 14
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.staticconstructor__6rfcqt" />  MethodKindEnum.StaticConstructor Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is a static constructor.



```csharp
 StaticConstructor = 14
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.methodkindenum.userdefinedoperator__11f8k5d" />  MethodKindEnum.UserDefinedOperator Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)           
Sources: CodeModel\Enums.cs</small>


Method is an operator.



```csharp
 UserDefinedOperator = 9
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel" />  ModifierEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible access modifiers



```csharp
public enum ModifierEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [NotApplicable](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.notapplicable__1c9bqep) | 0 | Not applicable/unknown | 
 | [Public](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.public__16bc72i) | 1 | Member is public | 
 | [Private](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.private__10gl1bm) | 2 | Member is private | 
 | [Protected](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.protected__ghfrnv) | 3 | Member is protected | 
 | [Internal](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.internal__1fcelle) | 4 | Member is internal | 
 | [ProtectedInternal](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.protectedinternal__1u0qjgu) | 5 | Member is protected internal (protected or internal) | 
 | [PrivateProtected](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.modifierenum.privateprotected__16sulww) | 6 | Member is private protected (protected and internal) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.internal__1fcelle" />  ModifierEnum.Internal Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is internal



```csharp
 Internal = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.notapplicable__1c9bqep" />  ModifierEnum.NotApplicable Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Not applicable/unknown



```csharp
 NotApplicable = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.private__10gl1bm" />  ModifierEnum.Private Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is private



```csharp
 Private = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.privateprotected__16sulww" />  ModifierEnum.PrivateProtected Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is private protected (protected and internal)



```csharp
 PrivateProtected = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.protected__ghfrnv" />  ModifierEnum.Protected Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is protected



```csharp
 Protected = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.protectedinternal__1u0qjgu" />  ModifierEnum.ProtectedInternal Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is protected internal (protected or internal)



```csharp
 ProtectedInternal = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.modifierenum.public__16bc72i" />  ModifierEnum.Public Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)           
Sources: CodeModel\Enums.cs</small>


Member is public



```csharp
 Public = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7" />  RefKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible reference parameter kinds



```csharp
public enum RefKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.refkindenum.none__115b1ud) | 0 | None | 
 | [Ref](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.refkindenum.ref__7rm5co) | 1 | Ref | 
 | [Out](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.refkindenum.out__1jsgqj5) | 2 | Out | 
 | [In](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.refkindenum.in__o6c6to) | 3 | In | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.in__o6c6to" />  RefKindEnum.In Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)           
Sources: CodeModel\Enums.cs</small>


In



```csharp
 In = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.none__115b1ud" />  RefKindEnum.None Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)           
Sources: CodeModel\Enums.cs</small>


None



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.out__1jsgqj5" />  RefKindEnum.Out Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)           
Sources: CodeModel\Enums.cs</small>


Out



```csharp
 Out = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.refkindenum.ref__7rm5co" />  RefKindEnum.Ref Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)           
Sources: CodeModel\Enums.cs</small>


Ref



```csharp
 Ref = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km" />  SplitTypeEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible split definitions



```csharp
public enum SplitTypeEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [None](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.none__5fy47s) | 0 | Don&#39;t split | 
 | [Namespace](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.namespace__1bo5ytj) | 1 | Split per namespace | 
 | [Type](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.splittypeenum.type__hbxlci) | 2 | Split per type (will also force split per namespace) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.namespace__1bo5ytj" />  SplitTypeEnum.Namespace Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)           
Sources: CodeModel\Enums.cs</small>


Split per namespace



```csharp
 Namespace = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.none__5fy47s" />  SplitTypeEnum.None Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)           
Sources: CodeModel\Enums.cs</small>


Don&#39;t split



```csharp
 None = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.splittypeenum.type__hbxlci" />  SplitTypeEnum.Type Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)           
Sources: CodeModel\Enums.cs</small>


Split per type (will also force split per namespace)



```csharp
 Type = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm" />  TypeKindEnum Enum ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Sources: CodeModel\Enums.cs</small>


Possible kinds of type symbol



```csharp
public enum TypeKindEnum: int
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.valuetype" target="_blank" >ValueType</a> -&gt; <a href="https://docs.microsoft.com/en-us/dotnet/api/system.enum" target="_blank" >Enum</a>           
Implements: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.icomparable" target="_blank" >System.IComparable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iformattable" target="_blank" >System.IFormattable</a>, <a href="https://docs.microsoft.com/en-us/dotnet/api/system.iconvertible" target="_blank" >System.IConvertible</a>


###  Constants ###

 | Name | Value | Summary | 
 | ------ | ------- | --------- | 
 | [Unknown](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.unknown__6qwupk) | 0 | Unknown or not set | 
 | [Class](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.class__mr4q2m) | 1 | Type is class | 
 | [Interface](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.interface__1kr3gmn) | 2 | Type is interface | 
 | [Delegate](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.delegate__1ia2gv1) | 3 | Type is delegate | 
 | [Array](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.array__1crhs0v) | 4 | Type is array | 
 | [Struct](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.struct__1qs31hl) | 5 | Type is structure | 
 | [Enum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.enum__xhij1l) | 6 | Type is enum | 
 | [Dynamic](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#f-net.adamec.dev.markupdoc.codemodel.typekindenum.dynamic__1ql5ndn) | 7 | Type is dynamic | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.array__1crhs0v" />  TypeKindEnum.Array Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is array



```csharp
 Array = 4
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.class__mr4q2m" />  TypeKindEnum.Class Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is class



```csharp
 Class = 1
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.delegate__1ia2gv1" />  TypeKindEnum.Delegate Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is delegate



```csharp
 Delegate = 3
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.dynamic__1ql5ndn" />  TypeKindEnum.Dynamic Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is dynamic



```csharp
 Dynamic = 7
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.enum__xhij1l" />  TypeKindEnum.Enum Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is enum



```csharp
 Enum = 6
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.interface__1kr3gmn" />  TypeKindEnum.Interface Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is interface



```csharp
 Interface = 2
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.struct__1qs31hl" />  TypeKindEnum.Struct Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Type is structure



```csharp
 Struct = 5
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.typekindenum.unknown__6qwupk" />  TypeKindEnum.Unknown Constant ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#n-net.adamec.dev.markupdoc.codemodel__1f8sg55)           
Assembly: MarkupDoc           
Type: [TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)           
Sources: CodeModel\Enums.cs</small>


Unknown or not set



```csharp
 Unknown = 0
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



