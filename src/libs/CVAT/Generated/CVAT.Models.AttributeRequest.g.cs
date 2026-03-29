
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AttributeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mutable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Mutable { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_value")]
        public string? DefaultValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mutable"></param>
        /// <param name="inputType">
        /// * `checkbox` - CHECKBOX<br/>
        /// * `radio` - RADIO<br/>
        /// * `number` - NUMBER<br/>
        /// * `text` - TEXT<br/>
        /// * `select` - SELECT
        /// </param>
        /// <param name="values"></param>
        /// <param name="id"></param>
        /// <param name="defaultValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AttributeRequest(
            string name,
            bool mutable,
            global::CVAT.InputTypeEnum inputType,
            global::System.Collections.Generic.IList<string> values,
            int? id,
            string? defaultValue)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Mutable = mutable;
            this.InputType = inputType;
            this.DefaultValue = defaultValue;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeRequest" /> class.
        /// </summary>
        public AttributeRequest()
        {
        }
    }
}