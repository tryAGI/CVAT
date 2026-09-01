
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `no_annotations` - no_annotations<br/>
    /// * `filter_no_matches` - filter_no_matches<br/>
    /// * `required_attributes_missing` - required_attributes_missing
    /// </summary>
    public enum ReasonEnum
    {
        /// <summary>
        ///
        /// </summary>
        FilterNoMatches,
        /// <summary>
        ///
        /// </summary>
        NoAnnotations,
        /// <summary>
        ///
        /// </summary>
        RequiredAttributesMissing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasonEnum value)
        {
            return value switch
            {
                ReasonEnum.FilterNoMatches => "filter_no_matches",
                ReasonEnum.NoAnnotations => "no_annotations",
                ReasonEnum.RequiredAttributesMissing => "required_attributes_missing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "filter_no_matches" => ReasonEnum.FilterNoMatches,
                "no_annotations" => ReasonEnum.NoAnnotations,
                "required_attributes_missing" => ReasonEnum.RequiredAttributesMissing,
                _ => null,
            };
        }
    }
}