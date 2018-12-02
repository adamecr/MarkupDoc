using System.Collections.Generic;
using net.adamec.dev.markupdoc.CodeModel.Builder;

namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <inheritdoc />
    /// <summary>
    /// Represents a property within the code model
    /// </summary>
    public class PropertyMember : TypeContentMember
    {
          /// <summary>
        /// Flag whether the property is indexer;
        /// </summary>
        public bool IsIndexer { get; set; }
        /// <summary>
        /// Flag whether the property is read only
        /// </summary>
        public bool IsReadOnly { get; set; }
        /// <summary>
        /// Flag whether the property is write only
        /// </summary>
        public bool IsWriteOnly { get; set; }
        /// <summary>
        /// Getter access modifier if it's different than the property one
        /// </summary>
        public string GetterModifier { get; set; }
        /// <summary>
        /// Setter access modifier if it's different than the property one
        /// </summary>
        public string SetterModifier { get; set; }
       
        /// <summary>
        /// Type reference of property type
        /// </summary>
        public TypeRef TypeRef { get; set; }
        /// <summary>
        /// List of property parameters (if any). Just the indexers may have the parameters
        /// </summary>
        public IReadOnlyList<MethodParameter> Parameters { get; set; }

        /// <summary>
        /// CTOR - from builder
        /// </summary>
        /// <param name="builder">Builder</param>
        public PropertyMember(PropertyMemberBuilder builder):base(builder)
        {
            IsIndexer = builder.IsIndexer;
            IsReadOnly = builder.IsReadOnly;
            IsWriteOnly = builder.IsWriteOnly;
            GetterModifier = builder.GetterModifier;
            SetterModifier = builder.SetterModifier;
            TypeRef = builder.TypeRef;
            Parameters = builder.Parameters;
        }
    }
}
