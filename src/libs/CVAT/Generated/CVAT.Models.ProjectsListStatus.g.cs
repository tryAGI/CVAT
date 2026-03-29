
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectsListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Annotation,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Validation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectsListStatus value)
        {
            return value switch
            {
                ProjectsListStatus.Annotation => "annotation",
                ProjectsListStatus.Completed => "completed",
                ProjectsListStatus.Validation => "validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "annotation" => ProjectsListStatus.Annotation,
                "completed" => ProjectsListStatus.Completed,
                "validation" => ProjectsListStatus.Validation,
                _ => null,
            };
        }
    }
}