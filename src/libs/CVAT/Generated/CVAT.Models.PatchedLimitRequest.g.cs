
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedLimitRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public int? User { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org")]
        public int? Org { get; set; }

        /// <summary>
        /// * `default` - DEFAULT<br/>
        /// * `paid` - PAID<br/>
        /// * `custom` - CUSTOM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.LimitTypeEnumJsonConverter))]
        public global::CVAT.LimitTypeEnum? Type { get; set; }

        /// <summary>
        /// The serializer validates limits field names and their value types.<br/>
        /// Null allowed in order to indicate unlimited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        public global::CVAT.LimitsFieldRequest? Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLimitRequest" /> class.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="org"></param>
        /// <param name="type">
        /// * `default` - DEFAULT<br/>
        /// * `paid` - PAID<br/>
        /// * `custom` - CUSTOM
        /// </param>
        /// <param name="limits">
        /// The serializer validates limits field names and their value types.<br/>
        /// Null allowed in order to indicate unlimited value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedLimitRequest(
            int? user,
            int? org,
            global::CVAT.LimitTypeEnum? type,
            global::CVAT.LimitsFieldRequest? limits)
        {
            this.User = user;
            this.Org = org;
            this.Type = type;
            this.Limits = limits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedLimitRequest" /> class.
        /// </summary>
        public PatchedLimitRequest()
        {
        }
    }
}