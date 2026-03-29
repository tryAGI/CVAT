
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionRequest
    {
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
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

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
        public global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? LabelsV2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_shape_types")]
        public global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? SupportedShapeTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionRequest" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="url"></param>
        /// <param name="apiKey">
        /// Included only in requests
        /// </param>
        /// <param name="name"></param>
        /// <param name="kind">
        /// * `detector` - Detector<br/>
        /// * `interactor` - Interactor<br/>
        /// * `reid` - Reid<br/>
        /// * `tracker` - Tracker
        /// </param>
        /// <param name="labelsV2"></param>
        /// <param name="supportedShapeTypes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionRequest(
            string provider,
            string? url,
            string? apiKey,
            string? name,
            global::CVAT.KindEnum? kind,
            global::System.Collections.Generic.IList<global::CVAT.FunctionLabelRequest>? labelsV2,
            global::System.Collections.Generic.IList<global::CVAT.ShapeType2>? supportedShapeTypes)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Url = url;
            this.ApiKey = apiKey;
            this.Name = name;
            this.Kind = kind;
            this.LabelsV2 = labelsV2;
            this.SupportedShapeTypes = supportedShapeTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionRequest" /> class.
        /// </summary>
        public FunctionRequest()
        {
        }
    }
}