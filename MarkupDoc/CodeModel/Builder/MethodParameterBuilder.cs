using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <summary>
    /// Builder for <see cref="MethodParameter"/>
    /// </summary>
    /// <remarks>Used for delegate parameters as well as the delegate is actually a type encapsulating the Invoke method</remarks>
    public class MethodParameterBuilder
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Type reference for the parameter's type
        /// </summary>
        public TypeRef TypeRef { get; set; }
        /// <summary>
        /// Flag whether the parameter is optional
        /// </summary>
        public bool IsOptional { get; set; }
        /// <summary>
        /// Flag whether the parameter has explicitly defined default value
        /// </summary>
        public bool HasExplicitDefaultValue { get; set; }
        /// <summary>
        /// Parameter's explicitly defined default value (when available)
        /// </summary>
        public object ExplicitDefaultValue { get; set; }
        /// <summary>
        /// Flag whether the parameter is with <c>params</c> modifier
        /// </summary>
        public bool IsParams { get; set; }
        /// <summary>
        /// Flag whether the parameter is with <c>this</c> modifier
        /// </summary>
        public bool IsThis { get; set; }
        /// <summary>
        /// Information whether the parameter is "by reference" with the reference kind (None, Ref, Out,In)
        /// </summary>
        public RefKindEnum RefKind { get; set; }
        /// <summary>
        /// Parameter attributes definition (including the parameters). 
        /// </summary>
        public List<string> Attributes { get; set; }
    }
}
