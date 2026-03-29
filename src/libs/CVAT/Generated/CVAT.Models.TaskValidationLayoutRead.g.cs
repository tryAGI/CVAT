
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskValidationLayoutRead
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.OneOfJsonConverter<global::CVAT.ValidationMode?, global::CVAT.NullEnum>))]
        public global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum>? Mode { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frames_per_job_count")]
        public int? FramesPerJobCount { get; set; }

        /// <summary>
        /// The list of frame ids to be used for validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_frames")]
        public global::System.Collections.Generic.IList<int>? ValidationFrames { get; set; }

        /// <summary>
        /// The list of frame ids excluded from validation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled_frames")]
        public global::System.Collections.Generic.IList<int>? DisabledFrames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_count")]
        public int? HoneypotCount { get; set; }

        /// <summary>
        /// The list of frame ids for all honeypots in the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_frames")]
        public global::System.Collections.Generic.IList<int>? HoneypotFrames { get; set; }

        /// <summary>
        /// The list of real (validation) frame ids for all honeypots in the task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_real_frames")]
        public global::System.Collections.Generic.IList<int>? HoneypotRealFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskValidationLayoutRead" /> class.
        /// </summary>
        /// <param name="mode">
        /// Included only in responses
        /// </param>
        /// <param name="framesPerJobCount">
        /// Included only in responses
        /// </param>
        /// <param name="validationFrames">
        /// The list of frame ids to be used for validation
        /// </param>
        /// <param name="disabledFrames">
        /// The list of frame ids excluded from validation
        /// </param>
        /// <param name="honeypotCount"></param>
        /// <param name="honeypotFrames">
        /// The list of frame ids for all honeypots in the task
        /// </param>
        /// <param name="honeypotRealFrames">
        /// The list of real (validation) frame ids for all honeypots in the task
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskValidationLayoutRead(
            global::CVAT.OneOf<global::CVAT.ValidationMode?, global::CVAT.NullEnum>? mode,
            int? framesPerJobCount,
            global::System.Collections.Generic.IList<int>? validationFrames,
            global::System.Collections.Generic.IList<int>? disabledFrames,
            int? honeypotCount,
            global::System.Collections.Generic.IList<int>? honeypotFrames,
            global::System.Collections.Generic.IList<int>? honeypotRealFrames)
        {
            this.Mode = mode;
            this.FramesPerJobCount = framesPerJobCount;
            this.ValidationFrames = validationFrames;
            this.DisabledFrames = disabledFrames;
            this.HoneypotCount = honeypotCount;
            this.HoneypotFrames = honeypotFrames;
            this.HoneypotRealFrames = honeypotRealFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskValidationLayoutRead" /> class.
        /// </summary>
        public TaskValidationLayoutRead()
        {
        }
    }
}