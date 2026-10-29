
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `replica` - REPLICA
    /// </summary>
    public enum ReplicaJobCreateTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        Replica,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReplicaJobCreateTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReplicaJobCreateTypeEnum value)
        {
            return value switch
            {
                ReplicaJobCreateTypeEnum.Replica => "replica",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReplicaJobCreateTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "replica" => ReplicaJobCreateTypeEnum.Replica,
                _ => null,
            };
        }
    }
}