
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedJobDataMetaWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_frames")]
        public global::System.Collections.Generic.IList<int>? DeletedFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedJobDataMetaWriteRequest" /> class.
        /// </summary>
        /// <param name="deletedFrames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedJobDataMetaWriteRequest(
            global::System.Collections.Generic.IList<int>? deletedFrames)
        {
            this.DeletedFrames = deletedFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedJobDataMetaWriteRequest" /> class.
        /// </summary>
        public PatchedJobDataMetaWriteRequest()
        {
        }
    }
}