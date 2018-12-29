#  MarkupDoc Documentation #
##  <a id="n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa" />  net.adamec.dev.markupdoc.CodeModel.Builder Namespace ##
Code model builder classes


###  Classes ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) | public | Builder for [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j) | 
 | [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) | public | Builder for [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l) | 
 | [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) | public | Builder for [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z) | 
 | [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) | public abstract | Builder for [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh) | 
 | [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) | public | Builder for [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq) | 
 | [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux) | public | Builder for [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483) | 
 | [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2) | public static | Code model builder | 
 | [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) | public | Builder for [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li) | 
 | [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) | public | Builder for [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu) | 
 | [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) | public | Builder for [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj) | 
 | [TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4) | public abstract | Builder for [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw) | 
 | [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) | public | Builder for [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp) | 
 | [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w) | public | Builder for [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35" />  AssemblyMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\AssemblyMemberBuilder.cs</small>


Builder for [AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)



```csharp
public class AssemblyMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.memberkind__vdzakj) | public | Kind (type) of the member | 
 | [Namespaces](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497) | public | List of namespaces within the assembly | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.memberkind__vdzakj" />  AssemblyMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)           
Sources: CodeModel\Builder\AssemblyMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497" />  AssemblyMemberBuilder.Namespaces Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)           
Sources: CodeModel\Builder\AssemblyMemberBuilder.cs</small>


List of namespaces within the assembly



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder> Namespaces { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn" />  EventMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\EventMemberBuilder.cs</small>


Builder for [EventMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.eventmember__qn6e6l)



```csharp
public class EventMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [HasExplicitAddAndRemove](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.hasexplicitaddandremove__pjyyg5) | public | Flag whether the event has explicit implementation of add and remove accessors | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.memberkind__r2w7o1) | public | Kind (type) of the member | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.typeref__qd87z0) | public | Delegate type (type reference) of the event handler | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.hasexplicitaddandremove__pjyyg5" />  EventMemberBuilder.HasExplicitAddAndRemove Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)           
Sources: CodeModel\Builder\EventMemberBuilder.cs</small>


Flag whether the event has explicit implementation of add and remove accessors



```csharp
public bool HasExplicitAddAndRemove { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.memberkind__r2w7o1" />  EventMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)           
Sources: CodeModel\Builder\EventMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder.typeref__qd87z0" />  EventMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn)           
Sources: CodeModel\Builder\EventMemberBuilder.cs</small>


Delegate type (type reference) of the event handler



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush" />  FieldMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Builder for [FieldMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.fieldmember__tbd84z)



```csharp
public class FieldMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ConstantValue](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.constantvalue__3vfjkc) | public | The constant value of the field | 
 | [IsConst](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isconst__1n6s3ui) | public | Flag whether the field is constant | 
 | [IsReadOnly](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isreadonly__7c8nkj) | public | Flag whether the field is read only | 
 | [IsVolatile](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isvolatile__u90vd5) | public | Flag whether the field is volatile | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.memberkind__m8cfwz) | public | Kind (type) of the member | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.typeref__1yrsoq0) | public | Type (type reference) of the field value | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.constantvalue__3vfjkc" />  FieldMemberBuilder.ConstantValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


The constant value of the field



```csharp
public object ConstantValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


###  Remarks ###
The ConstantValue is not the definition (for example &quot;2+customId&quot;) but the value is evaluated to the target type (for example 1002 if the customId in previous example is constant 1000). It&#39;s also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isconst__1n6s3ui" />  FieldMemberBuilder.IsConst Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Flag whether the field is constant



```csharp
public bool IsConst { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isreadonly__7c8nkj" />  FieldMemberBuilder.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Flag whether the field is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.isvolatile__u90vd5" />  FieldMemberBuilder.IsVolatile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Flag whether the field is volatile



```csharp
public bool IsVolatile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.memberkind__m8cfwz" />  FieldMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder.typeref__1yrsoq0" />  FieldMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush)           
Sources: CodeModel\Builder\FieldMemberBuilder.cs</small>


Type (type reference) of the field value



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab" />  MemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Builder for [Member](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.member__rd8rqh)



```csharp
public abstract class MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           
Derived: [net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35), [net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm), [net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad), [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4), [net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Assembly](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.assembly__u0picr) | public | Reference to the containing assembly member | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) | public | Member&#39;s attributes definition (including the parameters). | 
 | [AttributeTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33) | public | Types (type references) of the member attributes | 
 | [Documentation](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) | public | Parsed XML documentation comments. [Documentation](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) is the root element of the parsed XML documentation comments | 
 | [DocumentationId](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationid__fuj6uu) | public | Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod) | 
 | [DocumentationXml](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationxml__hki5yw) | public | XML documentation comments | 
 | [IsAbstract](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isabstract__1gvw0bf) | public | Flag whether the member is abstract | 
 | [IsExtern](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isextern__1lst26j) | public | Flag whether the member is extern | 
 | [IsNew](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isnew__7v1jmv) | public | Flag whether the member hides member with the same name in base class | 
 | [IsOverride](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isoverride__1p2q36b) | public | Flag whether the member overrides the member in the base class | 
 | [IsSealed](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.issealed__1biaeq1) | public | Flag whether the member is sealed | 
 | [IsStatic](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isstatic__exro8z) | public | Flag whether the member is static | 
 | [IsVirtual](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isvirtual__1rjdu3e) | public | Flag whether the member is virtual (can be overriden) | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat) | public | Kind (type) of the member | 
 | [Modifier](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.modifier__9ghn8u) | public | Member modifier (public, private, etc.) | 
 | [Name](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.name__1xiduuc) | public | Name of the member as presented in generated output | 
 | [NameBase](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namebase__1uczvyr) | public | Name of the member without type params, indexer params, operator params, etc. | 
 | [Namespace](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namespace__k8my0i) | public | Reference to the containing namespace member | 
 | [Root](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.root__1dexqz) | public | Reference to the root of the code model | 
 | [SourceFiles](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.sourcefiles__15tpme5) | public | Source file defining the symbol | 
 | [Symbol](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.symbol__11sbm3v) | public | Roslyn semantic analysis symbol of the member | 

 


