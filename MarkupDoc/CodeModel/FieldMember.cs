using System.Globalization;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a field within the code model
    /// </summary>
    public class FieldMember : TypeContentMember
    {
        /// <summary>
        /// Flag whether the field is constant
        /// </summary>
        public bool IsConst { get; }
        /// <summary>
        /// Flag whether the field is read only
        /// </summary>
        public bool IsReadOnly { get; }
        /// <summary>
        /// Flag whether the field is volatile
        /// </summary>
        public bool IsVolatile { get; }
        /// <summary>
        /// The constant value of the field
        /// </summary>
        /// <remarks>The ConstantValue is not the definition (for example "2+customId") but the value is evaluated to the target type
        /// (for example 1002 if the customId in previous example is constant 1000).
        /// It's also necessary to apply the format when the constant value is to be presented in the output (for example add quotation marks to strings)</remarks>
        public object ConstantValue { get; }
        /// <summary>
        /// Type (type reference) of the field value
        /// </summary>
        public TypeRef TypeRef { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public FieldMember(FieldMemberBuilder builder) : base(builder)
        {
            IsConst = builder.IsConst;
            IsReadOnly = builder.IsReadOnly;
            IsVolatile = builder.IsVolatile;
            ConstantValue = builder.ConstantValue;
            TypeRef = builder.TypeRef;
        }

        /// <summary>
        /// Gets the constant value as string with "code syntax" (meaning how would be the value defined in the code)
        /// </summary>
        /// <remarks>The constant value is stored as the object, so it's necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.</remarks>
        /// <returns>The constant value constant</returns>
        public string GetConstantValueString()
        {
            switch (ConstantValue)
            {
                case string s: return $"\"{s}\"";
                case char c: return $"'{c}'";
                case float f: return $"{f.ToString(CultureInfo.InvariantCulture)}f";
                case double d: return $"{d.ToString(CultureInfo.InvariantCulture)}d";
                case decimal m: return $"{m.ToString(CultureInfo.InvariantCulture)}m";
                case bool b: return b ? "true" : "false";
            }
            return $"{ConstantValue ?? "null"}";
        }
    }
}
