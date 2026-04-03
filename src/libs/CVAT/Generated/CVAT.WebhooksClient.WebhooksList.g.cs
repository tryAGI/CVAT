
#nullable enable

namespace CVAT
{
    public partial class WebhooksClient
    {
        partial void PrepareWebhooksListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? filter,
            ref string? org,
            ref int? orgId,
            ref string? owner,
            ref int? page,
            ref int? pageSize,
            ref int? projectId,
            ref string? search,
            ref string? sort,
            ref string? targetUrl,
            ref global::CVAT.WebhooksListType? type);
        partial void PrepareWebhooksListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? filter,
            string? org,
            int? orgId,
            string? owner,
            int? page,
            int? pageSize,
            int? projectId,
            string? search,
            string? sort,
            string? targetUrl,
            global::CVAT.WebhooksListType? type);
        partial void ProcessWebhooksListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessWebhooksListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List webhooks
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="targetUrl"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedWebhookReadList> WebhooksListAsync(
            string? xOrganization = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            string? search = default,
            string? sort = default,
            string? targetUrl = default,
            global::CVAT.WebhooksListType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareWebhooksListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                filter: ref filter,
                org: ref org,
                orgId: ref orgId,
                owner: ref owner,
                page: ref page,
                pageSize: ref pageSize,
                projectId: ref projectId,
                search: ref search,
                sort: ref sort,
                targetUrl: ref targetUrl,
                type: ref type);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/webhooks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("owner", owner)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("target_url", targetUrl)
                .AddOptionalParameter("type", type?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xOrganization != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Organization", xOrganization.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareWebhooksListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                filter: filter,
                org: org,
                orgId: orgId,
                owner: owner,
                page: page,
                pageSize: pageSize,
                projectId: projectId,
                search: search,
                sort: sort,
                targetUrl: targetUrl,
                type: type);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessWebhooksListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessWebhooksListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedWebhookReadList.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::CVAT.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::CVAT.PaginatedWebhookReadList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::CVAT.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}