###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [SetAttributes(RootMemberBuilder)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.setattributes_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___y95mcr) | public | Sets the member&#39;s [Attributes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) and [AttributeTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33) | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.assembly__u0picr" />  MemberBuilder.Assembly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Reference to the containing assembly member



```csharp
public AssemblyMember Assembly { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.AssemblyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.assemblymember__1lp0l3j)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce" />  MemberBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Member&#39;s attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33" />  MemberBuilder.AttributeTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Types (type references) of the member attributes



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AttributeTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf" />  MemberBuilder.Documentation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Parsed XML documentation comments. [Documentation](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentation__1h6mhf) is the root element of the parsed XML documentation comments



```csharp
public Documentation Documentation { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.XmlDocumentation.Documentation](net.adamec.dev.markupdoc.XmlDocumentation__1ter1y6.md#t-net.adamec.dev.markupdoc.xmldocumentation.documentation__19dzlhg)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationid__fuj6uu" />  MemberBuilder.DocumentationId Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Member&#39;s documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)



```csharp
public string DocumentationId { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


###  Remarks ###
See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.documentationxml__hki5yw" />  MemberBuilder.DocumentationXml Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


XML documentation comments



```csharp
public string DocumentationXml { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isabstract__1gvw0bf" />  MemberBuilder.IsAbstract Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member is abstract



```csharp
public bool IsAbstract { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isextern__1lst26j" />  MemberBuilder.IsExtern Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member is extern



```csharp
public bool IsExtern { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isnew__7v1jmv" />  MemberBuilder.IsNew Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member hides member with the same name in base class



```csharp
public bool IsNew { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isoverride__1p2q36b" />  MemberBuilder.IsOverride Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member overrides the member in the base class



```csharp
public bool IsOverride { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.issealed__1biaeq1" />  MemberBuilder.IsSealed Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member is sealed



```csharp
public bool IsSealed { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isstatic__exro8z" />  MemberBuilder.IsStatic Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member is static



```csharp
public bool IsStatic { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.isvirtual__1rjdu3e" />  MemberBuilder.IsVirtual Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Flag whether the member is virtual (can be overriden)



```csharp
public bool IsVirtual { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat" />  MemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Kind (type) of the member



```csharp
public virtual MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.modifier__9ghn8u" />  MemberBuilder.Modifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Member modifier (public, private, etc.)



```csharp
public ModifierEnum Modifier { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.ModifierEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.modifierenum__1xbpfel)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.name__1xiduuc" />  MemberBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Name of the member as presented in generated output



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namebase__1uczvyr" />  MemberBuilder.NameBase Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Name of the member without type params, indexer params, operator params, etc.



```csharp
public string NameBase { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.namespace__k8my0i" />  MemberBuilder.Namespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Reference to the containing namespace member



```csharp
public NamespaceMember Namespace { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.root__1dexqz" />  MemberBuilder.Root Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Reference to the root of the code model



```csharp
public RootMember Root { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.sourcefiles__15tpme5" />  MemberBuilder.SourceFiles Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Source file defining the symbol



```csharp
public List<string> SourceFiles { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.symbol__11sbm3v" />  MemberBuilder.Symbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Roslyn semantic analysis symbol of the member



```csharp
public ISymbol Symbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.setattributes_net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___y95mcr" />  MemberBuilder.SetAttributes(RootMemberBuilder) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Sources: CodeModel\Builder\MemberBuilder.cs</small>


Sets the member&#39;s [Attributes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributes__13uegce) and [AttributeTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.attributetyperefs__1w94m33)



```csharp
public void SetAttributes(RootMemberBuilder rootBuilder)
```

<strong>Method parameters</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>rootBuilder</strong></dt><dd>Root builder used to resolve the type references</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w" />  MethodMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Builder for [MethodMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodmember__od9yq)



```csharp
public class MethodMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsAsync](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isasync__8y3p82) | public | Flag whether the method is async | 
 | [IsConstructor](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isconstructor__1r17j86) | public | Flag whether the method is construction | 
 | [IsDestructor](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isdestructor__1xax39j) | public | Flag whether the method is destructor | 
 | [IsExtensionMethod](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isextensionmethod__pmj45m) | public | Flag whether the method is extension method | 
 | [IsGeneric](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isgeneric__1pwvqjl) | public | Flag whether method is generic | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.memberkind__woi5v2) | public | Kind (type) of the member | 
 | [MethodKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.methodkind__f41fm9) | public | Kind of the method (constructor, getter, regular method ...) | 
 | [OperatorCSharpSymbol](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.operatorcsharpsymbol__1f31bmr) | public | C# operator symbol for operator method | 
 | [Parameters](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.parameters__1usepgy) | public | Method parameters | 
 | [RefKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.refkind__1cgi9xv) | public | Method&#39;s return ref kind (none, ref) | 
 | [ReturnsByRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyref__1bdbn1h) | public | Flag whether the methods returns by reference | 
 | [ReturnsByRefReadonly](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyrefreadonly__ez3crj) | public | Flag whether the methods returns by read only reference (ref readonly) | 
 | [ReturnsVoid](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsvoid__n964nn) | public | Flags whether the method returns void | 
 | [ReturnTypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returntyperef__iiyukl) | public | Type reference of the method return type | 
 | [TypeParameters](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.typeparameters__n6xbei) | public | Type parameters for generic methods | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isasync__8y3p82" />  MethodMemberBuilder.IsAsync Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the method is async



```csharp
public bool IsAsync { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isconstructor__1r17j86" />  MethodMemberBuilder.IsConstructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the method is construction



```csharp
public bool IsConstructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isdestructor__1xax39j" />  MethodMemberBuilder.IsDestructor Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the method is destructor



```csharp
public bool IsDestructor { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isextensionmethod__pmj45m" />  MethodMemberBuilder.IsExtensionMethod Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the method is extension method



```csharp
public bool IsExtensionMethod { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.isgeneric__1pwvqjl" />  MethodMemberBuilder.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether method is generic



```csharp
public bool IsGeneric { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.memberkind__woi5v2" />  MethodMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.methodkind__f41fm9" />  MethodMemberBuilder.MethodKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Kind of the method (constructor, getter, regular method ...)



```csharp
public MethodKindEnum MethodKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MethodKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodkindenum__1u4eys9)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.operatorcsharpsymbol__1f31bmr" />  MethodMemberBuilder.OperatorCSharpSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


C# operator symbol for operator method



```csharp
public string OperatorCSharpSymbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.parameters__1usepgy" />  MethodMemberBuilder.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Method parameters



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.refkind__1cgi9xv" />  MethodMemberBuilder.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Method&#39;s return ref kind (none, ref)



```csharp
public RefKindEnum RefKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyref__1bdbn1h" />  MethodMemberBuilder.ReturnsByRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the methods returns by reference



```csharp
public bool ReturnsByRef { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsbyrefreadonly__ez3crj" />  MethodMemberBuilder.ReturnsByRefReadonly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flag whether the methods returns by read only reference (ref readonly)



```csharp
public bool ReturnsByRefReadonly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returnsvoid__n964nn" />  MethodMemberBuilder.ReturnsVoid Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Flags whether the method returns void



```csharp
public bool ReturnsVoid { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.returntyperef__iiyukl" />  MethodMemberBuilder.ReturnTypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Type reference of the method return type



```csharp
public TypeRef ReturnTypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder.typeparameters__n6xbei" />  MethodMemberBuilder.TypeParameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w)           
Sources: CodeModel\Builder\MethodMemberBuilder.cs</small>


Type parameters for generic methods



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux" />  MethodParameterBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Builder for [MethodParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.methodparameter__1ax0483)



```csharp
public class MethodParameterBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Remarks ###
Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.attributes__1t8c7wg) | public | Parameter attributes definition (including the parameters). | 
 | [ExplicitDefaultValue](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.explicitdefaultvalue__gvc0n5) | public | Parameter&#39;s explicitly defined default value (when available) | 
 | [HasExplicitDefaultValue](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.hasexplicitdefaultvalue__1kulx9f) | public | Flag whether the parameter has explicitly defined default value | 
 | [IsOptional](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isoptional__1rtnv9j) | public | Flag whether the parameter is optional | 
 | [IsParams](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isparams__b64bjt) | public | Flag whether the parameter is with `params` modifier | 
 | [IsThis](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isthis__xj2zwv) | public | Flag whether the parameter is with `this` modifier | 
 | [Name](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.name__zd3u2a) | public | Name of the parameter | 
 | [RefKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.refkind__1xrhok) | public | Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In) | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.typeref__r2j80u) | public | Type reference for the parameter&#39;s type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.attributes__1t8c7wg" />  MethodParameterBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.explicitdefaultvalue__gvc0n5" />  MethodParameterBuilder.ExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Parameter&#39;s explicitly defined default value (when available)



```csharp
public object ExplicitDefaultValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.hasexplicitdefaultvalue__1kulx9f" />  MethodParameterBuilder.HasExplicitDefaultValue Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Flag whether the parameter has explicitly defined default value



```csharp
public bool HasExplicitDefaultValue { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isoptional__1rtnv9j" />  MethodParameterBuilder.IsOptional Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Flag whether the parameter is optional



```csharp
public bool IsOptional { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isparams__b64bjt" />  MethodParameterBuilder.IsParams Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Flag whether the parameter is with `params` modifier



```csharp
public bool IsParams { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.isthis__xj2zwv" />  MethodParameterBuilder.IsThis Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Flag whether the parameter is with `this` modifier



```csharp
public bool IsThis { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.name__zd3u2a" />  MethodParameterBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Name of the parameter



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.refkind__1xrhok" />  MethodParameterBuilder.RefKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Information whether the parameter is &quot;by reference&quot; with the reference kind (None, Ref, Out,In)



```csharp
public RefKindEnum RefKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.RefKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.refkindenum__q0ecx7)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder.typeref__r2j80u" />  MethodParameterBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [MethodParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodparameterbuilder__lh5rux)           
Sources: CodeModel\Builder\MethodParameterBuilder.cs</small>


Type reference for the parameter&#39;s type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2" />  ModelBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Code model builder



```csharp
public static class ModelBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Methods ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Build(ISymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.build_microsoft.codeanalysis.isymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___15bn67a) | private static | Walks through the Roslyn symbols hierarchy and prepares the member builders hierarchy into the given <strong>root</strong> builder. | 
 | [BuildAssembly(IAssemblySymbol, RootMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildassembly_microsoft.codeanalysis.iassemblysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.int32___1lbqkgy) | private static | Prepares the [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) from the <strong>symbol</strong> and adds it to [Assemblies](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih) | 
 | [BuildEvent(IEventSymbol, RootMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildevent_microsoft.codeanalysis.ieventsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___jk6kv) | private static | Prepares the [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildField(IFieldSymbol, RootMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfield_microsoft.codeanalysis.ifieldsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___pykoun) | private static | Prepares the [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildFromProjectSourcesAsync(string, IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfromprojectsourcesasync_system.string-system.collections.generic.ienumerable_net.adamec.dev.markupdoc.addons.iaddon____d690to) | public static | Builds a code model for C# project | 
 | [BuildMethod(IMethodSymbol, RootMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildmethod_microsoft.codeanalysis.imethodsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___18on0xf) | private static | Prepares the [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildNamespace(INamespaceSymbol, RootMemberBuilder, AssemblyMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildnamespace_microsoft.codeanalysis.inamespacesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-system.int32___1weblwh) | private static | Prepares the [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) from the <strong>symbol</strong> and adds it to [Namespaces](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497) | 
 | [BuildProperty(IPropertySymbol, RootMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildproperty_microsoft.codeanalysis.ipropertysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___gfm8xv) | private static | Prepares the [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | 
 | [BuildType(INamedTypeSymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildtype_microsoft.codeanalysis.inamedtypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___af53q5) | private static | Prepares the [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) from the <strong>symbol</strong> and adds it to [Types](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp) | 
 | [GetMethodParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;, RootMemberBuilder, bool)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.getmethodparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.iparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.boolean___134ezzp) | private static | Gets the list of method parameters (also used for retrieving delegate and indexer parameters) | 
 | [GetTypeParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;, RootMemberBuilder)](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.gettypeparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.itypeparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___4af5sd) | private static | Gets the list of type parameters for generic type or generic method | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.build_microsoft.codeanalysis.isymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___15bn67a" />  ModelBuilder.Build(ISymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Walks through the Roslyn symbols hierarchy and prepares the member builders hierarchy into the given <strong>root</strong> builder.



```csharp
private static void Build(ISymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a> <strong>symbol</strong></dt><dd>Symbol to process</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Containing assembly builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>ns</strong></dt><dd>Containing namespace builder</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Containing type builder (used for nested types)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildassembly_microsoft.codeanalysis.iassemblysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.int32___1lbqkgy" />  ModelBuilder.BuildAssembly(IAssemblySymbol, RootMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) from the <strong>symbol</strong> and adds it to [Assemblies](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.rootmember.assemblies__nirzih)



```csharp
private static void BuildAssembly(IAssemblySymbol symbol, RootMemberBuilder root, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.iassemblysymbol" target="_blank" >Microsoft.CodeAnalysis.IAssemblySymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.IAssemblySymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildevent_microsoft.codeanalysis.ieventsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___jk6kv" />  ModelBuilder.BuildEvent(IEventSymbol, RootMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildEvent(IEventSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ieventsymbol" target="_blank" >Microsoft.CodeAnalysis.IEventSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfield_microsoft.codeanalysis.ifieldsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___pykoun" />  ModelBuilder.BuildField(IFieldSymbol, RootMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildField(IFieldSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ifieldsymbol" target="_blank" >Microsoft.CodeAnalysis.IFieldSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildfromprojectsourcesasync_system.string-system.collections.generic.ienumerable_net.adamec.dev.markupdoc.addons.iaddon____d690to" />  ModelBuilder.BuildFromProjectSourcesAsync(string, IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Builds a code model for C# project



```csharp
public static async Task<net.adamec.dev.markupdoc.CodeModel.RootMember> BuildFromProjectSourcesAsync(string projectFile, IEnumerable<net.adamec.dev.markupdoc.AddOns.IAddOn> addOns)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a> <strong>projectFile</strong></dt><dd>Project file full path</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1" target="_blank" >IEnumerable&lt;net.adamec.dev.markupdoc.AddOns.IAddOn&gt;</a> <strong>addOns</strong></dt><dd>Optional list of add-ons</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1" target="_blank" >System.Threading.Tasks.Task&lt;net.adamec.dev.markupdoc.CodeModel.RootMember&gt;</a></dt><dd>Code model root (async)</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildmethod_microsoft.codeanalysis.imethodsymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___18on0xf" />  ModelBuilder.BuildMethod(IMethodSymbol, RootMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildMethod(IMethodSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.imethodsymbol" target="_blank" >Microsoft.CodeAnalysis.IMethodSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildnamespace_microsoft.codeanalysis.inamespacesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-system.int32___1weblwh" />  ModelBuilder.BuildNamespace(INamespaceSymbol, RootMemberBuilder, AssemblyMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) from the <strong>symbol</strong> and adds it to [Namespaces](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder.namespaces__e9i497)



```csharp
private static void BuildNamespace(INamespaceSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamespacesymbol" target="_blank" >Microsoft.CodeAnalysis.INamespaceSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamespaceSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Parent [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildproperty_microsoft.codeanalysis.ipropertysymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___gfm8xv" />  ModelBuilder.BuildProperty(IPropertySymbol, RootMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c) from the <strong>symbol</strong> and adds it to [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf)



```csharp
private static void BuildProperty(IPropertySymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.ipropertysymbol" target="_blank" >Microsoft.CodeAnalysis.IPropertySymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.buildtype_microsoft.codeanalysis.inamedtypesymbol-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder-system.int32___af53q5" />  ModelBuilder.BuildType(INamedTypeSymbol, RootMemberBuilder, AssemblyMemberBuilder, NamespaceMemberBuilder, TypeMemberBuilder, int) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Prepares the [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) from the <strong>symbol</strong> and adds it to [Types](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp)



```csharp
private static void BuildType(INamedTypeSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns, TypeMemberBuilder type, int level)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.inamedtypesymbol" target="_blank" >Microsoft.CodeAnalysis.INamedTypeSymbol</a> <strong>symbol</strong></dt><dd>Source <em>Microsoft.CodeAnalysis.INamedTypeSymbol</em></dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Builder root</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35) <strong>assembly</strong></dt><dd>Containing [AssemblyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.assemblymemberbuilder__1t89m35)</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm) <strong>ns</strong></dt><dd>Parent [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) <strong>type</strong></dt><dd>Parent [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn) for nested types</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.int32" target="_blank" >int</a> <strong>level</strong></dt><dd>Hierarchy level (used to indent the console output)</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.void" target="_blank" >void</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.getmethodparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.iparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder-system.boolean___134ezzp" />  ModelBuilder.GetMethodParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;, RootMemberBuilder, bool) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Gets the list of method parameters (also used for retrieving delegate and indexer parameters)



```csharp
private static List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> GetMethodParameters(ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol> parameterSymbols, RootMemberBuilder root, bool isExtensionMethod = false)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablearray-1" target="_blank" >System.Collections.Immutable.ImmutableArray&lt;Microsoft.CodeAnalysis.IParameterSymbol&gt;</a> <strong>parameterSymbols</strong></dt><dd>Method parameter symbols</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a> <strong>isExtensionMethod</strong></dt><dd>Flag whether the <strong>parameterSymbols</strong> are of an extension method</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd>List of method parameters</dd></dl>


###  Remarks ###
As <em>Microsoft.CodeAnalysis.IParameterSymbol.IsThis</em> doesn&#39;t provide the correct info, there is a workaround and [IsThis](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#p-net.adamec.dev.markupdoc.codemodel.methodparameter.isthis__1u7nw65) is set for the first param of an extension method. The <strong>isExtensionMethod</strong> must be set to true to apply the workaround (the default value is false)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder.gettypeparameters_system.collections.immutable.immutablearray_microsoft.codeanalysis.itypeparametersymbol_-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder___4af5sd" />  ModelBuilder.GetTypeParameters(ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;, RootMemberBuilder) Method ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [ModelBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.modelbuilder__1bidpb2)           
Sources: CodeModel\Builder\ModelBuilder.cs</small>


Gets the list of type parameters for generic type or generic method



```csharp
private static List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> GetTypeParameters(ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol> parameterSymbols, RootMemberBuilder root)
```

<strong>Method parameters</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.immutable.immutablearray-1" target="_blank" >System.Collections.Immutable.ImmutableArray&lt;Microsoft.CodeAnalysis.ITypeParameterSymbol&gt;</a> <strong>parameterSymbols</strong></dt><dd>Type parameter symbols</dd><dt>[net.adamec.dev.markupdoc.CodeModel.Builder.RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad) <strong>root</strong></dt><dd>Root builder</dd></dl>
<strong>Return value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd>List of type parameters</dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm" />  NamespaceMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\NamespaceMemberBuilder.cs</small>


Builder for [NamespaceMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.namespacemember__ja97li)



```csharp
public class NamespaceMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [IsGlobalNamespace](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.isglobalnamespace__1idlboq) | public | Flag whether the namespace is global | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.memberkind__1w0tyvk) | public | Kind (type) of the member | 
 | [Types](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp) | public | List of all types (including interfaces, delegates, etc.) defined within the namespace | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.isglobalnamespace__1idlboq" />  NamespaceMemberBuilder.IsGlobalNamespace Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)           
Sources: CodeModel\Builder\NamespaceMemberBuilder.cs</small>


Flag whether the namespace is global



```csharp
public bool IsGlobalNamespace { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.memberkind__1w0tyvk" />  NamespaceMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)           
Sources: CodeModel\Builder\NamespaceMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder.types__robhnp" />  NamespaceMemberBuilder.Types Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [NamespaceMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.namespacememberbuilder__1a79nrm)           
Sources: CodeModel\Builder\NamespaceMemberBuilder.cs</small>


List of all types (including interfaces, delegates, etc.) defined within the namespace



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder> Types { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.TypeMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c" />  PropertyMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Builder for [PropertyMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.propertymember__m06mbu)



```csharp
public class PropertyMemberBuilder : TypeContentMemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab) -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [GetterModifier](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.gettermodifier__114qq8s) | public | Getter access modifier if it&#39;s different than the property one | 
 | [IsIndexer](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isindexer__1ux36yh) | public | Flag whether the property is indexer; | 
 | [IsReadOnly](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isreadonly__evv3bs) | public | Flag whether the property is read only | 
 | [IsWriteOnly](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.iswriteonly__z59w9d) | public | Flag whether the property is write only | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.memberkind__6klili) | public | Kind (type) of the member | 
 | [Parameters](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.parameters__1xthnx6) | public | List of property parameters (if any). Just the indexers may have the parameters | 
 | [SetterModifier](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.settermodifier__13b9zlk) | public | Setter access modifier if it&#39;s different than the property one | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.typeref__1tm2yvr) | public | Type reference of property type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.gettermodifier__114qq8s" />  PropertyMemberBuilder.GetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Getter access modifier if it&#39;s different than the property one



```csharp
public string GetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isindexer__1ux36yh" />  PropertyMemberBuilder.IsIndexer Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Flag whether the property is indexer;



```csharp
public bool IsIndexer { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.isreadonly__evv3bs" />  PropertyMemberBuilder.IsReadOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Flag whether the property is read only



```csharp
public bool IsReadOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.iswriteonly__z59w9d" />  PropertyMemberBuilder.IsWriteOnly Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Flag whether the property is write only



```csharp
public bool IsWriteOnly { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.memberkind__6klili" />  PropertyMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.parameters__1xthnx6" />  PropertyMemberBuilder.Parameters Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


List of property parameters (if any). Just the indexers may have the parameters



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> Parameters { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.settermodifier__13b9zlk" />  PropertyMemberBuilder.SetterModifier Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Setter access modifier if it&#39;s different than the property one



```csharp
public string SetterModifier { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder.typeref__1tm2yvr" />  PropertyMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           
Sources: CodeModel\Builder\PropertyMemberBuilder.cs</small>


Type reference of property type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad" />  RootMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


Builder for [RootMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.rootmember__mwa6pj)



```csharp
public class RootMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.alltyperefs__6pc6ms) | public | List of all type references used within the code model | 
 | [Assemblies](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.assemblies__1y8u6kb) | public | List of all assemblies defined within the code model | 
 | [BaseMainFile](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.basemainfile__152qap3) | public | Name of the main (index) file without the path and extension | 
 | [CompilationFiles](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.compilationfiles__1bber0z) | public | List of all source files in compilation | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.memberkind__1hvln7) | public | Kind (type) of the member | 
 | [ProjectRootDir](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.projectrootdir__ylhykn) | public | Full path to the project root directory | 
 | [SplitFileType](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.splitfiletype__jt8zgj) | public | Information whether and how to split the output (none, per namespace, per type) | 

 


###  Constructors ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [RootMemberBuilder()](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#m-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.-ctor__1ut3l6j) | public | CTOR - sets the name to `<ROOT>` | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.alltyperefs__6pc6ms" />  RootMemberBuilder.AllTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


List of all type references used within the code model



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllTypeRefs { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.assemblies__1y8u6kb" />  RootMemberBuilder.Assemblies Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


List of all assemblies defined within the code model



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder> Assemblies { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.AssemblyMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.basemainfile__152qap3" />  RootMemberBuilder.BaseMainFile Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


Name of the main (index) file without the path and extension



```csharp
public string BaseMainFile { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.compilationfiles__1bber0z" />  RootMemberBuilder.CompilationFiles Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


List of all source files in compilation



```csharp
public List<string> CompilationFiles { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.memberkind__1hvln7" />  RootMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.projectrootdir__ylhykn" />  RootMemberBuilder.ProjectRootDir Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


Full path to the project root directory



```csharp
public string ProjectRootDir { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.splitfiletype__jt8zgj" />  RootMemberBuilder.SplitFileType Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


Information whether and how to split the output (none, per namespace, per type)



```csharp
public SplitTypeEnum SplitFileType { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.SplitTypeEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.splittypeenum__1fx14km)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="m-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder.-ctor__1ut3l6j" />  RootMemberBuilder.RootMemberBuilder() Constructor ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [RootMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.rootmemberbuilder__19g2xad)           
Sources: CodeModel\Builder\RootMemberBuilder.cs</small>


CTOR - sets the name to `<ROOT>`



```csharp
public RootMemberBuilder()
```

Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4" />  TypeContentMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\TypeContentMemberBuilder.cs</small>


Builder for [TypeContentMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typecontentmember__suhfqw)



```csharp
public abstract class TypeContentMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           
Derived: [net.adamec.dev.markupdoc.CodeModel.Builder.EventMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.eventmemberbuilder__6cikxn), [net.adamec.dev.markupdoc.CodeModel.Builder.FieldMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.fieldmemberbuilder__1jrcush), [net.adamec.dev.markupdoc.CodeModel.Builder.MethodMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.methodmemberbuilder__1p2pk7w), [net.adamec.dev.markupdoc.CodeModel.Builder.PropertyMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.propertymemberbuilder__k8fr6c)           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [ExplicitInterfaceImplementationMemberSymbol](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.explicitinterfaceimplementationmembersymbol__1wn9wyv) | public | Symbol of explicitly implemented interface member | 
 | [OverridesSymbol](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.overridessymbol__13r4tkp) | public | Symbol of member overriden by this member | 
 | [Type](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.type__1bgq70u) | public | Type containing the content member | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.explicitinterfaceimplementationmembersymbol__1wn9wyv" />  TypeContentMemberBuilder.ExplicitInterfaceImplementationMemberSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           
Sources: CodeModel\Builder\TypeContentMemberBuilder.cs</small>


Symbol of explicitly implemented interface member



```csharp
public ISymbol ExplicitInterfaceImplementationMemberSymbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.overridessymbol__13r4tkp" />  TypeContentMemberBuilder.OverridesSymbol Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           
Sources: CodeModel\Builder\TypeContentMemberBuilder.cs</small>


Symbol of member overriden by this member



```csharp
public ISymbol OverridesSymbol { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.isymbol" target="_blank" >Microsoft.CodeAnalysis.ISymbol</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder.type__1bgq70u" />  TypeContentMemberBuilder.Type Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeContentMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typecontentmemberbuilder__1kmstl4)           
Sources: CodeModel\Builder\TypeContentMemberBuilder.cs</small>


Type containing the content member



```csharp
public TypeMember Type { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn" />  TypeMemberBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Builder for [TypeMember](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typemember__1dz0rmp)



```csharp
public class TypeMemberBuilder : MemberBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a> -&gt; [net.adamec.dev.markupdoc.CodeModel.Builder.MemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder__ju81ab)           



###  Fields ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [DelegateParameters](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegateparameters__14r3a3m) | public | Delegate parameters for delegate types | 
 | [DelegateReturnType](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegatereturntype__10z9wvk) | public | Type reference for delegate return type | 
 | [TypeParameters](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeparameters__7d95h) | public | Type parameters for generic types | 

 


###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [AllInterfacesTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.allinterfacestyperefs__br2ak) | public | Type references for all implemented interfaces (both directly implemented and inherited) | 
 | [ContentMembers](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf) | public | List of all type content members (fields, properties, methods, events) | 
 | [InterfaceImplementationsByInterfaceMember](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfaceimplementationsbyinterfacemember__1topu9r) | public | Dictionary of  interface member implementation by interface member (key=interface member symbol, value=implementation member symbol) | 
 | [InterfaceMembersByInterfaceImplementation](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacemembersbyinterfaceimplementation__b1sx1b) | public | Dictionary of implemented interface members by implementation member (key=implementation member symbol, value=interface member symbol) | 
 | [InterfacesTypeRefs](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacestyperefs__3ufra9) | public | Type references for directly implemented interfaces | 
 | [IsGeneric](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.isgeneric__utg9go) | public | Flag whether type is generic | 
 | [MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.memberkind__1y10oqd) | public | Kind (type) of the member | 
 | [TypeKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typekind__qphofl) | public | Type kind (class, interface, ...) | 
 | [TypeRef](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeref__1hwjb38) | public | Type reference for this type | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegateparameters__14r3a3m" />  TypeMemberBuilder.DelegateParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Delegate parameters for delegate types



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.MethodParameter> DelegateParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.MethodParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.delegatereturntype__10z9wvk" />  TypeMemberBuilder.DelegateReturnType Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type reference for delegate return type



```csharp
public TypeRef DelegateReturnType
```

<strong>Field value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="f-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeparameters__7d95h" />  TypeMemberBuilder.TypeParameters Field ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type parameters for generic types



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeParameter> TypeParameters
```

<strong>Field value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeParameter&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.allinterfacestyperefs__br2ak" />  TypeMemberBuilder.AllInterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type references for all implemented interfaces (both directly implemented and inherited)



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> AllInterfacesTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.contentmembers__1jrowmf" />  TypeMemberBuilder.ContentMembers Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


List of all type content members (fields, properties, methods, events)



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder> ContentMembers { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.Builder.TypeContentMemberBuilder&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfaceimplementationsbyinterfacemember__1topu9r" />  TypeMemberBuilder.InterfaceImplementationsByInterfaceMember Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Dictionary of  interface member implementation by interface member (key=interface member symbol, value=implementation member symbol)



```csharp
public Dictionary<Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.ISymbol> InterfaceImplementationsByInterfaceMember { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;Microsoft.CodeAnalysis.ISymbol,Microsoft.CodeAnalysis.ISymbol&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacemembersbyinterfaceimplementation__b1sx1b" />  TypeMemberBuilder.InterfaceMembersByInterfaceImplementation Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Dictionary of implemented interface members by implementation member (key=implementation member symbol, value=interface member symbol)



```csharp
public Dictionary<Microsoft.CodeAnalysis.ISymbol,IReadOnlyList<Microsoft.CodeAnalysis.ISymbol>> InterfaceMembersByInterfaceImplementation { get; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2" target="_blank" >Dictionary&lt;Microsoft.CodeAnalysis.ISymbol,IReadOnlyList&lt;Microsoft.CodeAnalysis.ISymbol&gt;&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.interfacestyperefs__3ufra9" />  TypeMemberBuilder.InterfacesTypeRefs Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type references for directly implemented interfaces



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> InterfacesTypeRefs { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.isgeneric__utg9go" />  TypeMemberBuilder.IsGeneric Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Flag whether type is generic



```csharp
public bool IsGeneric { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.memberkind__1y10oqd" />  TypeMemberBuilder.MemberKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Kind (type) of the member



```csharp
public override MemberKindEnum MemberKind { get; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.MemberKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.memberkindenum__cdphd0)</dt><dd></dd></dl>Overrides: [MemberBuilder.MemberKind](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.memberbuilder.memberkind__1o9lat)


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typekind__qphofl" />  TypeMemberBuilder.TypeKind Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type kind (class, interface, ...)



```csharp
public TypeKindEnum TypeKind { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeKindEnum](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typekindenum__1aridgm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder.typeref__1hwjb38" />  TypeMemberBuilder.TypeRef Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeMemberBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typememberbuilder__15jf5vn)           
Sources: CodeModel\Builder\TypeMemberBuilder.cs</small>


Type reference for this type



```csharp
public TypeRef TypeRef { get; set; }
```

<strong>Property value</strong><dl><dt>[net.adamec.dev.markupdoc.CodeModel.TypeRef](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeref__u09wkm)</dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w" />  TypeParameterBuilder Class ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Builder for [TypeParameter](net.adamec.dev.markupdoc.CodeModel__1f8sg55.md#t-net.adamec.dev.markupdoc.codemodel.typeparameter__hye408)



```csharp
public class TypeParameterBuilder
```

Inheritance: <a href="https://docs.microsoft.com/en-us/dotnet/api/system.object" target="_blank" >object</a>           



###  Properties ###

 | Name | Modifier | Summary | 
 | ------ | ---------- | --------- | 
 | [Attributes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.attributes__i6iqgf) | public | Type parameter attributes definition (including the parameters). | 
 | [ConstraintTypes](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.constrainttypes__1sn5icu) | public | List of type references of constraint types  when the concrete types are defined as constraints | 
 | [HasConstructorConstraint](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasconstructorconstraint__lz79dv) | public | Flag whether the type parameter has constructor constraint ( new() ) | 
 | [HasReferenceTypeConstraint](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasreferencetypeconstraint__1c0buuo) | public | Flag whether the type parameter has reference type constraint ( class ) | 
 | [HasUnmanagedTypeConstraint](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasunmanagedtypeconstraint__14xpe3x) | public | Flag whether the type parameter has unmanaged type constraint ( unmanaged ) | 
 | [HasValueTypeConstraint](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasvaluetypeconstraint__1ojvgf8) | public | Flag whether the type parameter has value type constraint ( struct ) | 
 | [Name](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.name__1swcen7) | public | Name of the parameter | 
 | [Variance](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.variance__r9zbyx) | public | Variance (covariance and contravariance) modifier (in, out) for the type parameter if available. | 

 


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.attributes__i6iqgf" />  TypeParameterBuilder.Attributes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Type parameter attributes definition (including the parameters).



```csharp
public List<string> Attributes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;string&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.constrainttypes__1sn5icu" />  TypeParameterBuilder.ConstraintTypes Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


List of type references of constraint types  when the concrete types are defined as constraints



```csharp
public List<net.adamec.dev.markupdoc.CodeModel.TypeRef> ConstraintTypes { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1" target="_blank" >List&lt;net.adamec.dev.markupdoc.CodeModel.TypeRef&gt;</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasconstructorconstraint__lz79dv" />  TypeParameterBuilder.HasConstructorConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Flag whether the type parameter has constructor constraint ( new() )



```csharp
public bool HasConstructorConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasreferencetypeconstraint__1c0buuo" />  TypeParameterBuilder.HasReferenceTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Flag whether the type parameter has reference type constraint ( class )



```csharp
public bool HasReferenceTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasunmanagedtypeconstraint__14xpe3x" />  TypeParameterBuilder.HasUnmanagedTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Flag whether the type parameter has unmanaged type constraint ( unmanaged )



```csharp
public bool HasUnmanagedTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.hasvaluetypeconstraint__1ojvgf8" />  TypeParameterBuilder.HasValueTypeConstraint Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Flag whether the type parameter has value type constraint ( struct )



```csharp
public bool HasValueTypeConstraint { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.boolean" target="_blank" >bool</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.name__1swcen7" />  TypeParameterBuilder.Name Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Name of the parameter



```csharp
public string Name { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 


##  <a id="p-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder.variance__r9zbyx" />  TypeParameterBuilder.Variance Property ##
<small>Namespace: [net.adamec.dev.markupdoc.CodeModel.Builder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#n-net.adamec.dev.markupdoc.codemodel.builder__w36mxa)           
Assembly: MarkupDoc           
Type: [TypeParameterBuilder](net.adamec.dev.markupdoc.CodeModel.Builder__w36mxa.md#t-net.adamec.dev.markupdoc.codemodel.builder.typeparameterbuilder__1h07j2w)           
Sources: CodeModel\Builder\TypeParameterBuilder.cs</small>


Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.



```csharp
public string Variance { get; set; }
```

<strong>Property value</strong><dl><dt><a href="https://docs.microsoft.com/en-us/dotnet/api/system.string" target="_blank" >string</a></dt><dd></dd></dl>


Go to [namespaces](MarkupDoc.md#namespace-list) or [types](MarkupDoc.md#type-list)


 



