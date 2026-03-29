
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SocialAuthMethods
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SocialAuthMethod Google { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SocialAuthMethod Github { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amazon-cognito")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SocialAuthMethod AmazonCognito { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sso")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SSOAuthMethod Sso { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAuthMethods" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="github"></param>
        /// <param name="amazonCognito"></param>
        /// <param name="sso"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SocialAuthMethods(
            global::CVAT.SocialAuthMethod google,
            global::CVAT.SocialAuthMethod github,
            global::CVAT.SocialAuthMethod amazonCognito,
            global::CVAT.SSOAuthMethod sso)
        {
            this.Google = google ?? throw new global::System.ArgumentNullException(nameof(google));
            this.Github = github ?? throw new global::System.ArgumentNullException(nameof(github));
            this.AmazonCognito = amazonCognito ?? throw new global::System.ArgumentNullException(nameof(amazonCognito));
            this.Sso = sso ?? throw new global::System.ArgumentNullException(nameof(sso));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAuthMethods" /> class.
        /// </summary>
        public SocialAuthMethods()
        {
        }
    }
}