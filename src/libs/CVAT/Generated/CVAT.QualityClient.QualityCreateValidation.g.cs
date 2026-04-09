
#nullable enable

namespace CVAT
{
    public partial class QualityClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_QualityCreateValidationSecurityRequirement0 =
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
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_QualityCreateValidationSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_QualityCreateValidationSecurityRequirement0,
            };
        partial void PrepareQualityCreateValidationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::CVAT.JobValidationCreateRequest request);
        partial void PrepareQualityCreateValidationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::CVAT.JobValidationCreateRequest request);
        partial void ProcessQualityCreateValidationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessQualityCreateValidationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a job validation request<br/>
        /// The endpoint can be used this way:<br/>
        ///     request_data = {"job_id": 42}<br/>
        ///     response = post(body=request_data)<br/>
        ///     if response.status == 200:<br/>
        ///         return response.data["status"] # likely, "disabled"<br/>
        ///     rq_id = response.data["rq_id"]<br/>
        ///     while True:<br/>
        ///         response = get(f"/api/requests/{rq_id}")<br/>
        ///         background_request = json.loads(response.data)<br/>
        ///         if background_request["status"] == "finished":<br/>
        ///             return background_request<br/>
        ///         elif background_request["status"] == "failed":<br/>
        ///             raise Exception(background_request["message"])<br/>
        /// Only the last validation request to a job is considered valid. If a new request arrives<br/>
        /// before the previous one is completed, the previous one is considered canceled.<br/>
        /// The attempts counter will be increased regardless of the results being collected.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.JobValidation> QualityCreateValidationAsync(

            global::CVAT.JobValidationCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareQualityCreateValidationArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_QualityCreateValidationSecurityRequirements,
                operationName: "QualityCreateValidationAsync");

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/quality/job_validations",
                baseUri: HttpClient.BaseAddress);
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareQualityCreateValidationRequest(
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
            ProcessQualityCreateValidationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
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
                ProcessQualityCreateValidationResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.JobValidation.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.JobValidation.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a job validation request<br/>
        /// The endpoint can be used this way:<br/>
        ///     request_data = {"job_id": 42}<br/>
        ///     response = post(body=request_data)<br/>
        ///     if response.status == 200:<br/>
        ///         return response.data["status"] # likely, "disabled"<br/>
        ///     rq_id = response.data["rq_id"]<br/>
        ///     while True:<br/>
        ///         response = get(f"/api/requests/{rq_id}")<br/>
        ///         background_request = json.loads(response.data)<br/>
        ///         if background_request["status"] == "finished":<br/>
        ///             return background_request<br/>
        ///         elif background_request["status"] == "failed":<br/>
        ///             raise Exception(background_request["message"])<br/>
        /// Only the last validation request to a job is considered valid. If a new request arrives<br/>
        /// before the previous one is completed, the previous one is considered canceled.<br/>
        /// The attempts counter will be increased regardless of the results being collected.
        /// </summary>
        /// <param name="jobId">
        /// Included only in requests
        /// </param>
        /// <param name="timeout">
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.JobValidation> QualityCreateValidationAsync(
            int jobId,
            int? timeout,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.JobValidationCreateRequest
            {
                JobId = jobId,
                Timeout = timeout,
            };

            return await QualityCreateValidationAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}