using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <summary>
    /// Builder for <see cref="TypeParameter"/>
    /// </summary>
    public class TypeParameterBuilder
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Flag whether the type parameter has constructor constraint ( new() )
        /// </summary>
        public bool HasConstructorConstraint { get; set; } //new()
        /// <summary>
        /// Flag whether the type parameter has reference type constraint ( class )
        /// </summary>
        public bool HasReferenceTypeConstraint { get; set; } //class
        /// <summary>
        /// Flag whether the type parameter has unmanaged type constraint ( unmanaged )
        /// </summary>
        public bool HasUnmanagedTypeConstraint { get; set; }//unmanaged
        /// <summary>
        /// Flag whether the type parameter has value type constraint ( struct )
        /// </summary>
        public bool HasValueTypeConstraint { get; set; } //struct
        /// <summary>
        /// List of type references of constraint types  when the concrete types are defined as constraints
        /// </summary>
        public List<TypeRef> ConstraintTypes { get; set; }
        /// <summary>
        /// Type parameter attributes definition (including the parameters). 
        /// </summary>
        public List<string> Attributes { get; set; }
        /// <summary>
        /// Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.
        /// </summary>
        public string Variance { get; set; }

    }
}
