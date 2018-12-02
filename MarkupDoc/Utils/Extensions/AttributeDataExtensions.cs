using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="AttributeData"/>
    /// </summary>
    public static class AttributeDataExtensions
    {
        /// <summary>
        /// Gets the string representing the attribute definition in code - class (constructor params, named params)
        /// </summary>
        /// <param name="attributeData">Attribute data to create the code from</param>
        /// <returns>String representing the attribute definition as in code (without [ ] brackets)</returns>
        public static string ToCodeString(this AttributeData attributeData)
        {
            if (attributeData.AttributeClass == null) return attributeData.ToString();
            var className = attributeData.AttributeClass.Name;
            if (className.EndsWith("Attribute"))
                className = className.Substring(0, className.Length - "Attribute".Length);

            if (!attributeData.ConstructorArguments.Any() & !attributeData.NamedArguments.Any()) return className;


            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{className}(");


            var first = true;

            foreach (var constructorArgument in attributeData.ConstructorArguments)
            {
                if (!first) stringBuilder.Append(", ");

                stringBuilder.Append(constructorArgument.ToCSharpString());
                first = false;
            }

            foreach (var namedArgument in attributeData.NamedArguments)
            {
                if (!first) stringBuilder.Append(", ");

                stringBuilder.Append($"{namedArgument.Key} = {namedArgument.Value.ToCSharpString()}");
                first = false;
            }

            stringBuilder.Append(")");

            return stringBuilder.ToString();
        }

        /// <summary>
        /// Returns the full name of the attribute class
        /// </summary>
        /// <param name="attributeData">Attribute data to get the class from</param>
        /// <returns>Full name of the attribute class</returns>
        public static string AttributeClassString(this AttributeData attributeData)
        {
            if (attributeData.AttributeClass == null) return attributeData.ToString();
            var className = attributeData.AttributeClass.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
            className = className.Replace("global::", "");
            return className;
        }
    }
}
