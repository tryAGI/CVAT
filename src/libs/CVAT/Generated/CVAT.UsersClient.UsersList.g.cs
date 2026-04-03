
#nullable enable

namespace CVAT
{
    public partial class UsersClient
    {
        partial void PrepareUsersListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xOrganization,
            ref string? filter,
            ref string? firstName,
            ref bool? isActive,
            ref string? lastName,
            ref string? org,
            ref int? orgId,
            ref int? page,
            ref int? pageSize,
            ref string? search,
            ref string? sort,
            ref string? username);
        partial void PrepareUsersListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xOrganization,
            string? filter,
            string? firstName,
            bool? isActive,
            string? lastName,
            string? org,
            int? orgId,
            int? page,
            int? pageSize,
            string? search,
            string? sort,
            string? username);
        partial void ProcessUsersListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUsersListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List users
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="filter"></param>
        /// <param name="firstName"></param>
        /// <param name="isActive"></param>
        /// <param name="lastName"></param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::CVAT.PaginatedMetaUserList> UsersListAsync(
            string? xOrganization = default,
            string? filter = default,
            string? firstName = default,
            bool? isActive = default,
            string? lastName = default,
            string? org = default,
            int? orgId = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            string? username = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUsersListArguments(
                httpClient: HttpClient,
                xOrganization: ref xOrganization,
                filter: ref filter,
                firstName: ref firstName,
                isActive: ref isActive,
                lastName: ref lastName,
                org: ref org,
                orgId: ref orgId,
                page: ref page,
                pageSize: ref pageSize,
                search: ref search,
                sort: ref sort,
                username: ref username);

            var __pathBuilder = new global::CVAT.PathBuilder(
                path: "/api/users",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("first_name", firstName)
                .AddOptionalParameter("is_active", isActive?.ToString().ToLowerInvariant())
                .AddOptionalParameter("last_name", lastName)
                .AddOptionalParameter("org", org)
                .AddOptionalParameter("org_id", orgId?.ToString())
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("sort", sort)
                .AddOptionalParameter("username", username) 
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
            PrepareUsersListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                xOrganization: xOrganization,
                filter: filter,
                firstName: firstName,
                isActive: isActive,
                lastName: lastName,
                org: org,
                orgId: orgId,
                page: page,
                pageSize: pageSize,
                search: search,
                sort: sort,
                username: username);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUsersListResponse(
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
                ProcessUsersListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::CVAT.PaginatedMetaUserList.FromJson(__content, JsonSerializerContext) ??
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
                        await global::CVAT.PaginatedMetaUserList.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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