
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsensusSettings
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

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
        /// Initializes a new instance of the <see cref="ConsensusSettings" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="taskId">
        /// Included only in responses
        /// </param>
        /// <param name="iouThreshold">
        /// Pairwise annotation matching IoU threshold
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsensusSettings(
            int? id,
            int? taskId,
            double? iouThreshold)
        {
            this.Id = id;
            this.TaskId = taskId;
            this.IouThreshold = iouThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsensusSettings" /> class.
        /// </summary>
        public ConsensusSettings()
        {
        }
    }
}