using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.Utils.Extensions;
using net.adamec.dev.markupdoc.XmlDocumentation;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <summary>
    /// Builder for <see cref="Member"/>
    /// </summary>
    public abstract class MemberBuilder
    {
        /// <summary>
        /// Name of the member as presented in generated output
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of the member without type params, indexer params, operator params, etc.
        /// </summary>
        public string NameBase { get; set; }
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public virtual MemberKindEnum MemberKind => MemberKindEnum.Unknown;
        /// <summary>
        /// Reference to the root of the code model
        /// </summary>
        public RootMember Root { get; set; }
        /// <summary>
        /// Reference to the containing assembly member
        /// </summary>
        public AssemblyMember Assembly { get; set; }
        /// <summary>
        /// Reference to the containing namespace member
        /// </summary>
        public NamespaceMember Namespace { get; set; }

        /// <summary>
        /// Member modifier (public, private, etc.)
        /// </summary>
        public ModifierEnum Modifier { get; set; }
        /// <summary>
        /// Flag whether the member is abstract
        /// </summary>
        public bool IsAbstract { get; set; }
        /// <summary>
        /// Flag whether the member is extern
        /// </summary>
        public bool IsExtern { get; set; }
        /// <summary>
        /// Flag whether the member is sealed
        /// </summary>
        public bool IsSealed { get; set; }
        /// <summary>
        /// Flag whether the member is static
        /// </summary>
        public bool IsStatic { get; set; }
        /// <summary>
        /// Flag whether the member hides member with the same name in base class
        /// </summary>
        public bool IsNew { get; set; }
        /// <summary>
        /// Flag whether the member overrides the member in the base class
        /// </summary>
        public bool IsOverride { get; set; }
        /// <summary>
        /// Flag whether the member is virtual (can be overriden)
        /// </summary>
        public bool IsVirtual { get; set; }

        /// <summary>
        /// Member's attributes definition (including the parameters). 
        /// </summary>
        public List<string> Attributes { get; set; }
        /// <summary>
        /// Types (type references) of the member attributes
        /// </summary>
        public List<TypeRef> AttributeTypeRefs { get; set; }

        /// <summary>
        /// Member's documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)
        /// </summary>
        /// <remarks>See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details</remarks>
        public string DocumentationId { get; set; }
        /// <summary>
        /// XML documentation comments
        /// </summary>
        public string DocumentationXml { get; set; }
        /// <summary>
        /// Parsed XML documentation comments. <see cref="Documentation"/> is the root element of the parsed XML documentation comments
        /// </summary>
        public Documentation Documentation { get; set; }
        /// <summary>
        /// Roslyn semantic analysis symbol of the member
        /// </summary>
        public ISymbol Symbol { get; set; }

        /// <summary>
        /// Sets the member's <see cref="Attributes"/> and <see cref="AttributeTypeRefs"/>
        /// </summary>
        /// <param name="rootBuilder">Root builder used to resolve the type references</param>
        public void SetAttributes(RootMemberBuilder rootBuilder)
        {
            var attrs = Symbol.GetAttributes();
            if (attrs == null || attrs.Length <= 0) return;

            Attributes = new List<string>();
            AttributeTypeRefs = new List<TypeRef>();
            foreach (var attr in attrs)
            {
                Attributes.Add(attr.ToCodeString());
                AttributeTypeRefs.Add(TypeRef.GetOrCreate(attr.AttributeClass, rootBuilder));
            }
        }
    }
}
