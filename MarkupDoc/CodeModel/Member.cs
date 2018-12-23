using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel.Builder;
using net.adamec.dev.markupdoc.XmlDocumentation;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <summary>
    /// Represents a single entity of the code model - called member. The member can be namespace, type, type member like field, method (aka type code member) , etc.
    /// </summary>
    /// <remarks>
    /// The code model should not be manipulated (changed) once built, however for the sake of the simplicity, the setters are currently kept public.
    /// This might change in future when (if) the MarkupDoc will come with greater extensibility
    /// </remarks>
    public abstract class Member
    {
        /// <summary>
        /// Member id, used to distinguish between the names when building the "internal" links
        /// (for example when ti difference is in case only)
        /// </summary>
        /// <remarks>
        /// Id is not necessary unique across all members, but the combination <see cref="Name"/>+<see cref="Id"/>
        /// is believed to be unique.
        /// <para>The Id is created/updated when the <see cref="DocumentationId"/> is set
        /// and it's calculated as Base36 encoded hash of the DocumentationId</para>
        /// </remarks>
        public string Id { get; }
        /// <summary>
        /// Source file defining the member
        /// </summary>
        public IReadOnlyList<string> SourceFiles { get; }
        /// <summary>
        /// Name of the member as presented in generated output
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Name of the member without type params, indexer params, operator params, etc.
        /// </summary>
        public string NameBase { get; }
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public MemberKindEnum MemberKind { get; }
        /// <summary>
        /// Reference to the root of the code model
        /// </summary>
        public RootMember Root { get; set; }
        /// <summary>
        /// Reference to the containing assembly member
        /// </summary>
        public AssemblyMember Assembly { get; set; }
        /// <summary>
        /// Reference to the containing namespace member
        /// </summary>
        public NamespaceMember Namespace { get; set; }
        /// <summary>
        /// All child members, for example types for namespace; fields, properties, methods, etc. for types
        /// </summary>
        public IReadOnlyList<Member> AllMembers { get; }

        /// <summary>
        /// Member modifier (public, private, etc.)
        /// </summary>
        public ModifierEnum Modifier { get; }
        /// <summary>
        /// Flag whether the member is abstract
        /// </summary>
        public bool IsAbstract { get; }
        /// <summary>
        /// Flag whether the member is extern
        /// </summary>
        public bool IsExtern { get; }
        /// <summary>
        /// Flag whether the member is sealed
        /// </summary>
        public bool IsSealed { get; }
        /// <summary>
        /// Flag whether the member is static
        /// </summary>
        public bool IsStatic { get; }
        /// <summary>
        /// Flag whether the member hides member with the same name in base class
        /// </summary>
        public bool IsNew { get; }
        /// <summary>
        /// Flag whether the member overrides the member in the base class
        /// </summary>
        public bool IsOverride { get; }
        /// <summary>
        /// Flag whether the member is virtual (can be overriden)
        /// </summary>
        public bool IsVirtual { get; }

        /// <summary>
        /// Member's attributes definition (including the parameters). 
        /// </summary>
        public IReadOnlyList<string> Attributes { get; }
        /// <summary>
        /// Types (type references) of the member attributes
        /// </summary>
        public IReadOnlyList<TypeRef> AttributeTypeRefs { get; }

        /// <summary>
        /// Member's documentation ID as provided by the compiler (for example M:myNamespace.myType.myMethod)
        /// </summary>
        /// <remarks>See https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/processing-the-xml-file for details</remarks>
        public string DocumentationId { get; }

        /// <summary>
        /// XML documentation comments
        /// </summary>
        public string DocumentationXml { get; }
        /// <summary>
        /// Parsed XML documentation comments. <see cref="Documentation"/> is the root element of the parsed XML documentation comments
        /// </summary>
        public Documentation Documentation { get; }
        /// <summary>
        /// Roslyn semantic analysis symbol of the member
        /// </summary>
        public ISymbol Symbol { get; }

        /// <summary>
        /// File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string.
        /// This is also used when building the links to the member (FileName.extension#Anchor)
        /// </summary>
        public virtual string FileName => Root.ProcessingInfo.SplitFileType != SplitTypeEnum.None ? $"{Name}__{Id}" : "";
        /// <summary>
        /// Anchor to the member to point the links  (FileName.extension#Anchor) to proper part of generated output file.
        /// </summary>
        public virtual string Anchor => FormatAnchor();

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        protected Member(MemberBuilder builder)
        {
            if (builder == null) throw new ArgumentNullException(nameof(builder));
            SourceFiles = builder.SourceFiles;
            Name = builder.Name;
            NameBase = builder.NameBase;
            MemberKind = builder.MemberKind;
            Root = builder.Root;
            Assembly = builder.Assembly;
            Namespace = builder.Namespace;

            Modifier = builder.Modifier;
            IsAbstract = builder.IsAbstract;
            IsExtern = builder.IsExtern;
            IsSealed = builder.IsSealed;
            IsStatic = builder.IsStatic;
            IsNew = builder.IsNew;
            IsOverride = builder.IsOverride;
            IsVirtual = builder.IsVirtual;
            Attributes = builder.Attributes;
            AttributeTypeRefs = builder.AttributeTypeRefs;
            DocumentationId = builder.DocumentationId;
            DocumentationXml = builder.DocumentationXml;
            Documentation = builder.Documentation;
            Symbol = builder.Symbol;

            Id = Base36(StableHash(DocumentationId ?? MemberKind + "_" + Name));

            AllMembers = new List<Member>(); //To be filled in child classes
        }

        /// <summary>
        /// Returns the brief description of the member
        /// </summary>
        /// <returns>The brief description of the member</returns>
        public override string ToString()
        {
            return $"{MemberKind}: {Name}";
        }

        /// <summary>
        /// Creates and format the anchor based on the <see cref="DocumentationId"/>.
        /// In general, it gets the DocumentationID, trims is, converts it to lower case and replaces the "special" characters with '_' or '-'
        /// </summary>
        /// <returns>The anchor for the member</returns>
        protected string FormatAnchor()
        {
            var text = !string.IsNullOrEmpty(DocumentationId) ? DocumentationId : MemberKind + "_" + Name;

            text = text.Trim().ToLower()
                .Replace('<', '_').Replace('>', '_')
                .Replace('[', '_').Replace(']', '_')
                .Replace('(', '_').Replace(')', '_')
                .Replace('{', '_').Replace('}', '_')

                .Replace(',', '-')
                .Replace(' ', '-')
                .Replace(':', '-')
                .Replace("`", "-")
                .Replace("@", "-")
                .Replace("#", "-")
                .Replace("~", "dtor");
            text += "__" + Id;
            return text;
        }

        /// <summary>
        /// Hashing function for strings that generates the sting hash as <see cref="uint"/>
        /// </summary>
        /// <remarks>The hash function is based on the .NET implementation of <see cref="String.GetHashCode"/> optimized for 64bit processors.
        /// The reason for the explicit hash function is that the .NET implementation is not granted to be stable across versions and/or frameworks.
        /// The stability is needed as the Base36 encoded hash is a part of the file name and may be used in perma links</remarks>
        /// <param name="s">String to hash</param>
        /// <returns>Hash of given <paramref name="s">string</paramref></returns>
        public static uint StableHash(string s)
        {
            unchecked
            {
                var hash1 = 5381;
                var hash2 = hash1;

                for (var i = 0; i < s.Length && s[i] != '\0'; i += 2)
                {
                    hash1 = ((hash1 << 5) + hash1) ^ s[i];
                    if (i == s.Length - 1 || s[i + 1] == '\0') break;
                    hash2 = ((hash2 << 5) + hash2) ^ s[i + 1];
                }

                return (uint)(hash1 + (hash2 * 1566083941));
            }
        }

        /// <summary>
        /// Characters allowed in Base36 encoding
        /// </summary>
        private const string Base36Chars = "0123456789abcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// Encodes the <paramref name="input"/> number to Base36 encoded string
        /// </summary>
        /// <param name="input">Number to encode</param>
        /// <returns>Base36 encoded string</returns>
        public static string Base36(uint input)
        {

            var charArray = Base36Chars.ToCharArray();
            var result = new Stack<char>();
            while (input != 0)
            {
                result.Push(charArray[input % 36]);
                input /= 36;
            }
            return new string(result.ToArray());
        }
    }
}
