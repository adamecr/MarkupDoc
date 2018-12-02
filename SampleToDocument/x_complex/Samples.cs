using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Sample2;

namespace SampleToDocument.x_complex
{
    /// <summary>
    /// A bit more samples
    /// </summary>
    /// <remarks>Add something more if you want</remarks>
    /// <seealso cref="Dummy">Dummy class is here</seealso>
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    internal class NamespaceDoc { }

    /// <summary>
    /// Dummy class with the mixture of members
    /// </summary>
    /// <remarks>
    /// There is nothing real about the class, just need something to check the correct generation
    /// and output of documentation.
    /// <para>And to be able to write the comments somewhere</para>
    /// </remarks>
    public class Dummy
    {
        /// <summary>
        /// This is the property with getter and setter
        /// </summary>
        public string Aa { get; set; }
        /// <summary>
        /// This is the <see cref="String"/> field
        /// </summary>
        public string Ab;
        /// <summary>
        /// Overrides the <see cref="Object.ToString"/> method
        /// </summary>
        /// <returns>Returns <see cref="Ab"/> field</returns>
        public override string ToString()
        {
            return Ab;
        }
        /// <summary>
        /// This is totally empty method
        /// </summary>
        /// <remarks>No parameters, <see cref="Void"/> return type</remarks>
        public void C() { }
        /// <summary>
        /// This is also an empty method, but it's virtual
        /// </summary>
        /// <example>
        /// It's possible to override this method in child class
        /// <code>
        /// public class A:Dummy{
        ///   public override void D(){
        ///     //do something here
        ///   }
        /// }
        /// </code>
        /// <para>The overriding is quite simple, isn't it?</para>
        /// </example>
        /// <exception cref="Exception">Exception may be thrown if something is wrong</exception>
        /// <exception cref="Exception">Well, can't be thrown twice, but can be documented twice. </exception>
        public virtual void D() { }
        /// <summary>
        /// <see cref="RefClass"/> is in another assembly
        /// </summary>
        /// <returns></returns>
        public RefClass E { get; }
        /// <summary>
        /// Simple async method
        /// </summary>
        /// <returns>Returning the <see cref="Task"/></returns>
        public async Task MethodAsync()
        {
            await Task.Delay(1);
        }
        /// <summary>
        /// Async method with a bit more complicated signature
        /// </summary>
        /// <typeparam name="T">Type parameter with constraint <see cref="struct"/> (actually, this reference should not generate the link)</typeparam>
        /// <param name="i">Parameter with attribute</param>
        /// <returns>Async <see cref="Task{Int32}"/></returns>
        public async Task<int> FunctionAsync<[Category("a")] T>([Category("a")] int i) where T : struct
        {
            await Task.Delay(1);
            return i;
        }
    }

    /// <summary>
    /// Some interface
    /// </summary>
    public interface IDummy1
    {
        /// <summary>
        /// Property with getter
        /// </summary>
        string Prop1 { get; }
        /// <summary>
        /// Property with getter and setter
        /// </summary>
        string Prop2 { get; set; }
        /// <summary>
        /// Method w/o parameters
        /// </summary>
        /// <returns>Some string</returns>
        string Met1();
    }

    /// <summary>
    /// Another interface
    /// </summary>
    public interface IDummy2
    {
        /// <summary>
        /// Very simple method
        /// </summary>
        string Met2();
    }
    /// <summary>
    /// An empty interface
    /// </summary>
    public interface IDummy3 { }
    /// <summary>
    /// Void returning public delegate within the namespace
    /// </summary>
    /// <param name="p1">Should have some parameter</param>
    public delegate void NsDelegate1(string p1);
    /// <summary>
    /// Namespace level delegate without explicit access modifier
    /// </summary>
    delegate string NsDelegate2(string p1);

