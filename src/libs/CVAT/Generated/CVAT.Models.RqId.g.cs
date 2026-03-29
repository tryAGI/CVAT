
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RqId
    {
        /// <summary>
        /// Request id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rq_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RqId1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RqId" /> class.
        /// </summary>
        /// <param name="rqId1">
        /// Request id
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RqId(
            string rqId1)
        {
            this.RqId1 = rqId1 ?? throw new global::System.ArgumentNullException(nameof(rqId1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RqId" /> class.
        /// </summary>
        public RqId()
        {
        }
    }
}