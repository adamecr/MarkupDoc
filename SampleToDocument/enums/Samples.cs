using System.ComponentModel;


namespace SampleToDocument.enums
{
    /// <summary>
    /// Namespace for checking the enum documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Test enum of integers (default)
    /// </summary>
    public enum TestEnum1
    {
        /// <summary>
        /// Red value
        /// </summary>
        Red,
        /// <summary>
        /// Green value
        /// </summary>
        Green,
        /// <summary>
        /// Blue value
        /// </summary>
        Blue
    }

    /// <summary>
    /// Test enum of longs (explicit)
    /// </summary>
    /// <remarks>This enum has a <see cref="CategoryAttribute"/></remarks>
    [Category("Enum")]
    internal enum TestEnum2 : long
    {
        /// <summary>
        /// Red value
        /// </summary>
        /// <value>Something is red</value>
        Red,
        /// <summary>
        /// Green value =4
        /// </summary>
        /// <remarks>This enum member has a <see cref="CategoryAttribute"/></remarks>
        /// <value>Something is green</value>
        [Category("EnumItem")]
        Green = 4,
        /// <summary>
        /// Blue value
        /// </summary>
        /// <value>Something is blue</value>
        Blue,
        /// <summary>
        /// Rot value =Red
        /// </summary>
        /// <remarks>It doesn't matter whether it will use <see cref="Red"/> or <see cref="Rot"/></remarks>
        /// <example>
        /// So assign it to something like
        /// <code>
        ///   TestEnum2 a=TestEnum2.Rot;
        /// </code>
        /// </example>
        /// <value>Actually the same value as red</value>
        Rot = Red
    }

    /// <summary>
    /// This is just the container for the nested enums
    /// </summary>
    public class EnumContainer
    {
        /// <summary>
        /// The private nested enum
        /// </summary>
        private enum TestEnum3
        {
            Item1,
            Item2,
        }

        /// <summary>
        /// The protected nested enum
        /// </summary>
        protected enum TestEnum4
        {
            Item1,
            Item2,
        }

    }

    /// <summary>
    /// This is just another container for the nested enums
    /// </summary>
    public class EnumContainer2 : EnumContainer
    {
        /// <summary>
        /// The private nested enum
        /// </summary>
        private enum TestEnum3
        {
            Item1,
            Item2
        }

        /// <summary>
        /// The protected nested enum - this one is hiding the <see cref="EnumContainer.TestEnum4"/>
        /// </summary>
        protected new enum TestEnum4
        {
            Item1,
            Item2,
        }
    }
}
