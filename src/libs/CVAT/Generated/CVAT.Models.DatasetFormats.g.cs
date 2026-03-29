
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetFormats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("importers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.DatasetFormat> Importers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exporters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::CVAT.DatasetFormat> Exporters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFormats" /> class.
        /// </summary>
        /// <param name="importers"></param>
        /// <param name="exporters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFormats(
            global::System.Collections.Generic.IList<global::CVAT.DatasetFormat> importers,
            global::System.Collections.Generic.IList<global::CVAT.DatasetFormat> exporters)
        {
            this.Importers = importers ?? throw new global::System.ArgumentNullException(nameof(importers));
            this.Exporters = exporters ?? throw new global::System.ArgumentNullException(nameof(exporters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFormats" /> class.
        /// </summary>
        public DatasetFormats()
        {
        }
    }
}