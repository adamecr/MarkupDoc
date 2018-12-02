using System.Collections.Generic;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a method within the code model
    /// </summary>
    public class MethodMember : TypeContentMember
    {
        /// <summary>
        /// Kind of the method (constructor, getter, regular method ...)
        /// </summary>
        public MethodKindEnum MethodKind { get; }

        /// <summary>
        /// Flag whether the method is async
        /// </summary>
        public bool IsAsync { get; }
        /// <summary>
        /// Flag whether the method is extension method
        /// </summary>
        public bool IsExtensionMethod { get; }

        /// <summary>
        /// Flag whether method is generic
        /// </summary>
        public bool IsGeneric { get; }
        /// <summary>
        /// Type parameters for generic methods
        /// </summary>
        public IReadOnlyList<TypeParameter> TypeParameters { get; }

        /// <summary>
        /// Method parameters
        /// </summary>
        public IReadOnlyList<MethodParameter> Parameters { get; }

        /// <summary>
        /// Type reference of the method return type
        /// </summary>
        public TypeRef ReturnTypeRef { get; }
        /// <summary>
        /// Flags whether the method returns void
        /// </summary>
        public bool ReturnsVoid { get; }
        /// <summary>
        /// Flag whether the methods returns by reference
        /// </summary>
        public bool ReturnsByRef { get; }
        /// <summary>
        /// Flag whether the methods returns by read only reference (ref readonly)
        /// </summary>
        public bool ReturnsByRefReadonly { get; }
        /// <summary>
        /// Method's return ref kind (none, ref)
        /// </summary>
        public RefKindEnum RefKind { get; }

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
        /// <summary>
        /// Flag whether the method is operator
        /// </summary>
        public bool IsOperator => MethodKind == MethodKindEnum.BuiltinOperator ||
                                  MethodKind == MethodKindEnum.UserDefinedOperator;
        /// <summary>
        /// Flag whether the method is conversion
        /// </summary>
        public bool IsConversion => MethodKind == MethodKindEnum.Conversion;
        /// <summary>
        /// Flag whether the method is operator or conversion
        /// </summary>
        public bool IsOperatorOrConversion => IsOperator | IsConversion;
        /// <summary>
        /// Flag whether the method has parameters
        /// </summary>
        public bool HasParameters => Parameters != null && Parameters.Count > 0;

        /// <summary>
        /// C# operator symbol for operator method
        /// </summary>
        public string OperatorCSharpSymbol { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public MethodMember(MethodMemberBuilder builder) : base(builder)
        {
            MethodKind = builder.MethodKind;
            IsAsync = builder.IsAsync;
            IsExtensionMethod = builder.IsExtensionMethod;
            IsGeneric = builder.IsGeneric;
            TypeParameters = builder.TypeParameters;
            Parameters = builder.Parameters;
            ReturnTypeRef = builder.ReturnTypeRef;
            ReturnsVoid = builder.ReturnsVoid;
            ReturnsByRef = builder.ReturnsByRef;
            ReturnsByRefReadonly = builder.ReturnsByRefReadonly;
            RefKind = builder.RefKind;
            OperatorCSharpSymbol = builder.OperatorCSharpSymbol;
        }
    }
}
