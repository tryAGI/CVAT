#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ProjectRead> ProjectsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedProjectWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="labels">
        /// Default Value: []<br/>
        /// Included only in requests
        /// </param>
        /// <param name="ownerId">
        /// Included only in requests
        /// </param>
        /// <param name="assigneeId">
        /// Included only in requests
        /// </param>
        /// <param name="bugTracker"></param>
        /// <param name="targetStorage">
        /// Included only in requests
        /// </param>
        /// <param name="sourceStorage">
        /// Included only in requests
        /// </param>
        /// <param name="organizationId">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ProjectRead> ProjectsPartialUpdateAsync(
            int id,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest> labels,
            int? ownerId,
            int? assigneeId,
            global::CVAT.StorageRequest targetStorage,
            global::CVAT.StorageRequest sourceStorage,
            int? organizationId,
            string? name = default,
            string? bugTracker = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}