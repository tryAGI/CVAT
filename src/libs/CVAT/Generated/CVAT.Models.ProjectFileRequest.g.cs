
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectFileRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] ProjectFile { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFileRequest" /> class.
        /// </summary>
        /// <param name="projectFile"></param>
        /// <param name="projectFilename"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectFileRequest(
            byte[] projectFile,
            string projectFilename)
        {
            this.ProjectFile = projectFile ?? throw new global::System.ArgumentNullException(nameof(projectFile));
            this.ProjectFilename = projectFilename ?? throw new global::System.ArgumentNullException(nameof(projectFilename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectFileRequest" /> class.
        /// </summary>
        public ProjectFileRequest()
        {
        }
    }
}