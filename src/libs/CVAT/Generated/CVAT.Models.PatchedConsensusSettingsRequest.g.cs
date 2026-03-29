
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedConsensusSettingsRequest
    {
        /// <summary>
        /// Pairwise annotation matching IoU threshold
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iou_threshold")]
        public double? IouThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedConsensusSettingsRequest" /> class.
        /// </summary>
        /// <param name="iouThreshold">
        /// Pairwise annotation matching IoU threshold
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedConsensusSettingsRequest(
            double? iouThreshold)
        {
            this.IouThreshold = iouThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedConsensusSettingsRequest" /> class.
        /// </summary>
        public PatchedConsensusSettingsRequest()
        {
        }
    }
}