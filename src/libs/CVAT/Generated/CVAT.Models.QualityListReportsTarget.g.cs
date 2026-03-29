
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityListReportsTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Job,
        /// <summary>
        /// 
        /// </summary>
        Project,
        /// <summary>
        /// 
        /// </summary>
        Task,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QualityListReportsTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListReportsTarget value)
        {
            return value switch
            {
                QualityListReportsTarget.Job => "job",
                QualityListReportsTarget.Project => "project",
                QualityListReportsTarget.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListReportsTarget? ToEnum(string value)
        {
            return value switch
            {
                "job" => QualityListReportsTarget.Job,
                "project" => QualityListReportsTarget.Project,
                "task" => QualityListReportsTarget.Task,
                _ => null,
            };
        }
    }
}