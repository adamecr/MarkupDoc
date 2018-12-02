using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <summary>
    /// Type reference - used to hold the reference to the type from the commented code as we as the referenced/used types.
    /// There is only single TypeRef for a type even if used on multiple "places"
    /// </summary>
    public class TypeRef
    {
        /// <summary>
        /// Containing namespace of type
        /// </summary>
        public string Namespace { get; private set; }
        /// <summary>
        /// Name of the type
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Documentation ID of type when available
        /// </summary>
        public string DocumentationId { get; private set; }
        /// <summary>
        /// Base (parent) type when available
        /// </summary>
        public TypeRef Base { get; private set; }
        /// <summary>
        /// Corresponding type member from the code model when available
        /// </summary>
        public TypeMember Member { get; set; }
        /// <summary>
        /// Base generic type when available - used for the types that have applied generic parameters. In such case, GenericDefinition refers to the "original" type
        /// </summary>
        public TypeRef GenericDefinition { get; private set; }
        /// <summary>
        /// Base name (without the type parameters) for generic types
        /// </summary>
        public string GenericBaseName { get; private set; }
        /// <summary>
        /// Generic type arity (number of type parameters) when available
        /// </summary>
        public int GenericArity { get; private set; }
        /// <summary>
        /// Type reference of array element type when available
        /// </summary>
        public TypeRef ArrayElementType { get; private set; }
        /// <summary>
        /// Underlying value type name for enums
        /// </summary>
        public string EnumValueType { get; private set; }

        /// <summary>
        /// Base (parent) type excluding the System.Object, when available
        /// </summary>
        public TypeRef BaseExclObject
        {
            get
            {
                if (Base == null) return null;
                if (Base.Namespace == "System" && Base.Name == "Object") return null;
                return Base;
            }
        }

        /// <summary>
        /// Gets the <see cref="TypeRef"/> from the <see cref="ITypeSymbol"/>. When such TypeRef doesn't exist yet, it's created.
        /// </summary>
        /// <remarks>The list of existing type references is held by <see cref="RootMemberBuilder"/>.</remarks>
        /// <param name="symbol">Type symbol to get the TypeRef for</param>
        /// <param name="root">Root builder keeping the list of all type references</param>
        /// <returns><see cref="TypeRef"/> corresponding to the <paramref name="symbol"/></returns>
        public static TypeRef GetOrCreate(ITypeSymbol symbol, RootMemberBuilder root)
        {
            var ns = symbol.ContainingNamespace?.ToDisplayString();
            var name = symbol.ContainingType == null ? symbol.Name : GetOrCreate(symbol.ContainingType, root).Name + "." + symbol.Name;
            var namedTypeSymbol = symbol as INamedTypeSymbol;

            //Arrays
            TypeRef arrayElementType = null;
            if (symbol is IArrayTypeSymbol arrayTypeSymbol)
            {
                var element = arrayTypeSymbol.ElementType;
                var nameExt = $"[{(arrayTypeSymbol.Rank > 1 ? new string(',', arrayTypeSymbol.Rank - 1) : "")}]"; //multi array
                while (element is IArrayTypeSymbol elementArray) //array of arrays
                {
                    nameExt += $"[{(arrayTypeSymbol.Rank > 1 ? new string(',', arrayTypeSymbol.Rank - 1) : "")}]";
                    element = elementArray.ElementType;
                }
                arrayElementType = GetOrCreate(element, root);
                ns = arrayElementType.Namespace;
                name = arrayElementType.Name + nameExt;
            }

            //Tuples
            if (symbol.IsTupleType && namedTypeSymbol != null)
            {
                var tupleElements = namedTypeSymbol.TupleElements;
                var tupleUnderlyingType = namedTypeSymbol.TupleUnderlyingType;
                var parts = new List<string>();
                for (var i = 0; i < tupleUnderlyingType.TypeArguments.Length; i++)
                {
                    var itemTypeName = GetOrCreate(tupleUnderlyingType.TypeArguments[i], root).ApplySpecialName();
                    var itemName = tupleElements[i].Name;
                    parts.Add($"{itemTypeName} {itemName}");
                }
                name = $"({string.Join(", ", parts)})";
                ns = "";
            }

            //Generics
            var needsGenericDefinition = false;
            var genericBaseName = name;
            TypeRef genericDefinition = null;
            if (namedTypeSymbol != null &&
                namedTypeSymbol.IsGenericType &&
                namedTypeSymbol.TypeParameters != null &&
                namedTypeSymbol.TypeParameters.Length > 0)
            {
                //generic, add types to name
                var paramListApplied = new List<string>();
                for (var i = 0; i < namedTypeSymbol.TypeParameters.Length; i++)
                {
                    var arg = namedTypeSymbol.TypeArguments[i];
                    switch (arg)
                    {
                        case ITypeParameterSymbol p:
                            {
                                //for base class A<T> is class B<T>:A<T> or B<U>:A<U> (rename)
                                paramListApplied.Add(p.Name);
                                if (arg.Name != namedTypeSymbol.TypeParameters[i].Name) needsGenericDefinition = true; //rename
                                break;
                            }
                        case IArrayTypeSymbol argArray:
                            {
                                //for base class A<T> is class B<U>:A<U[]>or  class B:A<some type[]> 
                                if (argArray.ElementType is ITypeParameterSymbol argArrayElementParam)
                                {
                                    //for base class A<T> is class B<U>:A<U[]>
                                    paramListApplied.Add(argArrayElementParam.Name + "[]");
                                }
                                else
                                {
                                    //for base class A<T> is class B:A<some type[]> {
                                    paramListApplied.Add(GetOrCreate(argArray.ElementType, root) + "[]");
                                }

                                needsGenericDefinition = true;
                                break;
                            }
                        default:
                            //for base class A<T> is class B<U>:A<U> or  class B:A<some type>
                            paramListApplied.Add(GetOrCreate(arg, root).ToString());
                            needsGenericDefinition = true;
                            break;
                    }
                }
                name += $"<{string.Join(",", paramListApplied)}>";
                if (needsGenericDefinition) genericDefinition = GetOrCreate(namedTypeSymbol.ConstructedFrom, root);
            }
            //End of special cases

            //Try to get existing item
            var existingItem = root.AllTypeRefs.FirstOrDefault(tr => tr.Namespace == ns && tr.Name == name);
            if (existingItem != null)
            {
                return existingItem;
            }

            //Create a new TypeRef
            var retVal = new TypeRef
            {
                Namespace = ns ?? "",
                Name = name,
                DocumentationId = namedTypeSymbol?.GetDocumentationCommentId(),
                GenericBaseName = genericBaseName,
                GenericArity = namedTypeSymbol?.Arity ?? 0,
                EnumValueType = ApplySpecialName(namedTypeSymbol?.EnumUnderlyingType?.ContainingNamespace.Name, namedTypeSymbol?.EnumUnderlyingType?.Name, false),
                ArrayElementType = arrayElementType
            };
            root.AllTypeRefs.Add(retVal);

            if (symbol.BaseType != null)
            {
                retVal.Base = GetOrCreate(symbol.BaseType, root);
            }
            if (needsGenericDefinition)
            {
                retVal.GenericDefinition = genericDefinition;
            }

            return retVal;
        }

        /// <summary>
        /// Gets the brief description - name - of the type reference
        /// </summary>
        /// <returns>Brief description - name - of the type reference</returns>
        public override string ToString()
        {
            return ApplySpecialName();
        }

        /// <summary>
        /// Applies the type special name for the current type reference
        /// </summary>
        /// <remarks>See <see cref="ApplySpecialName(string,string,bool)"/> for details</remarks>
        /// <param name="includeNamespaceIfNotSpecial">Include the namespace to the output in case that the special name is not applicable</param>
        /// <returns>Special name of the type or original name (with or without namespace as defined by <paramref name="includeNamespaceIfNotSpecial"/>) when the special name is not applicable</returns>
        public string ApplySpecialName(bool includeNamespaceIfNotSpecial = true)
        {
            return ApplySpecialName(Namespace, Name, includeNamespaceIfNotSpecial);
        }
        /// <summary>
        /// Applies the type special name for given <paramref name="typeSymbol"/>
        /// </summary>
        /// <remarks>See <see cref="ApplySpecialName(string,string,bool)"/> for details</remarks>
        /// <param name="typeSymbol"></param>
        /// <param name="includeNamespaceIfNotSpecial">Include the namespace to the output in case that the special name is not applicable</param>
        /// <returns>Special name of the type or original name (with or without namespace as defined by <paramref name="includeNamespaceIfNotSpecial"/>) when the special name is not applicable</returns>
        public static string ApplySpecialName(ITypeSymbol typeSymbol, bool includeNamespaceIfNotSpecial = true)
        {
            return ApplySpecialName(typeSymbol.ContainingNamespace?.Name, typeSymbol.Name, includeNamespaceIfNotSpecial);
        }

        /// <summary>
        /// Applies the type special name for given type described by <paramref name="ns">namespace</paramref> and <paramref name="name"/>
        /// </summary>
        /// <remarks>
        /// Special name is actually the simplified and/or common name for selected types. For example "string" for "System.String", "bool" for "System.Boolean", "int" for "System.Int32".
        /// The simplification means removing the well known namespace (System, System.Collections, ...), using the common name for some types (bool, int, double, ...),
        /// replacing Nullable&lt;T&gt; with "T?" syntax.
        /// <para>
        /// Special names for System namespace: bool, byte, char, DateTime, decimal, double, Enum, IAsyncResult, IDisposable, short, int, long, object, sbyte, float, string, ushort, uint, ulong, void,
        /// Delegate, MulticastDelegate, ValueType, Attribute.
        /// </para>
        /// <para>
        /// Special names for System.Collections.Generic namespace: ICollection, IDictionary, IEnumerable, IEnumerator, IList, IReadOnlyCollection, IReadOnlyList, List, Dictionary, HashSet, Queue, Stack (all as generics).
        /// </para>
        /// <para>
        /// Special names for System.Collections namespace: ICollection, IDictionary, IEnumerable, IDictionary, IEnumerator, IList, Hashtable, Queue, Stack, ArrayList, SortedList.
        /// </para> 
        /// </remarks>
        /// <param name="ns">Namespace containing the type</param>
        /// <param name="name">Name of the type</param>
        /// <param name="includeNamespaceIfNotSpecial">Include the namespace to the output in case that the special name is not applicable</param>
        /// <returns>Special name of the type or original name (with or without namespace as defined by <paramref name="includeNamespaceIfNotSpecial"/>) when the special name is not applicable</returns>
        private static string ApplySpecialName(string ns, string name, bool includeNamespaceIfNotSpecial = true)
        {
            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (ns)
            {
                // ReSharper disable once InvertIf
                case "System":
                {
                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (name)
                    {
                        case "Boolean":
                            return "bool";
                        case "Byte":
                            return "byte";
                        case "Char":
                            return "char";
                        case "DateTime":
                            return "DateTime";
                        case "Decimal":
                            return "decimal";
                        case "Double":
                            return "double";
                        case "Enum":
                            return "Enum";
                        case "IAsyncResult":
                            return "IAsyncResult";
                        case "IDisposable":
                            return "IDisposable";
                        case "Int16":
                            return "short";
                        case "Int32":
                            return "int";
                        case "Int64":
                            return "long";
                        case "Object":
                            return "object";
                        case "SByte":
                            return "sbyte";
                        case "Single":
                            return "float";
                        case "String":
                            return "string";
                        case "UInt16":
                            return "ushort";
                        case "UInt32":
                            return "uint";
                        case "UInt64":
                            return "ulong";
                        case "Void":
                            return "void";
                        case "Delegate":
                            return "Delegate";
                        case "MulticastDelegate":
                            return "MulticastDelegate";
                        case "ValueType":
                            return "ValueType";
                        case "Attribute":
                            return "Attribute";
                    }

                    if (name.StartsWith("Nullable<"))
                    {
                        return name.Replace("Nullable<", "").Replace(">", "") + "?";
                    }

                    var idxArray = name.IndexOf('[');
                    if (idxArray > 0)
                    {
                        var nameArray = name.Substring(0, idxArray);
                        var rest = name.Substring(idxArray);
                        return ApplySpecialName(ns, nameArray, includeNamespaceIfNotSpecial) + rest;
                    }

                    break;
                }

                case "System.Collections.Generic" when name.StartsWith("ICollection<") ||
                                                       name.StartsWith("IDictionary<") ||
                                                       name.StartsWith("IEnumerable<") ||
                                                       name.StartsWith("IEnumerator<") ||
                                                       name.StartsWith("IList<") ||
                                                       name.StartsWith("IReadOnlyCollection<") ||
                                                       name.StartsWith("IReadOnlyList<") ||
                                                       name.StartsWith("List<") ||
                                                       name.StartsWith("Dictionary<") ||
                                                       name.StartsWith("HashSet<") ||
                                                       name.StartsWith("Queue<") ||
                                                       name.StartsWith("Stack<"):
                    return name;
                
                case "System.Collections" when name == "ICollection" ||
                                               name == "IDictionary" ||
                                               name == "IEnumerable" ||
                                               name == "IDictionary" ||
                                               name == "IEnumerator" ||
                                               name == "IList" ||
                                               name == "Hashtable" ||
                                               name == "Queue" ||
                                               name == "Stack" ||
                                               name == "ArrayList" ||
                                               name == "SortedList":
                    return name;
            }

            return includeNamespaceIfNotSpecial && !string.IsNullOrEmpty(ns) ? $"{ns}.{name}" : name;
        }
    }
}
