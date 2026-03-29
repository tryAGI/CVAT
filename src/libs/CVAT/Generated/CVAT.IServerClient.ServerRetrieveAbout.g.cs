#nullable enable

namespace CVAT
{
    public partial interface IServerClient
    {
        /// <summary>
        /// Get basic CVAT information
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.About> ServerRetrieveAboutAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}