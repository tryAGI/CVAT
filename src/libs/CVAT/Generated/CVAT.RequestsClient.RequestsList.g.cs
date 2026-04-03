
#nullable enable

namespace CVAT
{
    public partial class RequestsClient
    {
        partial void PrepareRequestsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? action,
            ref string? filter,
            ref string? format,
            ref int? jobId,
            ref string? org,
            ref int? page,
            ref int? pageSize,
            ref int? projectId,
            ref string? sort,
            ref global::CVAT.RequestsListStatus? status,
            ref string? subresource,
            ref string? target,
            ref int? taskId);
        partial void PrepareRequestsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? action,
            string? filter,
            string? format,
            int? jobId,
            string? org,
            int? page,
            int? pageSize,
            int? projectId,
            string? sort,
            global::CVAT.RequestsListStatus? status,
            string? subresource,
            string? target,
            int? taskId);
        partial void ProcessRequestsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessRequestsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List requests
        /// </summary>
        /// <param name="action"></param>
        /// <param name="filter"></param>
        /// <param name="format"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="subresource"></param>
        /// <param name="target"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedRequestList> RequestsListAsync(
            string? action = default,
            string? filter = default,
            string? format = default,
            int? jobId = default,
            string? org = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            string? sort = default,
            global::CVAT.RequestsListStatus? status = default,
            string? subresource = default,
            string? target = default,
            int? taskId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareRequestsListArguments(
                httpClient: HttpClient,
                action: ref action,
                filter: ref filter,
                format: ref format,
                jobId: ref jobId,
                org: ref org,
                page: ref page,
                pageSize: ref pageSize,
                projectId: ref projectId,
                sort: ref sort,
                status: ref status,
                subresource: ref subresource,
                target: ref target,
                taskId: ref taskId);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/requests",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("action", action)
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("format", format)
                .AddOptionalParameter("job_id", jobId?.ToString())
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("subresource", subresource)
                .AddOptionalParameter("target", target)
                .AddOptionalParameter("task_id", taskId?.ToString()) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareRequestsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                action: action,
                filter: filter,
                format: format,
                jobId: jobId,
                org: org,
                page: page,
                pageSize: pageSize,
                projectId: projectId,
                sort: sort,
                status: status,
                subresource: subresource,
                target: target,
                taskId: taskId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessRequestsListResponse(
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
                ProcessRequestsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedRequestList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedRequestList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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