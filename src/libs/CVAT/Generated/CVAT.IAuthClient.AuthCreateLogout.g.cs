#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Calls Django logout method and delete the Token object<br/>
        /// assigned to the current User object.<br/>
        /// Accepts/Returns nothing.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RestAuthDetail> AuthCreateLogoutAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}