
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Default Value: json
    /// </summary>
    public enum QualityRetrieveReportDataFormat
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
    public static class QualityRetrieveReportDataFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityRetrieveReportDataFormat value)
        {
            return value switch
            {
                QualityRetrieveReportDataFormat.Csv => "csv",
                QualityRetrieveReportDataFormat.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityRetrieveReportDataFormat? ToEnum(string value)
        {
            return value switch
            {
                "csv" => QualityRetrieveReportDataFormat.Csv,
                "json" => QualityRetrieveReportDataFormat.Json,
                _ => null,
            };
        }
    }
}