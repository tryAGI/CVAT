#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Recreate a task from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/tasks/backup creates a background job on the server<br/>
        /// in which the process of a task creating from an uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created task in the result_id field.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateBackupAsync(

            global::CVAT.TaskFileRequest request,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.TasksCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recreate a task from a backup<br/>
        /// The backup import process is as follows:<br/>
        /// The first request POST /api/tasks/backup creates a background job on the server<br/>
        /// in which the process of a task creating from an uploaded backup is carried out.<br/>
        /// To check the status of the import process, use GET /api/requests/rq_id,<br/>
        /// where rq_id is the request ID obtained from the response to the previous request.<br/>
        /// Once the import completes successfully, the response will contain the ID<br/>
        /// of the newly created task in the result_id field.
        /// </summary>
        /// <param name="xOrganization"></param>
        /// <param name="cloudStorageId"></param>
        /// <param name="filename"></param>
        /// <param name="location">
        /// Default Value: local
        /// </param>
        /// <param name="org"></param>
        /// <param name="orgId"></param>
        /// <param name="taskFile"></param>
        /// <param name="taskFilename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.RqId> TasksCreateBackupAsync(
            byte[] taskFile,
            string taskFilename,
            string? xOrganization = default,
            int? cloudStorageId = default,
            string? filename = default,
            global::CVAT.TasksCreateBackupLocation? location = default,
            string? org = default,
            int? orgId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}