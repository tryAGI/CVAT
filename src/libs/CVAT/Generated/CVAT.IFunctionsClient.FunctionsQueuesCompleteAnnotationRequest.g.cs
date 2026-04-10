#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Complete an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesCompleteAnnotationRequestAsync(
            string id,
            string requestId,

            global::CVAT.QueueRequestCompleteInputRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Complete an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="agentId"></param>
        /// <param name="annotations"></param>
        /// <param name="shapes"></param>
        /// <param name="states"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesCompleteAnnotationRequestAsync(
            string id,
            string requestId,
            string agentId,
            global::CVAT.LabeledDataRequest? annotations = default,
            global::System.Collections.Generic.IList<global::CVAT.ShapeRequest>? shapes = default,
            global::System.Collections.Generic.IList<string>? states = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}