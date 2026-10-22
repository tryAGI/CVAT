#nullable enable

namespace CVAT
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="id"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MetaUser> UsersRetrieveAsync(
            int id,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="id"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.MetaUser>> UsersRetrieveAsResponseAsync(
            int id,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}