#nullable enable

namespace CVAT
{
    public partial interface IRequestsClient
    {
        /// <summary>
        /// Cancel request
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task RequestsCreateCancelAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}