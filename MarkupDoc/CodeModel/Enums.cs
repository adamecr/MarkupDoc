namespace net.adamec.dev.markupdoc.CodeModel
{
    /// <summary>
    /// Possible member kinds
    /// </summary>
    public enum MemberKindEnum
    {
        /// <summary>
        /// Member type is unknown or not set
        /// </summary>
        Unknown,
        /// <summary>
        /// Member is the root
        /// </summary>
        Root,
        /// <summary>
        /// Member is assembly
        /// </summary>
        Assembly,
        /// <summary>
        /// Member is namespace
        /// </summary>
        Namespace,
        /// <summary>
        /// Member is type
        /// </summary>
        Type,
        /// <summary>
        /// Member is event
        /// </summary>
        Event,
        /// <summary>
        /// Members is field
        /// </summary>
        Field,
        /// <summary>
        /// Member is property
        /// </summary>
        Property,
        /// <summary>
        /// Member is method
        /// </summary>
        Method
    }

    /// <summary>
    /// Possible kinds of type symbol
    /// </summary>
    public enum TypeKindEnum
    {
        /// <summary>
        /// Unknown or not set
        /// </summary>
        Unknown,
        /// <summary>
        /// Type is class
        /// </summary>
        Class,
        /// <summary>
        /// Type is interface
        /// </summary>
        Interface,
        /// <summary>
        /// Type is delegate
        /// </summary>
        Delegate,
        /// <summary>
        /// Type is array
        /// </summary>
        Array,
        /// <summary>
        /// Type is structure
        /// </summary>
        Struct,
        /// <summary>
        /// Type is enum
        /// </summary>
        Enum,
        /// <summary>
        /// Type is dynamic
        /// </summary>
        Dynamic
    }

    /// <summary>
    /// Possible access modifiers
    /// </summary>
    public enum ModifierEnum
    {
        /// <summary>
        /// Not applicable/unknown
        /// </summary>
        NotApplicable,
        /// <summary>
        /// Member is public
        /// </summary>
        Public,
        /// <summary>
        /// Member is private
        /// </summary>
        Private,
        /// <summary>
        /// Member is protected
        /// </summary>
        Protected,
        /// <summary>
        /// Member is internal
        /// </summary>
        Internal,
        /// <summary>
        /// Member is protected internal (protected or internal)
        /// </summary>
        ProtectedInternal,
        /// <summary>
        /// Member is private protected (protected and internal)
        /// </summary>
        PrivateProtected

    }

    /// <summary>
    /// Possible reference parameter kinds
    /// </summary>
    public enum RefKindEnum
    {
        /// <summary>
        /// None
        /// </summary>
        None,
        /// <summary>
        /// Ref
        /// </summary>
        Ref,
        /// <summary>
        /// Out
        /// </summary>
        Out,
        /// <summary>
        /// In
        /// </summary>
        In
    }

    /// <summary>
    /// Possible kinds of method symbols
    /// </summary>
    public enum MethodKindEnum
    {
        /// <summary>An anonymous method or lambda expression</summary>
        AnonymousFunction = 0,
        LambdaMethod = 0,
        /// <summary>Method is a constructor.</summary>
        Constructor = 1,
        /// <summary>Method is a conversion.</summary>
        Conversion = 2,
        /// <summary>Method is a delegate invoke.</summary>
        DelegateInvoke = 3,
        /// <summary>Method is a destructor.</summary>
        Destructor = 4,
        /// <summary>Method is an event add.</summary>
        EventAdd = 5,
        /// <summary>Method is an event raise.</summary>
        EventRaise = 6,
        /// <summary>Method is an event remove.</summary>
        EventRemove = 7,
        /// <summary>Method is an explicit interface implementation.</summary>
        ExplicitInterfaceImplementation = 8,
        /// <summary>Method is an operator.</summary>
        UserDefinedOperator = 9,
        /// <summary>Method is an ordinary method.</summary>
        Ordinary = 10, // 0x0000000A
        /// <summary>Method is a property get.</summary>
        PropertyGet = 11, // 0x0000000B
        /// <summary>Method is a property set.</summary>
        PropertySet = 12, // 0x0000000C
        /// <summary>
        /// An extension method with the "this" parameter removed.
        /// </summary>
        ReducedExtension = 13, // 0x0000000D
        SharedConstructor = 14, // 0x0000000E
        /// <summary>Method is a static constructor.</summary>
        StaticConstructor = 14, // 0x0000000E
        /// <summary>A built-in operator.</summary>
        BuiltinOperator = 15, // 0x0000000F
        /// <summary>Declare Sub or Function.</summary>
        DeclareMethod = 16, // 0x00000010
        /// <summary>Method is declared inside of another method.</summary>
        LocalFunction = 17, // 0x00000011
    }

    /// <summary>
    /// Possible split definitions
    /// </summary>
    public enum SplitTypeEnum
    {
        /// <summary>
        /// Don't split
        /// </summary>
        None,
        /// <summary>
        /// Split per namespace
        /// </summary>
        Namespace,
        /// <summary>
        /// Split per type (will also force split per namespace)
        /// </summary>
        Type
    }
}
