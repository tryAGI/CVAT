
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SocialLoginSerializerExRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public string? AccessToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token")]
        public string? IdToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_params")]
        public string? AuthParams { get; set; }

        /// <summary>
        /// Default Value: login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("process")]
        public string? Process { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialLoginSerializerExRequest" /> class.
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="code"></param>
        /// <param name="idToken"></param>
        /// <param name="authParams"></param>
        /// <param name="process">
        /// Default Value: login
        /// </param>
        /// <param name="scope"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SocialLoginSerializerExRequest(
            string? accessToken,
            string? code,
            string? idToken,
            string? authParams,
            string? process,
            string? scope)
        {
            this.AccessToken = accessToken;
            this.Code = code;
            this.IdToken = idToken;
            this.AuthParams = authParams;
            this.Process = process;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialLoginSerializerExRequest" /> class.
        /// </summary>
        public SocialLoginSerializerExRequest()
        {
        }
    }
}