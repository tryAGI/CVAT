#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Create a task<br/>
        /// The new task will not have any attached images or videos.<br/>
        /// To attach them, use the /api/tasks/&lt;id&gt;/data endpoint.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.TaskRead> TasksCreateAsync(

            global::CVAT.TaskWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a task<br/>
        /// The new task will not have any attached images or videos.<br/>
        /// To attach them, use the /api/tasks/&lt;id&gt;/data endpoint.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="name"></param>
        /// <param name="projectId"></param>
        /// <param name="ownerId">
        /// Included only in requests
        /// </param>
        /// <param name="assigneeId">
        /// Included only in requests
        /// </param>
        /// <param name="bugTracker"></param>
        /// <param name="overlap"></param>
        /// <param name="segmentSize"></param>
        /// <param name="labels"></param>
        /// <param name="subset"></param>
        /// <param name="targetStorage"></param>
        /// <param name="sourceStorage"></param>
        /// <param name="consensusReplicas">
        /// The number of consensus replica jobs for each annotation job.<br/>
        /// Configured at task creation<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.TaskRead> TasksCreateAsync(
            string name,
            int? ownerId,
            int? assigneeId,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            int? projectId = default,
            string? bugTracker = default,
            int? overlap = default,
            int? segmentSize = default,
            global::System.Collections.Generic.IList<global::CVAT.PatchedLabelRequest>? labels = default,
            string? subset = default,
            global::CVAT.StorageRequest? targetStorage = default,
            global::CVAT.StorageRequest? sourceStorage = default,
            int? consensusReplicas = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}