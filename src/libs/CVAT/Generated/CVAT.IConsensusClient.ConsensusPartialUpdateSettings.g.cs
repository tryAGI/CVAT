#nullable enable

namespace CVAT
{
    public partial interface IConsensusClient
    {
        /// <summary>
        /// Update a consensus settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ConsensusSettings> ConsensusPartialUpdateSettingsAsync(
            int id,

            global::CVAT.PatchedConsensusSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a consensus settings instance
        /// </summary>
        /// <param name="id"></param>
        /// <param name="iouThreshold">
        /// Pairwise annotation matching IoU threshold
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ConsensusSettings> ConsensusPartialUpdateSettingsAsync(
            int id,
            double? iouThreshold = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}