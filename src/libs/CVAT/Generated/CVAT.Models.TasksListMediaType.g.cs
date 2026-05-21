
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksListMediaType
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
    public static class TasksListMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksListMediaType value)
        {
            return value switch
            {
                TasksListMediaType.Audio => "audio",
                TasksListMediaType.Image => "image",
                TasksListMediaType.PointCloud => "point_cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksListMediaType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => TasksListMediaType.Audio,
                "image" => TasksListMediaType.Image,
                "point_cloud" => TasksListMediaType.PointCloud,
                _ => null,
            };
        }
    }
}