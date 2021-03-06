﻿using System.Collections.Generic;
using Microsoft.CodeAnalysis;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="TypeMember"/>
    /// </summary>
    public class TypeMemberBuilder : MemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Type;
        /// <summary>
        /// Type kind (class, interface, ...)
        /// </summary>
        public TypeKindEnum TypeKind { get; set; }

        /// <summary>
        /// Type reference for this type
        /// </summary>
        public TypeRef TypeRef { get; set; }
      
        /// <summary>
        /// Flag whether type is generic
        /// </summary>
        public bool IsGeneric { get; set; }
        /// <summary>
        /// Type parameters for generic types
        /// </summary>
        public List<TypeParameter> TypeParameters;

        /// <summary>
        /// Delegate parameters for delegate types
        /// </summary>
        public List<MethodParameter> DelegateParameters;
        /// <summary>
        /// Type reference for delegate return type
        /// </summary>
        public TypeRef DelegateReturnType;

        /// <summary>
        /// Type references for directly implemented interfaces
        /// </summary>
        public List<TypeRef> InterfacesTypeRefs { get; set; }
        /// <summary>
        /// Type references for all implemented interfaces (both directly implemented and inherited)
        /// </summary>
        public List<TypeRef> AllInterfacesTypeRefs { get; set; }

        /// <summary>
        /// List of all type content members (fields, properties, methods, events)
        /// </summary>
        public List<TypeContentMemberBuilder> ContentMembers { get; } = new List<TypeContentMemberBuilder>();

        /// <summary>
        /// Dictionary of  interface member implementation by interface member (key=interface member symbol, value=implementation member symbol)
        /// </summary>
        public Dictionary<ISymbol, ISymbol> InterfaceImplementationsByInterfaceMember { get; }=new Dictionary<ISymbol, ISymbol>();

        /// <summary>
        /// Dictionary of implemented interface members by implementation member (key=implementation member symbol, value=interface member symbol)
        /// </summary>
        public Dictionary<ISymbol, IReadOnlyList<ISymbol>> InterfaceMembersByInterfaceImplementation { get; } = new Dictionary<ISymbol, IReadOnlyList<ISymbol>>();

    }
}
