
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Plugins
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ANALYTICS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Analytics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODELS")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Plugins" /> class.
        /// </summary>
        /// <param name="analytics"></param>
        /// <param name="models"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Plugins(
            bool analytics,
            bool models)
        {
            this.Analytics = analytics;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Plugins" /> class.
        /// </summary>
        public Plugins()
        {
        }
    }
}