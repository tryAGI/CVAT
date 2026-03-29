
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ext { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dimension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFormat" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ext"></param>
        /// <param name="version"></param>
        /// <param name="enabled"></param>
        /// <param name="dimension"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetFormat(
            string name,
            string ext,
            string version,
            bool enabled,
            string dimension)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Ext = ext ?? throw new global::System.ArgumentNullException(nameof(ext));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Enabled = enabled;
            this.Dimension = dimension ?? throw new global::System.ArgumentNullException(nameof(dimension));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFormat" /> class.
        /// </summary>
        public DatasetFormat()
        {
        }
    }
}