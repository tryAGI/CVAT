
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueueRequestAcquireOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ar_assignment")]
        public global::CVAT.ArAssignment? ArAssignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestAcquireOutput" /> class.
        /// </summary>
        /// <param name="arAssignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueueRequestAcquireOutput(
            global::CVAT.ArAssignment? arAssignment)
        {
            this.ArAssignment = arAssignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueRequestAcquireOutput" /> class.
        /// </summary>
        public QueueRequestAcquireOutput()
        {
        }
    }
}