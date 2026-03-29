
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Label
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
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        public string? Color { get; set; }

        /// <summary>
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public global::System.Collections.Generic.IList<global::CVAT.Attribute>? Attributes { get; set; }

        /// <summary>
        /// Associated annotation type for this label<br/>
        /// * `any` - ANY<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `mask` - MASK<br/>
        /// * `points` - POINTS<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `skeleton` - SKELETON<br/>
        /// * `tag` - TAG
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.LabelTypeJsonConverter))]
        public global::CVAT.LabelType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("svg")]
        public string? Svg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sublabels")]
        public global::System.Collections.Generic.IList<global::CVAT.Sublabel>? Sublabels { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public int? ProjectId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public int? TaskId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_parent")]
        public bool? HasParent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="color">
        /// The hex value for the RGB color. Will be generated automatically, unless specified explicitly.
        /// </param>
        /// <param name="attributes">
        /// The list of attributes. If you want to remove an attribute, you need to recreate the label and specify the remaining attributes.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="type">
        /// Associated annotation type for this label<br/>
        /// * `any` - ANY<br/>
        /// * `cuboid` - CUBOID<br/>
        /// * `ellipse` - ELLIPSE<br/>
        /// * `mask` - MASK<br/>
        /// * `points` - POINTS<br/>
        /// * `polygon` - POLYGON<br/>
        /// * `polyline` - POLYLINE<br/>
        /// * `rectangle` - RECTANGLE<br/>
        /// * `skeleton` - SKELETON<br/>
        /// * `tag` - TAG
        /// </param>
        /// <param name="svg"></param>
        /// <param name="sublabels"></param>
        /// <param name="projectId">
        /// Included only in responses
        /// </param>
        /// <param name="taskId">
        /// Included only in responses
        /// </param>
        /// <param name="parentId">
        /// Included only in responses
        /// </param>
        /// <param name="hasParent">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Label(
            string name,
            int? id,
            string? color,
            global::System.Collections.Generic.IList<global::CVAT.Attribute>? attributes,
            global::CVAT.LabelType? type,
            string? svg,
            global::System.Collections.Generic.IList<global::CVAT.Sublabel>? sublabels,
            int? projectId,
            int? taskId,
            int? parentId,
            bool? hasParent)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color;
            this.Attributes = attributes;
            this.Type = type;
            this.Svg = svg;
            this.Sublabels = sublabels;
            this.ProjectId = projectId;
            this.TaskId = taskId;
            this.ParentId = parentId;
            this.HasParent = hasParent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
        }
    }
}