#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// Cancel an annotation request
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task FunctionsDestroyRequestsAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}