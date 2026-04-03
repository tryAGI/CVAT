
#nullable enable

namespace CVAT
{
    public partial class JobsClient
    {
        partial void PrepareJobsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? assignee,
            ref global::CVAT.JobsListDimension? dimension,
            ref string? filter,
            ref string? org,
            ref int? orgId,
            ref int? page,
            ref int? pageSize,
            ref int? parentJobId,
            ref int? projectId,
            ref string? projectName,
            ref string? search,
            ref string? sort,
            ref global::CVAT.JobsListStage? stage,
            ref global::CVAT.JobsListState? state,
            ref int? taskId,
            ref string? taskName,
            ref global::CVAT.JobsListType? type);
        partial void PrepareJobsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? assignee,
            global::CVAT.JobsListDimension? dimension,
            string? filter,
            string? org,
            int? orgId,
            int? page,
            int? pageSize,
            int? parentJobId,
            int? projectId,
            string? projectName,
            string? search,
            string? sort,
            global::CVAT.JobsListStage? stage,
            global::CVAT.JobsListState? state,
            int? taskId,
            string? taskName,
            global::CVAT.JobsListType? type);
        partial void ProcessJobsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessJobsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List jobs
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="dimension"></param>
        /// <param name="filter"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentJobId"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="stage"></param>
        /// <param name="state"></param>
        /// <param name="taskId"></param>
        /// <param name="taskName"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedJobReadList> JobsListAsync(
            string? xOrganization = default,
            string? assignee = default,
            global::CVAT.JobsListDimension? dimension = default,
            string? filter = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? parentJobId = default,
            int? projectId = default,
            string? projectName = default,
            string? search = default,
            string? sort = default,
            global::CVAT.JobsListStage? stage = default,
            global::CVAT.JobsListState? state = default,
            int? taskId = default,
            string? taskName = default,
            global::CVAT.JobsListType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareJobsListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                assignee: ref assignee,
                dimension: ref dimension,
                filter: ref filter,
                org: ref org,
                orgId: ref orgId,
                page: ref page,
                pageSize: ref pageSize,
                parentJobId: ref parentJobId,
                projectId: ref projectId,
                projectName: ref projectName,
                search: ref search,
                sort: ref sort,
                stage: ref stage,
                state: ref state,
                taskId: ref taskId,
                taskName: ref taskName,
                type: ref type);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/jobs",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("assignee", assignee)
                .AddOptionalParameter("dimension", dimension?.ToValueString())
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("parent_job_id", parentJobId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("project_name", projectName)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("stage", stage?.ToValueString())
                .AddOptionalParameter("state", state?.ToValueString())
                .AddOptionalParameter("task_id", taskId?.ToString())
                .AddOptionalParameter("task_name", taskName)
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
            PrepareJobsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                assignee: assignee,
                dimension: dimension,
                filter: filter,
                org: org,
                orgId: orgId,
                page: page,
                pageSize: pageSize,
                parentJobId: parentJobId,
                projectId: projectId,
                projectName: projectName,
                search: search,
                sort: sort,
                stage: stage,
                state: state,
                taskId: taskId,
                taskName: taskName,
                type: type);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessJobsListResponse(
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
                ProcessJobsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedJobReadList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedJobReadList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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