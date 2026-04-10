#nullable enable

namespace CVAT
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get details of the current user<br/>
        /// Method returns an instance of a user who is currently authenticated
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MetaUser> UsersRetrieveSelfAsync(
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}