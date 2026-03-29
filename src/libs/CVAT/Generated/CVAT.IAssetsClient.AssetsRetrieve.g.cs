#nullable enable

namespace CVAT
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Get an asset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task AssetsRetrieveAsync(
            global::System.Guid uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}