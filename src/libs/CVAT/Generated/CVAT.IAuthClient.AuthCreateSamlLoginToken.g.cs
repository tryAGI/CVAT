#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Method returns an authentication token<br/>
        /// class used for social authentications<br/>
        /// example usage for facebook with access_token<br/>
        /// -------------<br/>
        /// from allauth.socialaccount.providers.facebook.views import FacebookOAuth2Adapter<br/>
        /// class FacebookLogin(SocialLoginView):<br/>
        ///     adapter_class = FacebookOAuth2Adapter<br/>
        /// -------------<br/>
        /// example usage for facebook with code<br/>
        /// -------------<br/>
        /// from allauth.socialaccount.providers.facebook.views import FacebookOAuth2Adapter<br/>
        /// from allauth.socialaccount.providers.oauth2.client import OAuth2Client<br/>
        /// class FacebookLogin(SocialLoginView):<br/>
        ///     adapter_class = FacebookOAuth2Adapter<br/>
        ///     client_class = OAuth2Client<br/>
        ///     callback_url = 'localhost:8000'<br/>
        /// -------------
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Token> AuthCreateSamlLoginTokenAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}