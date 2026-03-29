
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MembershipRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.BasicUser User { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_date")]
        public global::System.DateTime? JoinedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RoleEnumJsonConverter))]
        public global::CVAT.RoleEnum? Role { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invitation")]
        public string? Invitation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipRead" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
        /// <param name="isActive">
        /// Included only in responses
        /// </param>
        /// <param name="joinedDate">
        /// Included only in responses
        /// </param>
        /// <param name="role">
        /// Included only in responses
        /// </param>
        /// <param name="invitation">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MembershipRead(
            global::CVAT.BasicUser user,
            int? id,
            int? organization,
            bool? isActive,
            global::System.DateTime? joinedDate,
            global::CVAT.RoleEnum? role,
            string? invitation)
        {
            this.Id = id;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Organization = organization;
            this.IsActive = isActive;
            this.JoinedDate = joinedDate;
            this.Role = role;
            this.Invitation = invitation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipRead" /> class.
        /// </summary>
        public MembershipRead()
        {
        }
    }
}