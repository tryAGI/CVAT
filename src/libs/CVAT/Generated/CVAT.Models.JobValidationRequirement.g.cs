
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JobValidationRequirement
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
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Threshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Completed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationRequirement" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metric"></param>
        /// <param name="threshold"></param>
        /// <param name="completed"></param>
        /// <param name="score"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobValidationRequirement(
            string name,
            string metric,
            double threshold,
            bool completed,
            double? score)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Score = score;
            this.Threshold = threshold;
            this.Completed = completed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationRequirement" /> class.
        /// </summary>
        public JobValidationRequirement()
        {
        }

    }
}