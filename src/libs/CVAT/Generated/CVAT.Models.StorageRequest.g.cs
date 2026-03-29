
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StorageRequest
    {
        /// <summary>
        /// * `cloud_storage` - CLOUD_STORAGE<br/>
        /// * `local` - LOCAL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.LocationEnumJsonConverter))]
        public global::CVAT.LocationEnum? Location { get; set; }

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
        /// Initializes a new instance of the <see cref="StorageRequest" /> class.
        /// </summary>
        /// <param name="location">
        /// * `cloud_storage` - CLOUD_STORAGE<br/>
        /// * `local` - LOCAL
        /// </param>
        /// <param name="cloudStorageId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageRequest(
            global::CVAT.LocationEnum? location,
            int? cloudStorageId)
        {
            this.Location = location;
            this.CloudStorageId = cloudStorageId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRequest" /> class.
        /// </summary>
        public StorageRequest()
        {
        }
    }
}