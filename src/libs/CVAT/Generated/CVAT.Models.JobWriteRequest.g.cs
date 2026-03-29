
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public int? Assignee { get; set; }

        /// <summary>
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStageJsonConverter))]
        public global::CVAT.JobStage? Stage { get; set; }

        /// <summary>
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OperationStatusJsonConverter))]
        public global::CVAT.OperationStatus? State { get; set; }

        /// <summary>
        /// * `annotation` - ANNOTATION<br/>
        /// * `ground_truth` - GROUND_TRUTH<br/>
        /// * `consensus_replica` - CONSENSUS_REPLICA
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.JobType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_selection_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.FrameSelectionMethodJsonConverter))]
        public global::CVAT.FrameSelectionMethod? FrameSelectionMethod { get; set; }

        /// <summary>
        /// The number of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// The share of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_share")]
        public double? FrameShare { get; set; }

        /// <summary>
        /// The number of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames_per_job_count")]
        public int? FramesPerJobCount { get; set; }

        /// <summary>
        /// The share of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames_per_job_share")]
        public double? FramesPerJobShare { get; set; }

        /// <summary>
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("random_seed")]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<int>? Frames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobWriteRequest" /> class.
        /// </summary>
        /// <param name="type">
        /// * `annotation` - ANNOTATION<br/>
        /// * `ground_truth` - GROUND_TRUTH<br/>
        /// * `consensus_replica` - CONSENSUS_REPLICA
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="assignee"></param>
        /// <param name="stage">
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </param>
        /// <param name="state">
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </param>
        /// <param name="frameSelectionMethod">
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="frameCount">
        /// The number of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="frameShare">
        /// The share of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="framesPerJobCount">
        /// The number of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="framesPerJobShare">
        /// The share of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="randomSeed">
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </param>
        /// <param name="frames">
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobWriteRequest(
            global::CVAT.JobType type,
            int taskId,
            int? assignee,
            global::CVAT.JobStage? stage,
            global::CVAT.OperationStatus? state,
            global::CVAT.FrameSelectionMethod? frameSelectionMethod,
            int? frameCount,
            double? frameShare,
            int? framesPerJobCount,
            double? framesPerJobShare,
            int? randomSeed,
            global::System.Collections.Generic.IList<int>? frames)
        {
            this.Assignee = assignee;
            this.Stage = stage;
            this.State = state;
            this.Type = type;
            this.TaskId = taskId;
            this.FrameSelectionMethod = frameSelectionMethod;
            this.FrameCount = frameCount;
            this.FrameShare = frameShare;
            this.FramesPerJobCount = framesPerJobCount;
            this.FramesPerJobShare = framesPerJobShare;
            this.RandomSeed = randomSeed;
            this.Frames = frames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobWriteRequest" /> class.
        /// </summary>
        public JobWriteRequest()
        {
        }
    }
}