#nullable enable

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public sealed class JobsRetrieveAnnotationsLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.JobsRetrieveAnnotationsLocation?>
    {
        /// <inheritdoc />
        public override global::CVAT.JobsRetrieveAnnotationsLocation? Read(
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
                        return global::CVAT.JobsRetrieveAnnotationsLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CVAT.JobsRetrieveAnnotationsLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CVAT.JobsRetrieveAnnotationsLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.JobsRetrieveAnnotationsLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::CVAT.JobsRetrieveAnnotationsLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}
