
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] TaskFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskFileRequest" /> class.
        /// </summary>
        /// <param name="taskFile"></param>
        /// <param name="taskFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskFileRequest(
            byte[] taskFile,
            string taskFilename)
        {
            this.TaskFile = taskFile ?? throw new global::System.ArgumentNullException(nameof(taskFile));
            this.TaskFilename = taskFilename ?? throw new global::System.ArgumentNullException(nameof(taskFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskFileRequest" /> class.
        /// </summary>
        public TaskFileRequest()
        {
        }
    }
}