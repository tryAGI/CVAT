
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssueRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        public int? Frame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<double> Position { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public global::CVAT.BasicUser? Assignee { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public bool? Resolved { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.CommentsSummary Comments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueRead" /> class.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="comments"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="frame">
        /// Included only in responses
        /// </param>
        /// <param name="job">
        /// Included only in responses
        /// </param>
        /// <param name="owner"></param>
        /// <param name="assignee"></param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="resolved">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssueRead(
            global::System.Collections.Generic.IList<double> position,
            global::CVAT.CommentsSummary comments,
            int? id,
            int? frame,
            int? job,
            global::CVAT.BasicUser? owner,
            global::CVAT.BasicUser? assignee,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            bool? resolved)
        {
            this.Id = id;
            this.Frame = frame;
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.Job = job;
            this.Owner = owner;
            this.Assignee = assignee;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Resolved = resolved;
            this.Comments = comments ?? throw new global::System.ArgumentNullException(nameof(comments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueRead" /> class.
        /// </summary>
        public IssueRead()
        {
        }
    }
}