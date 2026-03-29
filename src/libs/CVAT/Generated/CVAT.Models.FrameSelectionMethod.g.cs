
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `random_uniform` - RANDOM_UNIFORM<br/>
    /// * `random_per_job` - RANDOM_PER_JOB<br/>
    /// * `manual` - MANUAL
    /// </summary>
    public enum FrameSelectionMethod
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        RandomPerJob,
        /// <summary>
        /// 
        /// </summary>
        RandomUniform,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FrameSelectionMethodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FrameSelectionMethod value)
        {
            return value switch
            {
                FrameSelectionMethod.Manual => "manual",
                FrameSelectionMethod.RandomPerJob => "random_per_job",
                FrameSelectionMethod.RandomUniform => "random_uniform",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FrameSelectionMethod? ToEnum(string value)
        {
            return value switch
            {
                "manual" => FrameSelectionMethod.Manual,
                "random_per_job" => FrameSelectionMethod.RandomPerJob,
                "random_uniform" => FrameSelectionMethod.RandomUniform,
                _ => null,
            };
        }
    }
}