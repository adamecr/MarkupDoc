using System;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods and factory for <see cref="ModifierEnum"/>
    /// </summary>
    public static class ModifierEnumExtensions
    {
        /// <summary>
        /// Creates the modifier from given <paramref name="accessibility"/>
        /// </summary>
        /// <param name="accessibility">Accessibility to create the <see cref="ModifierEnum"/> from</param>
        /// <returns><see cref="ModifierEnum"/> from given <paramref name="accessibility"/></returns>
        public static ModifierEnum Modifier(Accessibility accessibility)
        {
            switch (accessibility)
            {
                case Accessibility.NotApplicable: return ModifierEnum.NotApplicable;
                case Accessibility.Public: return ModifierEnum.Public;
                case Accessibility.Private: return ModifierEnum.Private;
                case Accessibility.Protected: return ModifierEnum.Protected;
                case Accessibility.Internal: return ModifierEnum.Internal;
                case Accessibility.ProtectedOrInternal: return ModifierEnum.ProtectedInternal;
                case Accessibility.ProtectedAndInternal: return ModifierEnum.PrivateProtected;
                default:
                    throw new ArgumentOutOfRangeException(nameof(accessibility), accessibility, null);
            }
        }

        /// <summary>
        /// Converts the <see cref="ModifierEnum"/> to string that can be used in code
        /// </summary>
        /// <param name="modifierEnum">Modifier to convert</param>
        /// <returns>"Code compatible" modifier string</returns>
        public static string ToModifierString(this ModifierEnum modifierEnum)
        {
            switch (modifierEnum)
            {
                case ModifierEnum.NotApplicable:
                    return "";
                case ModifierEnum.Public:
                    return "public";
                case ModifierEnum.Private:
                    return "private";
                case ModifierEnum.Protected:
                    return "protected";
                case ModifierEnum.Internal:
                    return "internal";
                case ModifierEnum.ProtectedInternal:
                    return "protected internal";
                case ModifierEnum.PrivateProtected:
                    return "private protected";
                default:
                    throw new ArgumentOutOfRangeException(nameof(modifierEnum), modifierEnum, null);
            }
        }
    }
}
