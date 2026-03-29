
#nullable enable

namespace CVAT
{
    public partial class CloudstoragesClient
    {
        partial void PrepareCloudstoragesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref global::CVAT.CloudstoragesListCredentialsType? credentialsType,
            ref string? filter,
            ref string? name,
            ref string? org,
            ref int? orgId,
            ref string? owner,
            ref int? page,
            ref int? pageSize,
            ref global::CVAT.CloudstoragesListProviderType? providerType,
            ref string? resource,
            ref string? search,
            ref string? sort);
        partial void PrepareCloudstoragesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            global::CVAT.CloudstoragesListCredentialsType? credentialsType,
            string? filter,
            string? name,
            string? org,
            int? orgId,
            string? owner,
            int? page,
            int? pageSize,
            global::CVAT.CloudstoragesListProviderType? providerType,
            string? resource,
            string? search,
            string? sort);
        partial void ProcessCloudstoragesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCloudstoragesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List cloud storages
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="credentialsType"></param>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="owner"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="providerType"></param>
        /// <param name="resource"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedCloudStorageReadList> CloudstoragesListAsync(
            string? xOrganization = default,
            global::CVAT.CloudstoragesListCredentialsType? credentialsType = default,
            string? filter = default,
            string? name = default,
            string? org = default,
            int? orgId = default,
            string? owner = default,
            int? page = default,
            int? pageSize = default,
            global::CVAT.CloudstoragesListProviderType? providerType = default,
            string? resource = default,
            string? search = default,
            string? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareCloudstoragesListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                credentialsType: ref credentialsType,
                filter: ref filter,
                name: ref name,
                org: ref org,
                orgId: ref orgId,
                owner: ref owner,
                page: ref page,
                pageSize: ref pageSize,
                providerType: ref providerType,
                resource: ref resource,
                search: ref search,
                sort: ref sort);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/cloudstorages",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("credentials_type", credentialsType?.ToValueString())
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("name", name)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("owner", owner)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("provider_type", providerType?.ToValueString())
                .AddOptionalParameter("resource", resource)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCloudstoragesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                credentialsType: credentialsType,
                filter: filter,
                name: name,
                org: org,
                orgId: orgId,
                owner: owner,
                page: page,
                pageSize: pageSize,
                providerType: providerType,
                resource: resource,
                search: search,
                sort: sort);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCloudstoragesListResponse(
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
                ProcessCloudstoragesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedCloudStorageReadList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedCloudStorageReadList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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