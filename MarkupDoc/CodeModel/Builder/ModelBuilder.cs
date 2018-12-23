using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using net.adamec.dev.markupdoc.AddOns;
using net.adamec.dev.markupdoc.Utils;
using net.adamec.dev.markupdoc.Utils.Extensions;
using net.adamec.dev.markupdoc.XmlDocumentation;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <summary>
    /// Code model builder
    /// </summary>
    public static class ModelBuilder
    {
        /// <summary>
        /// Builds a code model for C# project
        /// </summary>
        /// <param name="projectFile">Project file full path</param>
        /// <param name="addOns">Optional list of add-ons</param>
        /// <returns>Code model root (async)</returns>
        public static async Task<RootMember> BuildFromProjectSourcesAsync(string projectFile, IEnumerable<IAddOn> addOns)
        {
            RootMember root;
            var rootBuilder = new RootMemberBuilder();
            Console.WriteLine($"Preparing the workspace for {projectFile}");
            MSBuildLocator.RegisterDefaults();
            using (var msWorkspace = MSBuildWorkspace.Create())
            {
                Console.WriteLine($"Opening the project {projectFile}");
                var project = await msWorkspace.OpenProjectAsync(projectFile);
                var compilation = project.GetCompilationAsync().Result;
                var assemblySymbol = compilation.Assembly;

                //Build the code model
                Console.WriteLine("Building the code model...");
                rootBuilder.ProjectRootDir = new FileInfo(projectFile).DirectoryName;
                rootBuilder.CompilationFiles = compilation.SyntaxTrees.Select(st => st.FilePath).ToList();
                Build(assemblySymbol, rootBuilder, null, null, null, 0);
                root = new RootMember(rootBuilder,addOns);
                Console.WriteLine("Code model build");

                Console.WriteLine("Closing the workspace...");
                msWorkspace.CloseSolution();
                Console.WriteLine("Workspace closed");
            }

            return root;
        }

        /// <summary>
        /// Walks through the Roslyn symbols hierarchy and prepares the member builders hierarchy into the given <paramref name="root"/> builder.
        /// </summary>
        /// <param name="symbol">Symbol to process</param>
        /// <param name="root">Root builder</param>
        /// <param name="assembly">Containing assembly builder</param>
        /// <param name="ns">Containing namespace builder</param>
        /// <param name="type">Containing type builder (used for nested types)</param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void Build(ISymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns,
            TypeMemberBuilder type, int level)
        {
            Console.WriteLine($"{new string(' ', level)}Checking the {symbol.Kind}: {symbol.Name}");
            try
            {
                switch (symbol)
                {
                    case IAssemblySymbol assemblySymbol:
                        BuildAssembly(assemblySymbol, root, level);
                        break;

                    case INamespaceSymbol namespaceSymbol:
                        BuildNamespace(namespaceSymbol, root, assembly, level);
                        break;

                    case INamedTypeSymbol typeSymbol:
                        BuildType(typeSymbol, root, assembly, ns, type, level);
                        break;

                    case IFieldSymbol fieldSymbol:
                        BuildField(fieldSymbol, root, type, level);
                        break;

                    case IPropertySymbol propertySymbol:
                        BuildProperty(propertySymbol, root, type, level);
                        break;

                    case IMethodSymbol methodSymbol:
                        BuildMethod(methodSymbol, root, type, level);
                        break;
                    case IEventSymbol eventSymbol:
                        BuildEvent(eventSymbol, root, type, level);
                        break;
                }
            }
            catch (Exception exception)
            {
                ConsoleUtils.WriteErr($"{new string(' ', level)}Exception '{exception.Message}' while processing {symbol.Kind}: {symbol.Name}");
                throw;
            }
        }

        /// <summary>
        /// Prepares the <see cref="AssemblyMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="RootMember.Assemblies"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="IAssemblySymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildAssembly(IAssemblySymbol symbol, RootMemberBuilder root, int level)
        {
            var a = new AssemblyMemberBuilder
            {
                Name = symbol.Name,
                NameBase = symbol.Name,
                Symbol = symbol,
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml()
            };

            root.Assemblies.Add(a);
            Console.WriteLine($"{new string(' ', level)} read as {a}");
            // ReSharper disable once TailRecursiveCall
            Build(symbol.GlobalNamespace, root, a, null, null, level + 1);
        }

        /// <summary>
        /// Prepares the <see cref="NamespaceMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="AssemblyMemberBuilder.Namespaces"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamespaceSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="assembly">Parent <see cref="AssemblyMemberBuilder"/></param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildNamespace(INamespaceSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, int level)
        {
            var children = symbol.GetMembers().ToArray();
            var childNamespaces = children.OfType<INamespaceSymbol>().ToArray();
            var childTypes = children.OfType<ITypeSymbol>().ToArray();

            NamespaceMemberBuilder n = null;
            if (childTypes.Length > 0) //check if not "empty" namespace resp. part of "dot syntax" (when there is a ns a.b.c.d and "d" is the only one containing the types, the a,b and c are in symbols hierarchy as "empty" ns
            {
                n = new NamespaceMemberBuilder()
                {
                    Name = SymbolDisplay.ToDisplayString(symbol),
                    NameBase = SymbolDisplay.ToDisplayString(symbol),
                    Symbol = symbol,
                    DocumentationId = symbol.GetDocumentationCommentId(),
                };

                //ns documentation - internal class NamespaceDoc { }
                var docClass = symbol.GetMembers("NamespaceDoc").OfType<INamedTypeSymbol>().FirstOrDefault();
                if (docClass != null)
                {
                    n.DocumentationXml = docClass.GetDocumentationCommentXml();
                    n.Documentation = Documentation.Read(n.DocumentationXml);
                }

                assembly.Namespaces.Add(n);
                Console.WriteLine($"{new string(' ', level)} read as {n}");

                foreach (var memberSymbol in childTypes)
                {
                    Build(memberSymbol, root, assembly, n, null, level + 1);
                }
            }

            foreach (var memberSymbol in childNamespaces)
            {
                Build(memberSymbol, root, assembly, n, null, level + 1);
            }
        }

        /// <summary>
        /// Prepares the <see cref="TypeMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="NamespaceMemberBuilder.Types"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamedTypeSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="assembly">Containing <see cref="AssemblyMemberBuilder"/></param>
        /// <param name="ns">Parent <see cref="NamespaceMemberBuilder"/></param>
        /// <param name="type">Parent <see cref="TypeMemberBuilder"/> for nested types</param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        // ReSharper disable once SuggestBaseTypeForParameter
        private static void BuildType(INamedTypeSymbol symbol, RootMemberBuilder root, AssemblyMemberBuilder assembly, NamespaceMemberBuilder ns, TypeMemberBuilder type, int level)
        {
            if (symbol.IsImplicitlyDeclared) return;
            if (symbol.GetAttributes().Any(a => a.AttributeClassString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute")) return;
            if (symbol.Name.Contains("NuProps"))
            {

            }
            var t = new TypeMemberBuilder()
            {
                Name = type == null ? symbol.Name : $"{type.Name}.{symbol.Name}",
                Symbol = symbol,
                SourceFiles = symbol.DeclaringSyntaxReferences.Select(dsr=>dsr.SyntaxTree.FilePath).ToList(),
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml(),
                Documentation = Documentation.Read(symbol.GetDocumentationCommentXml()),
                TypeKind = symbol.TypeKind.ToTypeKindEnum(),
                TypeRef = TypeRef.GetOrCreate(symbol, root),

                Modifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility),
                IsAbstract = symbol.IsAbstract,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsStatic = symbol.IsStatic,
                IsNew = symbol.GetIsNew(),
                IsGeneric = symbol.IsGenericType &&
                            symbol.TypeParameters != null &&
                            symbol.TypeParameters.Length > 0
            };
            t.NameBase = t.Name;
           
            //Get the implemented interfaces
            var typeInterfaces = symbol.Interfaces;
            if (typeInterfaces != null && typeInterfaces.Length > 0)
            {
                //directly implemented
                t.InterfacesTypeRefs = typeInterfaces.Select(i => TypeRef.GetOrCreate(i, root)).ToList();
            }

            var typeAllInterfaces = symbol.AllInterfaces;
            if (typeAllInterfaces != null && typeAllInterfaces.Length > 0)
            {
                //includes the inherited
                t.AllInterfacesTypeRefs = typeAllInterfaces.Select(i => TypeRef.GetOrCreate(i, root)).ToList();
                foreach (var implementedInterface in typeAllInterfaces)
                {
                    var interfaceMembers = implementedInterface.GetMembers();
                    if (interfaceMembers == null) continue;

                    foreach (var interfaceMember in interfaceMembers.Where(
                        im=>im.Kind==SymbolKind.Event ||
                            im.Kind==SymbolKind.Property ||
                            im.Kind== SymbolKind.Method ))
                    {
                        var implementationMember = symbol.FindImplementationForInterfaceMember(interfaceMember);
                        if (implementationMember == null) continue;

                        t.InterfaceImplementationsByInterfaceMember.Add(interfaceMember,implementationMember);

                        if (!t.InterfaceMembersByInterfaceImplementation.TryGetValue(implementationMember,out var interfaceMemberList))
                        {
                            interfaceMemberList=new List<ISymbol>();
                            t.InterfaceMembersByInterfaceImplementation.Add(implementationMember, interfaceMemberList);
                        }
                        ((List<ISymbol>)interfaceMemberList).Add(interfaceMember);
                    }
                }
            }

            //Get the attributes
            t.SetAttributes(root);

            if (t.IsGeneric)
            {
                //Process the type parameters
                t.TypeParameters = GetTypeParameters(symbol.TypeParameters, root);
                t.Name += $"<{string.Join(",", t.TypeParameters.Select(tp => tp.Name))}>"; // add types to name
            }

            if (t.TypeKind == TypeKindEnum.Delegate)
            {
                //Process delegate - delegates only have parameters and return value
                t.DelegateReturnType = TypeRef.GetOrCreate(symbol.DelegateInvokeMethod.ReturnType, root);
                t.DelegateParameters = GetMethodParameters(symbol.DelegateInvokeMethod.Parameters, root);
            }

            ns.Types.Add(t);
            Console.WriteLine($"{new string(' ', level)} read as {t}");

            foreach (var subType in symbol.GetMembers())
            {
                if (!subType.IsImplicitlyDeclared)
                    Build(subType, root, assembly, ns, t, level + 1);
            }
        }

        /// <summary>
        /// Prepares the <see cref="FieldMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="TypeMemberBuilder.ContentMembers"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamedTypeSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="type">Parent <see cref="TypeMemberBuilder"/></param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildField(IFieldSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
        {
            if (symbol.IsImplicitlyDeclared) return;
            if (symbol.GetAttributes().Any(a => a.AttributeClassString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute")) return;

            var f = new FieldMemberBuilder()
            {
                Name = symbol.Name,
                NameBase = symbol.Name,
                Symbol = symbol,
                SourceFiles = symbol.DeclaringSyntaxReferences.Select(dsr => dsr.SyntaxTree.FilePath).ToList(),
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml(),
                Documentation = Documentation.Read(symbol.GetDocumentationCommentXml()),
                Modifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility),
                IsAbstract = symbol.IsAbstract,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsStatic = symbol.IsStatic,
                IsOverride = symbol.IsOverride,
                IsVirtual = symbol.IsVirtual,
                IsConst = symbol.IsConst,
                IsReadOnly = symbol.IsReadOnly,
                IsVolatile = symbol.IsVolatile,
                ConstantValue = symbol.ConstantValue,
                TypeRef = TypeRef.GetOrCreate(symbol.Type, root),
                IsNew = symbol.GetIsNew()
            };

            f.SetAttributes(root);

            type.ContentMembers.Add(f);
            Console.WriteLine($"{new string(' ', level)} read as {f}");
        }

        /// <summary>
        /// Prepares the <see cref="PropertyMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="TypeMemberBuilder.ContentMembers"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamedTypeSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="type">Parent <see cref="TypeMemberBuilder"/></param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildProperty(IPropertySymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
        {
            if (symbol.IsImplicitlyDeclared) return;
            if (symbol.GetAttributes().Any(a => a.AttributeClassString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute")) return;

            var p = new PropertyMemberBuilder()
            {
                Name = symbol.Name,
                NameBase = symbol.Name.Replace("[]", ""),
                Symbol = symbol,
                SourceFiles = symbol.DeclaringSyntaxReferences.Select(dsr => dsr.SyntaxTree.FilePath).ToList(),
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml(),
                Documentation = Documentation.Read(symbol.GetDocumentationCommentXml()),
                Modifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility),
                IsAbstract = symbol.IsAbstract,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsStatic = symbol.IsStatic,
                IsOverride = symbol.IsOverride,
                IsVirtual = symbol.IsVirtual,
                IsReadOnly = symbol.IsReadOnly,
                IsWriteOnly = symbol.IsWriteOnly,
                IsIndexer = symbol.IsIndexer,
                TypeRef = TypeRef.GetOrCreate(symbol.Type, root),
                IsNew = symbol.GetIsNew(),
                OverridesSymbol = symbol.OverriddenProperty,
                ExplicitInterfaceImplementationMemberSymbol =
                    symbol.ExplicitInterfaceImplementations != null && symbol.ExplicitInterfaceImplementations.Length > 0
                        ? symbol.ExplicitInterfaceImplementations[0]
                        : null
            };

            var propertyModifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility);
            var getterModifier = ModifierEnumExtensions.Modifier(symbol.GetMethod?.DeclaredAccessibility ?? symbol.DeclaredAccessibility);
            var setterModifier = ModifierEnumExtensions.Modifier(symbol.SetMethod?.DeclaredAccessibility ?? symbol.DeclaredAccessibility);
            if (getterModifier != propertyModifier) p.GetterModifier = getterModifier.ToModifierString();
            if (setterModifier != propertyModifier) p.SetterModifier = setterModifier.ToModifierString();

            if (symbol.Parameters != null && symbol.Parameters.Length > 0)
            {
                //Process the indexer parameters (the only property kind with parameters
                p.Parameters = GetMethodParameters(symbol.Parameters, root);
                p.Name = p.Name.Replace("[]",
                           $"[{string.Join(", ", p.Parameters.Select(param => param.TypeRef.ApplySpecialName(false)))}]");
            }

            p.SetAttributes(root);

            type.ContentMembers.Add(p);
            Console.WriteLine($"{new string(' ', level)} read as {p}");
        }

        /// <summary>
        /// Prepares the <see cref="MethodMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="TypeMemberBuilder.ContentMembers"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamedTypeSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="type">Parent <see cref="TypeMemberBuilder"/></param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildMethod(IMethodSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
        {
            if (symbol.IsImplicitlyDeclared ||
                 symbol.MethodKind == MethodKind.AnonymousFunction ||
                 symbol.MethodKind == MethodKind.BuiltinOperator ||
                 symbol.MethodKind == MethodKind.LambdaMethod ||
                 symbol.MethodKind == MethodKind.LocalFunction ||
                 symbol.MethodKind == MethodKind.PropertyGet ||
                 symbol.MethodKind == MethodKind.PropertySet ||
                 symbol.MethodKind == MethodKind.EventAdd ||
                 symbol.MethodKind == MethodKind.EventRemove) return;

            if (symbol.GetAttributes().Any(a => a.AttributeClassString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute")) return;

            var m = new MethodMemberBuilder()
            {
                Name = symbol.GetOperatorMethodAliasOrOriginalName(),
                NameBase = symbol.Name,
                OperatorCSharpSymbol = symbol.GetOperatorCSharpSymbol(),
                Symbol = symbol,
                SourceFiles = symbol.DeclaringSyntaxReferences.Select(dsr => dsr.SyntaxTree.FilePath).ToList(),
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml(),
                Documentation = Documentation.Read(symbol.GetDocumentationCommentXml()),
                Modifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility),
                IsAbstract = symbol.IsAbstract,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsStatic = symbol.IsStatic,
                IsOverride = symbol.IsOverride,
                IsVirtual = symbol.IsVirtual,
                IsAsync = symbol.IsAsync,
                IsExtensionMethod = symbol.IsExtensionMethod,
                IsGeneric = symbol.IsGenericMethod && symbol.TypeParameters != null &&
                            symbol.TypeParameters.Length > 0,
                ReturnsVoid = symbol.ReturnsVoid,
                ReturnsByRef = symbol.ReturnsByRef,
                ReturnsByRefReadonly = symbol.ReturnsByRefReadonly,
                RefKind = (RefKindEnum)symbol.RefKind,
                ReturnTypeRef = TypeRef.GetOrCreate(symbol.ReturnType, root),
                MethodKind = (MethodKindEnum)symbol.MethodKind,
                IsNew = symbol.GetIsNew(),
                OverridesSymbol = symbol.OverriddenMethod,
                ExplicitInterfaceImplementationMemberSymbol =
                    symbol.ExplicitInterfaceImplementations!=null && symbol.ExplicitInterfaceImplementations.Length>0
                        ?symbol.ExplicitInterfaceImplementations[0]
                        :null
            };

            if (m.IsConstructor || m.IsDestructor)
            {
                m.Name = $"{(m.IsDestructor ? "~" : "")}{type.Name}";
                m.NameBase = m.Name;
            }

            if (m.IsGeneric)
            {
                //Process the type parameters
                m.TypeParameters = GetTypeParameters(symbol.TypeParameters, root);
                m.Name += $"<{string.Join(",", m.TypeParameters.Select(tp => tp.Name))}>"; // add types to name
            }

            if (symbol.Parameters != null && symbol.Parameters.Length > 0)
            {
                //Process the method parameters
                m.Parameters = GetMethodParameters(symbol.Parameters, root, m.IsExtensionMethod);
                m.Name += $"({string.Join(", ", m.Parameters.Select(p => p.TypeRef.ApplySpecialName(false)))})";
            }
            else
            {
                m.Name += "()";
            }

            m.SetAttributes(root);

            type.ContentMembers.Add(m);
            Console.WriteLine($"{new string(' ', level)} read as {m}");
        }

        /// <summary>
        /// Prepares the <see cref="EventMemberBuilder"/> from the <paramref name="symbol"/>
        /// and adds it to <see cref="TypeMemberBuilder.ContentMembers"/>
        /// </summary>
        /// <param name="symbol">Source <see cref="INamedTypeSymbol"/></param>
        /// <param name="root">Builder root</param>
        /// <param name="type">Parent <see cref="TypeMemberBuilder"/></param>
        /// <param name="level">Hierarchy level (used to indent the console output)</param>
        private static void BuildEvent(IEventSymbol symbol, RootMemberBuilder root, TypeMemberBuilder type, int level)
        {
            if (symbol.IsImplicitlyDeclared) return;
            if (symbol.GetAttributes().Any(a => a.AttributeClassString() == "System.Runtime.CompilerServices.CompilerGeneratedAttribute")) return;

            var e = new EventMemberBuilder
            {
                Name = symbol.Name,
                NameBase = symbol.Name,
                Symbol = symbol,
                SourceFiles = symbol.DeclaringSyntaxReferences.Select(dsr => dsr.SyntaxTree.FilePath).ToList(),
                DocumentationId = symbol.GetDocumentationCommentId(),
                DocumentationXml = symbol.GetDocumentationCommentXml(),
                Documentation = Documentation.Read(symbol.GetDocumentationCommentXml()),
                Modifier = ModifierEnumExtensions.Modifier(symbol.DeclaredAccessibility),
                IsAbstract = symbol.IsAbstract,
                IsExtern = symbol.IsExtern,
                IsSealed = symbol.IsSealed,
                IsStatic = symbol.IsStatic,
                IsOverride = symbol.IsOverride,
                IsVirtual = symbol.IsVirtual,
                HasExplicitAddAndRemove = !symbol.AddMethod.IsImplicitlyDeclared && !symbol.RemoveMethod.IsImplicitlyDeclared,
                TypeRef = TypeRef.GetOrCreate(symbol.Type, root),
                IsNew = symbol.GetIsNew(),
                OverridesSymbol = symbol.OverriddenEvent,
                ExplicitInterfaceImplementationMemberSymbol =
                    symbol.ExplicitInterfaceImplementations != null && symbol.ExplicitInterfaceImplementations.Length > 0
                        ? symbol.ExplicitInterfaceImplementations[0]
                        : null
            };

            e.SetAttributes(root);
            type.ContentMembers.Add(e);
            Console.WriteLine($"{new string(' ', level)} read as {e}");
        }

        /// <summary>
        /// Gets the list of type parameters for generic type or generic method
        /// </summary>
        /// <param name="parameterSymbols">Type parameter symbols</param>
        /// <param name="root">Root builder</param>
        /// <returns>List of type parameters</returns>
        private static List<TypeParameter> GetTypeParameters(ImmutableArray<ITypeParameterSymbol> parameterSymbols, RootMemberBuilder root)
        {
            if (parameterSymbols == null) return null;
            var retVal = new List<TypeParameter>();

            foreach (var typeParameter in parameterSymbols)
            {
                var param = new TypeParameterBuilder()
                {
                    Name = typeParameter.Name,
                    HasConstructorConstraint = typeParameter.HasConstructorConstraint,
                    HasReferenceTypeConstraint = typeParameter.HasReferenceTypeConstraint,
                    HasValueTypeConstraint = typeParameter.HasValueTypeConstraint,
                    HasUnmanagedTypeConstraint = typeParameter.HasUnmanagedTypeConstraint,
                    Variance = typeParameter.Variance == VarianceKind.None
                        ? ""
                        : typeParameter.Variance.ToString().ToLower()
                };

                if (typeParameter.ConstraintTypes != null && typeParameter.ConstraintTypes.Length > 0)
                {
                    param.ConstraintTypes = new List<TypeRef>();
                    foreach (var constraintType in typeParameter.ConstraintTypes)
                    {
                        param.ConstraintTypes.Add(TypeRef.GetOrCreate(constraintType, root));
                    }
                }

                var typeParamAttributes = typeParameter.GetAttributes();
                // ReSharper disable once InvertIf
                if (typeParamAttributes != null && typeParamAttributes.Length > 0)
                {
                    param.Attributes = new List<string>();
                    foreach (var attr in typeParamAttributes)
                    {
                        param.Attributes.Add(attr.ToCodeString());
                    }
                }

                retVal.Add(new TypeParameter(param));
            }

            return retVal;
        }

        /// <summary>
        ///  Gets the list of method parameters (also used for retrieving delegate and indexer parameters)
        /// </summary>
        /// <remarks>
        /// As <see cref="IParameterSymbol.IsThis"/> doesn't provide the correct info,
        /// there is a workaround and <see cref="MethodParameter.IsThis"/> is set for the first param of an extension method.
        /// The <paramref name="isExtensionMethod"/> must be set to true to apply the workaround (the default value is false)
        /// </remarks>
        /// <param name="parameterSymbols">Method parameter symbols</param>
        /// <param name="root">Root builder</param>
        /// <param name="isExtensionMethod">Flag whether the <paramref name="parameterSymbols"/> are of an extension method</param>
        /// <returns>List of method parameters</returns>
        private static List<MethodParameter> GetMethodParameters(ImmutableArray<IParameterSymbol> parameterSymbols, RootMemberBuilder root, bool isExtensionMethod = false)
        {
            if (parameterSymbols == null) return null;
            var retVal = new List<MethodParameter>();

            //HACK - parameterSymbol.IsThis doesn't provide the info, so set "IsThis" just for the first param of Extension method 
            var isThisCandidate = isExtensionMethod;

            foreach (var parameterSymbol in parameterSymbols)
            {
                var parameter = new MethodParameterBuilder()
                {
                    Name = parameterSymbol.Name,
                    TypeRef = TypeRef.GetOrCreate(parameterSymbol.Type, root),
                    IsOptional = parameterSymbol.IsOptional,
                    HasExplicitDefaultValue = parameterSymbol.HasExplicitDefaultValue,
                    ExplicitDefaultValue = parameterSymbol.HasExplicitDefaultValue
                        ? parameterSymbol.ExplicitDefaultValue
                        : null,
                    IsThis = isThisCandidate, // parameterSymbol.IsThis,
                    IsParams = parameterSymbol.IsParams,
                    RefKind = (RefKindEnum)parameterSymbol.RefKind
                };
                isThisCandidate = false; //can be used once only (for the first param of extension method)

                var attributes = parameterSymbol.GetAttributes();
                // ReSharper disable once InvertIf
                if (attributes != null && attributes.Length > 0)
                {
                    parameter.Attributes = new List<string>();
                    foreach (var attr in attributes)
                    {
                        parameter.Attributes.Add(attr.ToCodeString());
                    }
                }

                retVal.Add(new MethodParameter(parameter));
            }

            return retVal;
        }

    }
}
