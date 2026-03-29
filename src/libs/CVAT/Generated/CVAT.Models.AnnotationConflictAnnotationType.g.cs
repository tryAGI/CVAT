
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `tag` - TAG<br/>
    /// * `shape` - SHAPE<br/>
    /// * `track` - TRACK
    /// </summary>
    public enum AnnotationConflictAnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        Shape,
        /// <summary>
        /// 
        /// </summary>
        Tag,
        /// <summary>
        /// 
        /// </summary>
        Track,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationConflictAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationConflictAnnotationType value)
        {
            return value switch
            {
                AnnotationConflictAnnotationType.Shape => "shape",
                AnnotationConflictAnnotationType.Tag => "tag",
                AnnotationConflictAnnotationType.Track => "track",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationConflictAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "shape" => AnnotationConflictAnnotationType.Shape,
                "tag" => AnnotationConflictAnnotationType.Tag,
                "track" => AnnotationConflictAnnotationType.Track,
                _ => null,
            };
        }
    }
}