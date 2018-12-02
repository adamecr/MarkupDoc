using System;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="TypeKind"/>
    /// </summary>
    public static class TypeKindExtensions
    {
        /// <summary>
        /// Converts the <see cref="TypeKind"/> to <see cref="TypeKindEnum"/>
        /// </summary>
        /// <param name="typeKind">TypeKind to convert</param>
        /// <returns>TypeKindEnum from the TypeKind</returns>
        public static TypeKindEnum ToTypeKindEnum(this TypeKind typeKind)
        {
            switch (typeKind)
            {
                case TypeKind.Class:
                    return TypeKindEnum.Class;
                case TypeKind.Delegate:
                    return TypeKindEnum.Delegate;
                case TypeKind.Enum:
                    return TypeKindEnum.Enum;
                case TypeKind.Interface:
                    return TypeKindEnum.Interface;
                case TypeKind.Struct:
                    return TypeKindEnum.Struct;

                case TypeKind.Dynamic:
                case TypeKind.Error:
                case TypeKind.Unknown:
                case TypeKind.Array:
                case TypeKind.Module:
                case TypeKind.Pointer:
                case TypeKind.TypeParameter:
                case TypeKind.Submission:
                    return TypeKindEnum.Unknown;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}
