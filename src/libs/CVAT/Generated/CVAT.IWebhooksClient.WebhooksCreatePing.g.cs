#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Send a ping webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookDeliveryRead> WebhooksCreatePingAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}