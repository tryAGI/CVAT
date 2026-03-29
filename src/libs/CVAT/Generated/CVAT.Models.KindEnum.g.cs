
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `detector` - Detector<br/>
    /// * `interactor` - Interactor<br/>
    /// * `reid` - Reid<br/>
    /// * `tracker` - Tracker
    /// </summary>
    public enum KindEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Detector,
        /// <summary>
        /// 
        /// </summary>
        Interactor,
        /// <summary>
        /// 
        /// </summary>
        Reid,
        /// <summary>
        /// 
        /// </summary>
        Tracker,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KindEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KindEnum value)
        {
            return value switch
            {
                KindEnum.Detector => "detector",
                KindEnum.Interactor => "interactor",
                KindEnum.Reid => "reid",
                KindEnum.Tracker => "tracker",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KindEnum? ToEnum(string value)
        {
            return value switch
            {
                "detector" => KindEnum.Detector,
                "interactor" => KindEnum.Interactor,
                "reid" => KindEnum.Reid,
                "tracker" => KindEnum.Tracker,
                _ => null,
            };
        }
    }
}