
#nullable enable

namespace CVAT
{
    public partial class ProjectsClient
    {
        partial void PrepareProjectsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? assignee,
            ref string? filter,
            ref string? name,
            ref string? org,
            ref int? orgId,
            ref string? owner,
            ref int? page,
            ref int? pageSize,
            ref string? search,
            ref string? sort,
            ref global::CVAT.ProjectsListStatus? status);
        partial void PrepareProjectsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? assignee,
            string? filter,
            string? name,
            string? org,
            int? orgId,
            string? owner,
            int? page,
            int? pageSize,
            string? search,
            string? sort,
            global::CVAT.ProjectsListStatus? status);
        partial void ProcessProjectsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List projects
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedProjectReadList> ProjectsListAsync(
            string? xOrganization = default,
            string? assignee = default,
            string? filter = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            global::CVAT.ProjectsListStatus? status = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareProjectsListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                assignee: ref assignee,
                filter: ref filter,
                name: ref name,
                org: ref org,
                orgId: ref orgId,
                owner: ref owner,
                page: ref page,
                pageSize: ref pageSize,
                search: ref search,
                sort: ref sort,
                status: ref status);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/projects",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("assignee", assignee)
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("owner", owner)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("status", status?.ToValueString()) 
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
            PrepareProjectsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                assignee: assignee,
                filter: filter,
                name: name,
                org: org,
                orgId: orgId,
                owner: owner,
                page: page,
                pageSize: pageSize,
                search: search,
                sort: sort,
                status: status);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessProjectsListResponse(
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
                ProcessProjectsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedProjectReadList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedProjectReadList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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