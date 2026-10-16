
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `work_project` - work_project<br/>
    /// * `academic_research` - academic_research<br/>
    /// * `teaching_or_coursework` - teaching_or_coursework<br/>
    /// * `personal_project` - personal_project
    /// </summary>
    public enum CvatUsageReasonEnum
    {
        /// <summary>
        ///
        /// </summary>
        AcademicResearch,
        /// <summary>
        ///
        /// </summary>
        PersonalProject,
        /// <summary>
        ///
        /// </summary>
        TeachingOrCoursework,
        /// <summary>
        ///
        /// </summary>
        WorkProject,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CvatUsageReasonEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CvatUsageReasonEnum value)
        {
            return value switch
            {
                CvatUsageReasonEnum.AcademicResearch => "academic_research",
                CvatUsageReasonEnum.PersonalProject => "personal_project",
                CvatUsageReasonEnum.TeachingOrCoursework => "teaching_or_coursework",
                CvatUsageReasonEnum.WorkProject => "work_project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CvatUsageReasonEnum? ToEnum(string value)
        {
            return value switch
            {
                "academic_research" => CvatUsageReasonEnum.AcademicResearch,
                "personal_project" => CvatUsageReasonEnum.PersonalProject,
                "teaching_or_coursework" => CvatUsageReasonEnum.TeachingOrCoursework,
                "work_project" => CvatUsageReasonEnum.WorkProject,
                _ => null,
            };
        }
    }
}