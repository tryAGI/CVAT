#nullable enable

namespace CVAT
{
    public partial interface IServerClient
    {
        /// <summary>
        /// Get supported annotation formats
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DatasetFormats> ServerRetrieveAnnotationFormatsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}