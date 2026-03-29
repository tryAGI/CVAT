
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `checkbox` - CHECKBOX<br/>
    /// * `radio` - RADIO<br/>
    /// * `number` - NUMBER<br/>
    /// * `text` - TEXT<br/>
    /// * `select` - SELECT
    /// </summary>
    public enum InputTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Checkbox,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Radio,
        /// <summary>
        /// 
        /// </summary>
        Select,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputTypeEnum value)
        {
            return value switch
            {
                InputTypeEnum.Checkbox => "checkbox",
                InputTypeEnum.Number => "number",
                InputTypeEnum.Radio => "radio",
                InputTypeEnum.Select => "select",
                InputTypeEnum.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "checkbox" => InputTypeEnum.Checkbox,
                "number" => InputTypeEnum.Number,
                "radio" => InputTypeEnum.Radio,
                "select" => InputTypeEnum.Select,
                "text" => InputTypeEnum.Text,
                _ => null,
            };
        }
    }
}