
#nullable enable

namespace CVAT
{
    public partial class QualityClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_QualityListJobValidationsSecurityRequirement0 =
            new global::CVAT.EndPointSecurityRequirement
            {
                Authorizations = new global::CVAT.EndPointAuthorizationRequirement[]
                {                    new global::CVAT.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_QualityListJobValidationsSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_QualityListJobValidationsSecurityRequirement0,
            };
        partial void PrepareQualityListJobValidationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref int? assignee,
            ref string? filter,
            ref int? jobId,
            ref string? org,
            ref int? orgId,
            ref int? page,
            ref int? pageSize,
            ref int? projectId,
            ref int? reportId,
            ref string? sort,
            ref global::CVAT.QualityListJobValidationsStatus? status,
            ref int? taskId);
        partial void PrepareQualityListJobValidationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            int? assignee,
            string? filter,
            int? jobId,
            string? org,
            int? orgId,
            int? page,
            int? pageSize,
            int? projectId,
            int? reportId,
            string? sort,
            global::CVAT.QualityListJobValidationsStatus? status,
            int? taskId);
        partial void ProcessQualityListJobValidationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQualityListJobValidationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List job validations
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="assignee"></param>
        /// <param name="filter"></param>
        /// <param name="jobId"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="projectId"></param>
        /// <param name="reportId"></param>
        /// <param name="sort"></param>
        /// <param name="status"></param>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedJobValidationList> QualityListJobValidationsAsync(
            string? xOrganization = default,
            int? assignee = default,
            string? filter = default,
            int? jobId = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            int? projectId = default,
            int? reportId = default,
            string? sort = default,
            global::CVAT.QualityListJobValidationsStatus? status = default,
            int? taskId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareQualityListJobValidationsArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                assignee: ref assignee,
                filter: ref filter,
                jobId: ref jobId,
                org: ref org,
                orgId: ref orgId,
                page: ref page,
                pageSize: ref pageSize,
                projectId: ref projectId,
                reportId: ref reportId,
                sort: ref sort,
                status: ref status,
                taskId: ref taskId);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_QualityListJobValidationsSecurityRequirements,
                operationName: "QualityListJobValidationsAsync");

            using var __timeoutCancellationTokenSource = global::CVAT.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::CVAT.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::CVAT.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::CVAT.PathBuilder(
                                path: "/api/quality/job_validations",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("assignee", assignee?.ToString())
                                .AddOptionalParameter("filter", filter)
                                .AddOptionalParameter("job_id", jobId?.ToString())
                                .AddOptionalParameter("org", org)
                                .AddOptionalParameter("org_id", orgId?.ToString())
                                .AddOptionalParameter("page", page?.ToString())
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("project_id", projectId?.ToString())
                                .AddOptionalParameter("report_id", reportId?.ToString())
                                .AddOptionalParameter("sort", sort)
                                .AddOptionalParameter("status", status?.ToValueString())
                                .AddOptionalParameter("task_id", taskId?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::CVAT.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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

                global::CVAT.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareQualityListJobValidationsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xOrganization: xOrganization,
                    assignee: assignee,
                    filter: filter,
                    jobId: jobId,
                    org: org,
                    orgId: orgId,
                    page: page,
                    pageSize: pageSize,
                    projectId: projectId,
                    reportId: reportId,
                    sort: sort,
                    status: status,
                    taskId: taskId);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityListJobValidations",
                                methodName: "QualityListJobValidationsAsync",
                                pathTemplate: "\"/api/quality/job_validations\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityListJobValidations",
                                methodName: "QualityListJobValidationsAsync",
                                pathTemplate: "\"/api/quality/job_validations\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::CVAT.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::CVAT.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityListJobValidations",
                                methodName: "QualityListJobValidationsAsync",
                                pathTemplate: "\"/api/quality/job_validations\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::CVAT.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessQualityListJobValidationsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityListJobValidations",
                                methodName: "QualityListJobValidationsAsync",
                                pathTemplate: "\"/api/quality/job_validations\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "QualityListJobValidations",
                                methodName: "QualityListJobValidationsAsync",
                                pathTemplate: "\"/api/quality/job_validations\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessQualityListJobValidationsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::CVAT.PaginatedJobValidationList.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::CVAT.PaginatedJobValidationList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}