
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessTokenRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// A free-form name for the token.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_date")]
        public global::System.DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry_date")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// The last use date of the token. This field is NOT updated after each<br/>
        /// user request. The minimum expected resolution should be 1 day.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_date")]
        public global::System.DateTime? LastUsedDate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        /// The raw value of the token. Must be saved by the user, returned only once
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenRead" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="name">
        /// A free-form name for the token.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="createdDate">
        /// Included only in responses
        /// </param>
        /// <param name="updatedDate">
        /// Included only in responses
        /// </param>
        /// <param name="expiryDate">
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="lastUsedDate">
        /// The last use date of the token. This field is NOT updated after each<br/>
        /// user request. The minimum expected resolution should be 1 day.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="readOnly">
        /// Included only in responses
        /// </param>
        /// <param name="owner"></param>
        /// <param name="value">
        /// The raw value of the token. Must be saved by the user, returned only once
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessTokenRead(
            int? id,
            string? name,
            global::System.DateTime? createdDate,
            global::System.DateTime? updatedDate,
            global::System.DateTime? expiryDate,
            global::System.DateTime? lastUsedDate,
            bool? readOnly,
            global::CVAT.BasicUser? owner,
            string? value)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.ExpiryDate = expiryDate;
            this.LastUsedDate = lastUsedDate;
            this.ReadOnly = readOnly;
            this.Owner = owner;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessTokenRead" /> class.
        /// </summary>
        public AccessTokenRead()
        {
        }
    }
}