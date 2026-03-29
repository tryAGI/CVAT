
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AcceptInvitationRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInvitationRead" /> class.
        /// </summary>
        /// <param name="organizationSlug"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AcceptInvitationRead(
            string organizationSlug)
        {
            this.OrganizationSlug = organizationSlug ?? throw new global::System.ArgumentNullException(nameof(organizationSlug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AcceptInvitationRead" /> class.
        /// </summary>
        public AcceptInvitationRead()
        {
        }
    }
}