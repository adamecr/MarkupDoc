using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="RootMember"/>
    /// </summary>
    public class RootMemberBuilder : MemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Root;
        /// <summary>
        /// List of all assemblies defined within the code model
        /// </summary>
        public List<AssemblyMemberBuilder> Assemblies { get; } = new List<AssemblyMemberBuilder>();
      
        /// <summary>
        /// List of all type references used within the code model
        /// </summary>
        public List<TypeRef> AllTypeRefs { get; } = new List<TypeRef>();

        /// <summary>
        /// Information whether and how to split the output (none, per namespace, per type)
        /// </summary>
        public SplitTypeEnum SplitFileType { get; set; }

        /// <summary>
        /// Name of the main (index) file without the path and extension
        /// </summary>
        public string BaseMainFile { get; set; }

        /// <summary>
        /// CTOR - sets the name to <c>&lt;ROOT&gt;</c>
        /// </summary>
        public RootMemberBuilder()
        {
            Name = "<ROOT>";
        }
    }

}
