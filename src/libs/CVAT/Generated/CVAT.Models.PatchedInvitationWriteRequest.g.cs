
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedInvitationWriteRequest
    {
        /// <summary>
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RoleEnumJsonConverter))]
        public global::CVAT.RoleEnum? Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedInvitationWriteRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </param>
        /// <param name="email"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedInvitationWriteRequest(
            global::CVAT.RoleEnum? role,
            string? email)
        {
            this.Role = role;
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedInvitationWriteRequest" /> class.
        /// </summary>
        public PatchedInvitationWriteRequest()
        {
        }
    }
}