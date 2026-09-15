
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `micro` - micro<br/>
    /// * `mean` - mean<br/>
    /// * `label` - label
    /// </summary>
    public enum AggregationEnum
    {
        /// <summary>
        ///
        /// </summary>
        Label,
        /// <summary>
        ///
        /// </summary>
        Mean,
        /// <summary>
        ///
        /// </summary>
        Micro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AggregationEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AggregationEnum value)
        {
            return value switch
            {
                AggregationEnum.Label => "label",
                AggregationEnum.Mean => "mean",
                AggregationEnum.Micro => "micro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AggregationEnum? ToEnum(string value)
        {
            return value switch
            {
                "label" => AggregationEnum.Label,
                "mean" => AggregationEnum.Mean,
                "micro" => AggregationEnum.Micro,
                _ => null,
            };
        }
    }
}