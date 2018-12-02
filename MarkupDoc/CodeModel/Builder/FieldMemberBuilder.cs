namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="FieldMember"/>
    /// </summary>
    public class FieldMemberBuilder : TypeContentMemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Field;
        /// <summary>
        /// Flag whether the field is constant
        /// </summary>
        public bool IsConst { get; set; }
        /// <summary>
        /// Flag whether the field is read only
        /// </summary>
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Flag whether the field is volatile
        /// </summary>
        public bool IsVolatile { get; set; }
        /// <summary>
        /// The constant value of the field
        /// </summary>
        /// <remarks>The ConstantValue is not the definition (for example "2+customId") but the value is evaluated to the target type
        /// (for example 1002 if the customId in previous example is constant 1000).
        /// It's also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)</remarks>
        public object ConstantValue { get; set; }
        /// <summary>
        /// Type (type reference) of the field value
        /// </summary>
        public TypeRef TypeRef { get; set; }

       
    }
}
