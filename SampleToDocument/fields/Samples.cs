using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SampleToDocument.fields
{
    /// <summary>
    /// Namespace for checking the field documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Class containing bunch of the fields
    /// </summary>
    public class FieldContainer1
    {
        /// <summary>
        /// Test string field with example documentation comment
        /// </summary>
        /// <remarks>The field is here just for testing</remarks>
        /// <value>Value has no meaning here, it's just to test the output</value>
        /// <example>
        /// So assign it to something like
        /// <code>
        ///   Field1="abcd";
        ///  </code>
        /// or even
        /// <code>
        ///   var a="abcd";
        ///  Field1=a;
        /// </code>
        /// </example>
        public string Field1;
        /// <summary>
        /// Constant field with default value
        /// </summary>
        public const string Field2A = "testval";
        /// <summary>
        /// Field with default value - this is not a constant!
        /// </summary>
        public string Field2B = "testval";

        /// <summary>
        /// Simple field
        /// </summary>
        public int Field3;
        /// <summary>
        /// Field of int?
        /// </summary>
        public int? Field4;
        /// <summary>
        /// Generic field
        /// </summary>
        protected List<string> Field5;
        /// <summary>
        /// Generic field with default value 
        /// </summary>
        protected List<string> Field6 = new List<string>();

        /// <summary>
        /// Static field with attribute
        /// </summary>
        [Category("aaaa")]
        public static int Field7;
        /// <summary>
        /// read only field with multiple attributes
        /// </summary>
        [Category("aaaa")]
        [Browsable(false)]
        public readonly int Field8;
        /// <summary>
        /// Int constant
        /// </summary>
        public const int Field9 = 9;
        /// <summary>
        /// Static readonly field
        /// </summary>
        public static readonly int FieldA;

        /// <summary>
        /// Protected volatile field
        /// </summary>
        protected volatile int FieldB;
        /// <summary>
        /// Private static readonly field
        /// </summary>
        private static readonly int FieldC = 4;
        /// <summary>
        /// Public static field with default value 
        /// </summary>
        public static int FieldD = 5;
        /// <summary>
        /// Public static field with default value 
        /// </summary>
        public static int? FieldE = null;
        /// <summary>
        /// Constant field with null value
        /// </summary>
        public const string FieldF = null;
        /// <summary>
        /// Constant field with "xyz" value
        /// </summary>
        public const string FieldG = "xyz";
        /// <summary>
        /// Constant field with <c>default</c> value
        /// </summary>
        public const string FieldH = default;
        /// <summary>
        /// Constant field with null value
        /// </summary>
        public const Attribute FieldI = null;
        /// <summary>
        /// Constant field with <c>default</c> value
        /// </summary>
        public const Attribute FieldJ = default;
        /// <summary>
        /// Constant field with <c>default</c> value
        /// </summary>
        public const int FieldK = default;
        /// <summary>
        /// Constant field with value -1
        /// </summary>
        public const int FieldL = -1;
        /// <summary>
        /// Constant field with <c>default</c> value
        /// </summary>
        public const double FieldM = default;
        /// <summary>
        /// Constant field with value 0
        /// </summary>
        public const double FieldN = 0;
        /// <summary>
        /// Constant field with value -0d
        /// </summary>
        public const double FieldO = -0d;
        /// <summary>
        /// Constant field with value 4.0
        /// </summary>
        public const double FieldP = 4.0;
        /// <summary>
        /// Constant field with value 1.50E-15
        /// </summary>
        public const double FieldQ = 1.50E-15;
    }

    /// <summary>
    /// Class containing the fields with bit more complex types
    /// </summary>
    public class FieldContainer2 : FieldContainer1
    {
        /// <summary>
        /// Field with new
        /// </summary>
        public new int Field3;
        /// <summary>
        /// Constant field with new
        /// </summary>
        public new const double FieldQ = 1;
        /// <summary>
        /// Simple field
        /// </summary>
        public int FieldE2;
        /// <summary>
        /// Array field
        /// </summary>
        public string[] FieldFf;
        /// <summary>
        /// Array of arrays field
        /// </summary>
        public string[][] FieldFf2;
        /// <summary>
        /// Multi-array field
        /// </summary>
        public string[,] FieldFf3;
        /// <summary>
        /// Array of <see cref="FieldContainer1"/>. Should have <c>new</c>, but it's not in source code
        /// </summary>
        public FieldContainer1[] FieldG;
        /// <summary>
        /// Array of generic field
        /// </summary>
        public List<string>[] FieldFf4;
        /// <summary>
        /// Tuple field
        /// </summary>
        public (int, string) FieldFf5;
        /// <summary>
        /// Tuple having array field
        /// </summary>
        public (int, string[]) FieldFf6;
        /// <summary>
        /// Tuple having array field
        /// </summary>
        public (int, FieldContainer1[]) FieldFf7;
        /// <summary>
        /// Array of tuples field
        /// </summary>
        public (int, FieldContainer1[])[] FieldFf8;
    }

    /// <summary>
    /// Generic class containing the fields
    /// </summary>
    /// <typeparam name="U">Some type parameter</typeparam>
    /// <typeparam name="V">Another type parameter</typeparam>
    public class FieldContainer3<U, V>
    {
        /// <summary>
        /// Type parameter field
        /// </summary>
        public V Field1;
        /// <summary>
        /// Type parameter array field
        /// </summary>
        public U[] Field2;
        /// <summary>
        /// Generic list field
        /// </summary>
        public List<U> Field3;
        /// <summary>
        /// Array of generic list field
        /// </summary>
        public List<U>[] Field4;
        /// <summary>
        /// Bit more complex field type
        /// </summary>
        public List<FieldContainer1[]>[] Field5;
        /// <summary>
        /// Even more complex field type
        /// </summary>
        public FieldContainer3<FieldContainer1[], List<U>>[] Field6;
    }

    /// <summary>
    /// Generic class containing the tuple fields
    /// </summary>
    public class FieldContainer4<U, V>
    {
        public (int, V) Field1;
        protected (int, U[]) Field2;
        private (int, List<U>) Field3;
        internal (int, List<U>[]) Field4;
        private protected (int, List<FieldContainer1[]>[]) Field5;
        protected internal (int, FieldContainer3<FieldContainer1[], List<U>>[]) Field6;
        public (int, List<U>[])[] Field7;
        public (int, (double, float), (int, List<U>[])[])[] Field8;
    }

    /// <summary>
    /// Class containing the tuple fields
    /// </summary>
    public class FieldContainer5
    {
        public (int A, string B) Field1;
        public (int, string[] B) Field2;
        public (int A, (double B1, float B2) B, (int C1, List<string>[] C2)[] C) Field3;
    }

}
