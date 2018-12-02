using System;
using System.Collections.Generic;
using System.ComponentModel;
using SampleToDocument.classes.generic.test;

namespace SampleToDocument.classes.generic
{
    /// <summary>
    /// Namespace for checking the generic classes documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Simple generic class
    /// </summary>
    /// <typeparam name="T">Type parameter with constraint class, new()</typeparam>
    public class TestGenClass1<T> where T : class, new()
    {
        /// <summary>
        /// Generic property
        /// </summary>
        public T Prop1 { get; }
        /// <summary>
        /// Virtual generic method
        /// </summary>
        public virtual T GenMethod<T>(T v, string a) { return v; }
        /// <summary>
        /// Virtual method returning generic type
        /// </summary>
        public virtual T GenMethod2(T v, string a) { return v; }
    }
    /// <summary>
    /// Empty generic class
    /// </summary>
    /// <typeparam name="T">Type parameter</typeparam>
    /// <typeparam name="U">Type parameter with custom attributes. Multiple same attributes - 2x w/o param, once with param</typeparam>
    public class TestGenClass2<T, [Test][Test("a")][Test] U> { }
    /// <summary>
    /// Non generic class with the same name as generic one
    /// </summary>
    public class TestGenClass2 { }
    /// <summary>
    /// Empty generic class inheriting from <see cref="TestGenClass2{T,U}"/>
    /// </summary>
    public class TestGenClass2A<T, U> : TestGenClass2<T, U> { }
    /// <summary>
    /// Empty generic class inheriting from <see cref="TestGenClass2{X,Y}"/> using different type parameter names
    /// </summary>
    public class TestGenClass2B<X, Y> : TestGenClass2<X, Y> { }
    /// <summary>
    /// Generic class with multiple constraints
    /// </summary>
    /// <typeparam name="T">Type parameter with struct constraint</typeparam>
    /// <typeparam name="U">Type parameter with Attribute and  new() constraints</typeparam>
    public class TestGenClass3<T, U> where U : Attribute, new() where T : struct
    {
        public T Prop1 { get; }
        public U Prop2 { get; }
        /// <summary>
        /// Simple method
        /// </summary>
        public T GenMethod(T v, string a) { return v; }
        /// <summary>
        /// Generic method with constraints
        /// </summary>
        /// <typeparam name="T">Type parameter with constraint class, new()</typeparam>
        public T GenMethod<T>(T v, string a) where T : class, new() { return v; }

        /// <summary>
        /// Nested class inheriting from <see cref="TestGenClass1{T}"/>
        /// </summary>
        public class TestGenClass3Inner : TestGenClass1<object>
        {
            /// <summary>
            /// Generic methods with constraint
            /// </summary>
            public T GenMethod<T>(T v, bool a) where T : new() { return v; }
            /// <summary>
            /// Override generic method with different type parameter names
            /// </summary>
            public override U GenMethod<U>(U v, string a) { return v; }
            /// <summary>
            /// Override the method where the type parameter is assigned by concrete type (the same as in class inheritance)
            /// </summary>
            public override object GenMethod2(object v, string a) { return v; }
        }
    }
    /// <summary>
    /// Empty generic class inheriting from <see cref="TestGenClass3{T,U}"/> where one type is kept generic with different type name,
    /// the other type is assigned with the concrete type
    /// </summary>
    public class TestGenClass4<X> : TestGenClass3<X, DisplayNameAttribute> where X : struct { }
    /// <summary>
    /// Generic class with simple inheritance
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class TestGenClass5<T, U> : TestGenClass3<T, U> where U : Attribute, new() where T : struct { }
    /// <summary>
    /// Test generic class with two type parameters: <typeparamref name="U"/> and <typeparamref name="V"/>
    /// </summary>
    /// <typeparam name="U">The first type parameter</typeparam>
    /// <typeparam name="V">The second type parameter</typeparam>
    public class TestGenClass6<U, V> { }
    /// <summary>
    /// Internal generic class inheriting from <see cref="TestGenClass6{U,V}"/> with bit complex type parameter assignment
    /// </summary>
    internal class TestGenClass7<T> : TestGenClass6<string, T[]> { }
    /// <summary>
    /// Another internal generic class inheriting from <see cref="TestGenClass6{U,V}"/> with bit complex type parameter assignment
    /// </summary>
    internal class TestGenClass8<T> : TestGenClass6<string, string[]> { }
    /// <summary>
    /// Third internal generic class inheriting from <see cref="TestGenClass6{U,V}"/> with bit complex type parameter assignment
    /// </summary>
    internal class TestGenClass9<T> : TestGenClass6<TestClass5.Test5InnerClass2, TestClass3.TestInnerClass[]> { }
    /// <summary>
    /// Internal generic class with complex constraints
    /// </summary>
    /// <typeparam name="K">Type parameter with constraint IComparable&lt;K&gt;></typeparam>
    /// <typeparam name="V">Type parameter with constraint ICloneable, IEnumerable&lt;K&gt;, new()</typeparam>
    internal class TestGenClass10<K, V> where K : IComparable<K> where V : ICloneable, IEnumerable<K>, new() { }

    namespace test
    {
        /// <summary>
        /// Just the test attribute to used in samples
        /// </summary>
        /// <remarks>Having the attribute with default values</remarks>
        [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
        sealed class TestAttribute : Attribute
        {
            public TestAttribute() { }
            public TestAttribute(string s) { }
        }
    }
}
