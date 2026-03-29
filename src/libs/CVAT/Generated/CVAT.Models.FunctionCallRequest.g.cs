
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionCallRequest
    {
        /// <summary>
        /// The name of the function to execute
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Function { get; set; }

        /// <summary>
        /// The id of the task to be annotated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Task { get; set; }

        /// <summary>
        /// The id of the job to be annotated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        public int? Job { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_distance")]
        public int? MaxDistance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        public double? Threshold { get; set; }

        /// <summary>
        /// Whether existing annotations should be removed<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cleanup")]
        public bool? Cleanup { get; set; }

        /// <summary>
        /// Deprecated; use conv_mask_to_poly instead<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convMaskToPoly")]
        public bool? ConvMaskToPoly { get; set; }

        /// <summary>
        /// Convert mask shapes to polygons
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conv_mask_to_poly")]
        public bool? ConvMaskToPoly2 { get; set; }

        /// <summary>
        /// Label mapping from the model to the task labels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapping")]
        public global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? Mapping { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallRequest" /> class.
        /// </summary>
        /// <param name="function">
        /// The name of the function to execute
        /// </param>
        /// <param name="task">
        /// The id of the task to be annotated
        /// </param>
        /// <param name="job">
        /// The id of the job to be annotated
        /// </param>
        /// <param name="maxDistance"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup">
        /// Whether existing annotations should be removed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convMaskToPoly">
        /// Deprecated; use conv_mask_to_poly instead<br/>
        /// Included only in requests
        /// </param>
        /// <param name="convMaskToPoly2">
        /// Convert mask shapes to polygons
        /// </param>
        /// <param name="mapping">
        /// Label mapping from the model to the task labels
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionCallRequest(
            string function,
            int task,
            int? job,
            int? maxDistance,
            double? threshold,
            bool? cleanup,
            bool? convMaskToPoly,
            bool? convMaskToPoly2,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Task = task;
            this.Job = job;
            this.MaxDistance = maxDistance;
            this.Threshold = threshold;
            this.Cleanup = cleanup;
            this.ConvMaskToPoly = convMaskToPoly;
            this.ConvMaskToPoly2 = convMaskToPoly2;
            this.Mapping = mapping;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionCallRequest" /> class.
        /// </summary>
        public FunctionCallRequest()
        {
        }
    }
}