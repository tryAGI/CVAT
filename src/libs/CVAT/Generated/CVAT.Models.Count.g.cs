
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Count
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shapes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Shapes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Tracks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Manual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interpolated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Interpolated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        /// <param name="shapes"></param>
        /// <param name="tracks"></param>
        /// <param name="manual"></param>
        /// <param name="interpolated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Count(
            int shapes,
            int tracks,
            int manual,
            int interpolated)
        {
            this.Shapes = shapes;
            this.Tracks = tracks;
            this.Manual = manual;
            this.Interpolated = interpolated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Count" /> class.
        /// </summary>
        public Count()
        {
        }
    }
}