    /// <summary>
    /// Another test class.
    /// This one inherits from <see cref="Dummy"/>
    /// </summary>
    public class Dummy2 : Dummy
    {
        /// <summary>
        /// Class level delegate, looks like event handler
        /// </summary>
        /// <param name="sender">Object raising the event</param>
        /// <param name="e">Event arguments</param>
        /// <returns>Some string</returns>
        public delegate string Dummy2Delegate(object sender, EventArgs e);
        /// <summary>
        /// Private class level delegate.
        /// </summary>
        /// <remarks>
        ///  It can be also used as the event handler, even if not implementing a common signature pattern
        /// </remarks>
        /// <seealso cref="Dummy2.Evt"/>
        private delegate string NsDelegate3(string p1);

        /// <summary>
        /// Just and event using the namespace level handler delegate
        /// </summary>
        public event NsDelegate1 Evt1;
        /// <summary>
        /// Event using the class level handler delegate
        /// </summary>
        public event Dummy2Delegate Evt;

        /// <summary>
        /// Property with getter
        /// </summary>
        public string Bb { get; }
        /// <summary>
        /// Very empty method, should have new modifier, but has none
        /// </summary>
        public void E() { }
        /// <summary>
        /// Method override
        /// </summary>
        public override void D() { }
    }

    /// <summary>
    /// Simple enum
    /// </summary>
    public enum DummyEnum1
    {
        /// <summary>
        /// Value A
        /// </summary>
        A,
        B,
        /// <summary>
        /// Value C
        /// </summary>
        C
    }

    /// <summary>
    /// Structure with events, property and method
    /// </summary>
    public struct DummyStruct
    {
        /// <summary>
        /// Just and event using the namespace level handler delegate
        /// </summary>
        public event NsDelegate1 Evt1;
        /// <summary>
        /// Event using the class level handler delegate from another type (class)
        /// </summary>
        public event Dummy2.Dummy2Delegate Evt;
        /// <summary>
        /// Property
        /// </summary>
        public string Bb { get; }
        /// <summary>
        /// Methods
        /// </summary>
        public void E() { }
    }

    /// <summary>
    /// Some struct
    /// </summary>
    /// <remarks>with remarks</remarks>
    public struct DummyStruct2
    {
        /// <summary>
        /// The first field
        /// </summary>
        public string A;
        /// <summary>
        /// The second field
        /// </summary>
        /// <remarks>It does nothing, but can be
        /// <para>simply</para>
        /// documented</remarks>
        /// <seealso cref="A">this also does nothing</seealso>
        public int B;
    }

    /// <summary>
    /// The class having a lot of attributes and some nested members
    /// </summary>
    [Category("cat")]
    [Serializable]
    [Browsable(false)]
    [TypeConverter(typeof(string))]
    [Bindable(BindableSupport.Yes, BindingDirection.TwoWay)]
    public class Dummy3 : Dummy, IDummy3
    {
        /// <summary>
        /// Nested enum
        /// </summary>
        public enum Dummy3InnerEnum1
        {
            X,
            Y,
            Z
        }
        /// <summary>
        /// Nested interface
        /// </summary>
        public interface IInnerDummy3
        {
            string Met2();
        }
        /// <summary>
        /// Nested empty class
        /// </summary>
        public class InnerDummy31 { }
        /// <summary>
        /// Nested class inheriting from <see cref="Dummy2"/>
        /// </summary>
        public class InnerDummy32 : Dummy2 { }
        /// <summary>
        /// Nested class implementing the <see cref="IDummy1">interface IDummy1</see>
        /// </summary>
        public class InnerDummy33 : IDummy1
        {
            /// <summary>
            /// Implements the <see cref="IDummy1.Prop2"/>
            /// </summary>
            public string Prop1 { get; }
            /// <summary>
            /// Implements the <see cref="IDummy1.Prop2">Prop2</see>
            /// </summary>
            public string Prop2 { get; set; }
            /// <summary>
            /// Implements the interface method <see cref="IDummy1.Met1"/>
            /// </summary>
            public string Met1() { return null; }
            /// <summary>
            /// Nested class in nested class
            /// </summary>
            public class DoubleInnerDummy33 { }
        }

