#nullable enable

namespace CVAT
{
    public partial interface IConsensusClient
    {
        /// <summary>
        /// Create a consensus merge
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ConsensusCreateMergeAsync(

            global::CVAT.ConsensusMergeCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a consensus merge
        /// </summary>
        /// <param name="taskId">
        /// Included only in requests
        /// </param>
        /// <param name="jobId">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ConsensusCreateMergeAsync(
            int taskId,
            int jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}