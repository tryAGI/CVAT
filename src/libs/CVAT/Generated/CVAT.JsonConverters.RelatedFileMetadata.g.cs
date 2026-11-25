#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public class RelatedFileMetadataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.RelatedFileMetadata>
    {
        /// <inheritdoc />
        public override global::CVAT.RelatedFileMetadata Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.RelatedFileMetadataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.RelatedFileMetadataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.RelatedFileMetadataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::CVAT.FileMetadata? file = default;
            if (discriminator?.Type == global::CVAT.RelatedFileMetadataDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.FileMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.FileMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.FileMetadata)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::CVAT.RelatedImageMetadata? relatedImage = default;
            if (discriminator?.Type == global::CVAT.RelatedFileMetadataDiscriminatorType.RelatedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.RelatedImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.RelatedImageMetadata> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.RelatedImageMetadata)}");
                relatedImage = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::CVAT.RelatedFileMetadata(
                discriminator?.Type,
                file,

                relatedImage
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.RelatedFileMetadata value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.FileMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.FileMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CVAT.FileMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFile(), typeInfo);
            }
            else if (value.IsRelatedImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.RelatedImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.RelatedImageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CVAT.RelatedImageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickRelatedImage(), typeInfo);
            }
        }
    }
}