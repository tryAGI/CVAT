
#nullable enable

namespace CVAT
{
    public partial class CloudstoragesClient
    {


        private static readonly global::CVAT.EndPointSecurityRequirement s_CloudstoragesRetrieveContentV2SecurityRequirement0 =
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
        private static readonly global::CVAT.EndPointSecurityRequirement[] s_CloudstoragesRetrieveContentV2SecurityRequirements =
            new global::CVAT.EndPointSecurityRequirement[]
            {                s_CloudstoragesRetrieveContentV2SecurityRequirement0,
            };
        partial void PrepareCloudstoragesRetrieveContentV2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            ref string? manifestPath,
            ref string? nextToken,
            ref int? pageSize,
            ref string? prefix);
        partial void PrepareCloudstoragesRetrieveContentV2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            string? manifestPath,
            string? nextToken,
            int? pageSize,
            string? prefix);
        partial void ProcessCloudstoragesRetrieveContentV2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCloudstoragesRetrieveContentV2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get cloud storage content
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manifestPath"></param>
        /// <param name="nextToken"></param>
        /// <param name="pageSize"></param>
        /// <param name="prefix"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.CloudStorageContent> CloudstoragesRetrieveContentV2Async(
            int id,
            string? manifestPath = default,
            string? nextToken = default,
            int? pageSize = default,
            string? prefix = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCloudstoragesRetrieveContentV2Arguments(
                httpClient: HttpClient,
                id: ref id,
                manifestPath: ref manifestPath,
                nextToken: ref nextToken,
                pageSize: ref pageSize,
                prefix: ref prefix);


            var __authorizations = global::CVAT.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CloudstoragesRetrieveContentV2SecurityRequirements,
                operationName: "CloudstoragesRetrieveContentV2Async");

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: $"/api/cloudstorages/{id}/content-v2",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("manifest_path", manifestPath)
                .AddOptionalParameter("next_token", nextToken)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("prefix", prefix) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCloudstoragesRetrieveContentV2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                manifestPath: manifestPath,
                nextToken: nextToken,
                pageSize: pageSize,
                prefix: prefix);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCloudstoragesRetrieveContentV2Response(
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
                ProcessCloudstoragesRetrieveContentV2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.CloudStorageContent.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.CloudStorageContent.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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