namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="EventMember"/>
    /// </summary>
    public class EventMemberBuilder : TypeContentMemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Event;
        /// <summary>
        /// Flag whether the event has explicit implementation of add and remove accessors
        /// </summary>
        public bool HasExplicitAddAndRemove { get; set; }
        /// <summary>
        /// Delegate type (type reference) of the event handler
        /// </summary>
        public TypeRef TypeRef { get; set; }

        
    }
}
