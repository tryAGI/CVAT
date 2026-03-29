#nullable enable

namespace CVAT
{
    public partial interface IGuidesClient
    {
        /// <summary>
        /// Update an annotation guide
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationGuideRead> GuidesPartialUpdateAsync(
            int id,

            global::CVAT.PatchedAnnotationGuideWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation guide
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskId"></param>
        /// <param name="projectId"></param>
        /// <param name="markdown"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationGuideRead> GuidesPartialUpdateAsync(
            int id,
            int? taskId = default,
            int? projectId = default,
            string? markdown = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}