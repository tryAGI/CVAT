#nullable enable

namespace CVAT
{
    public partial interface ICloudstoragesClient
    {
        /// <summary>
        /// Get a preview image for a cloud storage
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task CloudstoragesRetrievePreviewAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}