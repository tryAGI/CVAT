
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionAttributeRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// * `checkbox` - CHECKBOX<br/>
        /// * `radio` - RADIO<br/>
        /// * `number` - NUMBER<br/>
        /// * `text` - TEXT<br/>
        /// * `select` - SELECT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.InputTypeEnumJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::CVAT.InputTypeEnum InputType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionAttributeRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="values"></param>
        /// <param name="inputType">
        /// * `checkbox` - CHECKBOX<br/>
        /// * `radio` - RADIO<br/>
        /// * `number` - NUMBER<br/>
        /// * `text` - TEXT<br/>
        /// * `select` - SELECT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FunctionAttributeRequest(
            string name,
            global::System.Collections.Generic.IList<string> values,
            global::CVAT.InputTypeEnum inputType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.InputType = inputType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionAttributeRequest" /> class.
        /// </summary>
        public FunctionAttributeRequest()
        {
        }
    }
}