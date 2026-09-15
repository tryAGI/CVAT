
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `accuracy` - ACCURACY<br/>
    /// * `precision` - PRECISION<br/>
    /// * `recall` - RECALL<br/>
    /// * `jaccard_index` - JACCARD_INDEX<br/>
    /// * `dice` - DICE<br/>
    /// * `mean_accuracy` - MEAN_ACCURACY<br/>
    /// * `mean_precision` - MEAN_PRECISION<br/>
    /// * `mean_recall` - MEAN_RECALL<br/>
    /// * `mean_jaccard_index` - MEAN_JACCARD_INDEX<br/>
    /// * `mean_dice` - MEAN_DICE<br/>
    /// * `label_accuracy` - LABEL_ACCURACY<br/>
    /// * `label_precision` - LABEL_PRECISION<br/>
    /// * `label_recall` - LABEL_RECALL<br/>
    /// * `label_jaccard_index` - LABEL_JACCARD_INDEX<br/>
    /// * `label_dice` - LABEL_DICE
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
        Dice,
        /// <summary>
        ///
        /// </summary>
        JaccardIndex,
        /// <summary>
        ///
        /// </summary>
        LabelAccuracy,
        /// <summary>
        ///
        /// </summary>
        LabelDice,
        /// <summary>
        ///
        /// </summary>
        LabelJaccardIndex,
        /// <summary>
        ///
        /// </summary>
        LabelPrecision,
        /// <summary>
        ///
        /// </summary>
        LabelRecall,
        /// <summary>
        ///
        /// </summary>
        MeanAccuracy,
        /// <summary>
        ///
        /// </summary>
        MeanDice,
        /// <summary>
        ///
        /// </summary>
        MeanJaccardIndex,
        /// <summary>
        ///
        /// </summary>
        MeanPrecision,
        /// <summary>
        ///
        /// </summary>
        MeanRecall,
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
                QualityTargetMetric.Dice => "dice",
                QualityTargetMetric.JaccardIndex => "jaccard_index",
                QualityTargetMetric.LabelAccuracy => "label_accuracy",
                QualityTargetMetric.LabelDice => "label_dice",
                QualityTargetMetric.LabelJaccardIndex => "label_jaccard_index",
                QualityTargetMetric.LabelPrecision => "label_precision",
                QualityTargetMetric.LabelRecall => "label_recall",
                QualityTargetMetric.MeanAccuracy => "mean_accuracy",
                QualityTargetMetric.MeanDice => "mean_dice",
                QualityTargetMetric.MeanJaccardIndex => "mean_jaccard_index",
                QualityTargetMetric.MeanPrecision => "mean_precision",
                QualityTargetMetric.MeanRecall => "mean_recall",
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
                "dice" => QualityTargetMetric.Dice,
                "jaccard_index" => QualityTargetMetric.JaccardIndex,
                "label_accuracy" => QualityTargetMetric.LabelAccuracy,
                "label_dice" => QualityTargetMetric.LabelDice,
                "label_jaccard_index" => QualityTargetMetric.LabelJaccardIndex,
                "label_precision" => QualityTargetMetric.LabelPrecision,
                "label_recall" => QualityTargetMetric.LabelRecall,
                "mean_accuracy" => QualityTargetMetric.MeanAccuracy,
                "mean_dice" => QualityTargetMetric.MeanDice,
                "mean_jaccard_index" => QualityTargetMetric.MeanJaccardIndex,
                "mean_precision" => QualityTargetMetric.MeanPrecision,
                "mean_recall" => QualityTargetMetric.MeanRecall,
                "precision" => QualityTargetMetric.Precision,
                "recall" => QualityTargetMetric.Recall,
                _ => null,
            };
        }
    }
}