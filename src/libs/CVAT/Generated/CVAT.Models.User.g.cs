
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Groups { get; set; }

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
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_login")]
        public global::System.DateTime? LastLogin { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_joined")]
        public global::System.DateTime? DateJoined { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_analytics_access")]
        public bool? HasAnalyticsAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="username">
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </param>
        /// <param name="groups"></param>
        /// <param name="url">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="isStaff">
        /// Designates whether the user can log into this admin site.
        /// </param>
        /// <param name="isSuperuser">
        /// Designates that this user has all permissions without explicitly assigning them.
        /// </param>
        /// <param name="isActive">
        /// Designates whether this user should be treated as active. Unselect this instead of deleting accounts.
        /// </param>
        /// <param name="lastLogin">
        /// Included only in responses
        /// </param>
        /// <param name="dateJoined">
        /// Included only in responses
        /// </param>
        /// <param name="hasAnalyticsAccess">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string username,
            global::System.Collections.Generic.IList<string> groups,
            string? url,
            int? id,
            string? firstName,
            string? lastName,
            string? email,
            bool? isStaff,
            bool? isSuperuser,
            bool? isActive,
            global::System.DateTime? lastLogin,
            global::System.DateTime? dateJoined,
            bool? hasAnalyticsAccess)
        {
            this.Url = url;
            this.Id = id;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.IsStaff = isStaff;
            this.IsSuperuser = isSuperuser;
            this.IsActive = isActive;
            this.LastLogin = lastLogin;
            this.DateJoined = dateJoined;
            this.HasAnalyticsAccess = hasAnalyticsAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}