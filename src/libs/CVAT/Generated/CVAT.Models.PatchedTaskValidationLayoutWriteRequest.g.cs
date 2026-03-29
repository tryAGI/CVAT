
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedTaskValidationLayoutWriteRequest
    {
        /// <summary>
        /// The list of frame ids to be excluded from validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_frames")]
        public global::System.Collections.Generic.IList<int>? DisabledFrames { get; set; }

        /// <summary>
        /// The method to use for frame selection of new real frames for honeypots in the task<br/>
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_selection_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.FrameSelectionMethodJsonConverter))]
        public global::CVAT.FrameSelectionMethod? FrameSelectionMethod { get; set; }

        /// <summary>
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_real_frames")]
        public global::System.Collections.Generic.IList<int>? HoneypotRealFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskValidationLayoutWriteRequest" /> class.
        /// </summary>
        /// <param name="disabledFrames">
        /// The list of frame ids to be excluded from validation
        /// </param>
        /// <param name="frameSelectionMethod">
        /// The method to use for frame selection of new real frames for honeypots in the task<br/>
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="honeypotRealFrames">
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedTaskValidationLayoutWriteRequest(
            global::System.Collections.Generic.IList<int>? disabledFrames,
            global::CVAT.FrameSelectionMethod? frameSelectionMethod,
            global::System.Collections.Generic.IList<int>? honeypotRealFrames)
        {
            this.DisabledFrames = disabledFrames;
            this.FrameSelectionMethod = frameSelectionMethod;
            this.HoneypotRealFrames = honeypotRealFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedTaskValidationLayoutWriteRequest" /> class.
        /// </summary>
        public PatchedTaskValidationLayoutWriteRequest()
        {
        }
    }
}