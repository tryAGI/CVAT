
#nullable enable

namespace CVAT
{
    public partial class CloudstoragesClient
    {
        partial void PrepareCloudstoragesCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? org,
            ref int? orgId,
            global::CVAT.CloudStorageWriteRequest request);
        partial void PrepareCloudstoragesCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? org,
            int? orgId,
            global::CVAT.CloudStorageWriteRequest request);
        partial void ProcessCloudstoragesCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCloudstoragesCreateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a cloud storage
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesCreateAsync(

            global::CVAT.CloudStorageWriteRequest request,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCloudstoragesCreateArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                org: ref org,
                orgId: ref orgId,
                request: request);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/cloudstorages",
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

            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCloudstoragesCreateRequest(
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
            ProcessCloudstoragesCreateResponse(
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
                ProcessCloudstoragesCreateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.CloudStorageRead.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.CloudStorageRead.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Create a cloud storage
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="providerType">
        /// * `AWS_S3_BUCKET` - Amazon S3<br/>
        /// * `AZURE_CONTAINER` - Azure Blob Storage<br/>
        /// * `GOOGLE_CLOUD_STORAGE` - Google Cloud Storage
        /// </param>
        /// <param name="resource"></param>
        /// <param name="displayName"></param>
        /// <param name="owner"></param>
        /// <param name="credentialsType">
        /// * `KEY_SECRET_KEY_PAIR` - KEY_SECRET_KEY_PAIR<br/>
        /// * `ACCOUNT_NAME_TOKEN_PAIR` - ACCOUNT_NAME_TOKEN_PAIR<br/>
        /// * `KEY_FILE_PATH` - KEY_FILE_PATH<br/>
        /// * `ANONYMOUS_ACCESS` - ANONYMOUS_ACCESS<br/>
        /// * `CONNECTION_STRING` - CONNECTION_STRING
        /// </param>
        /// <param name="sessionToken"></param>
        /// <param name="accountName"></param>
        /// <param name="key"></param>
        /// <param name="secretKey"></param>
        /// <param name="connectionString"></param>
        /// <param name="keyFile"></param>
        /// <param name="keyFilename"></param>
        /// <param name="specificAttributes"></param>
        /// <param name="description"></param>
        /// <param name="manifests">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.CloudStorageRead> CloudstoragesCreateAsync(
            global::CVAT.ProviderTypeEnum providerType,
            string resource,
            string displayName,
            global::CVAT.CredentialsTypeEnum credentialsType,
            string? xOrganization = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.BasicUserRequest? owner = default,
            string? sessionToken = default,
            string? accountName = default,
            string? key = default,
            string? secretKey = default,
            string? connectionString = default,
            byte[]? keyFile = default,
            string? keyFilename = default,
            string? specificAttributes = default,
            string? description = default,
            global::System.Collections.Generic.IList<string>? manifests = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::CVAT.CloudStorageWriteRequest
            {
                ProviderType = providerType,
                Resource = resource,
                DisplayName = displayName,
                Owner = owner,
                CredentialsType = credentialsType,
                SessionToken = sessionToken,
                AccountName = accountName,
                Key = key,
                SecretKey = secretKey,
                ConnectionString = connectionString,
                KeyFile = keyFile,
                KeyFilename = keyFilename,
                SpecificAttributes = specificAttributes,
                Description = description,
                Manifests = manifests,
            };

            return await CloudstoragesCreateAsync(
                xOrganization: xOrganization,
                org: org,
                orgId: orgId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}