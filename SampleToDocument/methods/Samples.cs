using System;
using System.Collections.Generic;
using System.ComponentModel;
using SampleToDocument.property;

namespace SampleToDocument.methods
{
    /// <summary>
    /// Namespace for checking the methods (incl. events and operators) documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Class with methods with complex params, also having CTOR and destructor
    /// </summary>
    public class TestMethods1
    {
        public const int Ci = 3;
        public enum TestEnum
        {
            First,
            Second,
            Third
        }

        /// <summary>
        /// Some static field
        /// </summary>
        public static int StaticFld;
        /// <summary>
        /// Just some private field
        /// </summary>
        private int x;

        /// <summary>
        /// Protected CTOR
        /// </summary>
        protected TestMethods1() { }
        /// <summary>
        /// CTOR with parameters
        /// </summary>
        /// <param name="c">Parameter with default value (null)</param>
        public TestMethods1(int a, string b, string c = null) { }

        /// <summary>
        /// Static CTOR
        /// </summary>
        static TestMethods1() { StaticFld = 1; }
        /// <summary>
        /// Destructor
        /// </summary>
        ~TestMethods1() { var a = 1; }

        /// <summary>
        /// Generic method with different kind of parameters
        /// </summary>
        /// <typeparam name="T">Type parameter with attribute and constraints</typeparam>
        /// <param name="i0">Parameter with <c>in</c> modifier</param>
        /// <param name="i">Parameter with <c>ref</c> modifier</param>
        /// <param name="io">Parameter with <c>out</c> modifier</param>
        /// <param name="rio">Parameter with <c>ref</c> modifier and attribute</param>
        /// <param name="d">Parameter with multiple attributes</param>
        /// <param name="b">Parameter with default value (false)</param>
        /// <param name="n">Parameter with default value (false)</param>
        /// <param name="s">Parameter with default value ("Hello") and attribute</param>
        /// <param name="o">Parameter with default value (null)</param>
        /// <param name="t">Generic parameter with default value (<c>default(T)</c>)</param>
        /// <param name="a">Array parameter (params)</param>
        public void Method1<[Category("a")] T>(
            in int i0,
            ref int i,
            out int io,
            [Category("cat")] ref int rio,
            [Category("cat")] [Browsable(false)] decimal d,
            bool b = false,
            bool? n = false,
            [Browsable(true)] string s = "Hello",
            object o = null,
            T t = default(T),
            params int[] a
        ) where T : class, new()
        {
            io = 5;
        }



        /// <summary>
        /// Generic method with different kind of parameters with default values
        /// </summary>
        /// <typeparam name="T">Type parameter</typeparam>
        /// <param name="i">Parameter with default value -5</param>
        /// <param name="d1">Parameter with default value 5.456d</param>
        /// <param name="d2">Parameter with default value -5.456d</param>
        /// <param name="m">Parameter with default value 234.5678m</param>
        /// <param name="f">Parameter with default value -345.67f</param>
        /// <param name="i2">Parameter with default value 7</param>
        /// <param name="i3">Parameter with default value Ci * 5</param>
        /// <param name="b">Parameter with default value false</param>
        /// <param name="n">Parameter with default value null</param>
        /// <param name="s">Parameter with default value "Hello"</param>
        /// <param name="e">Parameter with default value TestEnum.Second</param>
        /// <param name="me">Parameter with default value <c>default(TestMethods1)</c></param>
        /// <param name="o">Parameter with default value null</param>
        /// <param name="o2">Parameter with default value <c>default(List&lt;T&gt;)</c></param>
        /// <param name="l">Parameter with default value <c>default(List&lt;T&gt;)</c></param>
        /// <param name="t">Parameter with default value <c>default(T)</c></param>
        public void Method2<T>(
            int i = -5,
            double d1 = 5.456d,
            double d2 = -5.456d,
            decimal m = 234.5678m,
            float f = -345.67f,
            int i2 = 7,
            int i3 = Ci * 5,
            bool b = false,
            bool? n = null,
            string s = "Hello",
            TestEnum e = TestEnum.Second,
            TestMethods1 me = default(TestMethods1),
            object o = null,
            object o2 = default(List<T>),
            List<T> l = default(List<T>),
            T t = default(T)

        )
        { }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="a">Param with <c>in</c> modifier</param>
        /// <returns></returns>
        public int this[in int a] => 0;

