
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PasswordChangeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_password")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OldPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_password1")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPassword1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_password2")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPassword2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordChangeRequest" /> class.
        /// </summary>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword1"></param>
        /// <param name="newPassword2"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PasswordChangeRequest(
            string oldPassword,
            string newPassword1,
            string newPassword2)
        {
            this.OldPassword = oldPassword ?? throw new global::System.ArgumentNullException(nameof(oldPassword));
            this.NewPassword1 = newPassword1 ?? throw new global::System.ArgumentNullException(nameof(newPassword1));
            this.NewPassword2 = newPassword2 ?? throw new global::System.ArgumentNullException(nameof(newPassword2));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordChangeRequest" /> class.
        /// </summary>
        public PasswordChangeRequest()
        {
        }
    }
}