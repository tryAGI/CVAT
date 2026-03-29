#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Redeliver a webhook delivery
        /// </summary>
        /// <param name="deliveryId"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task WebhooksCreateDeliveriesRedeliveryAsync(
            string deliveryId,
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}