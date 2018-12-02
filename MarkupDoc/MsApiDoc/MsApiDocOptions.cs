namespace net.adamec.dev.markupdoc.MsApiDoc
{
    /// <summary>
    /// Configuration class for <see cref="MsApiDocEngine"/>
    /// </summary>
    public class MsApiDocOptions
    {
        /// <summary>
        /// Flag whether to generate the links to MS .NET API Browser
        /// </summary>
        public bool LinkToApi { get; set; }=true;
        /// <summary>
        /// Base URL of MS .NET API Browser (must end with "/")
        /// If <see cref="LinkToApi"/> is set, missing <see cref="ApiBaseUrl"/> throws the exception while building the link
        /// </summary>
        public string ApiBaseUrl { get; set; }= "https://docs.microsoft.com/en-us/dotnet/api/";

        /// <summary>
        /// Flag whether to build the links based on the local close of .NET API Documentation only.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If not set (is false), <see cref="MsApiDocEngine"/> will try to build the links for <see cref="CodeModel.TypeRef"/>,
        /// the links based on documentation ID will not be created
        /// </para>
        /// <para>
        /// Note: This will not suppress reading/using the links based on the local clone of the documentation,
        /// just the "fallback" will be disabled</para>
        /// </remarks>
        public bool RequireLocalDoc { get; set; } = false;

        /// <summary>
        ///  Local clone of .NET API Documentation root directory
        /// </summary>
        public string LocalDocDir { get; set; }
    }
}
