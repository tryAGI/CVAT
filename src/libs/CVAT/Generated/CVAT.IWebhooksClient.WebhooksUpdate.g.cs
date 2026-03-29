#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Replace a webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksUpdateAsync(
            int id,

            global::CVAT.WebhookWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace a webhook
        /// </summary>
        /// <param name="id"></param>
        /// <param name="targetUrl"></param>
        /// <param name="description"></param>
        /// <param name="type">
        /// * `organization` - ORGANIZATION<br/>
        /// * `project` - PROJECT
        /// </param>
        /// <param name="contentType">
        /// * `application/json` - JSON
        /// </param>
        /// <param name="secret"></param>
        /// <param name="isActive"></param>
        /// <param name="enableSsl"></param>
        /// <param name="projectId">
        /// Included only in requests
        /// </param>
        /// <param name="events">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksUpdateAsync(
            int id,
            string targetUrl,
            global::CVAT.WebhookType type,
            int? projectId,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum> events,
            string? description = default,
            global::CVAT.WebhookContentType? contentType = default,
            string? secret = default,
            bool? isActive = default,
            bool? enableSsl = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}