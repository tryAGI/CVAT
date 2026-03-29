
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] DatasetFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFileRequest" /> class.
        /// </summary>
        /// <param name="datasetFile"></param>
        /// <param name="datasetFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFileRequest(
            byte[] datasetFile,
            string datasetFilename)
        {
            this.DatasetFile = datasetFile ?? throw new global::System.ArgumentNullException(nameof(datasetFile));
            this.DatasetFilename = datasetFilename ?? throw new global::System.ArgumentNullException(nameof(datasetFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFileRequest" /> class.
        /// </summary>
        public DatasetFileRequest()
        {
        }
    }
}