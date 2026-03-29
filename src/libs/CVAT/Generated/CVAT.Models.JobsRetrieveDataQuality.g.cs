
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsRetrieveDataQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Compressed,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsRetrieveDataQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsRetrieveDataQuality value)
        {
            return value switch
            {
                JobsRetrieveDataQuality.Compressed => "compressed",
                JobsRetrieveDataQuality.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsRetrieveDataQuality? ToEnum(string value)
        {
            return value switch
            {
                "compressed" => JobsRetrieveDataQuality.Compressed,
                "original" => JobsRetrieveDataQuality.Original,
                _ => null,
            };
        }
    }
}