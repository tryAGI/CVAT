#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Fail an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesFailAnnotationRequestAsync(
            string id,
            string requestId,

            global::CVAT.QueueRequestFailInputRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Fail an annotation request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="agentId"></param>
        /// <param name="excInfo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task FunctionsQueuesFailAnnotationRequestAsync(
            string id,
            string requestId,
            string agentId,
            string? excInfo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}