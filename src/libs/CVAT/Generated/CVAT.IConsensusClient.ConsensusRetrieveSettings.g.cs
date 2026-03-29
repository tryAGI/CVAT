#nullable enable

namespace CVAT
{
    public partial interface IConsensusClient
    {
        /// <summary>
        /// Get consensus settings instance details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.ConsensusSettings> ConsensusRetrieveSettingsAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}