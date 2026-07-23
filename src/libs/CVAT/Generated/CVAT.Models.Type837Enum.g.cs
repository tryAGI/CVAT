
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotate_task` - annotate_task<br/>
    /// * `annotate_frame` - annotate_frame<br/>
    /// * `interact` - interact<br/>
    /// * `init_tracking` - init_tracking<br/>
    /// * `track` - track
    /// </summary>
    public enum Type837Enum
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
        Interact,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Type837EnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Type837Enum value)
        {
            return value switch
            {
                Type837Enum.AnnotateFrame => "annotate_frame",
                Type837Enum.AnnotateTask => "annotate_task",
                Type837Enum.InitTracking => "init_tracking",
                Type837Enum.Interact => "interact",
                Type837Enum.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Type837Enum? ToEnum(string value)
        {
            return value switch
            {
                "annotate_frame" => Type837Enum.AnnotateFrame,
                "annotate_task" => Type837Enum.AnnotateTask,
                "init_tracking" => Type837Enum.InitTracking,
                "interact" => Type837Enum.Interact,
                "track" => Type837Enum.Track,
                _ => null,
            };
        }
    }
}