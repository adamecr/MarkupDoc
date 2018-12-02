using System.Collections.Generic;
using System.Globalization;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <summary>
    /// Represents a method parameter within the code model 
    /// </summary>
    /// <remarks>Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method</remarks>
    public class MethodParameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Type reference for the parameter's type
        /// </summary>
        public TypeRef TypeRef { get; }
        /// <summary>
        /// Flag whether the parameter is optional
        /// </summary>
        public bool IsOptional { get; }
        /// <summary>
        /// Flag whether the parameter has explicitly defined default value
        /// </summary>
        public bool HasExplicitDefaultValue { get; }
        /// <summary>
        /// Parameter's explicitly defined default value (when available)
        /// </summary>
        public object ExplicitDefaultValue { get; }
        /// <summary>
        /// Flag whether the parameter is with <c>params</c> modifier
        /// </summary>
        public bool IsParams { get; }
        /// <summary>
        /// Flag whether the parameter is with <c>this</c> modifier
        /// </summary>
        public bool IsThis { get; }
        /// <summary>
        /// Information whether the parameter is "by reference" with the reference kind (None, Ref, Out,In)
        /// </summary>
        public RefKindEnum RefKind { get; }
        /// <summary>
        /// Parameter attributes definition (including the parameters). 
        /// </summary>
        public IReadOnlyList<string> Attributes { get; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public MethodParameter(MethodParameterBuilder builder)
        {
            Name = builder.Name;
            TypeRef = builder.TypeRef;
            IsOptional = builder.IsOptional;
            HasExplicitDefaultValue = builder.HasExplicitDefaultValue;
            ExplicitDefaultValue = builder.ExplicitDefaultValue;
            IsParams = builder.IsParams;
            IsThis = builder.IsThis;
            RefKind = builder.RefKind;
            Attributes = builder.Attributes;
        }

        /// <summary>
        /// Gets the default value for the parameter as string with "code syntax" (meaning how would be the value defined in the code)
        /// </summary>
        /// <remarks>The default value is stored as the object, so it's necessary to do some formatting like add the quotation marks for strings, format the numeric constants,  etc.</remarks>
        /// <returns>The default value for the parameter or empty string if not defined</returns>
        public string GetDefaultValueString()
        {
            if (!HasExplicitDefaultValue) return "";
            switch (ExplicitDefaultValue)
            {
                case string s: return $"\"{s}\"";
                case char c: return $"'{c}'";
                case float f: return $"{f.ToString(CultureInfo.InvariantCulture)}f";
                case double d: return $"{d.ToString(CultureInfo.InvariantCulture)}d";
                case decimal m: return $"{m.ToString(CultureInfo.InvariantCulture)}m";
                case bool b: return b ? "true" : "false";
            }
            return $"{ExplicitDefaultValue ?? "null"}";
        }
    }
}