        /// <summary>
        /// Nested class inheriting from <see cref="Dummy"/> and implementing two interfaces
        /// </summary>
        public class InnerDummy34 : Dummy, IDummy1, IDummy2
        {
            public string Met2() { throw new NotImplementedException(); }
            public string Prop1 { get; }
            public string Prop2 { get; set; }
            public string Met1() { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Nested class implementing two interfaces with method having the same signature, so the explicit implementation needs to be used
        /// </summary>
        public class InnerDummy35 : IDummy2, IInnerDummy3
        {
            /// <summary>
            /// Implementation of <see cref="IDummy2.Met2"/>
            /// </summary>
            /// <returns>Should return some string</returns>
            string IDummy2.Met2() { throw new NotImplementedException(); }
            /// <summary>
            /// Implementation of <see cref="IInnerDummy3.Met2"/>
            /// </summary>
            string IInnerDummy3.Met2() { throw new NotImplementedException(); }
        }
    }

    /// <summary>
    /// Generic class
    /// </summary>
    /// <typeparam name="T">Single type parameter</typeparam>
    public class DummyGen1<T>
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
        /// Virtual method with generic parameter and return value
        /// </summary>
        public virtual T GenMethod2(T v, string a) { return v; }
    }

    /// <summary>
    /// Class with generic method
    /// </summary>
    public class DummyGen2
    {
        /// <summary>
        /// Generic method
        /// </summary>
        /// <typeparam name="T">Simple type parameter</typeparam>
        /// <param name="v">Parameter of <typeparamref name="T"/></param>
        /// <param name="a"><see cref="String"/> parameter</param>
        /// <returns>Some value of <typeparamref name="T"/></returns>
        public T GenMethod<T>(T v, string a) { return v; }
    }

    /// <summary>
    /// Generic class with nested class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="U"></typeparam>
    public class DummyGen3<T, U> where U : Attribute, new() where T : struct
    {
        public T Prop1 { get; }
        public U Prop2 { get; }

        public T GenMethod(T v, string a) { return v; }
        public T GenMethod<T>(T v, string a) { return v; }

        /// <summary>
        /// Nested class inheriting from generic class
        /// </summary>
        public class DummyGen4 : DummyGen1<string>
        {
            /// <summary>
            /// Generic method with type param constraint
            /// </summary>
            /// <typeparam name="T">Type parameter with constraint new()</typeparam>
            /// <param name="v">Parameter of type <typeparamref name="T"/></param>
            /// <param name="a"><see cref="Boolean"/> parameter</param>
            /// <returns></returns>
            public T GenMethod<T>(T v, bool a) where T : new() { return v; }

            /// <summary>
            /// Override generic method
            /// </summary>
            public override U GenMethod<U>(U v, string a) { return v; }
            /// <summary>
            /// Overrides generic method with concrete type
            /// </summary>
            public override string GenMethod2(string v, string a) { return v; }
        }
    }

    /// <summary>
    /// Generic class sample
    /// </summary>
    public class DummyGen4<X> : DummyGen3<X, DisplayNameAttribute> where X : struct { }
    /// <summary>
    /// Generic class with two type parameters having constraints. Inheriting from <see cref="DummyGen3{T,U}"/>
    /// </summary>
    /// <typeparam name="T">Type parameter with constraint struct</typeparam>
    /// <typeparam name="U">Type parameter with constraints Attribute, new ()</typeparam>
    public class DummyGen5<T, U> : DummyGen3<T, U> where U : Attribute, new() where T : struct { }

    /// <summary>
    /// Dummy class for testing
    /// It just do nothing, but contains <see cref="string"/> constants and <see cref="DummyLib2"/> fields
    /// <para>but no <see cref="List{T}"/> is used at all</para>
    /// <seealso cref="DummyLib2"/>
    /// <seealso cref="string.Clone"/>
    /// </summary>
    /// <remarks>
    /// Also some remarks are there, you can go to <see cref="FieldD"/>
    /// </remarks>
    /// <example> 
    /// This sample shows how to call the <see cref="GetZero"/> method.
    /// <code>
    /// class TestClass 
    /// {
    ///     static int Main() 
    ///     {
    ///         return GetZero();
    ///     }
    /// }
    /// </code>
    /// </example>
    public class DummyLib
    {
        /// <summary>
        /// Public const "ttttt"
        /// </summary>
        public const string StringCons = "ttttt";
        /// <summary>
        /// Private const =12
        /// </summary>
        private const int IntCons = 12;
        /// <summary>
        /// Protected const <c>FlagCons = DummyLibEnum2.A | DummyLibEnum2.C</c>. 
        /// </summary>
        protected const DummyLibEnum2 FlagCons = DummyLibEnum2.A | DummyLibEnum2.C;

