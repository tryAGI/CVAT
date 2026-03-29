
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterSerializerWithSubscriptions
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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_verification_required")]
        public bool? EmailVerificationRequired { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confirmations")]
        public global::System.Collections.Generic.IList<global::CVAT.UserAgreement>? Confirmations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSerializerWithSubscriptions" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="emailVerificationRequired">
        /// Included only in responses
        /// </param>
        /// <param name="key">
        /// Included only in responses
        /// </param>
        /// <param name="confirmations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterSerializerWithSubscriptions(
            string username,
            string email,
            string? firstName,
            string? lastName,
            bool? emailVerificationRequired,
            string? key,
            global::System.Collections.Generic.IList<global::CVAT.UserAgreement>? confirmations)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailVerificationRequired = emailVerificationRequired;
            this.Key = key;
            this.Confirmations = confirmations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterSerializerWithSubscriptions" /> class.
        /// </summary>
        public RegisterSerializerWithSubscriptions()
        {
        }
    }
}