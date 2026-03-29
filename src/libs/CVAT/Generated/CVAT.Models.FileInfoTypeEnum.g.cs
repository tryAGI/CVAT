
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `REG` - REG<br/>
    /// * `DIR` - DIR
    /// </summary>
    public enum FileInfoTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Dir,
        /// <summary>
        /// 
        /// </summary>
        Reg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileInfoTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileInfoTypeEnum value)
        {
            return value switch
            {
                FileInfoTypeEnum.Dir => "DIR",
                FileInfoTypeEnum.Reg => "REG",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileInfoTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "DIR" => FileInfoTypeEnum.Dir,
                "REG" => FileInfoTypeEnum.Reg,
                _ => null,
            };
        }
    }
}