
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum TasksRetrieveDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Chunk,
        /// <summary>
        /// 
        /// </summary>
        ContextImage,
        /// <summary>
        /// 
        /// </summary>
        Frame,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TasksRetrieveDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TasksRetrieveDataType value)
        {
            return value switch
            {
                TasksRetrieveDataType.Chunk => "chunk",
                TasksRetrieveDataType.ContextImage => "context_image",
                TasksRetrieveDataType.Frame => "frame",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TasksRetrieveDataType? ToEnum(string value)
        {
            return value switch
            {
                "chunk" => TasksRetrieveDataType.Chunk,
                "context_image" => TasksRetrieveDataType.ContextImage,
                "frame" => TasksRetrieveDataType.Frame,
                _ => null,
            };
        }
    }
}