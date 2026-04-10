#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Update a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.TaskRead> TasksPartialUpdateAsync(
            int id,

            global::CVAT.PatchedTaskWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a task
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="ownerId">
        /// Included only in requests
        /// </param>
        /// <param name="assigneeId">
        /// Included only in requests
        /// </param>
        /// <param name="bugTracker"></param>
        /// <param name="labels"></param>
        /// <param name="subset"></param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="organizationId">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.TaskRead> TasksPartialUpdateAsync(
            int id,
            int? ownerId,
            int? assigneeId,
            int? organizationId,
            string? name = default,
            int? projectId = default,
            string? bugTracker = default,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? labels = default,
            string? subset = default,
            global::CVAT.StorageRequest? targetStorage = default,
            global::CVAT.StorageRequest? sourceStorage = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}