
#nullable enable

namespace CVAT
{
    public partial class TasksClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_TasksCreateBackupSecurityRequirement0 =
            new global::CVAT.EndPointSecurityRequirement
            {
                Authorizations = new global::CVAT.EndPointAuthorizationRequirement[]
                {                    new global::CVAT.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_TasksCreateBackupSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_TasksCreateBackupSecurityRequirement0,
            };
        partial void PrepareTasksCreateBackupArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref int? cloudStorageId,
            ref string? filename,
            ref global::CVAT.TasksCreateBackupLocation? location,
            ref string? org,
            ref int? orgId,
            global::CVAT.TaskFileRequest request);
        partial void PrepareTasksCreateBackupRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            int? cloudStorageId,
            string? filename,
            global::CVAT.TasksCreateBackupLocation? location,
            string? org,
            int? orgId,
            global::CVAT.TaskFileRequest request);
        partial void ProcessTasksCreateBackupResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTasksCreateBackupResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Recreate a task from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/tasks/backup creates a background job on the server<br/>
        /// in which the process of a task creating from an uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created task in the result_id field.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="location">
        /// Default Value: local
        /// </param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateBackupAsync(

            global::CVAT.TaskFileRequest request,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.TasksCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTasksCreateBackupArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                cloudStorageId: ref cloudStorageId,
                filename: ref filename,
                location: ref location,
                org: ref org,
                orgId: ref orgId,
                request: request);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TasksCreateBackupSecurityRequirements,
                operationName: "TasksCreateBackupAsync");

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/tasks/backup/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("cloud_storage_id", cloudStorageId?.ToString())
                .AddOptionalParameter("filename", filename)
                .AddOptionalParameter("location", location?.ToValueString())
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTasksCreateBackupRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                cloudStorageId: cloudStorageId,
                filename: filename,
                location: location,
                org: org,
                orgId: orgId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTasksCreateBackupResponse(
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
                ProcessTasksCreateBackupResponseContent(
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
        /// Recreate a task from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/tasks/backup creates a background job on the server<br/>
        /// in which the process of a task creating from an uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created task in the result_id field.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="location">
        /// Default Value: local
        /// </param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="taskFile"></param>
        /// <param name="taskFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateBackupAsync(
            byte[] taskFile,
            string taskFilename,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.TasksCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.TaskFileRequest
            {
                TaskFile = taskFile,
                TaskFilename = taskFilename,
            };

            return await TasksCreateBackupAsync(
                xOrganization: xOrganization,
                cloudStorageId: cloudStorageId,
                filename: filename,
                location: location,
                org: org,
                orgId: orgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}