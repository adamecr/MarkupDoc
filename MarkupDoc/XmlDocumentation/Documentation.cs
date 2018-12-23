using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using net.adamec.dev.markupdoc.CodeModel;
using net.adamec.dev.markupdoc.Utils;

namespace net.adamec.dev.markupdoc.XmlDocumentation
{
    /// <summary>
    /// Class representing (internal) &lt;member&gt; element of XML Documentation Comments.
    /// Used as a root documentation object for the code model <see cref="Member"/>
    /// </summary>
    /// <remarks>
    /// The <see cref="Documentation"/> class provides the "alias" properties
    /// to access the common elements like <see cref="Summary"/>, <see cref="Remarks"/>, <see cref="Exceptions"/>, etc.</remarks>
    public class Documentation : ModelElement
    {
        /// <summary>
        /// Content of <c>name</c> attribute of <c>member</c> element
        /// </summary>
        public string OwnRef { get; }

        /// <summary>
        /// Flag whether to inherit the documentation
        /// </summary>
        public bool ShouldInheritDoc { get; private set; }

        /// <summary>
        /// Optional inherit doc reference
        /// </summary>
        public string InheritDocRef { get; private set; }

        /// <summary>
        /// Returns the first <c>summary</c> documentation element or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public Summary Summary => Elements.OfType<Summary>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>remarks</c> documentation element or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public Remarks Remarks => Elements.OfType<Remarks>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>example</c> documentation element or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public Example Example => Elements.OfType<Example>().FirstOrDefault();
        /// <summary>
        /// Returns the <c>exception</c> documentation elements or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public IList<ExceptionDoc> Exceptions => Elements.OfType<ExceptionDoc>().ToList();
        /// <summary>
        /// Returns the <c>seealso</c> documentation elements or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public IList<SeeAlso> SeeAlso => Elements.OfType<SeeAlso>().ToList();
        /// <summary>
        /// Returns the first <c>value</c> documentation element or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public Value Value => Elements.OfType<Value>().FirstOrDefault();
        /// <summary>
        /// Returns the first <c>returns</c> documentation element or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        public Returns Returns => Elements.OfType<Returns>().FirstOrDefault();

        /// <summary>
        /// Returns the first <c>param</c> documentation element with given <paramref name="name"/> or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>param</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        private Param Param(string name) => Elements.OfType<Param>().FirstOrDefault(p => p.Name == name);
        /// <summary>
        /// Returns the first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available. Inheritdoc is not taken into the consideration here.
        /// </summary>
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        private TypeParam TypeParam(string name) => Elements.OfType<TypeParam>().FirstOrDefault(tp => tp.Name == name);

        /// <summary>
        /// Initialize <see cref="Documentation"/> instance from XML Documentation Comments element
        /// </summary>
        /// <param name="element">XML element of XML Documentation Comments</param>
        public Documentation(XElement element) : base(element)
        {
            OwnRef = element?.Attribute("name")?.Value;
        }

        /// <summary>
        /// Returns the first <c>summary</c> documentation element or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public Summary GetSummary(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Summary;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Summary : memberBase.Documentation?.GetSummary(memberBase);
        }

