
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterSerializerWithSubscriptionsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password1")]
        public string? Password1 { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password2")]
        public string? Password2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmations")]
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? Confirmations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSerializerWithSubscriptionsRequest" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="password1">
        /// Included only in requests
        /// </param>
        /// <param name="password2">
        /// Included only in requests
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="confirmations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterSerializerWithSubscriptionsRequest(
            string username,
            string email,
            string? password1,
            string? password2,
            string? firstName,
            string? lastName,
            global::System.Collections.Generic.IList<global::CVAT.UserAgreementRequest>? confirmations)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Password1 = password1;
            this.Password2 = password2;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Confirmations = confirmations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSerializerWithSubscriptionsRequest" /> class.
        /// </summary>
        public RegisterSerializerWithSubscriptionsRequest()
        {
        }
    }
}