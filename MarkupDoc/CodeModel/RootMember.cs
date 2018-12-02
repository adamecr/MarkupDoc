using System.Collections.Generic;
using System.Linq;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a root of the code model
    /// </summary>
    public class RootMember : Member
    {
        /// <summary>
        /// List of all assemblies defined within the code model
        /// </summary>
        public IReadOnlyList<AssemblyMember> Assemblies { get; }
        /// <summary>
        /// List of namespaces within the code model
        /// </summary>
        public IReadOnlyList<NamespaceMember> AllNamespaces { get; }
        /// <summary>
        /// List of all types (including interfaces, delegates, etc.) defined within the code model
        /// </summary>
        public IReadOnlyList<TypeMember> AllTypes { get; }

        /// <summary>
        /// List of all type references used within the code model
        /// </summary>
        public IReadOnlyList<TypeRef> AllTypeRefs { get; }

        /// <summary>
        /// Dictionary of all members by their documentation ID
        /// </summary>
        public IReadOnlyDictionary<string, Member> AllMembersByDocId { get; }

        /// <summary>
        /// Processing information. This is the only part that can be modified after the code model is built
        /// as it's used to adjust the behavior during the processing within markup generator
        /// </summary>
        public ProcessingInfoContainer ProcessingInfo { get; }

        /// <summary>
        /// Processing information
        /// </summary>
        public class ProcessingInfoContainer
        {
            /// <summary>
            /// Information whether and how to split the output (none, per namespace, per type)
            /// </summary>
            public SplitTypeEnum SplitFileType { get; set; }

            /// <summary>
            /// Name of the main (index) file without the path and extension
            /// </summary>
            public string BaseMainFile { get; set; }
        }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <remarks>Use the <see cref="RootMember"/> to build the whole code model hierarchy
        /// from the <see cref="RootMemberBuilder"/> that contains such hierarchy and the details about individual entities</remarks>
        /// <param name="builder">Builder</param>
        public RootMember(RootMemberBuilder builder) : base(builder)
        {
            AllTypeRefs = builder.AllTypeRefs;
            var assemblies = new List<AssemblyMember>();
            var namespaces = new List<NamespaceMember>();
            var types = new List<TypeMember>();
            var members = new List<Member>();
            foreach (var assemblyBuilder in builder.Assemblies)
            {
                assemblyBuilder.Root = this;
                var a = new AssemblyMember(assemblyBuilder);
                assemblies.Add(a);
                namespaces.AddRange(a.Namespaces);
                types.AddRange(a.AllTypes);
                members.AddRange(a.AllMembers);
            }

            Assemblies = assemblies;
            AllNamespaces = namespaces;
            AllTypes = types;
            if (AllMembers is List<Member> allMembers) allMembers.AddRange(members);

            //Ensure the Members in type refs where available
            foreach (var typeRef in AllTypeRefs)
            {
                typeRef.Member = AllTypes.FirstOrDefault(t => t.FullName == typeRef.Namespace + "." + typeRef.Name);

            }

            //Generate index documentation ID->member
            var membersWithDocId = AllMembers.Where(m => !string.IsNullOrEmpty(m.DocumentationId));
            var membersByDocId = membersWithDocId.ToDictionary(member => member.DocumentationId);
            AllMembersByDocId = membersByDocId;

            //Processing info
            ProcessingInfo = new ProcessingInfoContainer
            {
                SplitFileType = builder.SplitFileType,
                BaseMainFile = builder.BaseMainFile
            };
        }
    }
}
