#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Method returns SSO login URL based on server configuration and request parameters
        /// </summary>
        /// <param name="email"></param>
        /// <param name="iss"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.SSOLoginURL> AuthRetrieveSsoLoginUrlAsync(
            string? email = default,
            string? iss = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}