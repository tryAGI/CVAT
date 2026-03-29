
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedMembershipWriteRequest
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedMembershipWriteRequest" /> class.
        /// </summary>
        /// <param name="role">
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedMembershipWriteRequest(
            global::CVAT.RoleEnum? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedMembershipWriteRequest" /> class.
        /// </summary>
        public PatchedMembershipWriteRequest()
        {
        }
    }
}