        /// <summary>
        /// Simple field
        /// </summary>
        public string FieldA;
        /// <summary>
        /// Public field of <see cref="DummyLib2"/>
        /// </summary>
        public DummyLib2 FieldB;
        /// <summary>
        /// Protected field with default value
        /// </summary>
        protected DummyLib2 FieldC = new DummyLib2();
        /// <summary>
        /// Read only field
        /// </summary>
        public readonly int FieldD;
        /// <summary>
        /// Static field
        /// </summary>
        public static string FieldE;

        /// <summary>
        /// Property
        /// </summary>
        public int PropA { get; set; }
        /// <summary>
        /// Property with getter only
        /// </summary>
        public int PropB { get; }
        /// <summary>
        /// Public property with private setter
        /// </summary>
        public int PropD { get; private set; }
        /// <summary>
        /// Internal property with simplified getter
        /// </summary>
        internal int PropE => PropA + PropB;
        /// <summary>
        /// Static property with getter and setter
        /// </summary>
        public static int PropF { get; set; }
        /// <summary>
        /// Virtual property with getter and setter
        /// </summary>
        public virtual int PropG { get; set; }
        /// <summary>
        /// Virtual property with getter and setter
        /// </summary>
        public virtual int PropH { get; set; }
        /// <summary>
        /// Virtual property with getter and setter
        /// </summary>
        public virtual int PropI { get; set; }

        /// <summary>
        /// Static CTOR
        /// </summary>
        static DummyLib() { }
        /// <summary>
        /// CTOR without parameters
        /// </summary>
        public DummyLib() { }

        /// <summary>
        /// CTOR with parameter
        /// </summary>
        /// <param name="a">CTOR parameter</param>
        public DummyLib(string a) { }

        /// <summary>
        /// Protected method
        /// </summary>
        /// <param name="b">The first  param</param>
        /// <param name="a">The second param</param>
        protected DummyLib(string b, int a) { }
    }

    /// <summary>
    /// Empty class
    /// </summary>
    public class DummyLib2 { }

    /// <summary>
    /// Class inheriting from DummyLib and having two attributes
    /// </summary>
    [Dummy("abcd")]
    [Dummy]
    public class DummyLib3 : DummyLib
    {
        /// <summary>
        /// Override property
        /// </summary>
        public override int PropH { get; set; }
        /// <summary>
        /// Sealed override property
        /// </summary>
        public sealed override int PropI { get; set; }
    }

    /// <summary>
    /// Enum with two values
    /// </summary>
    public enum DummyLibEnum
    {
        /// <summary>
        /// The first item
        /// </summary>
        /// <remarks>Nothing special about it</remarks>
        /// <seealso cref="Second"/>
        First,
        /// <summary>
        /// Second item
        /// </summary>
        Second
    }

    /// <summary>
    /// Enum with explicit values, base on <see cref="Byte"/>. Having <see cref="FlagsAttribute"/> 
    /// </summary>
    [Flags]
    public enum DummyLibEnum2 : byte
    {
        /// <summary>
        /// Value 4
        /// </summary>
        A = 4,
        B = 2,
        C = 1
    }

    /// <summary>
    /// Some attribute to play with
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class DummyAttribute : Attribute
    {
        /// <summary>
        /// CTOR without parameters
        /// </summary>
        public DummyAttribute() { }
        /// <summary>
        /// CTOR with parameter
        /// </summary>
        /// <param name="a">Put some value here</param>
        public DummyAttribute(string a) { }
    }
}
