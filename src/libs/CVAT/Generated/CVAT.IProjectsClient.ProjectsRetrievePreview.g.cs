#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get a preview image for a project
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task ProjectsRetrievePreviewAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}