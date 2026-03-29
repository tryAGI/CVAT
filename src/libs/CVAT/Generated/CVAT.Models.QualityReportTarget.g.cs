
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `job` - JOB<br/>
    /// * `task` - TASK<br/>
    /// * `project` - PROJECT
    /// </summary>
    public enum QualityReportTarget
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
    public static class QualityReportTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityReportTarget value)
        {
            return value switch
            {
                QualityReportTarget.Job => "job",
                QualityReportTarget.Project => "project",
                QualityReportTarget.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityReportTarget? ToEnum(string value)
        {
            return value switch
            {
                "job" => QualityReportTarget.Job,
                "project" => QualityReportTarget.Project,
                "task" => QualityReportTarget.Task,
                _ => null,
            };
        }
    }
}