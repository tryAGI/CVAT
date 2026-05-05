#nullable enable

namespace CVAT
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksCreateAsync(

            global::CVAT.WebhookWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.WebhookRead>> WebhooksCreateAsResponseAsync(

            global::CVAT.WebhookWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a webhook
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.WebhookRead> WebhooksCreateAsync(
            string targetUrl,
            global::CVAT.WebhookType type,
            int? projectId,
            global::System.Collections.Generic.IList<global::CVAT.EventsEnum> events,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            string? description = default,
            global::CVAT.WebhookContentType? contentType = default,
            string? secret = default,
            bool? isActive = default,
            bool? enableSsl = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}