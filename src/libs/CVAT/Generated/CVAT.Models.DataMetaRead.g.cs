
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DataMetaRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chapters")]
        public global::System.Collections.Generic.IList<global::CVAT.Chapter>? Chapters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_updated_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ChunksUpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// The number of frames included. Deleted frames do not affect this value.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public int? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_quality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageQuality { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public int? StartFrame { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_frame")]
        public int? StopFrame { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_filter")]
        public string? FrameFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames")]
        public global::System.Collections.Generic.IList<global::CVAT.FrameMeta>? Frames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted_frames")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> DeletedFrames { get; set; }

        /// <summary>
        /// A list of valid frame ids. The None value means all frames are included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_frames")]
        public global::System.Collections.Generic.IList<int>? IncludedFrames { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.StorageTypeJsonConverter))]
        public global::CVAT.StorageType? Storage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storage_id")]
        public int? CloudStorageId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetaRead" /> class.
        /// </summary>
        /// <param name="chunksUpdatedDate"></param>
        /// <param name="imageQuality"></param>
        /// <param name="deletedFrames"></param>
        /// <param name="chapters"></param>
        /// <param name="chunkSize">
        /// Included only in responses
        /// </param>
        /// <param name="size">
        /// The number of frames included. Deleted frames do not affect this value.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="startFrame">
        /// Included only in responses
        /// </param>
        /// <param name="stopFrame">
        /// Included only in responses
        /// </param>
        /// <param name="frameFilter">
        /// Included only in responses
        /// </param>
        /// <param name="frames"></param>
        /// <param name="includedFrames">
        /// A list of valid frame ids. The None value means all frames are included.
        /// </param>
        /// <param name="storage">
        /// Included only in responses
        /// </param>
        /// <param name="cloudStorageId">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataMetaRead(
            global::System.DateTime chunksUpdatedDate,
            int imageQuality,
            global::System.Collections.Generic.IList<int> deletedFrames,
            global::System.Collections.Generic.IList<global::CVAT.Chapter>? chapters,
            int? chunkSize,
            int? size,
            int? startFrame,
            int? stopFrame,
            string? frameFilter,
            global::System.Collections.Generic.IList<global::CVAT.FrameMeta>? frames,
            global::System.Collections.Generic.IList<int>? includedFrames,
            global::CVAT.StorageType? storage,
            int? cloudStorageId)
        {
            this.Chapters = chapters;
            this.ChunksUpdatedDate = chunksUpdatedDate;
            this.ChunkSize = chunkSize;
            this.Size = size;
            this.ImageQuality = imageQuality;
            this.StartFrame = startFrame;
            this.StopFrame = stopFrame;
            this.FrameFilter = frameFilter;
            this.Frames = frames;
            this.DeletedFrames = deletedFrames ?? throw new global::System.ArgumentNullException(nameof(deletedFrames));
            this.IncludedFrames = includedFrames;
            this.Storage = storage;
            this.CloudStorageId = cloudStorageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetaRead" /> class.
        /// </summary>
        public DataMetaRead()
        {
        }
    }
}