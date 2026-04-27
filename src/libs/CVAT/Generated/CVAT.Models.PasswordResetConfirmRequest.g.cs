
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Serializer for confirming a password reset attempt.
    /// </summary>
    public sealed partial class PasswordResetConfirmRequest
    {
        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_password1")]
        public string? NewPassword1 { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_password2")]
        public string? NewPassword2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetConfirmRequest" /> class.
        /// </summary>
        /// <param name="uid"></param>
        /// <param name="token"></param>
        /// <param name="newPassword1">
        /// Included only in requests
        /// </param>
        /// <param name="newPassword2">
        /// Included only in requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PasswordResetConfirmRequest(
            string uid,
            string token,
            string? newPassword1,
            string? newPassword2)
        {
            this.NewPassword1 = newPassword1;
            this.NewPassword2 = newPassword2;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordResetConfirmRequest" /> class.
        /// </summary>
        public PasswordResetConfirmRequest()
        {
        }
    }
}