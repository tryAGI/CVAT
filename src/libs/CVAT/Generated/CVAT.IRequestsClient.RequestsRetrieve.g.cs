#nullable enable

namespace CVAT
{
    public partial interface IRequestsClient
    {
        /// <summary>
        /// Get request details
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Request> RequestsRetrieveAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}