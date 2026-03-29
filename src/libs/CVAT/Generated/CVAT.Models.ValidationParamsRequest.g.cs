
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValidationParamsRequest
    {
        /// <summary>
        /// * `gt` - GT<br/>
        /// * `gt_pool` - GT_POOL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ValidationModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.ValidationMode Mode { get; set; }

        /// <summary>
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_selection_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.FrameSelectionMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.FrameSelectionMethod FrameSelectionMethod { get; set; }

        /// <summary>
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// The list of file names to be included in the validation set.<br/>
        /// Applicable only to the "manual" frame selection method.<br/>
        /// Can only be used for images.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<string>? Frames { get; set; }

        /// <summary>
        /// The number of frames to be included in the validation set.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// The share of frames to be included in the validation set.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_share")]
        public double? FrameShare { get; set; }

        /// <summary>
        /// The number of frames to be included in the validation set from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames_per_job_count")]
        public int? FramesPerJobCount { get; set; }

        /// <summary>
        /// The share of frames to be included in the validation set from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames_per_job_share")]
        public double? FramesPerJobShare { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationParamsRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// * `gt` - GT<br/>
        /// * `gt_pool` - GT_POOL
        /// </param>
        /// <param name="frameSelectionMethod">
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="randomSeed">
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </param>
        /// <param name="frames">
        /// The list of file names to be included in the validation set.<br/>
        /// Applicable only to the "manual" frame selection method.<br/>
        /// Can only be used for images.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="frameCount">
        /// The number of frames to be included in the validation set.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="frameShare">
        /// The share of frames to be included in the validation set.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="framesPerJobCount">
        /// The number of frames to be included in the validation set from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="framesPerJobShare">
        /// The share of frames to be included in the validation set from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationParamsRequest(
            global::CVAT.ValidationMode mode,
            global::CVAT.FrameSelectionMethod frameSelectionMethod,
            int? randomSeed,
            global::System.Collections.Generic.IList<string>? frames,
            int? frameCount,
            double? frameShare,
            int? framesPerJobCount,
            double? framesPerJobShare)
        {
            this.Mode = mode;
            this.FrameSelectionMethod = frameSelectionMethod;
            this.RandomSeed = randomSeed;
            this.Frames = frames;
            this.FrameCount = frameCount;
            this.FrameShare = frameShare;
            this.FramesPerJobCount = framesPerJobCount;
            this.FramesPerJobShare = framesPerJobShare;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationParamsRequest" /> class.
        /// </summary>
        public ValidationParamsRequest()
        {
        }
    }
}