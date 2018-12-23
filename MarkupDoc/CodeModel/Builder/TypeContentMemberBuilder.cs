using Microsoft.CodeAnalysis;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="TypeContentMember"/>
    /// </summary>
    public abstract class TypeContentMemberBuilder : MemberBuilder
    {
        /// <summary>
        /// Type containing the content member
        /// </summary>
        public TypeMember Type { get; set; }

        /// <summary>
        /// Symbol of member overriden by this member
        /// </summary>
        public ISymbol OverridesSymbol { get; set; }

        /// <summary>
        /// Symbol of explicitly implemented interface member
        /// </summary>
        public ISymbol ExplicitInterfaceImplementationMemberSymbol { get; set; }
    }
}
