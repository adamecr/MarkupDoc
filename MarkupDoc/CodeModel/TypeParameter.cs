using System.Collections.Generic;
using System.Linq;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <summary>
    /// Represents a type parameter within the code model
    /// </summary>
    public class TypeParameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Flag whether the type parameter has constructor constraint ( new() )
        /// </summary>
        public bool HasConstructorConstraint { get; }
        /// <summary>
        /// Flag whether the type parameter has reference type constraint ( class )
        /// </summary>
        public bool HasReferenceTypeConstraint { get; }
        /// <summary>
        /// Flag whether the type parameter has unmanaged type constraint ( unmanaged )
        /// </summary>
        public bool HasUnmanagedTypeConstraint { get; }
        /// <summary>
        /// Flag whether the type parameter has value type constraint ( struct )
        /// </summary>
        public bool HasValueTypeConstraint { get; }
        /// <summary>
        /// List of type references of constraint types  when the concrete types are defined as constraints
        /// </summary>
        public List<TypeRef> ConstraintTypes { get; }
        /// <summary>
        /// Type parameter attributes definition (including the parameters). 
        /// </summary>
        public List<string> Attributes { get; }
        /// <summary>
        /// Variance (covariance and contravariance) modifier (in, out) for the type parameter if available.
        /// </summary>
        public string Variance { get; }

        /// <summary>
        /// Flag whether the type parameter has any constraint
        /// </summary>
        public bool HasAnyConstraint =>
            HasConstructorConstraint ||
            HasReferenceTypeConstraint ||
            HasUnmanagedTypeConstraint ||
            HasValueTypeConstraint ||
            ConstraintTypes != null && ConstraintTypes.Count > 0;

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public TypeParameter(TypeParameterBuilder builder)
        {
            Name = builder.Name;
            HasConstructorConstraint = builder.HasConstructorConstraint;
            HasReferenceTypeConstraint = builder.HasReferenceTypeConstraint;
            HasUnmanagedTypeConstraint = builder.HasUnmanagedTypeConstraint;
            HasValueTypeConstraint = builder.HasValueTypeConstraint;
            ConstraintTypes = builder.ConstraintTypes;
            Attributes = builder.Attributes;
            Variance = builder.Variance;
        }

        /// <summary>
        /// Returns the string with all constraints as defined in code
        /// </summary>
        /// <returns>String with all constraints as defined in code</returns>
        public string GetConstraintsString()
        {
            if (!HasAnyConstraint) return null;

            var items = new List<string>();
            if (HasReferenceTypeConstraint) items.Add("class");
            if (HasUnmanagedTypeConstraint) items.Add("unmanaged");
            if (HasValueTypeConstraint) items.Add("struct");
            if (ConstraintTypes != null) items.AddRange(ConstraintTypes.Select(ct => ct.Name));
            if (HasConstructorConstraint) items.Add("new()");
            return $" where {Name}: {string.Join(", ", items)}";
        }
    }
}
