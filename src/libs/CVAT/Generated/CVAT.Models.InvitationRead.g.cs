
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InvitationRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RoleEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.RoleEnum Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.BasicUser User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expired")]
        public bool? Expired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.BasicOrganization OrganizationInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationRead" /> class.
        /// </summary>
        /// <param name="role">
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </param>
        /// <param name="user"></param>
        /// <param name="organization"></param>
        /// <param name="organizationInfo"></param>
        /// <param name="key">
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="owner"></param>
        /// <param name="expired">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvitationRead(
            global::CVAT.RoleEnum role,
            global::CVAT.BasicUser user,
            int organization,
            global::CVAT.BasicOrganization organizationInfo,
            string? key,
            global::System.DateTime? createdDate,
            global::CVAT.BasicUser? owner,
            bool? expired)
        {
            this.Key = key;
            this.CreatedDate = createdDate;
            this.Owner = owner;
            this.Role = role;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Organization = organization;
            this.Expired = expired;
            this.OrganizationInfo = organizationInfo ?? throw new global::System.ArgumentNullException(nameof(organizationInfo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationRead" /> class.
        /// </summary>
        public InvitationRead()
        {
        }
    }
}