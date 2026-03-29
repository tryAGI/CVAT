#nullable enable

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public sealed class TasksCreateAnnotationsLocationJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.TasksCreateAnnotationsLocation>
    {
        /// <inheritdoc />
        public override global::CVAT.TasksCreateAnnotationsLocation Read(
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
                        return global::CVAT.TasksCreateAnnotationsLocationExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CVAT.TasksCreateAnnotationsLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CVAT.TasksCreateAnnotationsLocation);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.TasksCreateAnnotationsLocation value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::CVAT.TasksCreateAnnotationsLocationExtensions.ToValueString(value));
        }
    }
}
