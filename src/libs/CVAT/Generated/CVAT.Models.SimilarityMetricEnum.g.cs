
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `iou` - IoU<br/>
    /// * `oks` - OKS<br/>
    /// * `boundary_f` - Boundary F<br/>
    /// * `equality` - Equality
    /// </summary>
    public enum SimilarityMetricEnum
    {
        /// <summary>
        ///
        /// </summary>
        BoundaryF,
        /// <summary>
        ///
        /// </summary>
        Equality,
        /// <summary>
        ///
        /// </summary>
        Iou,
        /// <summary>
        ///
        /// </summary>
        Oks,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SimilarityMetricEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SimilarityMetricEnum value)
        {
            return value switch
            {
                SimilarityMetricEnum.BoundaryF => "boundary_f",
                SimilarityMetricEnum.Equality => "equality",
                SimilarityMetricEnum.Iou => "iou",
                SimilarityMetricEnum.Oks => "oks",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SimilarityMetricEnum? ToEnum(string value)
        {
            return value switch
            {
                "boundary_f" => SimilarityMetricEnum.BoundaryF,
                "equality" => SimilarityMetricEnum.Equality,
                "iou" => SimilarityMetricEnum.Iou,
                "oks" => SimilarityMetricEnum.Oks,
                _ => null,
            };
        }
    }
}