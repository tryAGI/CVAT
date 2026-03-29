#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Acquire an annotation request from a queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QueueRequestAcquireOutput> FunctionsQueuesAcquireAnnotationRequestAsync(
            string id,

            global::CVAT.QueueRequestAcquireInputRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Acquire an annotation request from a queue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="agentId"></param>
        /// <param name="requestCategory">
        /// * `interactive` - Interactive<br/>
        /// * `batch` - Batch
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.QueueRequestAcquireOutput> FunctionsQueuesAcquireAnnotationRequestAsync(
            string id,
            string agentId,
            global::CVAT.RequestCategoryEnum requestCategory,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}