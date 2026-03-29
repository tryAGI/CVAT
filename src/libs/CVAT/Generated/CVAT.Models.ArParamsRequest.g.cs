
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArParamsRequest
    {
        /// <summary>
        /// * `annotate_task` - annotate_task<br/>
        /// * `annotate_frame` - annotate_frame<br/>
        /// * `init_tracking` - init_tracking<br/>
        /// * `track` - track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.TypeCcbEnumJsonConverter))]
        public global::CVAT.TypeCcbEnum? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Task { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame")]
        public int? Frame { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanup")]
        public bool? Cleanup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conv_mask_to_poly")]
        public bool? ConvMaskToPoly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? Mapping { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        public global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? Shapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        public global::System.Collections.Generic.IList<string>? States { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArParamsRequest" /> class.
        /// </summary>
        /// <param name="task"></param>
        /// <param name="type">
        /// * `annotate_task` - annotate_task<br/>
        /// * `annotate_frame` - annotate_frame<br/>
        /// * `init_tracking` - init_tracking<br/>
        /// * `track` - track
        /// </param>
        /// <param name="frame"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup"></param>
        /// <param name="convMaskToPoly"></param>
        /// <param name="mapping"></param>
        /// <param name="shapes"></param>
        /// <param name="states"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArParamsRequest(
            int task,
            global::CVAT.TypeCcbEnum? type,
            int? frame,
            double? threshold,
            bool? cleanup,
            bool? convMaskToPoly,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping,
            global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? shapes,
            global::System.Collections.Generic.IList<string>? states)
        {
            this.Type = type;
            this.Task = task;
            this.Frame = frame;
            this.Threshold = threshold;
            this.Cleanup = cleanup;
            this.ConvMaskToPoly = convMaskToPoly;
            this.Mapping = mapping;
            this.Shapes = shapes;
            this.States = states;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArParamsRequest" /> class.
        /// </summary>
        public ArParamsRequest()
        {
        }
    }
}