#nullable enable

namespace CVAT
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Recreate a project from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/projects/backup schedules a background job on the server<br/>
        /// in which the process of creating a project from the uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created project in the result_id field.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="location">
        /// Default Value: local
        /// </param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateBackupAsync(

            global::CVAT.ProjectFileRequest request,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.ProjectsCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recreate a project from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/projects/backup schedules a background job on the server<br/>
        /// in which the process of creating a project from the uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created project in the result_id field.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="location">
        /// Default Value: local
        /// </param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="projectFile"></param>
        /// <param name="projectFilename"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> ProjectsCreateBackupAsync(
            byte[] projectFile,
            string projectFilename,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.ProjectsCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}