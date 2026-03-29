
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum SchemaRetrieveScheme
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Yaml,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SchemaRetrieveSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SchemaRetrieveScheme value)
        {
            return value switch
            {
                SchemaRetrieveScheme.Json => "json",
                SchemaRetrieveScheme.Yaml => "yaml",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SchemaRetrieveScheme? ToEnum(string value)
        {
            return value switch
            {
                "json" => SchemaRetrieveScheme.Json,
                "yaml" => SchemaRetrieveScheme.Yaml,
                _ => null,
            };
        }
    }
}