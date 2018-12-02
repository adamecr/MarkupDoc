namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="TypeContentMember"/>
    /// </summary>
    public abstract class TypeContentMemberBuilder : MemberBuilder
    {
        /// <summary>
        /// Type containing the content member
        /// </summary>
        public TypeMember Type { get; set; }
    }
}
