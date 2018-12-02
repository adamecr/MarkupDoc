using System.Collections.Generic;

namespace net.adamec.dev.markupdoc.CodeModel.Builder
{
    /// <inheritdoc />
    /// <summary>
    /// Builder for <see cref="PropertyMember"/>
    /// </summary>
    public class PropertyMemberBuilder : TypeContentMemberBuilder
    {
        /// <inheritdoc />
        /// <summary>
        /// Kind (type) of the member
        /// </summary>
        public override MemberKindEnum MemberKind => MemberKindEnum.Property;
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
        public List<MethodParameter> Parameters { get; set; }

      
    }
}
