
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SocialAuthMethod
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAuthMethod" /> class.
        /// </summary>
        /// <param name="publicName"></param>
        /// <param name="isEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="icon"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SocialAuthMethod(
            string publicName,
            bool? isEnabled,
            string? icon)
        {
            this.IsEnabled = isEnabled;
            this.Icon = icon;
            this.PublicName = publicName ?? throw new global::System.ArgumentNullException(nameof(publicName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SocialAuthMethod" /> class.
        /// </summary>
        public SocialAuthMethod()
        {
        }
    }
}