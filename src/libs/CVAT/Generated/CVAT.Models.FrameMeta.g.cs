
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FrameMeta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RelatedFiles { get; set; }

        /// <summary>
        /// It is only included in job "meta" responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("related_files_metadata")]
        public global::System.Collections.Generic.IList<global::CVAT.RelatedFileMetadata>? RelatedFilesMetadata { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_related_context")]
        public bool? HasRelatedContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameMeta" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="relatedFiles"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="relatedFilesMetadata">
        /// It is only included in job "meta" responses.
        /// </param>
        /// <param name="hasRelatedContext">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FrameMeta(
            string name,
            int relatedFiles,
            int? width,
            int? height,
            global::System.Collections.Generic.IList<global::CVAT.RelatedFileMetadata>? relatedFilesMetadata,
            bool? hasRelatedContext)
        {
            this.Width = width;
            this.Height = height;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RelatedFiles = relatedFiles;
            this.RelatedFilesMetadata = relatedFilesMetadata;
            this.HasRelatedContext = hasRelatedContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameMeta" /> class.
        /// </summary>
        public FrameMeta()
        {
        }

    }
}