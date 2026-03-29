
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Function
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// * `detector` - Detector<br/>
        /// * `interactor` - Interactor<br/>
        /// * `reid` - Reid<br/>
        /// * `tracker` - Tracker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.KindEnumJsonConverter))]
        public global::CVAT.KindEnum? Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels_v2")]
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>? LabelsV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_shape_types")]
        public global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? SupportedShapeTypes { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="url"></param>
        /// <param name="name"></param>
        /// <param name="kind">
        /// * `detector` - Detector<br/>
        /// * `interactor` - Interactor<br/>
        /// * `reid` - Reid<br/>
        /// * `tracker` - Tracker
        /// </param>
        /// <param name="labelsV2"></param>
        /// <param name="supportedShapeTypes"></param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="organization">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Function(
            string provider,
            int? id,
            string? url,
            string? name,
            global::CVAT.KindEnum? kind,
            global::System.Collections.Generic.IList<global::CVAT.FunctionLabel>? labelsV2,
            global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? supportedShapeTypes,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            global::CVAT.BasicUser? owner,
            int? organization)
        {
            this.Id = id;
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Url = url;
            this.Name = name;
            this.Kind = kind;
            this.LabelsV2 = labelsV2;
            this.SupportedShapeTypes = supportedShapeTypes;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.Owner = owner;
            this.Organization = organization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Function" /> class.
        /// </summary>
        public Function()
        {
        }
    }
}