        /// <summary>
        /// Method with <c>ref readonly</c> return type
        /// </summary>
        public ref readonly int Method3() { return ref x; }
        /// <summary>
        /// Method with <c>ref </c> return type
        /// </summary>
        public ref int Method4() { return ref x; }


        /// <summary>
        /// Simple method to check hiding in <see cref="TestMethods2"/>
        /// </summary>
        public void Method5() { }
        /// <summary>
        /// Simple field to check hiding in <see cref="TestMethods2"/>
        /// </summary>
        public string Field5;
        /// <summary>
        /// Simple property to check hiding in <see cref="TestMethods2"/>
        /// </summary>
        public int Property5 { get; }
    }

    /// <summary>
    /// Class to check hiding (new keyword)
    /// </summary>
    public class TestMethods2 : TestMethods1
    {
        /// <summary>
        /// Simple method with hide
        /// </summary>
        public new void Method5() { }
        /// <summary>
        /// Simple field with hide
        /// </summary>
        public new string Field5;
        /// <summary>
        /// Simple property with hide
        /// </summary>
        public new int Property5 { get; set; }
    }

    /// <summary>
    /// Extensions class for <see cref="TestMethods2"/>
    /// </summary>
    public static class TestMethods2Ext
    {
        /// <summary>
        /// Extension method for <see cref="TestMethods2"/>
        /// </summary>
        /// <param name="this">Param with <c>@this</c> name</param>
        public static int ExtensionMethod1(this TestMethods2 @this) { return 0; }
        /// <summary>
        /// Extension method for <see cref="TestMethods2"/>
        /// </summary>

        public static int ExtensionMethod2(this TestMethods2 e1, int i1) { return 0; }
    }

    /// <summary>
    /// Class containing the events with different types of event handler delegates
    /// </summary>
    public class TestEvents1
    {
        public delegate void Event2EventHandler(object sender, EventArgs e);
        public delegate void Event3Handler<in TEventArgs>(object sender, TEventArgs e);
        public delegate void Event4Handler();
        protected delegate int Event5Handler();

        public event EventHandler Event1;
        public event Event2EventHandler Event2;
        public event Event3Handler<EventArgs> Event3;
        protected event Event4Handler Event4;
        private event Event5Handler Event5;
        protected virtual event Event5Handler Event6;
    }

    /// <summary>
    /// Abstract class containing the events
    /// </summary>
    public abstract class TestEvents2
    {
        /// <summary>
        /// Protected delegate
        /// </summary>
        protected delegate void Event4Handler();
        /// <summary>
        /// Internal abstract event
        /// </summary>
        internal abstract event EventHandler Event1;
        /// <summary>
        /// Protected abstract event
        /// </summary>
        protected abstract event EventHandler Event2;
        /// <summary>
        /// Protected virtual event
        /// </summary>
        protected virtual event EventHandler Event3;
        /// <summary>
        /// Protected event
        /// </summary>
        protected event Event4Handler Event4;
        /// <summary>
        /// Protected static event
        /// </summary>
        protected static event EventHandler Event5;
    }

    /// <summary>
    /// Class containing the events, inheriting <see cref="TestEvents2"/>
    /// </summary>
    public abstract class TestEvents3 : TestEvents2
    {
        /// <summary>
        /// Override of abstract event. Custom accessors (add and remove)
        /// </summary>
        internal override event EventHandler Event1
        {
            add { }
            remove { }
        }
        /// <summary>
        /// Override of abstract event
        /// </summary>
        protected override event EventHandler Event2;
        /// <summary>
        /// Override of virtual event
        /// </summary>
        protected override event EventHandler Event3;
        /// <summary>
        /// Event with new
        /// </summary>
        protected new event Event4Handler Event4;
    }

