
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobValidationLayoutRead
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_count")]
        public int? HoneypotCount { get; set; }

        /// <summary>
        /// The list of frame ids for honeypots in the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_frames")]
        public global::System.Collections.Generic.IList<int>? HoneypotFrames { get; set; }

        /// <summary>
        /// The list of real (validation) frame ids for honeypots in the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("honeypot_real_frames")]
        public global::System.Collections.Generic.IList<int>? HoneypotRealFrames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationLayoutRead" /> class.
        /// </summary>
        /// <param name="honeypotCount"></param>
        /// <param name="honeypotFrames">
        /// The list of frame ids for honeypots in the job
        /// </param>
        /// <param name="honeypotRealFrames">
        /// The list of real (validation) frame ids for honeypots in the job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobValidationLayoutRead(
            int? honeypotCount,
            global::System.Collections.Generic.IList<int>? honeypotFrames,
            global::System.Collections.Generic.IList<int>? honeypotRealFrames)
        {
            this.HoneypotCount = honeypotCount;
            this.HoneypotFrames = honeypotFrames;
            this.HoneypotRealFrames = honeypotRealFrames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobValidationLayoutRead" /> class.
        /// </summary>
        public JobValidationLayoutRead()
        {
        }
    }
}