#nullable enable

namespace CVAT
{
    public partial interface IGuidesClient
    {
        /// <summary>
        /// Create an annotation guide<br/>
        /// The new guide will be bound either to a project or a task, depending on parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationGuideRead> GuidesCreateAsync(

            global::CVAT.AnnotationGuideWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an annotation guide<br/>
        /// The new guide will be bound either to a project or a task, depending on parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.AnnotationGuideRead>> GuidesCreateAsResponseAsync(

            global::CVAT.AnnotationGuideWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an annotation guide<br/>
        /// The new guide will be bound either to a project or a task, depending on parameters.
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="projectId"></param>
        /// <param name="markdown"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AnnotationGuideRead> GuidesCreateAsync(
            int? taskId = default,
            int? projectId = default,
            string? markdown = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}