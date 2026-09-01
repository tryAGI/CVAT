
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum QualityRetrieveReportRequirementConfusionFormat
    {
        /// <summary>
        ///
        /// </summary>
        Csv,
        /// <summary>
        ///
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityRetrieveReportRequirementConfusionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityRetrieveReportRequirementConfusionFormat value)
        {
            return value switch
            {
                QualityRetrieveReportRequirementConfusionFormat.Csv => "csv",
                QualityRetrieveReportRequirementConfusionFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityRetrieveReportRequirementConfusionFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => QualityRetrieveReportRequirementConfusionFormat.Csv,
                "json" => QualityRetrieveReportRequirementConfusionFormat.Json,
                _ => null,
            };
        }
    }
}