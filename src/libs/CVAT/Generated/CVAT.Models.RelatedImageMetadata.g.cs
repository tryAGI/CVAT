
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RelatedImageMetadata
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: related_image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.RelatedImageMetadataTypeEnumJsonConverter))]
        public global::CVAT.RelatedImageMetadataTypeEnum? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intrinsic_matrix")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? IntrinsicMatrix { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extrinsic_matrix")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? ExtrinsicMatrix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedImageMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type">
        /// Default Value: related_image
        /// </param>
        /// <param name="intrinsicMatrix"></param>
        /// <param name="extrinsicMatrix"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelatedImageMetadata(
            string name,
            global::CVAT.RelatedImageMetadataTypeEnum? type,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? intrinsicMatrix,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? extrinsicMatrix)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.IntrinsicMatrix = intrinsicMatrix;
            this.ExtrinsicMatrix = extrinsicMatrix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedImageMetadata" /> class.
        /// </summary>
        public RelatedImageMetadata()
        {
        }

    }
}