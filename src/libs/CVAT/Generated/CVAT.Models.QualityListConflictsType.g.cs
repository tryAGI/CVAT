
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityListConflictsType
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
    public static class QualityListConflictsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListConflictsType value)
        {
            return value switch
            {
                QualityListConflictsType.CoveredAnnotation => "covered_annotation",
                QualityListConflictsType.ExtraAnnotation => "extra_annotation",
                QualityListConflictsType.LowOverlap => "low_overlap",
                QualityListConflictsType.MismatchingAttributes => "mismatching_attributes",
                QualityListConflictsType.MismatchingDirection => "mismatching_direction",
                QualityListConflictsType.MismatchingGroups => "mismatching_groups",
                QualityListConflictsType.MismatchingLabel => "mismatching_label",
                QualityListConflictsType.MissingAnnotation => "missing_annotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListConflictsType? ToEnum(string value)
        {
            return value switch
            {
                "covered_annotation" => QualityListConflictsType.CoveredAnnotation,
                "extra_annotation" => QualityListConflictsType.ExtraAnnotation,
                "low_overlap" => QualityListConflictsType.LowOverlap,
                "mismatching_attributes" => QualityListConflictsType.MismatchingAttributes,
                "mismatching_direction" => QualityListConflictsType.MismatchingDirection,
                "mismatching_groups" => QualityListConflictsType.MismatchingGroups,
                "mismatching_label" => QualityListConflictsType.MismatchingLabel,
                "missing_annotation" => QualityListConflictsType.MissingAnnotation,
                _ => null,
            };
        }
    }
}