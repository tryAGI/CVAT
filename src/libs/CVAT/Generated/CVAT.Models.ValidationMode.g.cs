
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `gt` - GT<br/>
    /// * `gt_pool` - GT_POOL
    /// </summary>
    public enum ValidationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        GtPool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidationMode value)
        {
            return value switch
            {
                ValidationMode.Gt => "gt",
                ValidationMode.GtPool => "gt_pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidationMode? ToEnum(string value)
        {
            return value switch
            {
                "gt" => ValidationMode.Gt,
                "gt_pool" => ValidationMode.GtPool,
                _ => null,
            };
        }
    }
}