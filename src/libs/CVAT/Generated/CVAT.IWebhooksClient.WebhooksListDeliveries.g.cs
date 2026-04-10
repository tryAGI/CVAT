#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// List deliveries for a webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedWebhookDeliveryReadList> WebhooksListDeliveriesAsync(
            int id,
            int? page = default,
            int? pageSize = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}