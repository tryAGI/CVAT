
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksRetrieveDataQuality
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
    public static class TasksRetrieveDataQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksRetrieveDataQuality value)
        {
            return value switch
            {
                TasksRetrieveDataQuality.Compressed => "compressed",
                TasksRetrieveDataQuality.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksRetrieveDataQuality? ToEnum(string value)
        {
            return value switch
            {
                "compressed" => TasksRetrieveDataQuality.Compressed,
                "original" => TasksRetrieveDataQuality.Original,
                _ => null,
            };
        }
    }
}