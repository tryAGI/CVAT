#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Redirects to provider authentication page<br/>
        /// Redirects to the specified provider authentication page. After successful authentication on the provider side, a redirect to the callback endpoint is performed
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task AuthRetrieveOidcLoginAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}