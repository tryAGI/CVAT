
#nullable enable

namespace CVAT
{
    public partial class JobsClient
    {
        partial void PrepareJobsCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::CVAT.JobWriteRequest request);
        partial void PrepareJobsCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::CVAT.JobWriteRequest request);
        partial void ProcessJobsCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessJobsCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a job
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsCreateAsync(

            global::CVAT.JobWriteRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareJobsCreateArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/jobs",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareJobsCreateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessJobsCreateResponse(
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
                ProcessJobsCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.JobRead.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.JobRead.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a job
        /// </summary>
        /// <param name="assignee"></param>
        /// <param name="stage">
        /// * `annotation` - ANNOTATION<br/>
        /// * `validation` - VALIDATION<br/>
        /// * `acceptance` - ACCEPTANCE
        /// </param>
        /// <param name="state">
        /// * `new` - NEW<br/>
        /// * `in progress` - IN_PROGRESS<br/>
        /// * `completed` - COMPLETED<br/>
        /// * `rejected` - REJECTED
        /// </param>
        /// <param name="type">
        /// * `annotation` - ANNOTATION<br/>
        /// * `ground_truth` - GROUND_TRUTH<br/>
        /// * `consensus_replica` - CONSENSUS_REPLICA
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="frameSelectionMethod">
        /// * `random_uniform` - RANDOM_UNIFORM<br/>
        /// * `random_per_job` - RANDOM_PER_JOB<br/>
        /// * `manual` - MANUAL
        /// </param>
        /// <param name="frameCount">
        /// The number of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="frameShare">
        /// The share of frames included in the GT job.<br/>
        /// Applicable only to the "random_uniform" frame selection method
        /// </param>
        /// <param name="framesPerJobCount">
        /// The number of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="framesPerJobShare">
        /// The share of frames included in the GT job from each annotation job.<br/>
        /// Applicable only to the "random_per_job" frame selection method
        /// </param>
        /// <param name="randomSeed">
        /// The seed value for the random number generator.<br/>
        /// The same value will produce the same frame sets.<br/>
        /// Applicable only to random frame selection methods.<br/>
        /// By default, a random value is used.
        /// </param>
        /// <param name="frames">
        /// The list of frame ids. Applicable only to the "manual" frame selection method
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.JobRead> JobsCreateAsync(
            global::CVAT.JobType type,
            int taskId,
            int? assignee = default,
            global::CVAT.JobStage? stage = default,
            global::CVAT.OperationStatus? state = default,
            global::CVAT.FrameSelectionMethod? frameSelectionMethod = default,
            int? frameCount = default,
            double? frameShare = default,
            int? framesPerJobCount = default,
            double? framesPerJobShare = default,
            int? randomSeed = default,
            global::System.Collections.Generic.IList<int>? frames = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.JobWriteRequest
            {
                Assignee = assignee,
                Stage = stage,
                State = state,
                Type = type,
                TaskId = taskId,
                FrameSelectionMethod = frameSelectionMethod,
                FrameCount = frameCount,
                FrameShare = frameShare,
                FramesPerJobCount = framesPerJobCount,
                FramesPerJobShare = framesPerJobShare,
                RandomSeed = randomSeed,
                Frames = frames,
            };

            return await JobsCreateAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}