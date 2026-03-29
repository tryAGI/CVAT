
#nullable enable

namespace CVAT
{
    public partial class LabelsClient
    {
        partial void PrepareLabelsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? color,
            ref string? filter,
            ref int? jobId,
            ref string? name,
            ref string? org,
            ref int? orgId,
            ref int? page,
            ref int? pageSize,
            ref string? parent,
            ref int? parentId,
            ref int? projectId,
            ref string? search,
            ref string? sort,
            ref int? taskId,
            ref global::CVAT.LabelsListType? type);
        partial void PrepareLabelsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? color,
            string? filter,
            int? jobId,
            string? name,
            string? org,
            int? orgId,
            int? page,
            int? pageSize,
            string? parent,
            int? parentId,
            int? projectId,
            string? search,
            string? sort,
            int? taskId,
            global::CVAT.LabelsListType? type);
        partial void ProcessLabelsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLabelsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List labels
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="color"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parent"></param>
        /// <param name="parentId"></param>
        /// <param name="projectId"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="taskId"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedLabelList> LabelsListAsync(
            string? xOrganization = default,
            string? color = default,
            string? filter = default,
            int? jobId = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? parent = default,
            int? parentId = default,
            int? projectId = default,
            string? search = default,
            string? sort = default,
            int? taskId = default,
            global::CVAT.LabelsListType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareLabelsListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                color: ref color,
                filter: ref filter,
                jobId: ref jobId,
                name: ref name,
                org: ref org,
                orgId: ref orgId,
                page: ref page,
                pageSize: ref pageSize,
                parent: ref parent,
                parentId: ref parentId,
                projectId: ref projectId,
                search: ref search,
                sort: ref sort,
                taskId: ref taskId,
                type: ref type);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/labels",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("color", color)
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("job_id", jobId?.ToString())
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("parent", parent)
                .AddOptionalParameter("parent_id", parentId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("task_id", taskId?.ToString())
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
            PrepareLabelsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                color: color,
                filter: filter,
                jobId: jobId,
                name: name,
                org: org,
                orgId: orgId,
                page: page,
                pageSize: pageSize,
                parent: parent,
                parentId: parentId,
                projectId: projectId,
                search: search,
                sort: sort,
                taskId: taskId,
                type: type);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessLabelsListResponse(
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
                ProcessLabelsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedLabelList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedLabelList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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