
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum JobsListDimension
    {
        /// <summary>
        /// 
        /// </summary>
        x1d,
        /// <summary>
        /// 
        /// </summary>
        x2d,
        /// <summary>
        /// 
        /// </summary>
        x3d,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobsListDimensionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobsListDimension value)
        {
            return value switch
            {
                JobsListDimension.x1d => "1d",
                JobsListDimension.x2d => "2d",
                JobsListDimension.x3d => "3d",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobsListDimension? ToEnum(string value)
        {
            return value switch
            {
                "1d" => JobsListDimension.x1d,
                "2d" => JobsListDimension.x2d,
                "3d" => JobsListDimension.x3d,
                _ => null,
            };
        }
    }
}