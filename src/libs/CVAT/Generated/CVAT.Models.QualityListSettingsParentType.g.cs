
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum QualityListSettingsParentType
    {
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
    public static class QualityListSettingsParentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QualityListSettingsParentType value)
        {
            return value switch
            {
                QualityListSettingsParentType.Project => "project",
                QualityListSettingsParentType.Task => "task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QualityListSettingsParentType? ToEnum(string value)
        {
            return value switch
            {
                "project" => QualityListSettingsParentType.Project,
                "task" => QualityListSettingsParentType.Task,
                _ => null,
            };
        }
    }
}