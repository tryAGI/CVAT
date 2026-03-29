
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnnotationFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] AnnotationFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnnotationFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationFileRequest" /> class.
        /// </summary>
        /// <param name="annotationFile"></param>
        /// <param name="annotationFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationFileRequest(
            byte[] annotationFile,
            string annotationFilename)
        {
            this.AnnotationFile = annotationFile ?? throw new global::System.ArgumentNullException(nameof(annotationFile));
            this.AnnotationFilename = annotationFilename ?? throw new global::System.ArgumentNullException(nameof(annotationFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationFileRequest" /> class.
        /// </summary>
        public AnnotationFileRequest()
        {
        }
    }
}