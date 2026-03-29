#nullable enable

namespace CVAT
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// List tokens
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="name"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.PaginatedAccessTokenReadList> AuthListAccessTokensAsync(
            string? filter = default,
            string? name = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? sort = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}