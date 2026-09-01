
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityRequirementBulkCreateRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SettingsId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest> Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityRequirementBulkCreateRequest" /> class.
        /// </summary>
        /// <param name="settingsId"></param>
        /// <param name="requirements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityRequirementBulkCreateRequest(
            int settingsId,
            global::System.Collections.Generic.IList<global::CVAT.QualityRequirementBulkCreateNodeRequest> requirements)
        {
            this.SettingsId = settingsId;
            this.Requirements = requirements ?? throw new global::System.ArgumentNullException(nameof(requirements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityRequirementBulkCreateRequest" /> class.
        /// </summary>
        public QualityRequirementBulkCreateRequest()
        {
        }

    }
}