
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedUserRequest
    {
        /// <summary>
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// Designates whether the user can log into this admin site.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_staff")]
        public bool? IsStaff { get; set; }

        /// <summary>
        /// Designates that this user has all permissions without explicitly assigning them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_superuser")]
        public bool? IsSuperuser { get; set; }

        /// <summary>
        /// Designates whether this user should be treated as active. Unselect this instead of deleting accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedUserRequest" /> class.
        /// </summary>
        /// <param name="username">
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="groups"></param>
        /// <param name="isStaff">
        /// Designates whether the user can log into this admin site.
        /// </param>
        /// <param name="isSuperuser">
        /// Designates that this user has all permissions without explicitly assigning them.
        /// </param>
        /// <param name="isActive">
        /// Designates whether this user should be treated as active. Unselect this instead of deleting accounts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedUserRequest(
            string? username,
            string? firstName,
            string? lastName,
            string? email,
            global::System.Collections.Generic.IList<string>? groups,
            bool? isStaff,
            bool? isSuperuser,
            bool? isActive)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Groups = groups;
            this.IsStaff = isStaff;
            this.IsSuperuser = isSuperuser;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedUserRequest" /> class.
        /// </summary>
        public PatchedUserRequest()
        {
        }
    }
}