#nullable enable

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public sealed class ComparatorEnumJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.ComparatorEnum>
    {
        /// <inheritdoc />
        public override global::CVAT.ComparatorEnum Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::CVAT.ComparatorEnumExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CVAT.ComparatorEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CVAT.ComparatorEnum);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.ComparatorEnum value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CVAT.ComparatorEnumExtensions.ToValueString(value));
        }
    }
}
