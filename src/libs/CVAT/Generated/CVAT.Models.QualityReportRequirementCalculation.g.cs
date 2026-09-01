
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QualityReportRequirementCalculation
    {
        /// <summary>
        /// * `computed` - computed<br/>
        /// * `not_computed` - not_computed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.QualityReportRequirementCalculationStatusEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.QualityReportRequirementCalculationStatusEnum Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>))]
        public global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementCalculation" /> class.
        /// </summary>
        /// <param name="status">
        /// * `computed` - computed<br/>
        /// * `not_computed` - not_computed
        /// </param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QualityReportRequirementCalculation(
            global::CVAT.QualityReportRequirementCalculationStatusEnum status,
            global::CVAT.OneOf<global::CVAT.ReasonEnum?, global::CVAT.NullEnum?>? reason)
        {
            this.Status = status;
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityReportRequirementCalculation" /> class.
        /// </summary>
        public QualityReportRequirementCalculation()
        {
        }

    }
}