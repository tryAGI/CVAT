
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserAgreement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_display_text")]
        public string? UrlDisplayText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prefix")]
        public string? TextPrefix { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public bool? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgreement" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="urlDisplayText"></param>
        /// <param name="url"></param>
        /// <param name="textPrefix"></param>
        /// <param name="required">
        /// Default Value: false
        /// </param>
        /// <param name="value">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserAgreement(
            string name,
            string? urlDisplayText,
            string? url,
            string? textPrefix,
            bool? required,
            bool? value)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UrlDisplayText = urlDisplayText;
            this.Url = url;
            this.TextPrefix = textPrefix;
            this.Required = required;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserAgreement" /> class.
        /// </summary>
        public UserAgreement()
        {
        }
    }
}