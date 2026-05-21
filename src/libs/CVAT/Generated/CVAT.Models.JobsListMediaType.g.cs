
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsListMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        PointCloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsListMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListMediaType value)
        {
            return value switch
            {
                JobsListMediaType.Audio => "audio",
                JobsListMediaType.Image => "image",
                JobsListMediaType.PointCloud => "point_cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => JobsListMediaType.Audio,
                "image" => JobsListMediaType.Image,
                "point_cloud" => JobsListMediaType.PointCloud,
                _ => null,
            };
        }
    }
}