using System;

namespace SampleToDocument.classes
{
    /// <summary>
    /// Namespace for checking the classes documentation
    /// </summary>
    [System.Runtime.CompilerServices.CompilerGenerated]
    internal class NamespaceDoc { }

    /// <summary>
    /// Basic test class
    /// </summary>
    /// <remarks>The <see cref="TestClass1"/> is just a class for testing as well
    /// as <see cref="TestClass2"/>. It has a <see cref="String"/> field <see cref="Str"/>.
    /// Maybe also <see cref="TestClass2">custom text for link to Test2</see> can be provided.
    /// And also try to nest it <see cref="TestClass2">meaning that it could contain maybe inner <see cref="TestClass3">link to test3</see> or to <see cref="String.Clone"/> for example</see></remarks>
    /// <example>
    /// It's possible to use the class anywhere
    /// <code>
    ///  var a=new Test1();
    ///  var b= new Test1();
    /// </code>
    /// </example>
    /// <seealso cref="TestClass2"/>
    /// <seealso cref="TestClass3"/>
    /// <seealso cref="TestClass5"/>
    /// <seealso cref="TestClass4"/>
    /// <seealso cref="String"/>
    public class TestClass1
    {
        /// <summary>
        /// Readonly dynamic field with default value (not a constant)
        /// </summary>
        private readonly dynamic dyn1 = 2;
        /// <summary>
        /// Dynamic field with default value
        /// </summary>
        public dynamic Dyn2 = new { S = "ddd", i = 5 };
        //Just some property
        public string Str;
    }

    /// <summary>
    /// Static class
    /// </summary>
    static class TestStaticClass { }

    /// <summary>
    /// Internal class inheriting from <see cref="TestClass1"/>
    /// </summary>
    internal class TestInternalClass : TestClass1 { }

    /// <summary>
    /// Class with inner classes
    /// </summary>
    public class TestClass2
    {
        /// <summary>
        /// Nested class
        /// </summary>
        public class TestInnerClass { }
        /// <summary>
        /// Nested protected class
        /// </summary>
        protected class TestInnerProtectedClass { }
    }

    /// <summary>
    /// Class inheriting from <see cref="TestClass2"/>
    /// </summary>
    public class TestClass3 : TestClass2
    {
        /// <summary>
        /// Nested class with new
        /// </summary>
        public new class TestInnerClass { }
        /// <summary>
        /// Protected sealed nested class
        /// </summary>
        protected sealed class TestSealedInner { }
    }

    /// <summary>
    /// Class inheriting from nested class <see cref="SampleToDocument.classes.TestClass3.TestInnerClass"/>
    /// </summary>
    public class TestClass4 : TestClass3.TestInnerClass { }

    /// <summary>
    /// Class inheriting from <see cref="TestClass3"/>
    /// </summary>
    public class TestClass5 : TestClass3
    {
        /// <summary>
        /// Nested class inheriting from <see cref="TestClass2.TestInnerClass"/>
        /// </summary>
        public class Test5InnerClass1 : TestClass2.TestInnerClass { }
        /// <summary>
        /// Nested class inheriting from <see cref="TestClass3.TestInnerClass"/>
        /// </summary>
        public class Test5InnerClass2 : TestClass3.TestInnerClass { }
        /// <summary>
        /// Nested class inheriting from <see cref="TestClass3"/>
        /// </summary>
        public class Test5InnerClass3 : TestClass3 { }
    }

    /// <summary>
    /// Sealed class
    /// </summary>
    public sealed class TestSealedClass { }

    /// <summary>
    /// Partial class - part 1
    /// </summary>
    public partial class TestPartialClass
    {
        private string a;
    }
    /// <summary>
    /// Partial class - part 2
    /// </summary>
    public partial class TestPartialClass
    {
        private string b;
    }

}
