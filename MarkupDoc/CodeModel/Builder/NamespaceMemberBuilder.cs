using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="NamespaceMember"/>
    /// </summary>
    public class NamespaceMemberBuilder : MemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Namespace;
        /// <summary>
        /// List of all types (including interfaces, delegates, etc.) defined within the namespace
        /// </summary>
        public List<TypeMemberBuilder> Types { get; } = new List<TypeMemberBuilder>();
        /// <summary>
        /// Flag whether the namespace is global
        /// </summary>
        public bool IsGlobalNamespace { get; set; }

      
    }
}

