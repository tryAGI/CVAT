#nullable enable

namespace CVAT
{
    public partial interface IFunctionsClient
    {
        /// <summary>
        /// List annotation requests
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::CVAT.AnnotationRequest>> FunctionsListRequestsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}