using System.Collections.Generic;
using System.Linq;
using net.adamec.dev.markupdoc.CodeModel.Builder;
using net.adamec.dev.markupdoc.Utils.Extensions;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a type within the code model
    /// </summary>
    public class TypeMember : Member
    {
        /// <summary>
        /// Type kind (class, interface, ...)
        /// </summary>
        public TypeKindEnum TypeKind { get; }

        /// <summary>
        /// Type full name (namespace.type)
        /// </summary>
        public string FullName => $"{Namespace.Name}.{Name}";
        /// <summary>
        /// Flag whether the type is inherited (applicable to classes only)
        /// </summary>
        public bool IsInherited => TypeRef?.BaseExclObject != null && TypeKind == TypeKindEnum.Class;
        /// <summary>
        /// Type reference for this type
        /// </summary>
        public TypeRef TypeRef { get; }

        /// <summary>
        /// Flag whether type is generic
        /// </summary>
        public bool IsGeneric { get; }
        /// <summary>
        /// Type parameters for generic types
        /// </summary>
        public IReadOnlyList<TypeParameter> TypeParameters;

        /// <summary>
        /// Flag whether type is delegate
        /// </summary>
        public bool IsDelegate => TypeKind == TypeKindEnum.Delegate;
        /// <summary>
        /// Delegate parameters for delegate types
        /// </summary>
        public IReadOnlyList<MethodParameter> DelegateParameters;
        /// <summary>
        /// Type reference for delegate return type
        /// </summary>
        public TypeRef DelegateReturnType;

        /// <summary>
        /// Type references for directly implemented interfaces
        /// </summary>
        public IReadOnlyList<TypeRef> InterfacesTypeRefs { get; }
        /// <summary>
        /// Type references for all implemented interfaces (both directly implemented and inherited)
        /// </summary>
        public IReadOnlyList<TypeRef> AllInterfacesTypeRefs { get; }
        /// <summary>
        /// Flag whether the type implements any (at least one) interface
        /// </summary>
        public bool ImplementsAnyInterface => InterfacesTypeRefs != null && InterfacesTypeRefs.Count > 0;

        /// <summary>
        /// All fields defined within the type
        /// </summary>
        public IReadOnlyList<FieldMember> Fields => AllMembers.OfType<FieldMember>().ToList();
        /// <summary>
        /// All properties defined within the type
        /// </summary>
        public IReadOnlyList<PropertyMember> Properties => AllMembers.OfType<PropertyMember>().ToList();
        /// <summary>
        /// All methods defined within the type
        /// </summary>
        public IReadOnlyList<MethodMember> Methods => AllMembers.OfType<MethodMember>().Where(m => !m.IsConstructor && !m.IsDestructor && !m.IsOperatorOrConversion).ToList();
        /// <summary>
        /// All constructors defined within the type
        /// </summary>
        public IReadOnlyList<MethodMember> Constructors => AllMembers.OfType<MethodMember>().Where(m => m.IsConstructor).ToList();
        /// <summary>
        /// Destructor defined within the type or null if none
        /// </summary>
        public MethodMember Destructor => AllMembers.OfType<MethodMember>().FirstOrDefault(m => m.IsDestructor);
        /// <summary>
        /// All operators defined within the type
        /// </summary>
        public IReadOnlyList<MethodMember> Operators => AllMembers.OfType<MethodMember>().Where(m => m.IsOperator).ToList();
        /// <summary>
        /// All conversions defined within the type
        /// </summary>
        public IReadOnlyList<MethodMember> Conversions => AllMembers.OfType<MethodMember>().Where(m => m.IsConversion).ToList();
        /// <summary>
        /// All operators and conversions defined within the type
        /// </summary>
        public IReadOnlyList<MethodMember> OperatorsAndConversions => AllMembers.OfType<MethodMember>().Where(m => m.IsOperatorOrConversion).ToList();
        /// <summary>
        /// All events defined within the type
        /// </summary>
        public IReadOnlyList<EventMember> Events => AllMembers.OfType<EventMember>().ToList();

        /// <summary>
        /// File name (without extension !!!) where the type should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string.
        /// This is used when building the links to the member (FileName.extension#Anchor)
        /// </summary>
        public override string FileName =>
            Root.ProcessingInfo.SplitFileType == SplitTypeEnum.Type ? $"{FullName}__{Id}".Replace('<', '_').Replace('>', '_') :
            Root.ProcessingInfo.SplitFileType == SplitTypeEnum.Namespace ? Namespace.FileName : "";

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public TypeMember(TypeMemberBuilder builder) : base(builder)
        {
            TypeKind = builder.TypeKind;
            TypeRef = builder.TypeRef;
            IsGeneric = builder.IsGeneric;
            TypeParameters = builder.TypeParameters;
            DelegateParameters = builder.DelegateParameters;
            DelegateReturnType = builder.DelegateReturnType;
            InterfacesTypeRefs = builder.InterfacesTypeRefs;
            AllInterfacesTypeRefs = builder.AllInterfacesTypeRefs;

            var members = new List<Member>();
            foreach (var typeContentBuilder in builder.ContentMembers)
            {
                typeContentBuilder.Root = builder.Root;
                typeContentBuilder.Assembly = builder.Assembly;
                typeContentBuilder.Namespace = builder.Namespace;
                typeContentBuilder.Type = this;

                TypeContentMember m = null;
                switch (typeContentBuilder)
                {
                    case FieldMemberBuilder fieldBuilder:
                        m=new FieldMember(fieldBuilder);
                        break;
                    case PropertyMemberBuilder propertyBuilder:
                        m=new PropertyMember(propertyBuilder);
                        break;
                    case MethodMemberBuilder methodBuilder:
                        m=new MethodMember(methodBuilder);
                        break;
                    case EventMemberBuilder eventBuilder:
                        m=new EventMember(eventBuilder);
                        break;
                }

                members.Add(m);
            }

            if (AllMembers is List<Member> allMembers) allMembers.AddRange(members);
        }


        /// <summary>
        /// Returns the brief description of the type
        /// </summary>
        /// <returns>The brief description of the type</returns>
        public override string ToString()
        {
            return $"{MemberKind}.{TypeKind}: {Modifier.ToModifierString()} {FullName}";
        }
    }
}
