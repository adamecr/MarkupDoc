using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SampleToDocument.delegates
{
    /// <summary>
    /// Namespace for checking the delegate documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Delegate with attribute
    /// </summary>
    /// <param name="i">Regular parameter</param>
    /// <param name="d">Parameter with attributes</param>
    /// <returns>Some value</returns>
    [Category("Delegate")]
    delegate int TestDelegate1(int i, [Category("a")] [Browsable(false)] double d);
    /// <summary>
    /// Generic delegate
    /// </summary>
    /// <typeparam name="T">Delegate type parameter</typeparam>
    /// <param name="value">Some value of <typeparamref name="T"/></param>
    /// <returns>Bool value</returns>
    public delegate bool TestDelegate2<T>(T value);
    /// <summary>
    /// Void delegate
    /// </summary>
    delegate void TestDelegate3(int x);
    /// <summary>
    /// Generic delegate with constraint
    /// </summary>
    /// <typeparam name="T">Type parameter having the constraint new()</typeparam>
    /// <param name="value">Some value of <typeparamref name="T"/></param>
    /// <returns>Bool value</returns>
    delegate bool TestDelegate4<T>(T value) where T : new();
    /// <summary>
    /// Generic delegate with multiple type parameters
    /// </summary>
    /// <typeparam name="T">Type parameter with attribute and constraint T:new()</typeparam>
    /// <typeparam name="U">Type parameter with variance (out) and constraint U:<see cref="Attribute"/></typeparam>
    /// <param name="value">Some value of <typeparamref name="T"/></param>
    /// <returns>Bool value</returns>
    delegate bool TestDelegate5<[Category("a")] T, out U>(T value) where T : new() where U : Attribute;
    /// <summary>
    /// Delegate returning <see cref="Nullable{Boolean}"/>, resp. <see cref="Boolean?"/>
    /// </summary>
    delegate bool? TestDelegate6(int x);
    /// <summary>
    /// Delegate returning <see cref="TestDelegate2{T}"/> with "static" type parameter
    /// </summary>
    delegate TestDelegate2<string> TestDelegate7(int x);
    /// <summary>
    /// Generic delegate returning <see cref="TestDelegate2{T}"/> with generic type parameter
    /// </summary>
    delegate TestDelegate2<T> TestDelegate8<T>(int x);
    /// <summary>
    /// Delegate having the optional parameter
    /// </summary>
    /// <param name="x">Parameter with default value</param>
    delegate void TestDelegate9(int x = 0);
    /// <summary>
    /// Delegate with <c>params</c> parameter array
    /// </summary>
    /// <param name="a">Parameter array</param>
    delegate void TestDelegateA(int x, params byte[] a);
    /// <summary>
    /// Delegate with out parameter
    /// </summary>
    /// <param name="a">Parameter with <c>out</c> modifier</param>
    delegate void TestDelegateB(int x, out byte[] a);
    /// <summary>
    /// Delegate with ref parameter
    /// </summary>
    /// <param name="a">Parameter with <c>ref</c> modifier</param>
    delegate void TestDelegateC(int x, ref byte[] a);

    /// <summary>
    /// Delegate without parameters
    /// </summary>
    delegate void TestDelegateD();

    /// <summary>
    /// Class containing the delegates
    /// </summary>
    public class TestDelegateInClass
    {
        /// <summary>
        /// Simple delegated
        /// </summary>
        /// <param name="i">Int parameter</param>
        /// <param name="d"><see cref="Double"/> parameter</param>
        /// <returns><see cref="int"/> value</returns>
        delegate int TestDelegate1(int i, double d);
        /// <summary>
        /// Public generic delegate with variance
        /// </summary>
        /// <typeparam name="T">Type parameter with <c>in</c> variance</typeparam>
        public delegate bool TestDelegate2<in T>(T value);
        /// <summary>
        /// Another simple delegated
        /// </summary>
        delegate void TestDelegate3(int x);
        /// <summary>
        /// Internal generic delegate
        /// </summary>
        /// <typeparam name="T">Type parameter with constraint</typeparam>
        internal delegate bool TestDelegate4<T>(T value) where T : new();
        /// <summary>
        /// Generic delegate - bit complex one
        /// </summary>
        /// <typeparam name="T">Type parameter with <c>in</c> variance, attributes and constraint</typeparam>
        /// <typeparam name="U">Type parameter with <c>out</c> variance and constraint</typeparam>
        /// <param name="value">Value with the attribute</param>
        delegate bool TestDelegate5<[Category("a")][Browsable(false)]in T, out U>([XmlAnyAttribute] T value) where T : new() where U : Attribute;
        /// <summary>
        /// Protected delegate
        /// </summary>
        protected delegate bool? TestDelegate6(int x);
        /// <summary>
        /// Delegate returning the generic delegate
        /// </summary>
        delegate TestDelegate2<string> TestDelegate7(int x);
        /// <summary>
        /// Generic delegate returning the generic delegate
        /// </summary>
        delegate TestDelegate2<T> TestDelegate8<T>(int x);
    }

    /// <summary>
    /// Another class containing the delegates
    /// </summary>
    public class TestDelegateInClass2 : TestDelegateInClass
    {
        /// <summary>
        /// Public generic delegate with new
        /// </summary>
        public new delegate bool TestDelegate2<in T>(T value);
        /// <summary>
        /// Internal generic delegate with new
        /// </summary>
        internal new delegate bool TestDelegate4<in T>(T value) where T : new();
        /// <summary>
        /// Protected delegate with new
        /// </summary>
        protected new delegate bool? TestDelegate6(int x);
    }


}
