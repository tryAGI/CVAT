#nullable enable

namespace CVAT
{
    public partial interface IAssetsClient
    {
        /// <summary>
        /// Delete an asset
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task AssetsDestroyAsync(
            global::System.Guid uuid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}