#nullable enable

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectsCreateBackupExportLocationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.ProjectsCreateBackupExportLocation?>
    {
        /// <inheritdoc />
        public override global::CVAT.ProjectsCreateBackupExportLocation? Read(
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
                        return global::CVAT.ProjectsCreateBackupExportLocationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::CVAT.ProjectsCreateBackupExportLocation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::CVAT.ProjectsCreateBackupExportLocation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.ProjectsCreateBackupExportLocation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::CVAT.ProjectsCreateBackupExportLocationExtensions.ToValueString(value.Value));
            }
        }
    }
}
