
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `computed` - computed<br/>
    /// * `not_computed` - not_computed
    /// </summary>
    public enum QualityReportRequirementCalculationStatusEnum
    {
        /// <summary>
        ///
        /// </summary>
        Computed,
        /// <summary>
        ///
        /// </summary>
        NotComputed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityReportRequirementCalculationStatusEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityReportRequirementCalculationStatusEnum value)
        {
            return value switch
            {
                QualityReportRequirementCalculationStatusEnum.Computed => "computed",
                QualityReportRequirementCalculationStatusEnum.NotComputed => "not_computed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityReportRequirementCalculationStatusEnum? ToEnum(string value)
        {
            return value switch
            {
                "computed" => QualityReportRequirementCalculationStatusEnum.Computed,
                "not_computed" => QualityReportRequirementCalculationStatusEnum.NotComputed,
                _ => null,
            };
        }
    }
}