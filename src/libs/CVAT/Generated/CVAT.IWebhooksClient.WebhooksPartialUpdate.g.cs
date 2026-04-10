#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksPartialUpdateAsync(
            int id,

            global::CVAT.PatchedWebhookWriteRequest request,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="targetUrl"></param>
        /// <param name="description"></param>
        /// <param name="contentType">
        /// * `application/json` - JSON
        /// </param>
        /// <param name="secret"></param>
        /// <param name="isActive"></param>
        /// <param name="enableSsl"></param>
        /// <param name="events">
        /// Included only in requests
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksPartialUpdateAsync(
            int id,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum> events,
            string? targetUrl = default,
            string? description = default,
            global::CVAT.WebhookContentType? contentType = default,
            string? secret = default,
            bool? isActive = default,
            bool? enableSsl = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}