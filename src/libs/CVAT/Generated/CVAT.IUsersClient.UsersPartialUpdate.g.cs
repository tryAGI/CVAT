#nullable enable

namespace CVAT
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MetaUser> UsersPartialUpdateAsync(
            int id,

            global::CVAT.PatchedUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username">
        /// Required. 150 characters or fewer. Letters, digits and @/./+/-/_ only.
        /// </param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="groups"></param>
        /// <param name="isStaff">
        /// Designates whether the user can log into this admin site.
        /// </param>
        /// <param name="isSuperuser">
        /// Designates that this user has all permissions without explicitly assigning them.
        /// </param>
        /// <param name="isActive">
        /// Designates whether this user should be treated as active. Unselect this instead of deleting accounts.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.MetaUser> UsersPartialUpdateAsync(
            int id,
            string? username = default,
            string? firstName = default,
            string? lastName = default,
            string? email = default,
            global::System.Collections.Generic.IList<string>? groups = default,
            bool? isStaff = default,
            bool? isSuperuser = default,
            bool? isActive = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}