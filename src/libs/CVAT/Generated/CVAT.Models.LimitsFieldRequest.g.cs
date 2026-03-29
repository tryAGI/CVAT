
#nullable enable

namespace CVAT
{
    /// <summary>
    /// The serializer validates limits field names and their value types.<br/>
    /// Null allowed in order to indicate unlimited value.
    /// </summary>
    public sealed partial class LimitsFieldRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tasks")]
        public int? Tasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public int? Projects { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storages")]
        public int? CloudStorages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automatic_annotation")]
        public bool? AutomaticAnnotation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_export_dataset")]
        public bool? JobExportDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_export_dataset")]
        public bool? TaskExportDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_export_dataset")]
        public bool? ProjectExportDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analytics_reports_calculation")]
        public bool? AnalyticsReportsCalculation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ai_agents")]
        public int? ExternalAiAgents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_ai_agent_calls")]
        public int? ExternalAiAgentCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_ai_agent_calls")]
        public int? InternalAiAgentCalls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_storage_bytes")]
        public long? InternalStorageBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public int? Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memberships")]
        public int? Memberships { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organizations")]
        public int? Organizations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsFieldRequest" /> class.
        /// </summary>
        /// <param name="tasks"></param>
        /// <param name="projects"></param>
        /// <param name="cloudStorages"></param>
        /// <param name="automaticAnnotation"></param>
        /// <param name="jobExportDataset"></param>
        /// <param name="taskExportDataset"></param>
        /// <param name="projectExportDataset"></param>
        /// <param name="analyticsReportsCalculation"></param>
        /// <param name="externalAiAgents"></param>
        /// <param name="externalAiAgentCalls"></param>
        /// <param name="internalAiAgentCalls"></param>
        /// <param name="internalStorageBytes"></param>
        /// <param name="webhooks"></param>
        /// <param name="memberships"></param>
        /// <param name="organizations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LimitsFieldRequest(
            int? tasks,
            int? projects,
            int? cloudStorages,
            bool? automaticAnnotation,
            bool? jobExportDataset,
            bool? taskExportDataset,
            bool? projectExportDataset,
            bool? analyticsReportsCalculation,
            int? externalAiAgents,
            int? externalAiAgentCalls,
            int? internalAiAgentCalls,
            long? internalStorageBytes,
            int? webhooks,
            int? memberships,
            int? organizations)
        {
            this.Tasks = tasks;
            this.Projects = projects;
            this.CloudStorages = cloudStorages;
            this.AutomaticAnnotation = automaticAnnotation;
            this.JobExportDataset = jobExportDataset;
            this.TaskExportDataset = taskExportDataset;
            this.ProjectExportDataset = projectExportDataset;
            this.AnalyticsReportsCalculation = analyticsReportsCalculation;
            this.ExternalAiAgents = externalAiAgents;
            this.ExternalAiAgentCalls = externalAiAgentCalls;
            this.InternalAiAgentCalls = internalAiAgentCalls;
            this.InternalStorageBytes = internalStorageBytes;
            this.Webhooks = webhooks;
            this.Memberships = memberships;
            this.Organizations = organizations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LimitsFieldRequest" /> class.
        /// </summary>
        public LimitsFieldRequest()
        {
        }
    }
}