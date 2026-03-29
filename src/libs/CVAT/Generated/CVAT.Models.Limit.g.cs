
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Limit
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.LimitTypeEnum Type { get; set; }

        /// <summary>
        /// The serializer validates limits field names and their value types.<br/>
        /// Null allowed in order to indicate unlimited value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.LimitsField Limits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit" /> class.
        /// </summary>
        /// <param name="type">
        /// * `default` - DEFAULT<br/>
        /// * `paid` - PAID<br/>
        /// * `custom` - CUSTOM
        /// </param>
        /// <param name="limits">
        /// The serializer validates limits field names and their value types.<br/>
        /// Null allowed in order to indicate unlimited value.
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="user"></param>
        /// <param name="org"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Limit(
            global::CVAT.LimitTypeEnum type,
            global::CVAT.LimitsField limits,
            int? id,
            int? user,
            int? org)
        {
            this.Id = id;
            this.User = user;
            this.Org = org;
            this.Type = type;
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Limit" /> class.
        /// </summary>
        public Limit()
        {
        }
    }
}