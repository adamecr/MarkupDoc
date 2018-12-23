using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.MsApiDoc;
using net.adamec.dev.markupdoc.Options;
using net.adamec.dev.markupdoc.Utils;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.Markup
{
    /// <summary>
    /// Markup generator
    /// </summary>
    /// <remarks>
    /// Here is the overall look and feel of documentation implemented.
    /// The MarkupGenerator is the traversing the code model, building the documentation and render the output for individual parts using the <see cref="Markup"/> provider
    ///  <para>The term "page" used with the generator simply means the documentation for single member even if the whole documentation might be rendered into single file</para></remarks>
    public class MarkupGenerator
    {
        /// <summary>
        /// Full path to the (main) file
        /// </summary>
        protected string FileName { get; }
        /// <summary>
        /// Name of the (main) file
        /// </summary>
        protected string BaseFileName { get; }
        /// <summary>
        /// <see cref="IMarkupProvider"/> used to render the markup
        /// </summary>
        protected IMarkupProvider Markup { get; }
        /// <summary>
        /// Underlying output writer.
        /// </summary>
        /// <remarks>Used for splitting only. Never write to the output writer directly, use the <see cref="IMarkupProvider"/> instead!</remarks>
        protected INonWritableWriter Writer { get; set; }
        /// <summary>
        /// Root of the code model
        /// </summary>
        protected RootMember Model { get; set; }
        /// <summary>
        /// Output configuration
        /// </summary>
        public OutputOptions Options { get; }
        /// <summary>
        /// Documentation title shown at the top of each page
        /// </summary>
        protected string Title { get; set; }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="fileName">Full path to the (main) file</param>
        /// <param name="model">Root of the code model</param>
        /// <param name="markupProvider"><see cref="IMarkupProvider"/> used to render the markup</param>
        public MarkupGenerator(string fileName, RootMember model, IMarkupProvider markupProvider)
        {
            if (string.IsNullOrEmpty(fileName)) throw new ArgumentNullException(nameof(fileName));

            FileName = fileName;
            BaseFileName = Path.GetFileName(fileName);
            Model = model ?? throw new ArgumentNullException(nameof(model));
            Markup = markupProvider ?? throw new ArgumentNullException(nameof(markupProvider));
            Options = Configuration.Retrieve<OutputOptions>();
        }

        /// <summary>
        /// Main code model rendering public end point. Writes the model into the documentation file(s)
        /// </summary>
        /// <remarks>
        /// Initializes <see cref="MarkupFileWriter"/> or <see cref="MarkupMultiFileWriter"/> based on the split configuration.
        /// Executes the model rendering sequence.
        /// </remarks>
        /// <param name="title">Documentation title shown at the top of each page</param>
        /// <returns>Async task</returns>
        public virtual async Task WriteModelAsync(string title)
        {
            Console.WriteLine($"Writing markup to {FileName}...");
            Title = title ?? "API Reference";
            var writer = Options.SplitNs || Options.SplitType ? new MarkupMultiFileWriter() : new MarkupFileWriter();
            writer.SetTarget(FileName);
            Markup.MarkupWriter = writer;
            Writer = writer;

            await writer.WriteModelAsync(async () =>
            {
                await Markup.WriteDocumentStartAsync(Title);
                await WriteModelContentAsync();
                await Markup.WriteDocumentEndAsync();
            });
            Console.WriteLine($"Finished writing markup to {FileName}");
        }

        /// <summary>
        /// Writes the code model into the output 
        /// </summary>
        /// <remarks>Writes the namespaces and types lists and calls <see cref="WriteNamespacesAsync"/> to walk through the code model and generate the documentation for individual members</remarks>
        /// <returns>Async task</returns>
        protected virtual async Task WriteModelContentAsync()
        {
            await WriteNamespacesListAsync();
            await WriteTypesListAsync();

            //Add-ons indexes
            foreach (var addOn in Model.AddOnsSelector(a => a.PriorityIndexPage))
            {
                if(await addOn.WriteIndexAsync(Model, Markup))
                    await WritePageFooterAsync();
            }

            await WriteNamespacesAsync();

            //Add-ons pages
            foreach (var addOn in Model.AddOnsSelector(a => a.PriorityOwnPages))
            {
                await addOn.WriteOwnPagesAsync(Model, Markup, this);
            }
        }

        /// <summary>
        /// Writes the table of all namespaces within the code model into the output
        /// </summary>
        /// <returns>Async task</returns>
        protected virtual async Task WriteNamespacesListAsync()
        {
            await Markup.WriteH2Async("Namespaces", "namespace-list");
            await Markup.WriteTableHeaderAsync("Name", "Summary");
            foreach (var namespaceMember in Model.AllNamespaces.OrderBy(t => t.Name))
            {
                await Markup.WriteTableColsAsync(Markup.Link(namespaceMember.Name, namespaceMember),
                    namespaceMember.Documentation?.GetSummary(namespaceMember)?.Render(Markup, namespaceMember) ?? string.Empty);
            }
            await Markup.WriteTableFooterAsync();
        }



        /// <summary>
        /// Writes the table of all types within the code model into the output
        /// </summary>
        /// <returns>Async task</returns>
        protected virtual async Task WriteTypesListAsync()
        {
            await Markup.WriteH2Async("Types", "type-list");
            await Markup.WriteTableHeaderAsync("Name", "Modifier", "Kind", "Summary");
            foreach (var typeMember in Model.AllTypes.OrderBy(t => (int)t.TypeKind).ThenBy(t => t.Name))
            {
                await Markup.WriteTableColsAsync(
                    Markup.Link(typeMember.Name, typeMember),
                    $"{typeMember.Modifier.ToModifierString()}{(typeMember.IsStatic ? " static" : "")}{(typeMember.IsAbstract ? " abstract" : "")}",
                    typeMember.TypeKind.ToString(),
                    typeMember.Documentation?.GetSummary(typeMember)?.Render(Markup, typeMember) ?? string.Empty);
            }
            await Markup.WriteTableFooterAsync();

            await WritePageFooterAsync();
        }

        /// <summary>
        ///  Writes the namespaces and their members into the output
        /// </summary>
        /// <remarks>Walks through the namespaces and for each, the namespace page and namespace members' pages are rendered into the output</remarks>
        /// <returns>Async task</returns>
        protected virtual async Task WriteNamespacesAsync()
        {
            foreach (var namespaceMember in Model.AllNamespaces.OrderBy(t => t.Name))
            {
                //Namespace - "page"
                await WriteNamespaceAsync(namespaceMember);

                //Namespace members - "pages"
                await WriteTypesAsync(namespaceMember);
            }
        }

        /// <summary>
        ///  Writes the namespace documentation page
        /// </summary>
        /// <remarks>
        /// The namespace XML documentation comments are not available for the namespace itself.
        /// To document the namespace, create a class <c>NamespaceDoc</c> within the namespace and add the namespace documentation to this class.
        /// It's recommended to mark the class with <see cref="System.Runtime.CompilerServices.CompilerGeneratedAttribute"/>,
        /// so it will be excluded from the documentation as a type (meaning, the documentation will be applied to namespace and the class itself will not appear in the documentation).
        /// <para>When a split per namespace or per type is required, the new split is initialized at the beginning of the execution</para>
        /// </remarks>
        /// <param name="ns">Namespace to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteNamespaceAsync(NamespaceMember ns)
        {
            if (Options.SplitNs || Options.SplitType)
            {
                await SplitAsync(ns.FileName);
            }

            await Markup.WriteH2Async($"{ns.Name} Namespace", ns.Anchor);
            await Markup.WriteParaAsync(ns.Documentation?.GetSummary(ns)?.Render(Markup, ns));

            await WriteDocumentationExampleAsync(ns);  //Example
            await WriteDocumentationRemarksAsync(ns);  //Remarks
            await WriteDocumentationExceptionsAsync(ns); //Exceptions

            //Members
            await WriteMembersTableAsync("Classes", ns.Types.Where(t => t.TypeKind == TypeKindEnum.Class).OrderBy(t => t.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Structures", ns.Types.Where(t => t.TypeKind == TypeKindEnum.Struct).OrderBy(t => t.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Interfaces", ns.Types.Where(t => t.TypeKind == TypeKindEnum.Interface).OrderBy(t => t.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Enums", ns.Types.Where(t => t.TypeKind == TypeKindEnum.Enum).OrderBy(t => t.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Delegates", ns.Types.Where(t => t.TypeKind == TypeKindEnum.Delegate).OrderBy(t => t.Name).Cast<Member>().ToList());

            //AddOns
            await WriteAddOnsBodyAsync(ns);

            //SeeAlso
            await WriteDocumentationSeeAlsoAsync(ns);

            await WritePageFooterAsync();

        }

        /// <summary>
        ///  Writes the types and their members contained within given <paramref name="namespaceMember">namespace</paramref>into the output
        /// </summary>
        /// <remarks>Walks through the types in the namespace and for each, the type page and type members' pages are rendered into the output</remarks>
        /// <param name="namespaceMember">Document the types and their members that are contained within this namespace</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteTypesAsync(NamespaceMember namespaceMember)
        {

            foreach (var type in namespaceMember.Types.OrderBy(t => (int)t.TypeKind).ThenBy(t => t.Name))
            {
                await WriteTypeAsync(type);

                //Fields - "pages"
                foreach (var field in type.Fields.OrderBy(t => t.Name))
                {
                    await WriteFieldAsync(field);
                }

                //Property - "pages"
                foreach (var property in type.Properties.OrderBy(t => t.Name))
                {
                    await WritePropertyAsync(property);
                }
                //Event - "pages"
                foreach (var evt in type.Events.OrderBy(t => t.Name))
                {
                    await WriteEventAsync(evt);
                }
                //Ctor - "pages"
                foreach (var method in type.Constructors.OrderBy(t => t.Name))
                {
                    await WriteMethodAsync(method);
                }

                //Destructor - "page"
                if (type.Destructor != null)
                {
                    await WriteMethodAsync(type.Destructor);
                }
                //Method - "pages"
                foreach (var method in type.Methods.OrderBy(t => t.Name))
                {
                    await WriteMethodAsync(method);
                }

                //Operator - "pages"
                foreach (var method in type.Operators.OrderBy(t => t.Name))
                {
                    await WriteMethodAsync(method);
                }
                //Conversion - "pages"
                foreach (var method in type.Conversions.OrderBy(t => t.Name))
                {
                    await WriteMethodAsync(method);
                }
            }

        }

        /// <summary>
        /// Writes the type documentation page
        /// </summary>
        /// <remarks>When a split per type is required, the new split is initialized at the beginning of the execution</remarks>
        /// <param name="type">Type to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteTypeAsync(TypeMember type)
        {
            if (Options.SplitType)
            {
                await SplitAsync(type.FileName);
            }
            await WriteTypeHeaderAsync(type);
            await Markup.WriteParaAsync(type.Documentation?.GetSummary(type)?.Render(Markup, type));

            await Markup.WriteCodeAsync(new Txt()
                    .AddEach(a => $"[{a}]", type.Attributes, Environment.NewLine) //attributes
                    .AddIf(Environment.NewLine, type.Attributes != null)
                    .Add(type.Modifier.ToModifierString()) //modifiers
                    .AddIf(" new", type.IsNew)
                    .AddIf(" abstract", type.IsAbstract && type.TypeKind == TypeKindEnum.Class)
                    .AddIf(" sealed", type.IsSealed && type.TypeKind == TypeKindEnum.Class)
                    .AddIf(" static", type.IsStatic && type.TypeKind == TypeKindEnum.Class)
                    .AddIf(" extern", type.IsExtern && type.TypeKind == TypeKindEnum.Class)
                    .Add($" {type.TypeKind.ToString().ToLower()}")  //kind - class, delegate, interface,..
                    .AddIf($" {type.DelegateReturnType?.ApplySpecialName(false)}", type.IsDelegate)
                    .Add($" {type.NameBase}") //name base (w/o type params)
                    .AddIf(() => type.TypeParameters.GetTypeParametersCode(), type.TypeParameters != null) // (optional) type parameters
                    .AddIf("(", type.IsDelegate) //delegate parameters
                    .AddEach(p => new Txt()
                            .AddEach(a => $"[{a}]", p.Attributes, " ")
                            .AddIf(" ", p.Attributes != null && p.Attributes.Count > 0)
                            .AddIf("ref ", p.RefKind == RefKindEnum.Ref)
                            .AddIf("out ", p.RefKind == RefKindEnum.Out)
                            .AddIf("in ", p.RefKind == RefKindEnum.In)
                            .AddIf("params ", p.IsParams)
                            .AddIf("this ", p.IsThis)
                            .Add($"{p.TypeRef.ApplySpecialName(false)} ")
                            .Add(p.Name)
                            .AddIf($" = {p.GetDefaultValueString()}", p.HasExplicitDefaultValue)
                        , type.DelegateParameters, ", ")
                    .AddIf(")", type.IsDelegate)

                    .AddIf(" : ", type.IsInherited || type.ImplementsAnyInterface) //inherits or implements 
                    .AddIf(type.TypeRef.BaseExclObject?.Name, type.IsInherited) //base class
                    .AddIf(": " + type.TypeRef.EnumValueType, type.TypeKind == TypeKindEnum.Enum) //enum type 
                    .AddIf(", ", type.IsInherited && type.ImplementsAnyInterface) //separator before interfaces if needed
                    .AddEach(i => i.Name, type.InterfacesTypeRefs, ", ") //interfaces
                    .AddIf(Environment.NewLine, type.IsGeneric && type.TypeParameters != null &&
                                               type.TypeParameters.Count(tp => tp.HasAnyConstraint) > 1) //start constraints at new line if >1
                    .AddEach(c => c.GetConstraintsString(),
                        type.TypeParameters?.Where(tp => tp.HasAnyConstraint),
                        Environment.NewLine), //constraints for generics
            true); //encode here

            if (type.IsGeneric)
            {
                await Markup.WriteTextAsync(new Txt()
                    .Add(Markup.Bold("Type parameters"))
                    .Add(Markup.DescriptionList(
                        tp => $"{Markup.Bold(tp.Name)}",
                        tp => $"{type.Documentation?.GetTypeParam(type, tp.Name)?.Render(Markup, type)}",
                        type.TypeParameters)));
            }

            if (type.IsDelegate)
            {
                var returnsDocumentation = type.Documentation?.GetReturns(type)?.Render(Markup, type);
                await Markup.WriteParaAsync(new Txt()
                    .Add(Markup.Bold("Return value"))
                    .Add(Markup.DescriptionList(
                            tp => tp.Link,
                            tp => tp.Doc,
                            new (string Link, string Doc)[] { (TypeRefWithLink(type.DelegateReturnType), returnsDocumentation) }))
                );

                if (type.DelegateParameters != null && type.DelegateParameters.Count > 0)
                {
                    await Markup.WriteTextAsync(new Txt()
                        .Add(Markup.Bold("Delegate parameters"))
                        .Add(Markup.DescriptionList(
                            tp => $"{TypeRefWithLink(tp.TypeRef)} {Markup.Bold(tp.Name)}",
                            tp => $"{type.Documentation?.GetParam(type, tp.Name)?.Render(Markup, type)}",
                            type.DelegateParameters))
                    );
                }
            }

            var inheritanceText = TypRefHierarchyWithLinks(type.TypeRef, " -&gt; ")?.Trim();
            var derivedText = DerivedInfo(type);
            var implementedByText = ImplementedByInfo(type);
            await Markup.WriteParaAsync(Txt
                .Start("")
                .AddIf("Inheritance: " + inheritanceText, !string.IsNullOrEmpty(inheritanceText))
                .AddIf(Markup.LineBreak(), !string.IsNullOrEmpty(inheritanceText))
                
                .AddIf(derivedText, derivedText!=null)
                .AddIf(Markup.LineBreak(), derivedText != null)
                
                .AddIf(implementedByText, implementedByText != null)
                .AddIf(Markup.LineBreak(), implementedByText != null)
                
                .AddIf("Attributes: ", type.AttributeTypeRefs != null)
                .AddEach(tr => TypeRefWithLink(tr), type.AttributeTypeRefs?.Distinct(), ", ")
                .AddIf(Markup.LineBreak(), type.AttributeTypeRefs != null)
                
                .AddIf("Implements: ", type.AllInterfacesTypeRefs != null)
                .AddEach(i => TypeRefWithLink(i), type.AllInterfacesTypeRefs?.Distinct(), ", ")
                );


            await WriteDocumentationExampleAsync(type);  //Example
            await WriteDocumentationRemarksAsync(type);  //Remarks
            await WriteDocumentationExceptionsAsync(type); //Exceptions

            //Type content links
            var constants = type.Fields?.Where(f => f.IsConst);
            constants = type.TypeKind == TypeKindEnum.Enum ? constants?.OrderBy(f => f.ConstantValue).ThenBy(f => f.Name) : constants?.OrderBy(f => f.Name);
            await WriteConstantsTableAsync("Constants", constants?.ToList());
            await WriteMembersTableAsync("Fields", type.Fields?.Where(f => !f.IsConst).OrderBy(f => f.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Properties", type.Properties?.Where(p => !p.IsIndexer).OrderBy(p => p.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Indexers", type.Properties?.Where(p => p.IsIndexer).OrderBy(p => p.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Events", type.Events?.OrderBy(p => p.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Constructors", type.Constructors?.OrderBy(m => m.Name).Cast<Member>().ToList());
            if (type.Destructor != null) await WriteMembersTableAsync("Destructor", new[] { type.Destructor });
            await WriteMembersTableAsync("Methods", type.Methods?.OrderBy(m => m.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync("Operators and Conversions", type.OperatorsAndConversions?.OrderBy(m => m.IsConversion).ThenBy(m => m.Name).Cast<Member>().ToList());
            await WriteMembersTableAsync(
                "Explicit Interface Implementations",
                type.AllMembers
                    .Where(m=>m is TypeContentMember typeContentMember && typeContentMember.ExplicitInterfaceImplementationMemberSymbol!=null)
                    .OrderBy(p => p.Name)
                    .ToList());

            //AddOns
            await WriteAddOnsBodyAsync(type);

            //SeeAlso
            await WriteDocumentationSeeAlsoAsync(type);

            await WritePageFooterAsync();

        }

        /// <summary>
        /// Writes the field documentation page
        /// </summary>
        /// <param name="field">Field to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteFieldAsync(FieldMember field)
        {
            await WriteTypeContentMemberHeaderAsync(field, field.IsConst ? "Constant" : "Field");
            await Markup.WriteParaAsync(field.Documentation?.GetSummary(field)?.Render(Markup, field));

            await Markup.WriteCodeAsync(new Txt()
                .AddEach(a => $"[{a}]", field.Attributes, Environment.NewLine) //attributes
                .AddIf(Environment.NewLine, field.Attributes != null)
                .AddIf(field.Modifier.ToModifierString(), field.Type.TypeKind != TypeKindEnum.Enum) //modifiers
                .AddIf(" new", field.IsNew && field.Type.TypeKind != TypeKindEnum.Enum)
                .AddIf(" const", field.IsConst && field.Type.TypeKind != TypeKindEnum.Enum)
                .AddIf(" static", field.IsStatic && !field.IsConst && field.Type.TypeKind != TypeKindEnum.Enum)
                .AddIf(" readonly", field.IsReadOnly && !field.IsConst && field.Type.TypeKind != TypeKindEnum.Enum)
                .AddIf(" volatile", field.IsVolatile && field.Type.TypeKind != TypeKindEnum.Enum)
                .AddIf($" {field.TypeRef.ApplySpecialName(false)}", field.Type.TypeKind != TypeKindEnum.Enum) //type
                .Add($" {field.Name}") //name
                .AddIf($" = {field.GetConstantValueString()}", field.IsConst), //constants
                true); //encode here

            var valueDocumentation = field.Documentation?.GetValue(field)?.Render(Markup, field);
            await Markup.WriteParaAsync(Txt
                 .Start(Markup.Bold("Field value"))
                 .Add(Markup.DescriptionList(
                     tp => tp.Link,
                     tp => tp.Doc,
                     new (string Link, string Doc)[] { (TypeRefWithLink(field.TypeRef), valueDocumentation) }))
                 
                 .AddIf("Attributes: ", field.AttributeTypeRefs != null)
                 .AddEach(tr => TypeRefWithLink(tr), field.AttributeTypeRefs?.Distinct(), ", "));


            await WriteDocumentationExampleAsync(field); //Example
            await WriteDocumentationRemarksAsync(field); //Remarks
            await WriteDocumentationExceptionsAsync(field); //Exceptions
            await WriteAddOnsBodyAsync(field); //AddOns
            await WriteDocumentationSeeAlsoAsync(field); //SeeAlso

            await WritePageFooterAsync();
        }

        /// <summary>
        /// Writes the property documentation page
        /// </summary>
        /// <param name="property">Property to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WritePropertyAsync(PropertyMember property)
        {
            await WriteTypeContentMemberHeaderAsync(property, property.IsIndexer ? "Indexer" : "Property");
            await Markup.WriteParaAsync(property.Documentation?.GetSummary(property)?.Render(Markup, property));

            await Markup.WriteCodeAsync(new Txt()
                .AddEach(a => $"[{a}]", property.Attributes, Environment.NewLine) //attributes
                .AddIf(Environment.NewLine, property.Attributes != null)
                .Add(property.Modifier.ToModifierString()) //modifiers
                .AddIf(" new", property.IsNew)
                .AddIf(" static", property.IsStatic)
                .AddIf(" virtual", property.IsVirtual)
                .AddIf(" sealed", property.IsSealed)
                .AddIf(" override", property.IsOverride)
                .AddIf(" abstract", property.IsAbstract)
                .AddIf(" extern", property.IsExtern)
                .Add($" {property.TypeRef.ApplySpecialName(false)}") //type
                .Add($" {property.NameBase}") //name
                .AddIf(property.Parameters.GetIndexerParametersCode(), property.IsIndexer)
                .Add(" {")
                .AddIf($" {property.GetterModifier}", !property.IsWriteOnly && !string.IsNullOrEmpty(property.GetterModifier))
                .AddIf(" get; ", !property.IsWriteOnly)
                .AddIf(" ", property.IsWriteOnly)
                .AddIf($"{property.SetterModifier} ", !property.IsReadOnly && !string.IsNullOrEmpty(property.SetterModifier))
                .AddIf("set; ", !property.IsReadOnly)
                .Add("}"), true); //encode here

            if (property.IsIndexer)
            {
                await Markup.WriteTextAsync(new Txt()
                    .Add(Markup.Bold("Indexer parameters"))
                    .Add(Markup.DescriptionList(
                        tp => $"{TypeRefWithLink(tp.TypeRef)} {Markup.Italic(tp.Name)}",
                        tp => $"{property.Documentation?.GetParam(property, tp.Name)?.Render(Markup, property)}",
                        property.Parameters)));
            }

            var valueDocumentation = property.Documentation?.GetValue(property)?.Render(Markup, property);
            var returnsDocumentation = property.Documentation?.GetReturns(property)?.Render(Markup, property);
            await Markup.WriteParaAsync(Txt
                .Start(Markup.Bold($"{(property.IsIndexer ? "Indexer" : "Property")} value"))
                .Add(Markup.DescriptionList(
                    tp => tp.Link,
                    tp => tp.Doc,
                    new (string Link, string Doc)[] { (TypeRefWithLink(property.TypeRef), valueDocumentation) }))
                
                .AddIf($"Returns: {returnsDocumentation}{Markup.LineBreak()}", !string.IsNullOrEmpty(returnsDocumentation))
                
                .AddIf(() => OverrideInfo(property), property.OverridesSymbol != null)
                .AddIf(() => ImplementsInfo(property), property.ImplementsSymbols != null)
                
                .AddIf("Attributes: ", property.AttributeTypeRefs != null)
                .AddEach(tr => TypeRefWithLink(tr), property.AttributeTypeRefs?.Distinct(), ", "));

            await WriteDocumentationExampleAsync(property); //Example
            await WriteDocumentationRemarksAsync(property); //Remarks
            await WriteDocumentationExceptionsAsync(property); //Exceptions
            await WriteAddOnsBodyAsync(property); //AddOns
            await WriteDocumentationSeeAlsoAsync(property); //SeeAlso

            await WritePageFooterAsync();
        }

        /// <summary>
        /// Writes the method documentation page
        /// </summary>
        /// <param name="method">Method to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteMethodAsync(MethodMember method)
        {
            var title = "Method";
            if (method.IsConstructor) title = "Constructor";
            if (method.IsDestructor) title = "Destructor";
            if (method.IsOperator) title = "Operator";
            if (method.IsConversion) title = "Conversion";
            await WriteTypeContentMemberHeaderAsync(method, title);

            await Markup.WriteParaAsync(method.Documentation?.GetSummary(method)?.Render(Markup, method));

            await Markup.WriteCodeAsync(new Txt()
                    .AddEach(a => $"[{a}]", method.Attributes, Environment.NewLine) //attributes
                    .AddIf(Environment.NewLine, method.Attributes != null)
                    .AddIf(method.Modifier.ToModifierString(), !method.IsDestructor) //modifiers
                    .AddIf(" new", method.IsNew)
                    .AddIf(" static", method.IsStatic)
                    .AddIf(" virtual", method.IsVirtual)
                    .AddIf(" sealed", method.IsSealed)
                    .AddIf(" override", method.IsOverride)
                    .AddIf(" abstract", method.IsAbstract)
                    .AddIf(" extern", method.IsExtern)
                    .AddIf(" async", method.IsAsync)
                    .AddIf(" ref", method.ReturnsByRef)
                    .AddIf(" ref readonly", method.ReturnsByRefReadonly)
                    .AddIf($" {method.ReturnTypeRef.ApplySpecialName(false)}", !method.ReturnsVoid) //type
                    .AddIf(" void", method.ReturnsVoid && !method.IsDestructor && !method.IsConstructor)
                    .AddIf($" {method.NameBase}", !method.IsOperator) //name
                    .AddIf(() => method.TypeParameters.GetTypeParametersCode(), method.TypeParameters != null) // (optional) type parameters
                    .AddIf($" operator {method.OperatorCSharpSymbol}", method.IsOperator) //operator
                    .Add("(")
                    .AddEach(p => new Txt()
                            .AddEach(a => $"[{a}]", p.Attributes, " ")
                            .AddIf(" ", p.Attributes != null && p.Attributes.Count > 0)
                            .AddIf("ref ", p.RefKind == RefKindEnum.Ref)
                            .AddIf("out ", p.RefKind == RefKindEnum.Out)
                            .AddIf("in ", p.RefKind == RefKindEnum.In)
                            .AddIf("params ", p.IsParams)
                            .AddIf("this ", p.IsThis)
                            .Add($"{p.TypeRef.ApplySpecialName(false)} ")
                            .Add(p.Name)
                            .AddIf($" = {p.GetDefaultValueString()}", p.HasExplicitDefaultValue)
                        , method.Parameters, ", ")
                    .Add(")")
                    .AddIf(Environment.NewLine,
                        method.IsGeneric &&
                        method.TypeParameters?.Count(tp => tp.HasAnyConstraint) > 1) //start constraints at new line if >1
                    .AddEach(c => c.GetConstraintsString(),
                        method.TypeParameters?.Where(tp => tp.HasAnyConstraint),
                        Environment.NewLine), //constraints for generics
            true); //encode here

            if (method.IsGeneric)
            {
                await Markup.WriteTextAsync(new Txt()
                    .Add(Markup.Bold("Type parameters"))
                    .Add(Markup.DescriptionList(
                        tp => $"{Markup.Bold(tp.Name)}",
                        tp => $"{method.Documentation?.GetTypeParam(method, tp.Name)?.Render(Markup, method)}",
                        method.TypeParameters))
                    );
            }
            if (method.HasParameters)
            {
                await Markup.WriteTextAsync(new Txt()
                    .Add(Markup.Bold($"{title} parameters"))
                    .Add(Markup.DescriptionList(
                        tp => $"{TypeRefWithLink(tp.TypeRef)} {Markup.Bold(tp.Name)}",
                        tp => $"{method.Documentation?.GetParam(method, tp.Name)?.Render(Markup, method)}",
                        method.Parameters))
                    );
            }

            var returnsDocumentation = method.Documentation?.GetReturns(method)?.Render(Markup, method);
            await Markup.WriteParaAsync(new Txt()
                .AddIf(Markup.Bold("Return value"), !method.IsConstructor && !method.IsDestructor) //exclude ctor and dtor
                .AddIf(Markup.DescriptionList(
                    tp => tp.Link,
                    tp => tp.Doc,
                    new (string Link, string Doc)[] { (TypeRefWithLink(method.ReturnTypeRef), returnsDocumentation) }),
                    !method.IsConstructor && !method.IsDestructor)
                
                .AddIf(() => OverrideInfo(method), method.OverridesSymbol != null)
                .AddIf(() => ImplementsInfo(method), method.ImplementsSymbols != null)
                
                .AddIf("Attributes: ", method.AttributeTypeRefs != null)
                .AddEach(tr => TypeRefWithLink(tr), method.AttributeTypeRefs?.Distinct(), ", ")
                );

            await WriteDocumentationExampleAsync(method); //Example
            await WriteDocumentationRemarksAsync(method); //Remarks
            await WriteDocumentationExceptionsAsync(method); //Exceptions
            await WriteAddOnsBodyAsync(method); //AddOns
            await WriteDocumentationSeeAlsoAsync(method); //SeeAlso

            await WritePageFooterAsync();
        }

        /// <summary>
        /// Writes the event documentation page
        /// </summary>
        /// <param name="evt">Event to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteEventAsync(EventMember evt)
        {
            await WriteTypeContentMemberHeaderAsync(evt, "Event");
            await Markup.WriteParaAsync(evt.Documentation?.GetSummary(evt)?.Render(Markup, evt));

            await Markup.WriteCodeAsync(new Txt()
                .AddEach(a => $"[{a}]", evt.Attributes, Environment.NewLine) //attributes
                .AddIf(Environment.NewLine, evt.Attributes != null)
                .Add(evt.Modifier.ToModifierString()) //modifiers
                .AddIf(" new", evt.IsNew)
                .AddIf(" static", evt.IsStatic)
                .AddIf(" virtual", evt.IsVirtual)
                .AddIf(" sealed", evt.IsSealed)
                .AddIf(" override", evt.IsOverride)
                .AddIf(" abstract", evt.IsAbstract)
                .AddIf(" extern", evt.IsExtern)
                .Add($" {evt.TypeRef.ApplySpecialName(false)}") //type
                .Add($" {evt.NameBase}") //name
                .AddIf(" { add; remove; }", evt.HasExplicitAddAndRemove), true); //encode here

            var valueDocumentation = evt.Documentation?.GetValue(evt)?.Render(Markup, evt);
            await Markup.WriteParaAsync(Txt
                .Start(Markup.Bold("Event handler"))
                .Add(Markup.DescriptionList(
                    tp => tp.Link,
                    tp => tp.Doc,
                    new (string Link, string Doc)[] { (TypeRefWithLink(evt.TypeRef), valueDocumentation) }))
                
                .AddIf(() => OverrideInfo(evt), evt.OverridesSymbol != null)
                .AddIf(() => ImplementsInfo(evt), evt.ImplementsSymbols != null)
                
                .AddIf("Attributes: ", evt.AttributeTypeRefs != null)
                .AddEach(tr => TypeRefWithLink(tr), evt.AttributeTypeRefs?.Distinct(), ", "));


            await WriteDocumentationExampleAsync(evt); //Example
            await WriteDocumentationRemarksAsync(evt); //Remarks
            await WriteDocumentationExceptionsAsync(evt); //Exceptions
            await WriteAddOnsBodyAsync(evt); //AddOns
            await WriteDocumentationSeeAlsoAsync(evt); //SeeAlso

            await WritePageFooterAsync();
        }

        #region Macros

        /// <summary>
        /// Writes the header for the type member (field, method, etc.) 
        /// </summary>
        /// <remarks>Writes the header, namespace  name and link, assembly name, type name and link</remarks>
        /// <param name="member">Member to document</param>
        /// <param name="title">Type of the member to be shown in title together with member's name (for example Method, Field, etc.</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteTypeContentMemberHeaderAsync(TypeContentMember member, string title)
        {
            var addOns = Model.AddOnsSelector(a => a.PriorityPageHeader);

            await Markup.WriteH2Async($"{member.Type.Name}.{member.Name} {title}", member.Anchor);
            await Markup.WriteParaAsync(
                Markup.Small(
                    Txt
                        .Start($"Namespace: {Markup.Link(member.Namespace.Name, member.Namespace)}")
                        .Add(Markup.LineBreak())
                        .Add($"Assembly: {member.Assembly.Name}")
                        .Add(Markup.LineBreak())
                        .Add($"Type: {Markup.Link(member.Type.Name, member.Type)}")
                        .AddIf(Markup.LineBreak(), member.SourceFiles != null && member.SourceFiles.Count > 0)
                        .AddIf(() => "Sources: " + string.Join(", ", member.SourceFiles.Select(s => s.Substring(member.Root.ProjectRootDir.Length + 1))),
                            member.SourceFiles != null && member.SourceFiles.Count > 0)
                        .AddEachIf(a => a.WritePageHeader(member, Markup), addOns, addOns.Count > 0)));
        }

        /// <summary>
        /// Writes the header for the type member (field, method, etc.) 
        /// </summary>
        /// <remarks>Writes the header, namespace  name and link, assembly name</remarks>
        /// <param name="type">Type to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteTypeHeaderAsync(TypeMember type)
        {
            var addOns = Model.AddOnsSelector(a => a.PriorityPageHeader);

            await Markup.WriteH2Async($"{type.Name} {type.TypeKind}", type.Anchor);
            await Markup.WriteParaAsync(
                Markup.Small(
                    Txt
                        .Start($"Namespace: {Markup.Link(type.Namespace.Name, type.Namespace)}")
                        .Add(Markup.LineBreak())
                        .Add($"Assembly: {type.Assembly.Name}")
                        .AddIf(Markup.LineBreak(), type.SourceFiles != null && type.SourceFiles.Count > 0)
                        .AddIf(() => "Sources: " + string.Join(", ", type.SourceFiles.Select(s => s.Substring(type.Root.ProjectRootDir.Length + 1))),
                            type.SourceFiles != null && type.SourceFiles.Count > 0)
                        .AddEachIf(a => a.WritePageHeader(type, Markup), addOns, addOns.Count > 0)));
        }

        /// <summary>
        /// Writes the Example documentation section for given <paramref name="member"/> if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteDocumentationExampleAsync(Member member)
        {
            var exampleDocumentation = member.Documentation?.GetExample(member)?.Render(Markup, member);
            if (!string.IsNullOrEmpty(exampleDocumentation))
            {
                await Markup.WriteH3Async("Example");
                await Markup.WriteParaAsync(exampleDocumentation); //TODO check if it will work for code
            }
        }

        /// <summary>
        /// Writes the Remarks documentation section for given <paramref name="member"/> if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteDocumentationRemarksAsync(Member member)
        {
            var remarksDocumentation = member.Documentation?.GetRemarks(member)?.Render(Markup, member);
            if (!string.IsNullOrEmpty(remarksDocumentation))
            {
                await Markup.WriteH3Async("Remarks");
                await Markup.WriteParaAsync(remarksDocumentation);
            }
        }

        /// <summary>
        /// Writes the Exceptions documentation section for given <paramref name="member"/> if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteDocumentationExceptionsAsync(Member member)
        {
            var exceptionsDocumentation = member.Documentation?.GetExceptions(member);
            if (exceptionsDocumentation != null && exceptionsDocumentation.Count > 0)
            {
                await Markup.WriteH3Async("Exceptions");

                var renderedItems = exceptionsDocumentation.Select(exceptionDoc => exceptionDoc.Render(Markup, member)).ToList();
                await Markup.WriteParaAsync(Markup.DescriptionList(renderedItems));

            }
        }

        /// <summary>
        /// Writes the See Also documentation section for given <paramref name="member"/> if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteDocumentationSeeAlsoAsync(Member member)
        {
            var seeAlsoDocumentation = member.Documentation?.GetSeeAlso(member);
            if (seeAlsoDocumentation != null && seeAlsoDocumentation.Count > 0)
            {
                await Markup.WriteH3Async("See Also");

                await Markup.WriteParaAsync(new Txt()
                    .AddEach(sa => sa.Render(Markup, member), seeAlsoDocumentation, Markup.LineBreak())); //TODO check links
            }
        }

        /// <summary>
        /// Writes the add-on page bodies (if provided)
        /// </summary>
        /// <returns>Async task</returns>
        protected virtual async Task WriteAddOnsBodyAsync(Member member)
        {
            var addOns = Model.AddOnsSelector(a => a.PriorityPageBody);
            foreach (var addOn in addOns)
            {
                await addOn.WritePageBodyAsync(member, Markup);
            }
        }

        /// <summary>
        /// [Deprecated] Writes the page footer.
        /// WritePageFooter is deprecated, please use WritePageFooterAsync instead.
        /// </summary>
        /// <remarks>The functionality of <see cref="WritePageFooterAsync"/> remains the same, just the name of the method has been corrected</remarks>
        /// <returns>Async task</returns>
        [Obsolete("WritePageFooter is deprecated, please use WritePageFooterAsync instead.")]
        public virtual async Task WritePageFooter()
        {
            await WritePageFooterAsync();
        }

        /// <summary>
        /// Writes the page footer
        /// </summary>
        /// <remarks>Go to namespace or types links to namespaces list and types list are rendered here</remarks>
        /// <returns>Async task</returns>
        public virtual async Task WritePageFooterAsync()
        {
            var footerItems = new List<string>
            {
                Markup.Link("namespaces", BaseFileName, "namespace-list"),
                Markup.Link("types", BaseFileName, "type-list")
            };

            var addOns = Model.AddOnsSelector(a => a.PriorityPageFooter);
            if (addOns.Count > 0)
            {
                footerItems.AddRange(addOns.Select(a => a.WritePageFooter(BaseFileName, Markup)));
            }

            await Markup.WriteParaAsync($"Go to {string.Join(" or ", footerItems.Where(i=>!string.IsNullOrEmpty(i)))}");
            await Markup.WriteParaAsync(" ");
        }

        /// <summary>
        /// Renders the type reference (<see cref="TypeRef"/>) with link if available
        /// </summary>
        /// <remarks>When the <paramref name="typeRef"/> is related to a member from code model, the link to the member is created.
        /// Otherwise, the will try to resolve the link to MS API online documentation using <see cref="MsApiDocEngine.GetLink(net.adamec.dev.markupdoc.CodeModel.TypeRef)"/>.
        /// When the link can't be built, just member's name is returned as a plain text.</remarks>
        /// <param name="typeRef">Type reference to render</param>
        /// <param name="includeNamespace">Flag whether to include the namespace in the member name shown</param>
        /// <returns>Rendered type reference (<see cref="TypeRef"/>) with link if available</returns>
        protected virtual string TypeRefWithLink(TypeRef typeRef, bool includeNamespace = true)
        {
            var txt = typeRef.ApplySpecialName(includeNamespace);
            if (typeRef.ArrayElementType != null) typeRef = typeRef.ArrayElementType;

            //Local reference - link to member's anchor
            if (typeRef.Member != null) return Markup.Link(txt, typeRef.Member);
            //Local reference for "applied" generic ( Abc<string> goes to Abc<T>) - link to member's anchor
            if (typeRef.GenericDefinition?.Member != null)
                return Markup.Link(txt, typeRef.GenericDefinition.Member);

            //Try to resolve link to MS if available and applicable
            var msLink = MsApiDocEngine.GetLink(typeRef);

            //If got the MS link, return the external link. Otherwise, no idea about the link, so return just the text
            return msLink != null ? Markup.ExternalLink(txt, msLink) : Markup.Text(txt);
        }
        /// <summary>
        /// Renders the info about the overriden member/symbol with link if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Info about the overriden member/symbol with link if available</returns>
        protected virtual string OverrideInfo(TypeContentMember member)
        {
            if (member.OverridesSymbol == null) return "";
            if (member.OverridesMember != null)
            {
                return
                    $"Overrides: {Markup.Link(member.OverridesMember.Type.Name + "." + member.OverridesMember.Name, member.OverridesMember)}";
            }

            //Try to resolve link to MS if available and applicable
            var txt = TypeRef.ApplySpecialName(member.OverridesSymbol.ContainingType) + "." + member.OverridesSymbol.Name;
            var msLink = MsApiDocEngine.GetLink(member.OverridesSymbol.GetDocumentationCommentId());
            if (msLink == null && member.OverridesSymbol.OriginalDefinition != null)
            {
                //try also this - for generic members
                msLink = MsApiDocEngine.GetLink(member.OverridesSymbol.OriginalDefinition.GetDocumentationCommentId());
            }
            return "Overrides: " + (msLink != null ? Markup.ExternalLink(txt, msLink) : Markup.Text(txt));

        }

        /// <summary>
        /// Renders the info about the implemented members/symbols with link if available
        /// </summary>
        /// <param name="member">Member to document</param>
        /// <returns>Info about the overriden members/symbols with link if available</returns>
        protected virtual string ImplementsInfo(TypeContentMember member)
        {
            if (member.ImplementsSymbols == null) return "";
            var items = new List<string>();
            for (var idx = 0; idx < member.ImplementsSymbols.Count; idx++)
            {
                var implementsSymbol = member.ImplementsSymbols[idx];
                var implementsMember = member.ImplementsMembers[idx];
                if (implementsMember != null)
                {
                    items.Add(Markup.Link(implementsMember.Type.Name + "." + implementsMember.Name, implementsMember));
                    continue;
                }

                //Try to resolve link to MS if available and applicable
                var txt = TypeRef.ApplySpecialName(implementsSymbol.ContainingType) + "." + implementsSymbol.Name;
                var msLink = MsApiDocEngine.GetLink(implementsSymbol.GetDocumentationCommentId());
                if (msLink == null && implementsSymbol.OriginalDefinition != null)
                {
                    //try also this - for generic members
                    msLink = MsApiDocEngine.GetLink(implementsSymbol.OriginalDefinition.GetDocumentationCommentId());
                }
                items.Add(msLink != null ? Markup.ExternalLink(txt, msLink) : Markup.Text(txt));
            }

            return items.Count > 0 ? "Implements: " + string.Join(", ", items) : "";
        }

        /// <summary>
        /// Renders the info about the type members that directly inherits from the type member if available
        /// </summary>
        /// <param name="type">Type to document</param>
        /// <returns>info about the type members with links that directly inherits from the type member or null when not available</returns>
        protected virtual string DerivedInfo(TypeMember type)
        {
            var derived = Model.GetDerivedTypeMembers(type);
            if (derived == null || derived.Count == 0) return null;

            return "Derived: " + string.Join(", ", derived.Select(t => Markup.Link($"{t.Namespace.Name}.{t.Name}", t)));
        }

        /// <summary>
        /// Renders the info about the type members that implements the given <paramref name="type"/> (interface) if available
        /// </summary>
        /// <param name="type">Type (interface) to document</param>
        /// <returns>info about the type members with links that implements the given <paramref name="type"/> (interface) or null when not available</returns>
        protected virtual string ImplementedByInfo(TypeMember type)
        {
            if (type.TypeKind != TypeKindEnum.Interface) return null;

            var implementedBy = Model.GetTypeMembersImplementingInterface(type);
            if (implementedBy == null || implementedBy.Count == 0) return null;

            return "Implemented by: " + string.Join(", ", implementedBy.Select(t => Markup.Link($"{t.Namespace.Name}.{t.Name}", t)));
        }

        /// <summary>
        /// Renders the type hierarchy from the "very base type" to the type represented by given <paramref name="typeRef"/>
        /// </summary>
        /// <remarks>Uses <see cref="TypeRefWithLink"/> to render individual parts of hierarchy</remarks>
        /// <param name="typeRef">Type reference to render the type hierarchy for</param>
        /// <param name="separator">Inheritance separator</param>
        /// <param name="includeNamespace">Flag whether to include the namespace in the member name shown</param>
        /// <returns>Rendered type hierarchy from the "very base type" to the type represented by given <paramref name="typeRef"/></returns>
        protected virtual string TypRefHierarchyWithLinks(TypeRef typeRef, string separator, bool includeNamespace = true)
        {
            if (typeRef.Base == null) return null;

            string output = null;
            var t = typeRef.Base;
            while (t != null)
            {
                if (output != null) output = separator + output;
                output = TypeRefWithLink(t, includeNamespace) + output;

                t = t.Base;
            }

            return output;
        }

        /// <summary>
        /// Writes the table with given list of members
        /// </summary>
        /// <remarks>Table has three columns - Name, Modifier and Summary</remarks>
        /// <param name="part">Name of the part (kind of members) to be shown before the table</param>
        /// <param name="members">Members to be listed</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteMembersTableAsync(string part, ICollection<Member> members)
        {
            if (members == null || members.Count < 1) return;

            await Markup.WriteH3Async(part);
            await Markup.WriteTableHeaderAsync("Name", "Modifier", "Summary");
            foreach (var member in members)
            {
                await Markup.WriteTableColsAsync(
                    Markup.Link(member.Name, member),
                    $"{member.Modifier.ToModifierString()}{(member.IsStatic ? " static" : "")}{(member.IsAbstract ? " abstract" : "")}",
                    member.Documentation?.GetSummary(member)?.Render(Markup, member) ?? string.Empty);
            }
            await Markup.WriteTableFooterAsync();
            await Markup.WriteParaAsync(" ");
        }

        /// <summary>
        /// Writes the table with given list of constants
        /// </summary>
        /// <remarks>Table has three columns - Name, Value and Summary</remarks>
        /// <param name="part">Name of the part (kind of members) to be shown before the table</param>
        /// <param name="members">Members to be listed</param>
        /// <returns>Async task</returns>
        protected virtual async Task WriteConstantsTableAsync(string part, ICollection<FieldMember> members)
        {
            if (members == null || members.Count < 1) return;

            await Markup.WriteH3Async(part);
            await Markup.WriteTableHeaderAsync("Name", "Value", "Summary");
            foreach (var member in members)
            {
                await Markup.WriteTableColsAsync(
                    Markup.Link(member.Name, member),
                    member.ConstantValue?.ToString() ?? "null",
                    member.Documentation?.GetSummary(member)?.Render(Markup, member) ?? string.Empty);
            }
            await Markup.WriteTableFooterAsync();
            await Markup.WriteParaAsync(" ");
        }
        #endregion

        /// <summary>
        /// [Deprecated] Initializes a new split.
        /// Split is deprecated, please use SplitAsync instead.
        /// </summary>
        /// <remarks>The functionality of <see cref="SplitAsync"/> remains the same, just the name of the method has been corrected</remarks>
        /// <returns>Async task</returns>
        [Obsolete("Split is deprecated, please use SplitAsync instead.")]
        public virtual async Task Split(string splitName)
        {
            await SplitAsync(splitName);
        }

        /// <summary>
        /// Initializes a new split. When splitting is not required, it's ignored (no split generated)
        /// </summary>
        /// <seealso cref="MarkupMultiFileWriter"/>
        /// <param name="splitName">Name of the split</param>
        /// <returns>Async task</returns>
        public virtual async Task SplitAsync(string splitName)
        {
            if (!Options.SplitNs && !Options.SplitType) return;

            await Markup.WriteDocumentEndAsync();
            Writer.Split(splitName);
            await Markup.WriteDocumentStartAsync(Title);
        }

    }
}
