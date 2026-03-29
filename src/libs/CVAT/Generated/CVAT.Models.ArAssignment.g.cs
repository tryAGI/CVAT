
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArAssignment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FunctionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ar_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ArId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ar_params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.ArParams ArParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArAssignment" /> class.
        /// </summary>
        /// <param name="functionId"></param>
        /// <param name="arId"></param>
        /// <param name="arParams"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArAssignment(
            int functionId,
            string arId,
            global::CVAT.ArParams arParams)
        {
            this.FunctionId = functionId;
            this.ArId = arId ?? throw new global::System.ArgumentNullException(nameof(arId));
            this.ArParams = arParams ?? throw new global::System.ArgumentNullException(nameof(arParams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArAssignment" /> class.
        /// </summary>
        public ArAssignment()
        {
        }
    }
}