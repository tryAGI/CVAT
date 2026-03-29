
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsPartialUpdateAnnotationsAction
    {
        /// <summary>
        /// 
        /// </summary>
        Create,
        /// <summary>
        /// 
        /// </summary>
        Delete,
        /// <summary>
        /// 
        /// </summary>
        Update,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsPartialUpdateAnnotationsActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsPartialUpdateAnnotationsAction value)
        {
            return value switch
            {
                JobsPartialUpdateAnnotationsAction.Create => "create",
                JobsPartialUpdateAnnotationsAction.Delete => "delete",
                JobsPartialUpdateAnnotationsAction.Update => "update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsPartialUpdateAnnotationsAction? ToEnum(string value)
        {
            return value switch
            {
                "create" => JobsPartialUpdateAnnotationsAction.Create,
                "delete" => JobsPartialUpdateAnnotationsAction.Delete,
                "update" => JobsPartialUpdateAnnotationsAction.Update,
                _ => null,
            };
        }
    }
}