
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsRetrieveDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        ContextImage,
        /// <summary>
        /// 
        /// </summary>
        Frame,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsRetrieveDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsRetrieveDataType value)
        {
            return value switch
            {
                JobsRetrieveDataType.Chunk => "chunk",
                JobsRetrieveDataType.ContextImage => "context_image",
                JobsRetrieveDataType.Frame => "frame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsRetrieveDataType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => JobsRetrieveDataType.Chunk,
                "context_image" => JobsRetrieveDataType.ContextImage,
                "frame" => JobsRetrieveDataType.Frame,
                _ => null,
            };
        }
    }
}