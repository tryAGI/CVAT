
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `annotate_task` - annotate_task<br/>
    /// * `annotate_frame` - annotate_frame<br/>
    /// * `init_tracking` - init_tracking<br/>
    /// * `track` - track
    /// </summary>
    public enum TypeCcbEnum
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
    public static class TypeCcbEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TypeCcbEnum value)
        {
            return value switch
            {
                TypeCcbEnum.AnnotateFrame => "annotate_frame",
                TypeCcbEnum.AnnotateTask => "annotate_task",
                TypeCcbEnum.InitTracking => "init_tracking",
                TypeCcbEnum.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TypeCcbEnum? ToEnum(string value)
        {
            return value switch
            {
                "annotate_frame" => TypeCcbEnum.AnnotateFrame,
                "annotate_task" => TypeCcbEnum.AnnotateTask,
                "init_tracking" => TypeCcbEnum.InitTracking,
                "track" => TypeCcbEnum.Track,
                _ => null,
            };
        }
    }
}