
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LabeledInterval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LabelId { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public int? Group { get; set; }

        /// <summary>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? Attributes { get; set; }

        /// <summary>
        /// Default Value: 1F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Must be within the task frame bounds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Start { get; set; }

        /// <summary>
        /// Exclusive interval end. May be one greater than the task stop frame.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public int? Stop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledInterval" /> class.
        /// </summary>
        /// <param name="labelId"></param>
        /// <param name="start">
        /// Must be within the task frame bounds.
        /// </param>
        /// <param name="id"></param>
        /// <param name="group">
        /// Default Value: 0
        /// </param>
        /// <param name="source">
        /// Default Value: manual
        /// </param>
        /// <param name="attributes">
        /// Default Value: []
        /// </param>
        /// <param name="score">
        /// Default Value: 1F
        /// </param>
        /// <param name="stop">
        /// Exclusive interval end. May be one greater than the task stop frame.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LabeledInterval(
            int labelId,
            int start,
            int? id,
            int? group,
            string? source,
            global::System.Collections.Generic.IList<global::CVAT.AttributeVal>? attributes,
            double? score,
            int? stop)
        {
            this.Id = id;
            this.LabelId = labelId;
            this.Group = group;
            this.Source = source;
            this.Attributes = attributes;
            this.Score = score;
            this.Start = start;
            this.Stop = stop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LabeledInterval" /> class.
        /// </summary>
        public LabeledInterval()
        {
        }

    }
}