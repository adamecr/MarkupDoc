using System;
using System.ComponentModel;

namespace SampleToDocument.interfaces
{
    /// <summary>
    /// Namespace for checking the interface documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Empty interface to be "inherited" elsewhere
    /// </summary>
    interface IInterface1 { }
    /// <summary>
    /// Another empty interface to be "inherited" elsewhere
    /// </summary>
    interface IInterface2 { }
    /// <summary>
    /// Interface "inheriting" <see cref="IInterface1"/>
    /// </summary>
    interface IInterface3 : IInterface1 { }

    /// <summary>
    /// Generic interface with variant type parameters
    /// </summary>
    /// <typeparam name="X">This is the "out" type parameter</typeparam>
    /// <typeparam name="Y">This is the "in" type parameter</typeparam>
    /// <typeparam name="Z">This is the type parameter without variance</typeparam>
    public interface IInterface4<out X, in Y, Z> { }

    /// <summary>
    /// Generic interface  with variant type parameters "inheriting" from <see cref="IInterface4{X,Y,Z}"/>.
    /// The interface also has the attributes
    /// </summary>
    /// <remarks>The <typeparamref name="Z"/> type parameter is mapped to all type parameters if <see cref="IInterface4{X,Y,Z}"/></remarks>
    /// <typeparam name="X">This is the "out" type parameter</typeparam>
    /// <typeparam name="Y">This is the "in" type parameter. Has the attribute</typeparam>
    /// <typeparam name="Z">This is the type parameter without variance</typeparam>
    [Category("Interface")]
    [Browsable(false)]
    [TypeConverter(typeof(string))]
    public interface IInterface5<out X, [Category("TypeParam")] in Y, Z> : IInterface4<Z, Z, Z> { }

    /// <summary>
    /// Interface "inheriting" from <see cref="IInterface1"/> and <see cref="IInterface2"/>.
    /// It declares property <see cref="Name"/> and method <see cref="SetName"/>
    /// </summary>
    interface IInterface6 : IInterface1, IInterface2
    {
        string Name { get; }
        void SetName(string name);
    }

    /// <summary>
    /// Interface declares property <see cref="Name"/> and methods <see cref="SetName"/> and <see cref="ClearName"/>
    /// </summary>
    interface IInterface7
    {
        string Name { get; }
        void SetName(string name);
        void ClearName(string name);
    }

    /// <summary>
    /// Class implementing <see cref="IInterface6"/> and <see cref="IInterface7"/>.
    /// As there are the members with same signature, the explicit implementation must be used.
    /// </summary>
    public class WithI6And7 : IInterface6, IInterface7
    {
        /// <summary>
        /// Explicit implementation of <see cref="IInterface6.Name"/>
        /// </summary>
        string IInterface6.Name => throw new NotImplementedException();
        /// <summary>
        /// Explicit implementation of <see cref="IInterface7.Name"/>
        /// </summary>
        string IInterface7.Name => throw new NotImplementedException();

        /// <summary>
        /// Explicit implementation of <see cref="IInterface6.SetName"/>
        /// </summary>
        void IInterface6.SetName(string name) { }
        /// <summary>
        /// Explicit implementation of <see cref="IInterface7.SetName"/>
        /// </summary>
        void IInterface7.SetName(string name) { }

        /// <summary>
        /// Implicit implementation of <see cref="IInterface7.ClearName"/>
        /// </summary>
        public void ClearName(string name) { }
    }

    /// <summary>
    /// Class containing nested interfaces
    /// </summary>
    public class InterfaceContainer
    {
        /// <summary>
        /// Private nested interface
        /// </summary>
        private interface INestedInterface1 { }
        /// <summary>
        /// Protected nested interface
        /// </summary>
        protected interface INestedInterface2 { }
        /// <summary>
        /// Public nested interface
        /// </summary>
        public interface INestedInterface3 { }
        /// <summary>
        /// Internal nested interface
        /// </summary>
        internal interface INestedInterface4 { }
    }

    /// <summary>
    /// Class containing nested interfaces with hiding
    /// </summary>
    public class InterfaceContainer2 : InterfaceContainer
    {
        /// <summary>
        /// Private nested interface
        /// </summary>
        private interface INestedInterface1 { }
        /// <summary>
        /// Protected nested interface with new
        /// </summary>
        protected new interface INestedInterface2 { }
        /// <summary>
        /// Public nested interface with new
        /// </summary>
        public new interface INestedInterface3 { }
        /// <summary>
        /// Internal nested interface with new
        /// </summary>
        internal new interface INestedInterface4 { }
    }
}

