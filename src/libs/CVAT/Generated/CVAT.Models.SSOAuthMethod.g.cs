
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SSOAuthMethod
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicName { get; set; }

        /// <summary>
        /// * `email_address` - Email Address<br/>
        /// * `lowest_weight` - Lowest Weight
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selection_schema")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.SelectionSchemaEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.SelectionSchemaEnum SelectionSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOAuthMethod" /> class.
        /// </summary>
        /// <param name="publicName"></param>
        /// <param name="selectionSchema">
        /// * `email_address` - Email Address<br/>
        /// * `lowest_weight` - Lowest Weight
        /// </param>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="icon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SSOAuthMethod(
            string publicName,
            global::CVAT.SelectionSchemaEnum selectionSchema,
            bool? isEnabled,
            string? icon)
        {
            this.IsEnabled = isEnabled;
            this.Icon = icon;
            this.PublicName = publicName ?? throw new global::System.ArgumentNullException(nameof(publicName));
            this.SelectionSchema = selectionSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SSOAuthMethod" /> class.
        /// </summary>
        public SSOAuthMethod()
        {
        }
    }
}