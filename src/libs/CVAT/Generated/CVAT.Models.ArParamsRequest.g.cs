
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ArParamsRequest
    {
        /// <summary>
        /// * `annotate_frame` - annotate_frame<br/>
        /// * `annotate_task` - annotate_task<br/>
        /// * `init_tracking` - init_tracking<br/>
        /// * `interact` - interact<br/>
        /// * `track` - track
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.ArTypeJsonConverter))]
        public global::CVAT.ArType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Task { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("pos_points")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? PosPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neg_points")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? NegPoints { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obj_bbox")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? ObjBbox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roi")]
        public global::System.Collections.Generic.IList<int>? Roi { get; set; }

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
        /// * `annotate_frame` - annotate_frame<br/>
        /// * `annotate_task` - annotate_task<br/>
        /// * `init_tracking` - init_tracking<br/>
        /// * `interact` - interact<br/>
        /// * `track` - track
        /// </param>
        /// <param name="job"></param>
        /// <param name="frame"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup"></param>
        /// <param name="convMaskToPoly"></param>
        /// <param name="mapping"></param>
        /// <param name="posPoints"></param>
        /// <param name="negPoints"></param>
        /// <param name="objBbox"></param>
        /// <param name="roi"></param>
        /// <param name="shapes"></param>
        /// <param name="states"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArParamsRequest(
            int task,
            global::CVAT.ArType? type,
            int? job,
            int? frame,
            double? threshold,
            bool? cleanup,
            bool? convMaskToPoly,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? posPoints,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? negPoints,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? objBbox,
            global::System.Collections.Generic.IList<int>? roi,
            global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? shapes,
            global::System.Collections.Generic.IList<string>? states)
        {
            this.Type = type;
            this.Task = task;
            this.Job = job;
            this.Frame = frame;
            this.Threshold = threshold;
            this.Cleanup = cleanup;
            this.ConvMaskToPoly = convMaskToPoly;
            this.Mapping = mapping;
            this.PosPoints = posPoints;
            this.NegPoints = negPoints;
            this.ObjBbox = objBbox;
            this.Roi = roi;
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