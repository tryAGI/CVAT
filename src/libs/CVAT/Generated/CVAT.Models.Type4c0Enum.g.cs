
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotate_task` - annotate_task<br/>
    /// * `annotate_frame` - annotate_frame<br/>
    /// * `init_tracking` - init_tracking<br/>
    /// * `track` - track
    /// </summary>
    public enum Type4c0Enum
    {
        /// <summary>
        /// 
        /// </summary>
        AnnotateFrame,
        /// <summary>
        /// 
        /// </summary>
        AnnotateTask,
        /// <summary>
        /// 
        /// </summary>
        InitTracking,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Type4c0EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type4c0Enum value)
        {
            return value switch
            {
                Type4c0Enum.AnnotateFrame => "annotate_frame",
                Type4c0Enum.AnnotateTask => "annotate_task",
                Type4c0Enum.InitTracking => "init_tracking",
                Type4c0Enum.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type4c0Enum? ToEnum(string value)
        {
            return value switch
            {
                "annotate_frame" => Type4c0Enum.AnnotateFrame,
                "annotate_task" => Type4c0Enum.AnnotateTask,
                "init_tracking" => Type4c0Enum.InitTracking,
                "track" => Type4c0Enum.Track,
                _ => null,
            };
        }
    }
}