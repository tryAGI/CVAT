
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedIssueWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public global::System.Collections.Generic.IList<double>? Position { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignee")]
        public int? Assignee { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchedIssueWriteRequest" /> class.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="assignee"></param>
        /// <param name="resolved"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedIssueWriteRequest(
            global::System.Collections.Generic.IList<double>? position,
            int? assignee,
            bool? resolved)
        {
            this.Position = position;
            this.Assignee = assignee;
            this.Resolved = resolved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedIssueWriteRequest" /> class.
        /// </summary>
        public PatchedIssueWriteRequest()
        {
        }
    }
}