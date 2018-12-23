using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.AddOns;
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
        /// Dictionary of all members by their source file
        /// </summary>
        public IReadOnlyDictionary<string, IReadOnlyList<Member>> AllMembersBySourceFile { get; }

        /// <summary>
        /// Dictionary of all members by their Roslyn <see cref="Microsoft.CodeAnalysis.ISymbol"/>
        /// </summary>
        public IReadOnlyDictionary<ISymbol, Member> AllMembersBySymbol { get; }

        /// <summary>
        /// List of all inheritance pairs (member, parent)
        /// </summary>
        public IReadOnlyList<KeyValuePair<TypeMember, TypeMember>> TypeInheritsFromTypeList { get; }

        /// <summary>
        /// List of all direct and indirect interface-implementation type pairs
        /// </summary>
        public IReadOnlyList<KeyValuePair<TypeMember, TypeMember>> TypeImplementsInterfaceList { get; }

        /// <summary>
        /// Gets the parent <seealso cref="TypeMember"/> of given <paramref name="type"/>
        /// </summary>
        /// <remarks>
        /// This method should not be used to generic check for the inheritance.
        /// It's intended to get the parent existing within the project being documented!
        /// When the parent of <paramref name="type"/> is not defined within project,
        /// there is no <seealso cref="TypeMember"/> for the parent and the returned value will be null.
        /// </remarks>
        /// <param name="type">Type to get the parent for</param>
        /// <returns>The parent <seealso cref="TypeMember"/> of given <paramref name="type"/> or null</returns>
        public TypeMember GetParentTypeMember(TypeMember type)
        {
            var memberParentPair = TypeInheritsFromTypeList.FirstOrDefault(kv => kv.Key == type);
            return memberParentPair.Equals(default) ? null : memberParentPair.Value;
        }

        /// <summary>
        /// Gets the inherited (children) <seealso cref="TypeMember">type members</seealso> of given <paramref name="type"/>
        /// </summary>
        /// <remarks>
        /// This method should not be used to generic check for the inheritance.
        /// It's intended to get the children existing within the project being documented!
        /// When the child of <paramref name="type"/> is not defined within project,
        /// there is no corresponding <seealso cref="TypeMember"/> and such inheritance info
        /// will not be part of the list returned
        /// </remarks>
        /// <param name="type">Type to get the parent for</param>
        /// <returns>List of inherited (children) <seealso cref="TypeMember">type members</seealso> of given <paramref name="type"/></returns>
        public IReadOnlyList<TypeMember> GetDerivedTypeMembers(TypeMember type)
        {
            return TypeInheritsFromTypeList.Where(kv => kv.Value == type).Select(kv=>kv.Key).ToList();
        }

        /// <summary>
        /// Gets the<seealso cref="TypeMember">type members</seealso> implementing <paramref name="type"/> (interface)
        /// </summary>
        /// <remarks>
        /// This method should not be used to generic check for the interface implementation.
        /// It's intended to get the "in-project" type members implementing given interface.
        /// When the interface is implemented by type that is not defined within project,
        /// there is no corresponding <seealso cref="TypeMember"/> and such implemented interface info
        /// will not be part of the list returned
        /// </remarks>
        /// <param name="type">Interface to get the implementations for</param>
        /// <returns>List of <seealso cref="TypeMember">type members</seealso> implementing <paramref name="type"/> (interface)</returns>
        public IReadOnlyList<TypeMember> GetTypeMembersImplementingInterface(TypeMember type)
        {
            return TypeImplementsInterfaceList.Where(kv => kv.Value == type).Select(kv => kv.Key).ToList();
        }

        /// <summary>
        /// Full path to the project root directory
        /// </summary>
        public string ProjectRootDir { get; }
        
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
        /// Optional list of add-ons
        /// </summary>
        public IReadOnlyList<IAddOn> AddOns { get; }

        /// <summary>
        /// Return list of add-ons having the <paramref name="prioritySelector"/> &gt; 0 ordered by the priority.
        /// When  no add-ons applies, the empty list is returned
        /// </summary>
        /// <param name="prioritySelector">Priority selector</param>
        /// <returns>List of add-ons having the <paramref name="prioritySelector"/> &gt; 0 ordered by the priority</returns>
        public IReadOnlyList<IAddOn> AddOnsSelector(Func<IAddOn, int> prioritySelector)
        {
            return AddOns==null || prioritySelector==null ?
                new List<IAddOn>() : 
                AddOns.Where(a => prioritySelector.Invoke(a) > 0).OrderBy(prioritySelector.Invoke).ToList();
        }

        
        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <remarks>Use the <see cref="RootMember"/> to build the whole code model hierarchy
        /// from the <see cref="RootMemberBuilder"/> that contains such hierarchy and the details about individual entities</remarks>
        /// <param name="builder">Builder</param>
        /// <param name="addOns">Optional list of add-ons</param>
        public RootMember(RootMemberBuilder builder, IEnumerable<IAddOn> addOns) : base(builder)
        {
            AddOns = addOns?.ToList();
            ProjectRootDir = builder.ProjectRootDir;
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

            //Generate index symbol->member
            var allMembersWithSymbol = AllMembers.Where(m => m.Symbol!=null);
            var membersBySymbol = allMembersWithSymbol.ToDictionary(member => member.Symbol);
            AllMembersBySymbol = membersBySymbol;

            //Generate type member-parent type member list
            var typeInheritsFromTypeList = new List<KeyValuePair<TypeMember, TypeMember>>();
            TypeInheritsFromTypeList = typeInheritsFromTypeList;

            typeInheritsFromTypeList.AddRange(
                AllTypes
                    .Where(typeMember =>typeMember.TypeRef.Base?.Member != null)
                    .Select(typeMember => new KeyValuePair<TypeMember, TypeMember>(typeMember, typeMember.TypeRef.Base?.Member)));

            typeInheritsFromTypeList.AddRange(
                AllTypes
                    .Where(typeMember =>
                        typeMember.TypeRef.Base?.Member==null &&
                        typeMember.TypeRef.Base?.GenericDefinition?.Member != null)
                    .Select(typeMember => new KeyValuePair<TypeMember, TypeMember>(typeMember, typeMember.TypeRef.Base.GenericDefinition.Member)));

            //Generate type member-implemented interface type member list
            var typeImplementsInterfaceList = new List<KeyValuePair<TypeMember, TypeMember>>();
            TypeImplementsInterfaceList = typeImplementsInterfaceList;
            var typesWithInterfaces = AllTypes.Where(typeMember =>
                typeMember.AllInterfacesTypeRefs != null &&
                typeMember.AllInterfacesTypeRefs.Count > 0).ToList();
            foreach (var typeWithInterface in typesWithInterfaces)
            {
                typeImplementsInterfaceList.AddRange(
                    typeWithInterface.AllInterfacesTypeRefs
                        .Where(tr => tr.Member != null)
                        .Select(tr => new KeyValuePair<TypeMember, TypeMember>(typeWithInterface,tr.Member)));

                typeImplementsInterfaceList.AddRange(
                    typeWithInterface.AllInterfacesTypeRefs
                        .Where(tr => tr.Member == null && tr.GenericDefinition?.Member!=null)
                        .Select(tr => new KeyValuePair<TypeMember, TypeMember>(typeWithInterface, tr.GenericDefinition.Member)));
            }
            
            //Generate the source file index
            var allMembersBySourceFile = new Dictionary<string, IReadOnlyList<Member>>();
            AllMembersBySourceFile = allMembersBySourceFile;
            var membersWithSourceFile = AllMembers.Where(m => m.SourceFiles != null && m.SourceFiles.Count > 0);
            foreach (var member in membersWithSourceFile)
            {
                var srcFiles = member.SourceFiles;
                foreach (var srcFile in srcFiles)
                {
                    if (!allMembersBySourceFile.TryGetValue(srcFile, out var sourceFileMemberList))
                    {
                        sourceFileMemberList = new List<Member>();
                        allMembersBySourceFile.Add(srcFile, sourceFileMemberList);
                    }
                    ((List<Member>)sourceFileMemberList).Add(member);
                }
            }

            //Processing info
            ProcessingInfo = new ProcessingInfoContainer
            {
                SplitFileType = builder.SplitFileType,
                BaseMainFile = builder.BaseMainFile
            };

            //Process add-ons
            if (AddOns == null) return;

            foreach (var addOn in AddOnsSelector(a=>a.PriorityRootData))
            {
                addOn.ProcessRootData(this, builder);
            }

        }
    }
}
