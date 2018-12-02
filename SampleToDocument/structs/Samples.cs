using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SampleToDocument.interfaces;

namespace SampleToDocument.structs
{
    /// <summary>
    /// Namespace for checking the struct documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Empty structure
    /// </summary>
    public struct Struct1 { }
    /// <summary>
    /// Empty structure with attribute, implementing <see cref="IInterface1"/>
    /// </summary>
    [DataContract(Name = "a")]
    public struct Struct2 : IInterface1 { }
    /// <summary>
    /// Empty structure implementing <see cref="IInterface2"/> and <see cref="IInterface3"/>
    /// </summary>
    public struct Struct3 : IInterface2, IInterface3 { }
    /// <summary>
    /// Structure implementing <see cref="IEnumerable{T}"/>
    /// </summary>
    public struct Struct4 : IEnumerable<Struct4>
    {
        /// <summary>
        /// Implementation of <see cref="IEnumerable{T}.GetEnumerator"/>
        /// </summary>
        public IEnumerator<Struct4> GetEnumerator() { throw new NotImplementedException(); }

        /// <summary>
        /// Explicit implementation of <see cref="IEnumerable.GetEnumerator"/>
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

    /// <summary>
    /// Struct containing some members
    /// </summary>
    public struct Struct5
    {
        /// <summary>
        /// Inner struct implementing <see cref="IInterface3"/>
        /// </summary>
        public struct Struct5Inner1 : IInterface3 { }
        /// <summary>
        /// Inner class implementing <see cref="IInterface3"/>
        /// </summary>
        public class Struct5InnerClass : IInterface3 { }
        /// <summary>
        /// Private inner struct
        /// </summary>
        private struct Struct5Inner2 { }
        /// <summary>
        /// Internal inner struct
        /// </summary>
        internal struct Struct5Inner3 { }

        /// <summary>
        /// Struct property
        /// </summary>
        public int Struct5Property { get; }
        /// <summary>
        /// Struct indexer
        /// </summary>
        /// <param name="i"></param>
        internal int this[int i] => 1;
        /// <summary>
        /// Struct operator
        /// </summary>
        public static int operator +(Struct5 s) => 2;
        /// <summary>
        /// Struct method
        /// </summary>
        public void Struct5Method() { }
        /// <summary>
        /// Struct delegate
        /// </summary>
        public delegate int Struct5Delegate(int a, int b);

        /// <summary>
        /// Even the struct can have overrides (of <see cref="ValueType"/>)
        /// </summary>
        public override string ToString()
        {
            return base.ToString();
        }
    }

    /// <summary>
    /// Class containing structures
    /// </summary>
    public class StructContainer
    {
        /// <summary>
        /// Public inner struct
        /// </summary>
        public struct StructContainerInner1 { }
        /// <summary>
        /// Private inner struct
        /// </summary>
        private struct StructContainerInner2 { }
        /// <summary>
        /// Internal inner struct
        /// </summary>
        internal struct StructContainerInner3 { }
        /// <summary>
        /// Protected inner struct
        /// </summary>
        protected struct StructContainerInner4 { }
    }
    /// <summary>
    /// Class containing structures with members hiding 
    /// </summary>
    public class StructContainer2 : StructContainer
    {
        /// <summary>
        /// Public inner struct with new
        /// </summary>
        public new struct StructContainerInner1 { }
        /// <summary>
        /// Private inner struct
        /// </summary>
        private struct StructContainerInner2 { }
        /// <summary>
        /// Internal inner struct with new
        /// </summary>
        internal new struct StructContainerInner3 { }
        /// <summary>
        /// Protected inner struct with new
        /// </summary>
        protected new struct StructContainerInner4 { }
    }
}

