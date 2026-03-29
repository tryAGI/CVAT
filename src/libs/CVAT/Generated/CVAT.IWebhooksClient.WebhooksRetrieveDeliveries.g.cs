#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get details of a webhook delivery
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookDeliveryRead> WebhooksRetrieveDeliveriesAsync(
            string deliveryId,
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}