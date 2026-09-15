
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `accuracy` - accuracy<br/>
    /// * `precision` - precision<br/>
    /// * `recall` - recall<br/>
    /// * `jaccard_index` - jaccard_index<br/>
    /// * `dice` - dice
    /// </summary>
    public enum QualityReportTargetMetricSummaryMetricEnum
    {
        /// <summary>
        ///
        /// </summary>
        Accuracy,
        /// <summary>
        ///
        /// </summary>
        Dice,
        /// <summary>
        ///
        /// </summary>
        JaccardIndex,
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
    public static class QualityReportTargetMetricSummaryMetricEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityReportTargetMetricSummaryMetricEnum value)
        {
            return value switch
            {
                QualityReportTargetMetricSummaryMetricEnum.Accuracy => "accuracy",
                QualityReportTargetMetricSummaryMetricEnum.Dice => "dice",
                QualityReportTargetMetricSummaryMetricEnum.JaccardIndex => "jaccard_index",
                QualityReportTargetMetricSummaryMetricEnum.Precision => "precision",
                QualityReportTargetMetricSummaryMetricEnum.Recall => "recall",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityReportTargetMetricSummaryMetricEnum? ToEnum(string value)
        {
            return value switch
            {
                "accuracy" => QualityReportTargetMetricSummaryMetricEnum.Accuracy,
                "dice" => QualityReportTargetMetricSummaryMetricEnum.Dice,
                "jaccard_index" => QualityReportTargetMetricSummaryMetricEnum.JaccardIndex,
                "precision" => QualityReportTargetMetricSummaryMetricEnum.Precision,
                "recall" => QualityReportTargetMetricSummaryMetricEnum.Recall,
                _ => null,
            };
        }
    }
}