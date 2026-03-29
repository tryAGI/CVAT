#nullable enable

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public sealed class TasksCreateBackupExportLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.TasksCreateBackupExportLocation?>
    {
        /// <inheritdoc />
        public override global::CVAT.TasksCreateBackupExportLocation? Read(
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
                        return global::CVAT.TasksCreateBackupExportLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CVAT.TasksCreateBackupExportLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CVAT.TasksCreateBackupExportLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.TasksCreateBackupExportLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::CVAT.TasksCreateBackupExportLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}
