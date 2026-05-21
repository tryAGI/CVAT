#nullable enable

namespace CVAT
{
    public partial interface IMembershipsClient
    {
        /// <summary>
        /// Update a membership
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MembershipRead> MembershipsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedMembershipWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a membership
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.MembershipRead>> MembershipsPartialUpdateAsResponseAsync(
            int id,

            global::CVAT.PatchedMembershipWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a membership
        /// </summary>
        /// <param name="id"></param>
        /// <param name="role">
        /// * `worker` - Worker<br/>
        /// * `supervisor` - Supervisor<br/>
        /// * `maintainer` - Maintainer<br/>
        /// * `owner` - Owner
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MembershipRead> MembershipsPartialUpdateAsync(
            int id,
            global::CVAT.RoleEnum? role = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}