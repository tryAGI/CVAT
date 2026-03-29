
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `accuracy` - ACCURACY<br/>
    /// * `precision` - PRECISION<br/>
    /// * `recall` - RECALL
    /// </summary>
    public enum QualityTargetMetric
    {
        /// <summary>
        /// 
        /// </summary>
        Accuracy,
        /// <summary>
        /// 
        /// </summary>
        Precision,
        /// <summary>
        /// 
        /// </summary>
        Recall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityTargetMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityTargetMetric value)
        {
            return value switch
            {
                QualityTargetMetric.Accuracy => "accuracy",
                QualityTargetMetric.Precision => "precision",
                QualityTargetMetric.Recall => "recall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityTargetMetric? ToEnum(string value)
        {
            return value switch
            {
                "accuracy" => QualityTargetMetric.Accuracy,
                "precision" => QualityTargetMetric.Precision,
                "recall" => QualityTargetMetric.Recall,
                _ => null,
            };
        }
    }
}