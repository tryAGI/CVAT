#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Update an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesUpdateAnnotationRequestAsync(
            string id,
            string requestId,

            global::CVAT.QueueRequestUpdateInputRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="agentId"></param>
        /// <param name="progress"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesUpdateAnnotationRequestAsync(
            string id,
            string requestId,
            string agentId,
            double progress,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}