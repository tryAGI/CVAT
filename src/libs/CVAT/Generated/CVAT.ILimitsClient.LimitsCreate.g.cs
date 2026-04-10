#nullable enable

namespace CVAT
{
    public partial interface ILimitsClient
    {
        /// <summary>
        /// Method creates a limit
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Limit> LimitsCreateAsync(

            global::CVAT.LimitRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method creates a limit
        /// </summary>
        /// <param name="user"></param>
        /// <param name="org"></param>
        /// <param name="type">
        /// * `default` - DEFAULT<br/>
        /// * `paid` - PAID<br/>
        /// * `custom` - CUSTOM
        /// </param>
        /// <param name="limits">
        /// The serializer validates limits field names and their value types.<br/>
        /// Null allowed in order to indicate unlimited value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Limit> LimitsCreateAsync(
            global::CVAT.LimitTypeEnum type,
            global::CVAT.LimitsFieldRequest limits,
            int? user = default,
            int? org = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}