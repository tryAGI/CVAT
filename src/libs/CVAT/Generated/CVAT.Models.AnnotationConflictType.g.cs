
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `missing_annotation` - MISSING_ANNOTATION<br/>
    /// * `extra_annotation` - EXTRA_ANNOTATION<br/>
    /// * `mismatching_label` - MISMATCHING_LABEL<br/>
    /// * `low_overlap` - LOW_OVERLAP<br/>
    /// * `mismatching_direction` - MISMATCHING_DIRECTION<br/>
    /// * `mismatching_attributes` - MISMATCHING_ATTRIBUTES<br/>
    /// * `mismatching_groups` - MISMATCHING_GROUPS<br/>
    /// * `covered_annotation` - COVERED_ANNOTATION
    /// </summary>
    public enum AnnotationConflictType
    {
        /// <summary>
        /// 
        /// </summary>
        CoveredAnnotation,
        /// <summary>
        /// 
        /// </summary>
        ExtraAnnotation,
        /// <summary>
        /// 
        /// </summary>
        LowOverlap,
        /// <summary>
        /// 
        /// </summary>
        MismatchingAttributes,
        /// <summary>
        /// 
        /// </summary>
        MismatchingDirection,
        /// <summary>
        /// 
        /// </summary>
        MismatchingGroups,
        /// <summary>
        /// 
        /// </summary>
        MismatchingLabel,
        /// <summary>
        /// 
        /// </summary>
        MissingAnnotation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationConflictTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationConflictType value)
        {
            return value switch
            {
                AnnotationConflictType.CoveredAnnotation => "covered_annotation",
                AnnotationConflictType.ExtraAnnotation => "extra_annotation",
                AnnotationConflictType.LowOverlap => "low_overlap",
                AnnotationConflictType.MismatchingAttributes => "mismatching_attributes",
                AnnotationConflictType.MismatchingDirection => "mismatching_direction",
                AnnotationConflictType.MismatchingGroups => "mismatching_groups",
                AnnotationConflictType.MismatchingLabel => "mismatching_label",
                AnnotationConflictType.MissingAnnotation => "missing_annotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationConflictType? ToEnum(string value)
        {
            return value switch
            {
                "covered_annotation" => AnnotationConflictType.CoveredAnnotation,
                "extra_annotation" => AnnotationConflictType.ExtraAnnotation,
                "low_overlap" => AnnotationConflictType.LowOverlap,
                "mismatching_attributes" => AnnotationConflictType.MismatchingAttributes,
                "mismatching_direction" => AnnotationConflictType.MismatchingDirection,
                "mismatching_groups" => AnnotationConflictType.MismatchingGroups,
                "mismatching_label" => AnnotationConflictType.MismatchingLabel,
                "missing_annotation" => AnnotationConflictType.MissingAnnotation,
                _ => null,
            };
        }
    }
}