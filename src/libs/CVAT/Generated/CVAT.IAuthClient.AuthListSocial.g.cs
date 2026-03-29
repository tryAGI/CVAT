#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Method provides a list with integrated social accounts authentication.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::CVAT.SocialAuthMethods>> AuthListSocialAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}