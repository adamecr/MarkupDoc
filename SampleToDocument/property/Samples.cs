using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SampleToDocument.property
{
    /// <summary>
    /// Namespace for checking the property documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Class containing bunch of properties. <see cref="Property1"/> has lists and example in comments
    /// </summary>
    public class PropertyContainer1
    {
        /// <summary>
        /// Test <c>string</c> property with complex XML documentation comments
        /// </summary>
        /// <remarks>
        /// The property is here just for testing
        /// <list type="bullet">
        /// <item> <description>Item 1.</description> </item>
        /// <item> <description>Item 2.</description> </item>
        /// </list>
        /// split
        /// <list type="number">
        /// <item> <description>Item 1.</description> </item>
        /// <item> <description>Item 2.</description> </item>
        /// </list>
        /// split
        /// <list type="bullet"> <item> <term>b1</term> <description>Item 1. with link to <see cref="Property5"/></description> </item>
        /// <item> <term>b2</term>    </item>
        /// </list>
        /// <list type="number">
        /// <item> <term>n1</term>    <description>Item 1.</description> </item>
        /// <item> <term>n2</term> <description>Item 2.</description> </item>
        /// </list>
        /// split
        ///  <list type="table">
        /// <item> <description>Item 1.</description> </item>
        /// <item> <description>Item 2.</description> </item>
        /// <item> <term>t3</term> <description>Item 3.</description> </item>
        /// <item> <term>t4</term> </item>     </list>
        /// split
        ///  <list type="table">
        /// <listheader>   <term>term</term>  <description>description</description>  </listheader>
        /// <item> <description>Item 1.</description> </item>
        /// <item> <description>Item 2. with link to <see cref="String"/></description> </item>
        /// <item> <term>t3</term> <description>Item 3.</description> </item>
        /// <item> <term>t4</term> </item>    
        /// </list>
        /// </remarks>
        /// <value>Value has no meaning here, it's just to test the output</value>
        /// <example>
        /// So assign it to something like
        /// <code>
        ///Property1="abcd";
        ///  </code>
        /// or even work with <c>b</c> property.
        ///  Will try something  like <c>if(b>4)
        ///      { b=6;}</c> that should be put inline
        /// <code>
        ///var a="abcd";
        ///Property1=a;
        ///int b=5;
        ///if(b>4)
        ///  { b=6;}
        /// </code>
        /// </example>
        public virtual string Property1 { get; set; }
        /// <summary>
        /// Property with default value
        /// </summary>
        public string Property2 { get; set; } = "testval";
        /// <summary>
        /// Simple property, getter only
        /// </summary>
        public int Property3 { get; }
        /// <summary>
        /// Backing field for <see cref="Property4"/>
        /// </summary>
        private int? property4Fld;
        /// <summary>
        /// Property with setter only and backing field
        /// </summary>
        public int? Property4
        {
            set { property4Fld = value; }
        }
        /// <summary>
        /// Backing field for  <see cref="Property5"/>
        /// </summary>
        private int? property5Fld;
        /// <summary>
        /// Property with setter only and backing field
        /// </summary>
        public int? Property5
        {
            set => property5Fld = value;
        }
        /// <summary>
        /// Protected property with private setter
        /// </summary>
        protected List<string> Property6 { get; private set; }
        /// <summary>
        /// Protected property with private getter and default value
        /// </summary>
        protected List<string> Property7 { private get; set; } = new List<string>();
        /// <summary>
        /// Property with getter only (short notation)
        /// </summary>
        public int Property8 => Property3;
        /// <summary>
        /// Static property with protected setter and attribute
        /// </summary>
        [Category("aaaa")]
        public static int Property9 { get; protected set; }
        /// <summary>
        /// Property with getter only and multiple attributes
        /// </summary>
        [Category("aaaa")]
        [Browsable(false)]
        public int PropertyA { get; }
        /// <summary>
        /// Virtual property
        /// </summary>
        public virtual int PropertyB { get; }


    }

    /// <summary>
    /// Class with properties, inheriting from <see cref="PropertyContainer1"/>
    /// </summary>
    public class PropertyContainer2 : PropertyContainer1
    {
        /// <summary>
        /// Sealed override property
        /// </summary>
        public sealed override string Property1 { get; set; }
        /// <summary>
        /// Property with new
        /// </summary>
        public new int Property3 { get; set; }
        /// <summary>
        /// Override property
        /// </summary>
        public override int PropertyB { get; }
        /// <summary>
        /// Simple property with getter only
        /// </summary>
        public int PropertyC { get; }
    }

    /// <summary>
    /// Another class with properties, inheriting from <see cref="PropertyContainer1"/>
    /// </summary>
    public abstract class PropertyContainer3 : PropertyContainer1
    {
        /// <summary>
        /// Abstract property
        /// </summary>
        public abstract int PropertyG { get; }
    }

    /// <summary>
    /// Basic indexers here
    /// </summary>
    public abstract class PropertyContainer4 : PropertyContainer3
    {
        /// <summary>
        /// Property override
        /// </summary>
        public override int PropertyG { get; }
        /// <summary>
        /// Example of indexer with private setter
        /// </summary>
        /// <param name="i">single parameter</param>
        /// <returns>some value</returns>
        public int this[int i]
        {
            get { return 0; }
            private set { }
        }
        /// <summary>
        /// Abstract indexer with getter only
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public abstract int this[double i] { get; }

        /// <summary>
        /// Example of a bit more complex indexer 
        /// </summary>
        /// <param name="i">the first parameter</param>
        /// <param name="j">the second parameter</param>
        /// <value>the value of indexer is here just to be shown</value>
        /// <returns>some value</returns>
        /// <remarks>It's abstract</remarks>
        public abstract int this[float i, int j] { set; }
    }

    /// <summary>
    /// Generic class containing the properties
    /// </summary>
    /// <typeparam name="T">Type parameter</typeparam>
    /// <typeparam name="U">Type parameter with new() constraint</typeparam>
    public class PropertyContainer5<T, U> where U : new()
    {
        /// <summary>
        /// Generic property with getter only
        /// </summary>
        public T Property1 { get; }
        /// <summary>
        /// Generic property
        /// </summary>
        public U Property2 { get; set; }

        /// <summary>
        /// Array property with getter only
        /// </summary>
        public int[] Property3 { get; }
        /// <summary>
        /// Object array property with getter only
        /// </summary>
        public PropertyContainer4[] Property4 { get; }
        /// <summary>
        /// Generic array property with getter only
        /// </summary>
        public T[] Property5 { get; }
        /// <summary>
        /// Tuple with generics property
        /// </summary>
        public (T, U) Property6 { get; }
        /// <summary>
        /// Tuple property
        /// </summary>
        public (int, string) Property7 { get; set; }
        /// <summary>
        /// Another tuple property
        /// </summary>
        public (int, string[]) Property8 { get; set; }
        /// <summary>
        /// Another tuple property
        /// </summary>
        public (int, PropertyContainer4[]) Property9 { get; set; }
        /// <summary>
        /// Tuple with generic array property
        /// </summary>
        public (int, T[]) PropertyA { get; set; }

        /// <summary>
        /// Indexer returning generic type
        /// </summary>
        /// <param name="i">Parameter with <c>in</c> variance</param>
        /// <returns></returns>
        public U this[in int i] => new U();
        /// <summary>
        /// Generic indexer
        /// </summary>
        public U this[T t] => new U();
        /// <summary>
        /// Indexer returning tuple 
        /// </summary>
        public (U, string) this[double i] => (new U(), "A");
        /// <summary>
        /// Indexer returning tuple - bit different signature
        /// </summary>
        public (U, string) this[float i] => (new U(), "A");
        /// <summary>
        /// Indexer returning tuple with named fields
        /// </summary>
        public (U nam1, string nam2) this[byte i] => (new U(), "A");
        /// <summary>
        /// Indexer returning tuple with named fields, param with attribute
        /// </summary>
        public (U nam1, string nam2, U[]) this[byte i, [Category("aaa")] byte j] => (new U(), "A", null);
        /// <summary>
        /// Indexer
        /// </summary>
        public (U, string[]) this[double[] i] => (new U(), new[] { "A" });
        /// <summary>
        /// Complicated one
        /// </summary>
        public (U, string[][]) this[(U, T tKey)[,] i, (int, byte) tup] => (new U(), new[] { new[] { "A" } });
    }
}