        /// <summary>
        /// Returns the first <c>remarks</c> documentation element or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public Remarks GetRemarks(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Remarks;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Remarks : memberBase.Documentation?.GetRemarks(memberBase);
        }

        /// <summary>
        /// Returns the first <c>example</c> documentation element or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public Example GetExample(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Example;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Example : memberBase.Documentation?.GetExample(memberBase);
        }
        /// <summary>
        /// Returns the <c>exception</c> documentation elements or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public IList<ExceptionDoc> GetExceptions(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Exceptions;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Exceptions : memberBase.Documentation?.GetExceptions(memberBase);
        }
        /// <summary>
        /// Returns the <c>seealso</c> documentation elements or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public IList<SeeAlso> GetSeeAlso(Member member)
        {
            if (!ShouldInheritDoc || member == null) return SeeAlso;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? SeeAlso : memberBase.Documentation?.GetSeeAlso(memberBase);
        }
        /// <summary>
        /// Returns the first <c>value</c> documentation element or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public Value GetValue(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Value;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Value : memberBase.Documentation?.GetValue(memberBase);
        }
        /// <summary>
        /// Returns the first <c>returns</c> documentation element or null if not available. Inheritdoc is taken into the consideration here if applicable.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        public Returns GetReturns(Member member)
        {
            if (!ShouldInheritDoc || member == null) return Returns;
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Returns : memberBase.Documentation?.GetReturns(memberBase);
        }

        /// <summary>
        /// Returns the first <c>param</c> documentation element with given <paramref name="name"/> or null if not available. Inheritdoc is taken into the consideration here.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>param</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        public Param GetParam(Member member, string name)
        {
            if (!ShouldInheritDoc || member == null) return Param(name);
            var memberBase = GetMemberBase(member);
            return memberBase == null ? Param(name) : memberBase.Documentation?.GetParam(memberBase, name);
        }

        /// <summary>
        /// Returns the first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available. Inheritdoc is taken into the consideration here.
        /// </summary>
        ///<param name="member">Member the documentation belongs to</param>    
        /// <param name="name">Name of the parameter to get the documentation for</param>
        /// <returns>The first <c>typeparam</c> documentation element with given <paramref name="name"/> or null if not available</returns>
        public TypeParam GetTypeParam(Member member, string name)
        {
            if (!ShouldInheritDoc || member == null) return TypeParam(name);
            var memberBase = GetMemberBase(member);
            return memberBase == null ? TypeParam(name) : memberBase.Documentation?.GetTypeParam(memberBase, name);
        }

        /// <summary>
        /// Gets the member to inherit documentation from if available
        /// </summary>
        /// <param name="member">Current member owning the documentation</param>
        /// <returns>The member to inherit documentation from if available, otherwise null</returns>
        private Member GetMemberBase(Member member)
        {
            //Keep in mind, that inherit doc applies only to the item it's declared for, so if it's declared for type, it's not implicitly applied to type members

            //If an explicit cref attribute is specified, the documentation from the specified member is inherited. If member not found, documentation is not inherited.
            //If a cref attribute is not specified, the following rules apply.
            if (!string.IsNullOrEmpty(InheritDocRef))
            {
                return member.Root.AllMembersByDocId.TryGetValue(InheritDocRef, out var crefMember) ? crefMember : null;
            }

            switch (member)
            {
                //For types and interfaces:
                //Inherit documentation from all base classes working backwards up the inheritance chain.
                //If not inherited, inherit documentation from all interface implementations (if any) working through them in the order provided by Roslyn (in this case it's recommended to use "cref").
                case TypeMember typeMember:
                    {
                        var inheritMember = typeMember.TypeRef.Base?.Member;
                        if (inheritMember != null) return inheritMember;

                        //try interfaces
                        var directIfMember = typeMember.InterfacesTypeRefs?.FirstOrDefault(itr => itr.Member != null);
                        if (directIfMember != null) return directIfMember.Member;

                        var allIfMember = typeMember.AllInterfacesTypeRefs?.FirstOrDefault(itr => itr.Member != null);
                        if (allIfMember != null) return allIfMember.Member;
                        break;
                    }

                //If the member  (method, property, event) is an override, documentation is inherited from the member it overrides.
                case TypeContentMember typeContentMember when (member is MethodMember ||
                                                               member is PropertyMember ||
                                                               member is EventMember) &&
                                                              typeContentMember.OverridesMember != null:
                    return typeContentMember.OverridesMember;

                //If the member  (method, property, event) is part of an interface, documentation is inherited from the interface member being implemented.
                //If the member implements more than one interface member, the first one is returned (in this case it's recommended to use "cref")
                case TypeContentMember typeContentMember when (member is MethodMember ||
                                                               member is PropertyMember ||
                                                               member is EventMember) &&
                                                              typeContentMember.ImplementsMembers != null &&
                                                              typeContentMember.ImplementsMembers.Count > 0:
                    return typeContentMember.ImplementsMembers[0];
            }

            return null;
        }

        /// <summary>
        /// Reads the XML Documentation Comments from given <see cref="xml"/> string
        /// </summary>
        /// <param name="xml">XML with documentation comments to parse</param>
        /// <returns>The new instance of <see cref="Documentation"/> class with XML Documentation Comments parsed from given <paramref name="xml"/></returns>
        public static Documentation Read(string xml)
        {
            if (string.IsNullOrEmpty(xml)) return null;
            Documentation doc = null;
            try
            {
                doc = Read(XDocument.Parse(xml)) as Documentation;
                var inheritdocXElement = doc?.Elements.OfType<Inheritdoc>().FirstOrDefault();
                if (inheritdocXElement != null)
                {
                    if (doc.Summary == null &&
                        doc.Remarks == null &&
                        doc.Example == null &&
                        doc.Exceptions.Count == 0 &&
                        doc.SeeAlso.Count == 0 &&
                        doc.Value == null &&
                        doc.Returns == null)
                    {
                        doc.ShouldInheritDoc = true;
                        doc.InheritDocRef = inheritdocXElement.Ref;
                    }
                }
            }
            catch (Exception ex)
            {
                ConsoleUtils.WriteErrWarn($"Can't parse XML documentation - {ex.Message}");
                ConsoleUtils.WriteErrWarn(xml);
            }

            return doc;
        }
    }
}
