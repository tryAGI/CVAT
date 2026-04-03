
#nullable enable

namespace CVAT
{
    public partial class QualityClient
    {
        partial void PrepareQualityListReportsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? filter,
            ref int? jobId,
            ref string? org,
            ref int? orgId,
            ref int? page,
            ref int? pageSize,
            ref int? parentId,
            ref int? projectId,
            ref string? sort,
            ref global::CVAT.QualityListReportsTarget? target,
            ref int? taskId);
        partial void PrepareQualityListReportsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? filter,
            int? jobId,
            string? org,
            int? orgId,
            int? page,
            int? pageSize,
            int? parentId,
            int? projectId,
            string? sort,
            global::CVAT.QualityListReportsTarget? target,
            int? taskId);
        partial void ProcessQualityListReportsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQualityListReportsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Method returns a paginated list of quality reports.<br/>
        /// Please note that children reports are included by default<br/>
        /// if the "task_id", "project_id" filters are used.<br/>
        /// If you want to restrict the list of results to a specific report type,<br/>
        /// use the "target" parameter.<br/>
        /// The "parent_id" filter includes all the nested reports recursively.<br/>
        /// For instance, if the "parent_id" is a project report,<br/>
        /// all the related task and job reports will be returned.<br/>
        /// Please note that a report can be reused in several parent reports,<br/>
        /// but the "parent_id" field in responses will include only the first parent report id.<br/>
        /// The "parent_id" filter still returns all the relevant nested reports,<br/>
        /// even though the response "parent_id" values may be different from the requested one.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="parentId"></param>
        /// <param name="projectId"></param>
        /// <param name="sort"></param>
        /// <param name="target"></param>
        /// <param name="taskId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedQualityReportList> QualityListReportsAsync(
            string? xOrganization = default,
            string? filter = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? parentId = default,
            int? projectId = default,
            string? sort = default,
            global::CVAT.QualityListReportsTarget? target = default,
            int? taskId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareQualityListReportsArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                filter: ref filter,
                jobId: ref jobId,
                org: ref org,
                orgId: ref orgId,
                page: ref page,
                pageSize: ref pageSize,
                parentId: ref parentId,
                projectId: ref projectId,
                sort: ref sort,
                target: ref target,
                taskId: ref taskId);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/quality/reports",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("job_id", jobId?.ToString())
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("parent_id", parentId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("target", target?.ToValueString())
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

            if (xOrganization != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Organization", xOrganization.ToString());
            }


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQualityListReportsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                filter: filter,
                jobId: jobId,
                org: org,
                orgId: orgId,
                page: page,
                pageSize: pageSize,
                parentId: parentId,
                projectId: projectId,
                sort: sort,
                target: target,
                taskId: taskId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessQualityListReportsResponse(
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
                ProcessQualityListReportsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedQualityReportList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedQualityReportList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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