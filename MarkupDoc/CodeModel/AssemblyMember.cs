using System.Collections.Generic;
using System.Linq;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents an assembly within the code model
    /// </summary>
    public class AssemblyMember : Member
    {
        /// <summary>
        /// List of namespaces within the assembly
        /// </summary>
        public IReadOnlyList<NamespaceMember> Namespaces { get; } 
        /// <summary>
        /// List of all types (including interfaces, delegates, etc.) defined within the assembly
        /// </summary>
        public IReadOnlyList<TypeMember> AllTypes { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public AssemblyMember(AssemblyMemberBuilder builder):base(builder)
        {
            var namespaces = new List<NamespaceMember>();
            var types = new List<TypeMember>();
            var members = new List<Member>();
            foreach (var namespaceBuilder in builder.Namespaces)
            {
                namespaceBuilder.Root = builder.Root;
                namespaceBuilder.Assembly = this;
                var n = new NamespaceMember(namespaceBuilder);
                namespaces.Add(n);
                types.AddRange(n.AllMembers.OfType<TypeMember>());
                members.AddRange(n.AllMembers);
            }

            Namespaces = namespaces;
            AllTypes = types;
            if(AllMembers is List<Member> allMembers) allMembers.AddRange(members);
        }
    }

}
