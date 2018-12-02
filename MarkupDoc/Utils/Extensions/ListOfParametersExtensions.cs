using System.Collections.Generic;
using System.Linq;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="ICollection{T}"/> of <see cref="TypeParameter"/> and <see cref="MethodParameter"/>
    /// </summary>
    public static class ListOfParametersExtensions
    {
        /// <summary>
        /// Converts the <see cref="IEnumerable{T}"/> of <see cref="TypeParameter"/>s to the string as used in code.
        /// Used for typed parameters with attributes and parameters with variance (variance is at generic interfaces and delegates only)
        /// </summary>
        /// <param name="typeParameters">List of type parameters</param>
        /// <returns>Code string representation of the list of type parameters</returns>
        public static string GetTypeParametersCode(this IEnumerable<TypeParameter> typeParameters)
        {
            if (typeParameters == null) return "";

            var paramList = new List<string>();
            foreach (var parameter in typeParameters)
            {
                var name = (parameter.Variance != "" ? parameter.Variance + " " : "") + parameter.Name;
                if (parameter.Attributes == null)
                {
                    paramList.Add(name);
                }
                else
                {
                    var attrs = string.Join(" ", parameter.Attributes.Select(a => $"[{a}]"));
                    paramList.Add($"{attrs} {name}");
                }
            }
            var retVal = $"<{string.Join(", ", paramList)}>";
            return retVal;

        }

        /// <summary>
        /// Converts the <see cref="IEnumerable{T}"/> of indexer parameters (<see cref="MethodParameter"/>) to the string as used in code.
        /// </summary>
        /// <param name="methodParameters">List of indexer method parameters</param>
        /// <returns>Code string representation of the list of indexer parameters</returns>
        public static string GetIndexerParametersCode(this IEnumerable<MethodParameter> methodParameters)
        {
            if (methodParameters == null) return "";
           
            return new Txt()
                .Add("[")
                .AddEach((param) => new Txt()
                        .AddEach(a => $"[{a}]", param.Attributes, ", ") //attributes
                        .AddIf(" ", param.Attributes?.Count > 0) //spc after attributes
                        .AddIf("in ", param.RefKind == RefKindEnum.In) //variance
                        .Add(param.TypeRef.ApplySpecialName(false)) //type name
                        .Add($" {param.Name}") //name
                    , methodParameters, ", ")
                .Add("]");
        }
    }
}
