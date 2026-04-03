
#nullable enable

namespace CVAT
{
    public partial class TasksClient
    {
        partial void PrepareTasksCreateAnnotationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? cloudStorageId,
            ref string? filename,
            ref string? format,
            ref int id,
            ref global::CVAT.TasksCreateAnnotationsLocation? location,
            ref bool? useDefaultLocation,
            global::CVAT.AnnotationFileRequest request);
        partial void PrepareTasksCreateAnnotationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? cloudStorageId,
            string? filename,
            string? format,
            int id,
            global::CVAT.TasksCreateAnnotationsLocation? location,
            bool? useDefaultLocation,
            global::CVAT.AnnotationFileRequest request);
        partial void ProcessTasksCreateAnnotationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTasksCreateAnnotationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Import annotations into a task<br/>
        /// The request POST /api/tasks/id/annotations initiates a background process to import annotations into a task.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="useDefaultLocation">
        /// Default Value: true
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateAnnotationsAsync(
            int id,

            global::CVAT.AnnotationFileRequest request,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.TasksCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTasksCreateAnnotationsArguments(
                httpClient: HttpClient,
                cloudStorageId: ref cloudStorageId,
                filename: ref filename,
                format: ref format,
                id: ref id,
                location: ref location,
                useDefaultLocation: ref useDefaultLocation,
                request: request);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: $"/api/tasks/{id}/annotations/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cloud_storage_id", cloudStorageId?.ToString())
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("format", format)
                .AddOptionalParameter("location", location?.ToValueString())
                .AddOptionalParameter("use_default_location", useDefaultLocation?.ToString().ToLowerInvariant()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTasksCreateAnnotationsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cloudStorageId: cloudStorageId,
                filename: filename,
                format: format,
                id: id,
                location: location,
                useDefaultLocation: useDefaultLocation,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTasksCreateAnnotationsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 405)
            {
                string? __content_405 = null;
                global::System.Exception? __exception_405 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_405 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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
                ProcessTasksCreateAnnotationsResponseContent(
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
                        cancellationToken
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
        /// <summary>
        /// Import annotations into a task<br/>
        /// The request POST /api/tasks/id/annotations initiates a background process to import annotations into a task.<br/>
        /// Please, use the GET /api/requests/&lt;rq_id&gt; endpoint for checking status of the process.<br/>
        /// The `rq_id` parameter can be found in the response on initiating request.
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        /// <param name="id"></param>
        /// <param name="location"></param>
        /// <param name="useDefaultLocation">
        /// Default Value: true
        /// </param>
        /// <param name="annotationFile"></param>
        /// <param name="annotationFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateAnnotationsAsync(
            int id,
            byte[] annotationFile,
            string annotationFilename,
            int? cloudStorageId = default,
            string? filename = default,
            string? format = default,
            global::CVAT.TasksCreateAnnotationsLocation? location = default,
            bool? useDefaultLocation = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.AnnotationFileRequest
            {
                AnnotationFile = annotationFile,
                AnnotationFilename = annotationFilename,
            };

            return await TasksCreateAnnotationsAsync(
                cloudStorageId: cloudStorageId,
                filename: filename,
                format: format,
                id: id,
                location: location,
                useDefaultLocation: useDefaultLocation,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}