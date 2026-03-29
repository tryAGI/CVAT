
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Frame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public int? Assignee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public bool? Resolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueWriteRequest" /> class.
        /// </summary>
        /// <param name="frame"></param>
        /// <param name="position"></param>
        /// <param name="job"></param>
        /// <param name="message"></param>
        /// <param name="assignee"></param>
        /// <param name="resolved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueWriteRequest(
            int frame,
            global::System.Collections.Generic.IList<double> position,
            int job,
            string message,
            int? assignee,
            bool? resolved)
        {
            this.Frame = frame;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.Job = job;
            this.Assignee = assignee;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Resolved = resolved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueWriteRequest" /> class.
        /// </summary>
        public IssueWriteRequest()
        {
        }
    }
}