    /// <summary>
    /// Class containing the bunch of the operators
    /// </summary>
    public class TestOperators1
    {
        /// <summary>
        /// Plus operator
        /// </summary>
        public static TestOperators1 operator +(TestOperators1 b) { return new TestOperators1(); }
        /// <summary>
        /// Binary minus operator
        /// </summary>
        public static int operator -(TestOperators1 b, int a) { return -1; }
        /// <summary>
        /// Unary minus operator
        /// </summary>
        public static int operator -(TestOperators1 b) { return -1; }
        /// <summary>
        /// "Plus plus" operator
        /// </summary>
        public static TestOperators1 operator ++(TestOperators1 a) { return new TestOperators1(); }
        /// <summary>
        /// Equal operator
        /// </summary>
        public static bool operator ==(TestOperators1 a, TestOperators1 b) { return true; }
        /// <summary>
        /// Not equal operator
        /// </summary>
        public static bool operator !=(TestOperators1 a, TestOperators1 b) { return true; }
        /// <summary>
        /// Greater of equal operator
        /// </summary>
        public static bool operator >=(TestOperators1 a, int b) { return true; }
        /// <summary>
        /// Less or equal operator
        /// </summary>
        public static bool operator <=(TestOperators1 a, int b) { return true; }

        /// <summary>
        /// Equal operator with different signature
        /// </summary>
        public static int operator ==(TestOperators1 a, int b) { return 1; }
        /// <summary>
        /// Not equal operator with different signature
        /// </summary>
        public static int operator !=(TestOperators1 a, int b) { return 1; }

        /// <summary>
        /// Binary OR operator
        /// </summary>
        public static TestOperators1 operator |(TestOperators1 a, TestOperators1 b) { return new TestOperators1(); }

        /// <summary>
        /// True operator
        /// </summary>
        public static bool operator true(TestOperators1 a) { return true; }
        /// <summary>
        /// False operator
        /// </summary>
        public static bool operator false(TestOperators1 a) { return false; }

        /// <summary>
        /// Implicit conversion <see cref="Boolean"/> to <see cref="TestOperators1"/>
        /// </summary>
        public static implicit operator TestOperators1(bool x) { return new TestOperators1(); }
        /// <summary>
        /// Explicit conversion <see cref="TestOperators1"/> to <see cref="Boolean"/>
        /// </summary>
        public static explicit operator bool(TestOperators1 x) { return false; }
        /// <summary>
        /// Explicit conversion <see cref="TestOperators1"/> to <see cref="int"/>
        /// </summary>
        public static explicit operator int(TestOperators1 x) { return 1; }
        /// <summary>
        /// Explicit conversion <see cref="TestOperators1"/> to <see cref="List{T}"/>
        /// </summary>
        public static explicit operator List<string>(TestOperators1 x) { return new List<string>(); }
        /// <summary>
        /// Explicit conversion <see cref="TestOperators1"/> to <see cref="List{T}"/>
        /// </summary>
        public static explicit operator List<int>(TestOperators1 x) { return new List<int>(); }
        /// <summary>
        /// Implicit conversion <see cref="TestOperators1"/> to <see cref="Char"/>
        /// </summary>
        public static implicit operator char(TestOperators1 x) { return 'a'; }
        /// <summary>
        /// Explicit conversion <see cref="TestOperators1"/> to <see cref="Exception"/>
        /// </summary>
        public static explicit operator Exception(TestOperators1 x) { return new Exception(); }
        /// <summary>
        /// Explicit conversion <see cref="Exception"/> to <see cref="TestOperators1"/>
        /// </summary>
        public static explicit operator TestOperators1(Exception x) { return new TestOperators1(); }

        /// <summary>
        /// Property <c>Name</c> - to check the correct links for the "same" name just with different case
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Property <c>NaMe</c> - to check the correct links for the "same" name just with different case
        /// </summary>
        public string NaMe { get; }
        /// <summary>
        /// Method <c>NAme&lt;T&gt;</c> - to check the correct links for the "same" name just with different case
        /// </summary>
        public void NAme<T>() { }
        /// <summary>
        /// Method <c>NamE&lt;T&gt;</c> - to check the correct links for the "same" name just with different case
        /// </summary>
        public void NamE<T>() { }

    }

    /// <summary>
    /// Class to check the cross namespace links
    /// </summary>
    public class TestCrossNs : PropertyContainer1
    {
        /// <inheritdoc />
        public override string Property1 { get; set; }

        /// <summary>
        /// Just try to cross ns link <see cref="PropertyContainer1"/>
        /// </summary>
        /// <exception cref="PropertyContainer1">Well, not an exception, but the link should work</exception>
        /// <seealso cref="PropertyContainer1"/>
        public void Something() { }
    }



}
