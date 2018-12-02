using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="AssemblyMember"/>
    /// </summary>
    public class AssemblyMemberBuilder : MemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Assembly;
        /// <summary>
        /// List of namespaces within the assembly
        /// </summary>
        public List<NamespaceMemberBuilder> Namespaces { get; } = new List<NamespaceMemberBuilder>();
       
    }

}
