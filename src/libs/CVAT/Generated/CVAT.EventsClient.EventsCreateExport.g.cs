
#nullable enable

namespace CVAT
{
    public partial class EventsClient
    {
        partial void PrepareEventsCreateExportArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? cloudStorageId,
            ref string? filename,
            ref global::System.DateTime? from,
            ref int? jobId,
            ref global::CVAT.EventsCreateExportLocation? location,
            ref int? orgId,
            ref int? projectId,
            ref int? taskId,
            ref global::System.DateTime? to,
            ref int? userId);
        partial void PrepareEventsCreateExportRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? cloudStorageId,
            string? filename,
            global::System.DateTime? from,
            int? jobId,
            global::CVAT.EventsCreateExportLocation? location,
            int? orgId,
            int? projectId,
            int? taskId,
            global::System.DateTime? to,
            int? userId);
        partial void ProcessEventsCreateExportResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEventsCreateExportResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Initiate a process to export events
        /// </summary>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="from"></param>
        /// <param name="jobId"></param>
        /// <param name="location"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="taskId"></param>
        /// <param name="to"></param>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> EventsCreateExportAsync(
            int? cloudStorageId = default,
            string? filename = default,
            global::System.DateTime? from = default,
            int? jobId = default,
            global::CVAT.EventsCreateExportLocation? location = default,
            int? orgId = default,
            int? projectId = default,
            int? taskId = default,
            global::System.DateTime? to = default,
            int? userId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareEventsCreateExportArguments(
                httpClient: HttpClient,
                cloudStorageId: ref cloudStorageId,
                filename: ref filename,
                from: ref from,
                jobId: ref jobId,
                location: ref location,
                orgId: ref orgId,
                projectId: ref projectId,
                taskId: ref taskId,
                to: ref to,
                userId: ref userId);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/events/export",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cloud_storage_id", cloudStorageId?.ToString())
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("from", from?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("job_id", jobId?.ToString())
                .AddOptionalParameter("location", location?.ToValueString())
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("task_id", taskId?.ToString())
                .AddOptionalParameter("to", to?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("user_id", userId?.ToString()) 
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEventsCreateExportRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cloudStorageId: cloudStorageId,
                filename: filename,
                from: from,
                jobId: jobId,
                location: location,
                orgId: orgId,
                projectId: projectId,
                taskId: taskId,
                to: to,
                userId: userId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEventsCreateExportResponse(
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
                ProcessEventsCreateExportResponseContent(
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
    }
}