#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace CVAT.JsonConverters
{
    /// <inheritdoc />
    public class JobWriteRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::CVAT.JobWriteRequest>
    {
        /// <inheritdoc />
        public override global::CVAT.JobWriteRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.JobWriteRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.JobWriteRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.JobWriteRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::CVAT.GroundTruthJobCreateRequest? groundTruth = default;
            if (discriminator?.Type == global::CVAT.JobWriteRequestDiscriminatorType.GroundTruth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.GroundTruthJobCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.GroundTruthJobCreateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.GroundTruthJobCreateRequest)}");
                groundTruth = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::CVAT.ReplicaJobCreateRequest? replica = default;
            if (discriminator?.Type == global::CVAT.JobWriteRequestDiscriminatorType.Replica)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.ReplicaJobCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.ReplicaJobCreateRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::CVAT.ReplicaJobCreateRequest)}");
                replica = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::CVAT.JobWriteRequest(
                discriminator?.Type,
                groundTruth,

                replica
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::CVAT.JobWriteRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGroundTruth)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.GroundTruthJobCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.GroundTruthJobCreateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CVAT.GroundTruthJobCreateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickGroundTruth(), typeInfo);
            }
            else if (value.IsReplica)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::CVAT.ReplicaJobCreateRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::CVAT.ReplicaJobCreateRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::CVAT.ReplicaJobCreateRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickReplica(), typeInfo);
            }
        }
    }
}