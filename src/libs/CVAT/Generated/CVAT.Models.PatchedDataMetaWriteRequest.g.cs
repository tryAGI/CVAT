
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedDataMetaWriteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_frames")]
        public global::System.Collections.Generic.IList<int>? DeletedFrames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storage_id")]
        public int? CloudStorageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDataMetaWriteRequest" /> class.
        /// </summary>
        /// <param name="deletedFrames"></param>
        /// <param name="cloudStorageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedDataMetaWriteRequest(
            global::System.Collections.Generic.IList<int>? deletedFrames,
            int? cloudStorageId)
        {
            this.DeletedFrames = deletedFrames;
            this.CloudStorageId = cloudStorageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedDataMetaWriteRequest" /> class.
        /// </summary>
        public PatchedDataMetaWriteRequest()
        {
        }
    }
}