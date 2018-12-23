using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Abstract class for type members (fields, properties, etc.) within the code model
    /// </summary>
    public abstract class TypeContentMember : Member
    {
        /// <summary>
        /// Type containing the content member
        /// </summary>
        public TypeMember Type { get; }

        /// <summary>
        /// Symbol of member overriden by this member (if any)
        /// </summary>
        public ISymbol OverridesSymbol { get; }

        /// <summary>
        /// Member overriden by this member (if any)
        /// </summary>
        public TypeContentMember OverridesMember
        {
            get
            {
                if (OverridesSymbol == null) return null;

                if (Root.AllMembersBySymbol.TryGetValue(OverridesSymbol, out var overridenMember) &&
                    overridenMember is TypeContentMember typeContentMember)
                    return typeContentMember;
                // ReSharper disable once InvertIf
                if (OverridesSymbol.OriginalDefinition != null) //for generic methods
                {
                    if (Root.AllMembersBySymbol.TryGetValue(OverridesSymbol.OriginalDefinition, out var overridenOriginalMember) &&
                        overridenOriginalMember is TypeContentMember typeContentOriginalMember)
                        return typeContentOriginalMember;
                }

                return null;
            }
        }

        /// <summary>
        /// Symbol of explicitly implemented interface member
        /// </summary>
        public ISymbol ExplicitInterfaceImplementationMemberSymbol { get;  }

        /// <summary>
        /// Symbols of members implemented by this member (if any)
        /// </summary>
        public IReadOnlyList<ISymbol> ImplementsSymbols =>
            Type.InterfaceMembersByInterfaceImplementation.TryGetValue(Symbol, out var interfaceSymbols) && interfaceSymbols.Count > 0
                ? interfaceSymbols
                : null;

        /// <summary>
        /// Members implemented by this member (if any)
        /// </summary>
        /// <remarks>
        /// ImplementsMembers contain the same number of elements as <see cref="ImplementsSymbols"/>.
        /// When there is not member corresponding to the symbol, the ImplementsMembers item is null
        /// </remarks>
        public IReadOnlyList<TypeContentMember> ImplementsMembers
        {
            get
            {
                if (ImplementsSymbols == null || ImplementsSymbols.Count == 0) return null;

                var retVal = new List<TypeContentMember>();
                foreach (var implementsSymbol in ImplementsSymbols)
                {
                    if (Root.AllMembersBySymbol.TryGetValue(implementsSymbol, out var implementedMember) &&
                        implementedMember is TypeContentMember typeContentMember)
                    {
                        retVal.Add(typeContentMember);
                        continue;
                    }

                    // ReSharper disable once InvertIf
                    if (implementsSymbol.OriginalDefinition != null) //for generic methods
                    {
                        if (Root.AllMembersBySymbol.TryGetValue(implementsSymbol.OriginalDefinition,
                                out var implementedOriginalMember) &&
                            implementedOriginalMember is TypeContentMember typeContentOriginalMember)
                        {
                            retVal.Add(typeContentOriginalMember);
                            continue;
                        }
                    }

                    retVal.Add(null);
                }

               return retVal.Count > 0 ? retVal : null;
            }
        }
        /// <summary>
        /// File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string.
        /// This is also used when building the links to the member (FileName.extension#Anchor)
        /// </summary>
        /// <remarks>Type content is rendered together with type, so the <see cref="FileName"/> is taken from <see cref="Type"/></remarks>
        public override string FileName => Type.FileName;

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        protected TypeContentMember(TypeContentMemberBuilder builder) : base(builder)
        {
            Type = builder.Type;
            OverridesSymbol = builder.OverridesSymbol;
            ExplicitInterfaceImplementationMemberSymbol = builder.ExplicitInterfaceImplementationMemberSymbol;
        }
    }
}
