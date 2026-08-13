
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventGroup
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventGroup" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventGroup(
            string? displayName)
        {
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventGroup" /> class.
        /// </summary>
        public EventGroup()
        {
        }

    }
}