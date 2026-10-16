
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `set_up_projects` - set_up_projects<br/>
    /// * `annotate_data` - annotate_data<br/>
    /// * `review_quality` - review_quality<br/>
    /// * `manage_annotators` - manage_annotators<br/>
    /// * `connect_models` - connect_models<br/>
    /// * `evaluate_for_organization` - evaluate_for_organization
    /// </summary>
    public enum PlannedActivitiesEnum
    {
        /// <summary>
        ///
        /// </summary>
        AnnotateData,
        /// <summary>
        ///
        /// </summary>
        ConnectModels,
        /// <summary>
        ///
        /// </summary>
        EvaluateForOrganization,
        /// <summary>
        ///
        /// </summary>
        ManageAnnotators,
        /// <summary>
        ///
        /// </summary>
        ReviewQuality,
        /// <summary>
        ///
        /// </summary>
        SetUpProjects,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PlannedActivitiesEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PlannedActivitiesEnum value)
        {
            return value switch
            {
                PlannedActivitiesEnum.AnnotateData => "annotate_data",
                PlannedActivitiesEnum.ConnectModels => "connect_models",
                PlannedActivitiesEnum.EvaluateForOrganization => "evaluate_for_organization",
                PlannedActivitiesEnum.ManageAnnotators => "manage_annotators",
                PlannedActivitiesEnum.ReviewQuality => "review_quality",
                PlannedActivitiesEnum.SetUpProjects => "set_up_projects",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PlannedActivitiesEnum? ToEnum(string value)
        {
            return value switch
            {
                "annotate_data" => PlannedActivitiesEnum.AnnotateData,
                "connect_models" => PlannedActivitiesEnum.ConnectModels,
                "evaluate_for_organization" => PlannedActivitiesEnum.EvaluateForOrganization,
                "manage_annotators" => PlannedActivitiesEnum.ManageAnnotators,
                "review_quality" => PlannedActivitiesEnum.ReviewQuality,
                "set_up_projects" => PlannedActivitiesEnum.SetUpProjects,
                _ => null,
            };
        }
    }
}