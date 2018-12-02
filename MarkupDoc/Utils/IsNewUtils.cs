using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis;

namespace net.adamec.dev.markupdoc.Utils
{
    /// <summary>
    /// Helpers to get the access to internal ISymbol.IsNew property
    /// </summary>
    public static class IsNewUtils
    {
        /// <summary>
        /// Cache of the <see cref="PropertyInfo"/>s for IsNew properties for individual <see cref="ISymbol"/>s (types)
        /// </summary>
        private static readonly Dictionary<Type, PropertyInfo> IsNewPropertyCache = new Dictionary<Type, PropertyInfo>();

        /// <summary>
        /// Gets the value of internal IsNew property of given <paramref name="symbol"/>
        /// </summary>
        /// <remarks>Uses the reflection to get the access to the internal property IsNew.
        /// The retrieved <see cref="PropertyInfo"/> is cached in <see cref="IsNewPropertyCache"/> to minimize the performance impacts.</remarks>
        /// <param name="symbol">Symbol to get the value from</param>
        /// <returns>Value of internal IsNew property of given <paramref name="symbol"/> or <c>false</c> when the property can't be retrieved</returns>
        public static bool GetIsNew(this ISymbol symbol)
        {
            var type = symbol.GetType();
            PropertyInfo isNewProperty;
            if (IsNewPropertyCache.TryGetValue(type, out var cachedIsNewProperty))
            {
                isNewProperty = cachedIsNewProperty;
            }
            else
            {
                isNewProperty = type.GetProperty("IsNew",
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
                if (isNewProperty != null && isNewProperty.PropertyType != typeof(bool)) isNewProperty = null; //not the right one
                IsNewPropertyCache.Add(type, isNewProperty); //store even the null values -> we now there is no such property for given type
            }

            if (isNewProperty != null)
            {
                return (bool)isNewProperty.GetValue(symbol);
            }

            return false;
        }
    }
}
