
#nullable enable

namespace CVAT
{
    public partial class LambdaClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_LambdaCreateRequestsSecurityRequirement0 =
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
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_LambdaCreateRequestsSecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_LambdaCreateRequestsSecurityRequirement0,
            };
        partial void PrepareLambdaCreateRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? org,
            ref int? orgId,
            global::CVAT.FunctionCallRequest request);
        partial void PrepareLambdaCreateRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? org,
            int? orgId,
            global::CVAT.FunctionCallRequest request);
        partial void ProcessLambdaCreateRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLambdaCreateRequestsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Method calls the function
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.FunctionCall> LambdaCreateRequestsAsync(

            global::CVAT.FunctionCallRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareLambdaCreateRequestsArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                org: ref org,
                orgId: ref orgId,
                request: request);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_LambdaCreateRequestsSecurityRequirements,
                operationName: "LambdaCreateRequestsAsync");

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/lambda/requests",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
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
            PrepareLambdaCreateRequestsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
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
            ProcessLambdaCreateRequestsResponse(
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
                ProcessLambdaCreateRequestsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.FunctionCall.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.FunctionCall.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Method calls the function
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="function">
        /// The name of the function to execute
        /// </param>
        /// <param name="task">
        /// The id of the task to be annotated
        /// </param>
        /// <param name="job">
        /// The id of the job to be annotated
        /// </param>
        /// <param name="maxDistance"></param>
        /// <param name="threshold"></param>
        /// <param name="cleanup">
        /// Whether existing annotations should be removed<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convMaskToPoly">
        /// Deprecated; use conv_mask_to_poly instead<br/>
        /// Included only in requests
        /// </param>
        /// <param name="convMaskToPoly2">
        /// Convert mask shapes to polygons
        /// </param>
        /// <param name="mapping">
        /// Label mapping from the model to the task labels
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.FunctionCall> LambdaCreateRequestsAsync(
            string function,
            int task,
            bool convMaskToPoly,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            int? job = default,
            int? maxDistance = default,
            double? threshold = default,
            bool? cleanup = default,
            bool? convMaskToPoly2 = default,
            global::System.Collections.Generic.Dictionary<string, global::CVAT.LabelMappingEntryRequest>? mapping = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.FunctionCallRequest
            {
                Function = function,
                Task = task,
                Job = job,
                MaxDistance = maxDistance,
                Threshold = threshold,
                Cleanup = cleanup,
                ConvMaskToPoly = convMaskToPoly,
                ConvMaskToPoly2 = convMaskToPoly2,
                Mapping = mapping,
            };

            return await LambdaCreateRequestsAsync(
                xOrganization: xOrganization,
                org: org,
                orgId: orgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}