#nullable enable

namespace CVAT
{
    public partial interface ILimitsClient
    {
        /// <summary>
        /// Method updates a limit
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Limit> LimitsPartialUpdateAsync(
            int id,

            global::CVAT.PatchedLimitRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Method updates a limit
        /// </summary>
        /// <param name="id"></param>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.Limit> LimitsPartialUpdateAsync(
            int id,
            int? user = default,
            int? org = default,
            global::CVAT.LimitTypeEnum? type = default,
            global::CVAT.LimitsFieldRequest? limits = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}