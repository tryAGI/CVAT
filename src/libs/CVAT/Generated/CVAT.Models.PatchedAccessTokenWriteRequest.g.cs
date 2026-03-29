
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchedAccessTokenWriteRequest
    {
        /// <summary>
        /// A free-form name for the token. Doesn't have to be unique
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// If not set, the token will not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiry_date")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAccessTokenWriteRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A free-form name for the token. Doesn't have to be unique
        /// </param>
        /// <param name="expiryDate">
        /// Once the token expires, clients cannot use it anymore.<br/>
        /// If not set, the token will not expire.
        /// </param>
        /// <param name="readOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedAccessTokenWriteRequest(
            string? name,
            global::System.DateTime? expiryDate,
            bool? readOnly)
        {
            this.Name = name;
            this.ExpiryDate = expiryDate;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedAccessTokenWriteRequest" /> class.
        /// </summary>
        public PatchedAccessTokenWriteRequest()
        {
        }
    }
}