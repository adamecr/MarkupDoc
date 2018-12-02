using System.Collections.Generic;
using Microsoft.CodeAnalysis;
using net.adamec.dev.markupdoc.CodeModel;

namespace net.adamec.dev.markupdoc.Utils.Extensions
{
    /// <summary>
    /// Extension methods for <see cref="IMethodSymbol"/> related to the operators
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class IMethodSymbolExtensionsForOperators
    {
        /// <summary>
        /// Dictionary with translation of operator "internal" method name to operator symbol (for example op_Addition to +)
        /// </summary>
        private static readonly Dictionary<string, string> OperatorSymbols = new Dictionary<string, string>();
        /// <summary>
        /// Dictionary with translation of operator "internal" method name to operator alias (for example op_Addition to Add)
        /// </summary>
        private static readonly Dictionary<string, string> OperatorMethodAliases = new Dictionary<string, string>();

        /// <summary>
        /// Static CTOR - init operator translation dictionaries
        /// </summary>
        static IMethodSymbolExtensionsForOperators()
        {
            InitOperators();
        }

        /// <summary>
        /// Initializes operator translation dictionaries (symbols and aliases)
        /// </summary>
        private static void InitOperators()
        {
            OperatorSymbols.Add("op_Addition", "+");
            OperatorSymbols.Add("op_Subtraction", "-");
            OperatorSymbols.Add("op_Multiply", "*");
            OperatorSymbols.Add("op_Division", "/");
            OperatorSymbols.Add("op_Modulus", "%");
            OperatorSymbols.Add("op_ExclusiveOr", "^");
            OperatorSymbols.Add("op_BitwiseAnd", "&");
            OperatorSymbols.Add("op_BitwiseOr", "|");
            OperatorSymbols.Add("op_LogicalAnd", "&&");
            OperatorSymbols.Add("op_LogicalOr", "||");
            OperatorSymbols.Add("op_Assign", "=");
            OperatorSymbols.Add("op_LeftShift", "<<");
            OperatorSymbols.Add("op_RightShift", ">>");
            OperatorSymbols.Add("op_SignedRightShift", null);
            OperatorSymbols.Add("op_UnsignedRightShift", null);
            OperatorSymbols.Add("op_Equality", "==");
            OperatorSymbols.Add("op_Inequality", "!=");
            OperatorSymbols.Add("op_GreaterThan", ">");
            OperatorSymbols.Add("op_LessThan", "<");
            OperatorSymbols.Add("op_GreaterThanOrEqual", ">=");
            OperatorSymbols.Add("op_LessThanOrEqual", "<=");
            OperatorSymbols.Add("op_MultiplicationAssignment", "*=");
            OperatorSymbols.Add("op_SubtractionAssignment", "-=");
            OperatorSymbols.Add("op_ExclusiveOrAssignment", "^=");
            OperatorSymbols.Add("op_LeftShiftAssignment", "<<=");
            OperatorSymbols.Add("op_ModulusAssignment", "%=");
            OperatorSymbols.Add("op_AdditionAssignment", "+=");
            OperatorSymbols.Add("op_BitwiseAndAssignment", "&=");
            OperatorSymbols.Add("op_BitwiseOrAssignment", "|=");
            OperatorSymbols.Add("op_Comma", ",");
            OperatorSymbols.Add("op_DivisionAssignment", "/=");
            OperatorSymbols.Add("op_Decrement", "--");
            OperatorSymbols.Add("op_Increment", "++");
            OperatorSymbols.Add("op_UnaryNegation", "-");
            OperatorSymbols.Add("op_UnaryPlus", "+");
            OperatorSymbols.Add("op_OnesComplement", "~");
            OperatorSymbols.Add("op_False", "false");
            OperatorSymbols.Add("op_True", "true");

            OperatorMethodAliases.Add("op_Implicit", "ImplicitConversion");
            OperatorMethodAliases.Add("op_Explicit", "ExplicitConversion");
            OperatorMethodAliases.Add("op_False", "False");
            OperatorMethodAliases.Add("op_True", "True");

            OperatorMethodAliases.Add("op_Addition", "Add");
            OperatorMethodAliases.Add("op_Subtraction", "Subtract");
            OperatorMethodAliases.Add("op_Multiply", "Multiply");
            OperatorMethodAliases.Add("op_Division", "Divide");
            OperatorMethodAliases.Add("op_Modulus", "Mod");
            OperatorMethodAliases.Add("op_ExclusiveOr", "Xor");
            OperatorMethodAliases.Add("op_BitwiseAnd", "BitwiseAnd");
            OperatorMethodAliases.Add("op_BitwiseOr", "BitwiseOr");
            OperatorMethodAliases.Add("op_LogicalAnd", "And");
            OperatorMethodAliases.Add("op_LogicalOr", "Or");
            OperatorMethodAliases.Add("op_Assign", "Assign");
            OperatorMethodAliases.Add("op_LeftShift", "LeftShift");
            OperatorMethodAliases.Add("op_RightShift", "RightShift");
            OperatorMethodAliases.Add("op_SignedRightShift", "SignedRightShift");
            OperatorMethodAliases.Add("op_UnsignedRightShift", "UnsignedRightShift");
            OperatorMethodAliases.Add("op_Equality", "Equals");
            OperatorMethodAliases.Add("op_Inequality", "NotEquals");
            OperatorMethodAliases.Add("op_GreaterThan", "GreaterThan");
            OperatorMethodAliases.Add("op_LessThan", "LessThan");
            OperatorMethodAliases.Add("op_GreaterThanOrEqual", "GreaterThanOrEqual");
            OperatorMethodAliases.Add("op_LessThanOrEqual", "LessThanOrEqual");
            OperatorMethodAliases.Add("op_MultiplicationAssignment", "AssignMultiply");
            OperatorMethodAliases.Add("op_SubtractionAssignment", "AssignSubtract");
            OperatorMethodAliases.Add("op_ExclusiveOrAssignment", "AssignXor");
            OperatorMethodAliases.Add("op_LeftShiftAssignment", "AssignLeftShift");
            OperatorMethodAliases.Add("op_ModulusAssignment", "AssignMod");
            OperatorMethodAliases.Add("op_AdditionAssignment", "AssignAdd");
            OperatorMethodAliases.Add("op_BitwiseAndAssignment", "AssignBitwiseAnd");
            OperatorMethodAliases.Add("op_BitwiseOrAssignment", "AssignBitwiseOr");
            OperatorMethodAliases.Add("op_Comma", "Comma");
            OperatorMethodAliases.Add("op_DivisionAssignment", "AssignDivide");
            OperatorMethodAliases.Add("op_Decrement", "Decrement");
            OperatorMethodAliases.Add("op_Increment", "Increment");
            OperatorMethodAliases.Add("op_UnaryNegation", "Negate");
            OperatorMethodAliases.Add("op_UnaryPlus", "Plus");
            OperatorMethodAliases.Add("op_OnesComplement", "OnesComplement");

        }

        /// <summary>
        /// Get's the operator symbol for the method representing the operator
        /// </summary>
        /// <param name="methodSymbol">Method symbol</param>
        /// <returns>Operator symbol for the method representing the operator or null when unknown or not a user operator method</returns>
        public static string GetOperatorCSharpSymbol(this IMethodSymbol methodSymbol)
        {
            if (methodSymbol.MethodKind != MethodKind.UserDefinedOperator) return null;
            return OperatorSymbols.TryGetValue(methodSymbol.Name, out var symbol) ? symbol : null;
        }

        /// <summary>
        /// Get's the operator alias for the method representing the operator
        /// </summary>
        /// <param name="methodSymbol">Method symbol</param>
        /// <returns>Operator alias for the method representing the operator or original method name when unknown or not a user operator method</returns>
        public static string GetOperatorMethodAliasOrOriginalName(this IMethodSymbol methodSymbol)
        {
            if (methodSymbol.MethodKind != MethodKind.UserDefinedOperator && methodSymbol.MethodKind != MethodKind.Conversion) return methodSymbol.Name;

            if (methodSymbol.MethodKind == MethodKind.Conversion)
            {
                //conversion returns the "owning" type -> "from" conversion, otherwise "to" conversion         
                //?better comparison
                return methodSymbol.ReturnType.ToDisplayString() == methodSymbol.ContainingType.ToDisplayString() ?
                    "From" :
                    "To" + TypeRef.ApplySpecialName(methodSymbol.ReturnType, false).FirstLetterToUpper();
            }

            return OperatorMethodAliases.TryGetValue(methodSymbol.Name, out var alias) ? alias : methodSymbol.Name;
        }

    }
}
