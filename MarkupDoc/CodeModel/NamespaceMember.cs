using System.Collections.Generic;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a namespace within the code model
    /// </summary>
    public class NamespaceMember : Member
    {
        /// <summary>
        /// List of all types (including interfaces, delegates, etc.) defined within the namespace
        /// </summary>
        public IReadOnlyList<TypeMember> Types { get; }
        /// <summary>
        /// Flag whether the namespace is global
        /// </summary>
        public bool IsGlobalNamespace { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public NamespaceMember(NamespaceMemberBuilder builder) : base(builder)
        {
            IsGlobalNamespace = builder.IsGlobalNamespace;

            var types = new List<TypeMember>();
            var members = new List<Member>();
            foreach (var typeBuilder in builder.Types)
            {
                typeBuilder.Root = builder.Root;
                typeBuilder.Assembly = builder.Assembly;
                typeBuilder.Namespace = this;
                
                var t = new TypeMember(typeBuilder);
                types.Add(t);
                members.Add(t);
                members.AddRange(t.AllMembers);
            }

            Types = types;
            if (AllMembers is List<Member> allMembers) allMembers.AddRange(members);
        }

       
        /// <summary>
        /// Returns the brief description of the namespace
        /// </summary>
        /// <returns>The brief description of the namespace</returns>
        public override string ToString()
        {
            return $"{base.ToString()} {(IsGlobalNamespace ? "<global>" : "")}";
        }
    }
}

