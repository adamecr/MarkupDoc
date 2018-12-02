using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="MethodMember"/>
    /// </summary>
    public class MethodMemberBuilder : TypeContentMemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Method;
        /// <summary>
        /// Kind of the method (constructor, getter, regular method ...)
        /// </summary>
        public MethodKindEnum MethodKind { get; set; }

        /// <summary>
        /// Flag whether the method is async
        /// </summary>
        public bool IsAsync { get; set; }
        /// <summary>
        /// Flag whether the method is extension method
        /// </summary>
        public bool IsExtensionMethod { get; set; }

        /// <summary>
        /// Flag whether method is generic
        /// </summary>
        public bool IsGeneric { get; set; }
        /// <summary>
        /// Type parameters for generic methods
        /// </summary>
        public List<TypeParameter> TypeParameters { get; set; }

        /// <summary>
        /// Method parameters
        /// </summary>
        public List<MethodParameter> Parameters { get; set; }

        /// <summary>
        /// Type reference of the method return type
        /// </summary>
        public TypeRef ReturnTypeRef { get; set; }
        /// <summary>
        /// Flags whether the method returns void
        /// </summary>
        public bool ReturnsVoid { get; set; }
        /// <summary>
        /// Flag whether the methods returns by reference
        /// </summary>
        public bool ReturnsByRef { get; set; }
        /// <summary>
        /// Flag whether the methods returns by read only reference (ref readonly)
        /// </summary>
        public bool ReturnsByRefReadonly { get; set; }
        /// <summary>
        /// Method's return ref kind (none, ref)
        /// </summary>
        public RefKindEnum RefKind { get; set; }

        /// <summary>
        /// C# operator symbol for operator method
        /// </summary>
        public string OperatorCSharpSymbol { get; set; }

        /// <summary>
        /// Flag whether the method is construction
        /// </summary>
        public bool IsConstructor => MethodKind == MethodKindEnum.Constructor ||
                                     MethodKind == MethodKindEnum.SharedConstructor ||
                                     MethodKind == MethodKindEnum.StaticConstructor;
        /// <summary>
        /// Flag whether the method is destructor
        /// </summary>
        public bool IsDestructor => MethodKind == MethodKindEnum.Destructor;

     
    }
}
