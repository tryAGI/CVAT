
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReportEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TaskId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int JobId { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FrameCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Exists { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Objects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Assignee { get; set; }

        /// <summary>
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.JobStageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.JobStage Stage { get; set; }

        /// <summary>
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OperationStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.OperationStatus State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("working_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double WorkingTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedObjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedObjects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_objects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DeletedObjects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportEvent" /> class.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="taskName"></param>
        /// <param name="jobId"></param>
        /// <param name="type">
        /// * `annotation` - ANNOTATION<br/>
        /// * `ground_truth` - GROUND_TRUTH<br/>
        /// * `consensus_replica` - CONSENSUS_REPLICA
        /// </param>
        /// <param name="frameCount"></param>
        /// <param name="exists"></param>
        /// <param name="objects"></param>
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
        /// <param name="user"></param>
        /// <param name="workingTime"></param>
        /// <param name="createdDate"></param>
        /// <param name="updatedDate"></param>
        /// <param name="createdObjects"></param>
        /// <param name="updatedObjects"></param>
        /// <param name="deletedObjects"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReportEvent(
            int taskId,
            string taskName,
            int jobId,
            global::CVAT.JobType type,
            int frameCount,
            bool exists,
            int objects,
            string assignee,
            global::CVAT.JobStage stage,
            global::CVAT.OperationStatus state,
            string user,
            double workingTime,
            global::System.DateTime createdDate,
            global::System.DateTime updatedDate,
            int createdObjects,
            int updatedObjects,
            int deletedObjects)
        {
            this.TaskId = taskId;
            this.TaskName = taskName ?? throw new global::System.ArgumentNullException(nameof(taskName));
            this.JobId = jobId;
            this.Type = type;
            this.FrameCount = frameCount;
            this.Exists = exists;
            this.Objects = objects;
            this.Assignee = assignee ?? throw new global::System.ArgumentNullException(nameof(assignee));
            this.Stage = stage;
            this.State = state;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.WorkingTime = workingTime;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.CreatedObjects = createdObjects;
            this.UpdatedObjects = updatedObjects;
            this.DeletedObjects = deletedObjects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportEvent" /> class.
        /// </summary>
        public ReportEvent()
        {
        }
    }
}