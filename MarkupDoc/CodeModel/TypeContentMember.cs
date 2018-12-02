using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Abstract class for type members (fields, properties, etc.) within the code model
    /// </summary>
    public abstract class TypeContentMember : Member
    {
        /// <summary>
        /// Type containing the content member
        /// </summary>
        public TypeMember Type { get; set; }

        /// <summary>
        /// File name (without extension !!!) where the member should be generated to (aka split name) in case that the output splitting is allowed, otherwise the empty string.
        /// This is also used when building the links to the member (FileName.extension#Anchor)
        /// </summary>
        /// <remarks>Type content is rendered together with type, so the <see cref="FileName"/> is taken from <see cref="Type"/></remarks>
        public override string FileName => Type.FileName;

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        protected TypeContentMember(TypeContentMemberBuilder builder) : base(builder)
        {
            Type = builder.Type;
        }
    }
}
