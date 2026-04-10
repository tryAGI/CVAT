
#nullable enable

namespace CVAT
{
    public partial class ProjectsClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_ProjectsCreateDatasetSecurityRequirement0 =
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
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_ProjectsCreateDatasetSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_ProjectsCreateDatasetSecurityRequirement0,
            };
        partial void PrepareProjectsCreateDatasetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? cloudStorageId,
            ref string? filename,
            ref string? format,
            ref int id,
            ref global::CVAT.ProjectsCreateDatasetLocation? location,
            global::CVAT.DatasetFileRequest request);
        partial void PrepareProjectsCreateDatasetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? cloudStorageId,
            string? filename,
            string? format,
            int id,
            global::CVAT.ProjectsCreateDatasetLocation? location,
            global::CVAT.DatasetFileRequest request);
        partial void ProcessProjectsCreateDatasetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProjectsCreateDatasetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Import a dataset into a project<br/>
        /// The request POST /api/projects/id/dataset initiates a background process to import dataset into a project.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateDatasetAsync(
            int id,

            global::CVAT.DatasetFileRequest request,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.ProjectsCreateDatasetLocation? location = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProjectsCreateDatasetArguments(
                httpClient: HttpClient,
                cloudStorageId: ref cloudStorageId,
                filename: ref filename,
                format: ref format,
                id: ref id,
                location: ref location,
                request: request);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ProjectsCreateDatasetSecurityRequirements,
                operationName: "ProjectsCreateDatasetAsync");

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
                                path: $"/api/projects/{id}/dataset/",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("cloud_storage_id", cloudStorageId?.ToString())
                                .AddOptionalParameter("filename", filename)
                                .AddOptionalParameter("format", format)
                                .AddOptionalParameter("location", location?.ToValueString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::CVAT.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::CVAT.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareProjectsCreateDatasetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    cloudStorageId: cloudStorageId,
                    filename: filename,
                    format: format,
                    id: id,
                    location: location,
                    request: request);

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
                                operationId: "ProjectsCreateDataset",
                                methodName: "ProjectsCreateDatasetAsync",
                                pathTemplate: "$\"/api/projects/{id}/dataset/\"",
                                httpMethod: "POST",
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
                                operationId: "ProjectsCreateDataset",
                                methodName: "ProjectsCreateDatasetAsync",
                                pathTemplate: "$\"/api/projects/{id}/dataset/\"",
                                httpMethod: "POST",
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
                                operationId: "ProjectsCreateDataset",
                                methodName: "ProjectsCreateDatasetAsync",
                                pathTemplate: "$\"/api/projects/{id}/dataset/\"",
                                httpMethod: "POST",
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
                ProcessProjectsCreateDatasetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::CVAT.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::CVAT.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ProjectsCreateDataset",
                                methodName: "ProjectsCreateDatasetAsync",
                                pathTemplate: "$\"/api/projects/{id}/dataset/\"",
                                httpMethod: "POST",
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
                                operationId: "ProjectsCreateDataset",
                                methodName: "ProjectsCreateDatasetAsync",
                                pathTemplate: "$\"/api/projects/{id}/dataset/\"",
                                httpMethod: "POST",
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
                            // 
                            if ((int)__response.StatusCode == 400)
                            {
                                string? __content_400 = null;
                                global::System.Exception? __exception_400 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_400 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_400 = __ex;
                                }

                                throw new global::CVAT.ApiException(
                                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_400,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_400,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }
                            // 
                            if ((int)__response.StatusCode == 405)
                            {
                                string? __content_405 = null;
                                global::System.Exception? __exception_405 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                    else
                                    {
                                        __content_405 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_405 = __ex;
                                }

                                throw new global::CVAT.ApiException(
                                    message: __content_405 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_405,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_405,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
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
                                ProcessProjectsCreateDatasetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::CVAT.RqId.FromJson(__content, JsonSerializerContext) ??
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
                                        await global::CVAT.RqId.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Import a dataset into a project<br/>
        /// The request POST /api/projects/id/dataset initiates a background process to import dataset into a project.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="datasetFile"></param>
        /// <param name="datasetFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateDatasetAsync(
            int id,
            byte[] datasetFile,
            string datasetFilename,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.ProjectsCreateDatasetLocation? location = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.DatasetFileRequest
            {
                DatasetFile = datasetFile,
                DatasetFilename = datasetFilename,
            };

            return await ProjectsCreateDatasetAsync(
                cloudStorageId: cloudStorageId,
                filename: filename,
                format: format,
                id: id,
                location: location,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}