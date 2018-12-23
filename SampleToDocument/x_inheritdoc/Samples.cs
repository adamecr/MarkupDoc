using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Sample2;

namespace SampleToDocument.x_inheritdoc
{
    /// <summary>
    /// &lt;inheritdoc /&gt; samples
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute]
    internal class NamespaceDoc
    {
    }

    /// <summary>
    /// This is the class with documentation
    /// </summary>
    /// <remarks>Remark of class with documentation</remarks>
    /// <example>Example at class with documentation</example>
    ///  <exception cref="Exception">Exception at class with documentation</exception>
    /// <seealso cref="SampleWithDoc">Sea also at class with documentation</seealso>
    public class SampleWithDoc
    {
        /// <summary>
        /// This is the property with documentation
        /// </summary>
        /// <remarks>Remark of property with documentation</remarks>
        /// <example>Example at property with documentation</example>
        ///  <exception cref="Exception">Exception at property with documentation</exception>
        /// <seealso cref="SampleWithDoc">Sea also at property with documentation</seealso>
        /// <value>Value at property with documentation</value>
        public virtual int SamplePropertyWithDoc { get; set; }

        /// <summary>
        /// This is the method with documentation
        /// </summary>
        /// <remarks>Remark of method with documentation</remarks>
        /// <example>Example at method with documentation</example>
        ///  <exception cref="Exception">Exception at method with documentation</exception>
        /// <seealso cref="SampleWithDoc">Sea also at method with documentation</seealso>
        /// <returns>Returns at method with documentation</returns>
        /// <param name="param"><c>param</c> parameter at method with documentation</param>
        public virtual int SampleMethodWithDoc(int param)
        {
            return 0;
        }
    }

    /// <inheritdoc />
    public class SampleClassWithInheritDoc : SampleWithDoc
    {
    }
    /// <inheritdoc />
    public class SampleClassWithInheritDoc2 : SampleClassWithInheritDoc
    {
    }


    public class SampleInheritedClassWithoutInheritDoc : SampleWithDoc
    {
        /// <inheritdoc/>
        public override int SampleMethodWithDoc(int param)
        {
            return base.SampleMethodWithDoc(param) + 1;
        }
    }
    /// <inheritdoc />
    public class SampleClassWithInheritDoc3 : SampleInheritedClassWithoutInheritDoc
    {
    }

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    public class SampleClassWithInheritDocEmptySummary : SampleWithDoc
    {
    }

    /// <inheritdoc />
    /// <summary>
    /// This is SampleClassWithInheritDocNonEmptySummary
    /// </summary>
    public class SampleClassWithInheritDocNonEmptySummary : SampleWithDoc
    {
    }

    public delegate void D();
    /// <summary>
    ///  This is IInterfaceWithDocumentation documentation
    /// </summary>
    public interface IInterfaceWithDocumentation
    {
        /// <summary>
        /// IInterfaceWithDocumentation.P property documentation
        /// </summary>
        int P { get; }
        /// <summary>
        /// IInterfaceWithDocumentation.M method documentation
        /// </summary>
        /// <remarks>Have one parameter: <paramref name="p"/></remarks>
        /// <param name="p">parameter P</param>
        int M(int p);
        /// <summary>
        /// IInterfaceWithDocumentation.E event documentation
        /// </summary>
        event D E;
    }

    /// <summary>
    ///  This is IInterfaceWithDocumentation2 documentation
    /// </summary>
    public interface IInterfaceWithDocumentation2
    {
        /// <summary>
        /// IInterfaceWithDocumentation2.P property documentation
        /// </summary>
        int P { get; }
        /// <summary>
        /// IInterfaceWithDocumentation2.M method documentation
        /// </summary>
        /// <param name="p">parameter P</param>
        int M(int p);
        /// <summary>
        /// IInterfaceWithDocumentation2.E event documentation
        /// </summary>
        event D E;
    }

    /// <inheritdoc />
    public class SampleClassInheritingFromIface : IInterfaceWithDocumentation
    {
        /// <inheritdoc />
        public int P { get; }

        /// <inheritdoc />
        public int M(int p) { return 0; }
        /// <inheritdoc />
        public event D E;
    }

    /// <inheritdoc />
    public class SampleClassInheritingFromIface2 : IInterfaceWithDocumentation
    {
        /// <inheritdoc />
        public int P { get; }
        /// <inheritdoc />
        public int M(int x) //different name, parameter will not be documented
        {
            throw new NotImplementedException();
        }
        /// <inheritdoc />
        public event D E;
    }

    /// <inheritdoc />
    public class SampleClassInheritingFromClsAndIface : SampleWithDoc, IInterfaceWithDocumentation
    {
        /// <inheritdoc />
        public int P { get; }

        /// <inheritdoc />
        public int M(int p) { return 0; }
        /// <inheritdoc />
        public event D E;
    }

    /// <inheritdoc cref="SampleWithDoc" />
    public class SampleClassInheritingFromClsAndIface2 : SampleWithDoc, IInterfaceWithDocumentation
    {
        /// <inheritdoc />
        public int P { get; }

        /// <inheritdoc />
        public int M(int p) { return 0; }
        /// <inheritdoc />
        public event D E;
    }

    /// <inheritdoc cref="IInterfaceWithDocumentation" />
    public class SampleClassInheritingFromClsAndIface3 : SampleWithDoc, IInterfaceWithDocumentation
    {
        /// <inheritdoc />
        public int P { get; }

        /// <inheritdoc />
        public int M(int p) { return 0; }
        /// <inheritdoc />
        public event D E;
    }

    /// <inheritdoc  />
    public class SampleClassInheritingFromClsAndIface4 : IInterfaceWithDocumentation2, IInterfaceWithDocumentation
    {
        /// <summary>
        /// Some field
        /// </summary>
        public int F1, F2;
        /// <inheritdoc cref="IInterfaceWithDocumentation.P" />
        public int P { get; }

        /// <inheritdoc />
        public int M(int p) { return F2; }
        /// <inheritdoc />
        public event D E;
    }
}
