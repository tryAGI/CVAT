
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotate_frame` - annotate_frame<br/>
    /// * `annotate_task` - annotate_task<br/>
    /// * `init_tracking` - init_tracking<br/>
    /// * `interact` - interact<br/>
    /// * `track` - track
    /// </summary>
    public enum ArType
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
    public static class ArTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ArType value)
        {
            return value switch
            {
                ArType.AnnotateFrame => "annotate_frame",
                ArType.AnnotateTask => "annotate_task",
                ArType.InitTracking => "init_tracking",
                ArType.Interact => "interact",
                ArType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ArType? ToEnum(string value)
        {
            return value switch
            {
                "annotate_frame" => ArType.AnnotateFrame,
                "annotate_task" => ArType.AnnotateTask,
                "init_tracking" => ArType.InitTracking,
                "interact" => ArType.Interact,
                "track" => ArType.Track,
                _ => null,
            };
        }
    }
}