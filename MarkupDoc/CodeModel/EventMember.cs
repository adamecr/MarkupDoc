using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents an event within the code model
    /// </summary>
    public class EventMember : TypeContentMember
    {
        /// <summary>
        /// Flag whether the event has explicit implementation of add and remove accessors
        /// </summary>
        public bool HasExplicitAddAndRemove { get; }
        /// <summary>
        /// Delegate type (type reference) of the event handler
        /// </summary>
        public TypeRef TypeRef { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public EventMember(EventMemberBuilder builder) : base(builder)
        {
            HasExplicitAddAndRemove = builder.HasExplicitAddAndRemove;
            TypeRef = builder.TypeRef;
        }

    }
}
