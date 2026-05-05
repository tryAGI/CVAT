#nullable enable

namespace CVAT
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Attach data to a task<br/>
        /// Allows to upload data (images, video, etc.) to a task.<br/>
        /// Supports the TUS open file uploading protocol (https://tus.io/).<br/>
        /// Supports the following protocols:<br/>
        /// 1. A single Data request<br/>
        /// and<br/>
        /// 2.1. An Upload-Start request<br/>
        /// 2.2.a. Regular TUS protocol requests (Upload-Length + Chunks)<br/>
        /// 2.2.b. Upload-Multiple requests<br/>
        /// 2.3. An Upload-Finish request<br/>
        /// Requests:<br/>
        /// - Data - POST, no extra headers or 'Upload-Start' + 'Upload-Finish' headers.<br/>
        ///   Contains data in the body.<br/>
        /// - Upload-Start - POST, has an 'Upload-Start' header. No body is expected.<br/>
        /// - Upload-Length - POST, has an 'Upload-Length' header (see the TUS specification)<br/>
        /// - Chunk - HEAD/PATCH (see the TUS specification). Sent to /data/&lt;file id&gt; endpoints.<br/>
        /// - Upload-Finish - POST, has an 'Upload-Finish' header. Can contain data in the body.<br/>
        /// - Upload-Multiple - POST, has an 'Upload-Multiple' header. Contains data in the body.<br/>
        /// The 'Upload-Finish' request allows to specify the uploaded files should be ordered.<br/>
        /// This may be needed if the files can be sent unordered. To state that the input files<br/>
        /// are sent ordered, pass an empty list of files in the 'upload_file_order' field.<br/>
        /// If the files are sent unordered, the ordered file list is expected<br/>
        /// in the 'upload_file_order' field. It must be a list of string file paths,<br/>
        /// relative to the dataset root.<br/>
        /// Example:<br/>
        /// files = [<br/>
        ///     "cats/cat_1.jpg",<br/>
        ///     "dogs/dog2.jpg",<br/>
        ///     "image_3.png",<br/>
        ///     ...<br/>
        /// ]<br/>
        /// Independently of the file declaration field used<br/>
        /// ('client_files', 'server_files', etc.), when the 'predefined'<br/>
        /// sorting method is selected, the uploaded files will be ordered according<br/>
        /// to the '.jsonl' manifest file, if it is found in the list of files.<br/>
        /// For archives (e.g. '.zip'), a manifest file ('*.jsonl') is required when using<br/>
        /// the 'predefined' file ordering. Such file must be provided next to the archive<br/>
        /// in the list of files. Read more about manifest files here:<br/>
        /// https://docs.cvat.ai/docs/manual/advanced/dataset_manifest/<br/>
        /// After all data is sent, the operation status can be retrieved via<br/>
        /// the `GET /api/requests/&lt;rq_id&gt;`, where **rq_id** is request ID returned for this request.<br/>
        /// Once data is attached to a task, it cannot be detached or replaced.
        /// </summary>
        /// <param name="uploadFinish"></param>
        /// <param name="uploadMultiple"></param>
        /// <param name="uploadStart"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DataResponse> TasksCreateDataAsync(
            int id,

            global::CVAT.DataRequest request,
            bool? uploadFinish = default,
            bool? uploadMultiple = default,
            bool? uploadStart = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach data to a task<br/>
        /// Allows to upload data (images, video, etc.) to a task.<br/>
        /// Supports the TUS open file uploading protocol (https://tus.io/).<br/>
        /// Supports the following protocols:<br/>
        /// 1. A single Data request<br/>
        /// and<br/>
        /// 2.1. An Upload-Start request<br/>
        /// 2.2.a. Regular TUS protocol requests (Upload-Length + Chunks)<br/>
        /// 2.2.b. Upload-Multiple requests<br/>
        /// 2.3. An Upload-Finish request<br/>
        /// Requests:<br/>
        /// - Data - POST, no extra headers or 'Upload-Start' + 'Upload-Finish' headers.<br/>
        ///   Contains data in the body.<br/>
        /// - Upload-Start - POST, has an 'Upload-Start' header. No body is expected.<br/>
        /// - Upload-Length - POST, has an 'Upload-Length' header (see the TUS specification)<br/>
        /// - Chunk - HEAD/PATCH (see the TUS specification). Sent to /data/&lt;file id&gt; endpoints.<br/>
        /// - Upload-Finish - POST, has an 'Upload-Finish' header. Can contain data in the body.<br/>
        /// - Upload-Multiple - POST, has an 'Upload-Multiple' header. Contains data in the body.<br/>
        /// The 'Upload-Finish' request allows to specify the uploaded files should be ordered.<br/>
        /// This may be needed if the files can be sent unordered. To state that the input files<br/>
        /// are sent ordered, pass an empty list of files in the 'upload_file_order' field.<br/>
        /// If the files are sent unordered, the ordered file list is expected<br/>
        /// in the 'upload_file_order' field. It must be a list of string file paths,<br/>
        /// relative to the dataset root.<br/>
        /// Example:<br/>
        /// files = [<br/>
        ///     "cats/cat_1.jpg",<br/>
        ///     "dogs/dog2.jpg",<br/>
        ///     "image_3.png",<br/>
        ///     ...<br/>
        /// ]<br/>
        /// Independently of the file declaration field used<br/>
        /// ('client_files', 'server_files', etc.), when the 'predefined'<br/>
        /// sorting method is selected, the uploaded files will be ordered according<br/>
        /// to the '.jsonl' manifest file, if it is found in the list of files.<br/>
        /// For archives (e.g. '.zip'), a manifest file ('*.jsonl') is required when using<br/>
        /// the 'predefined' file ordering. Such file must be provided next to the archive<br/>
        /// in the list of files. Read more about manifest files here:<br/>
        /// https://docs.cvat.ai/docs/manual/advanced/dataset_manifest/<br/>
        /// After all data is sent, the operation status can be retrieved via<br/>
        /// the `GET /api/requests/&lt;rq_id&gt;`, where **rq_id** is request ID returned for this request.<br/>
        /// Once data is attached to a task, it cannot be detached or replaced.
        /// </summary>
        /// <param name="uploadFinish"></param>
        /// <param name="uploadMultiple"></param>
        /// <param name="uploadStart"></param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::CVAT.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.AutoSDKHttpResponse<global::CVAT.DataResponse>> TasksCreateDataAsResponseAsync(
            int id,

            global::CVAT.DataRequest request,
            bool? uploadFinish = default,
            bool? uploadMultiple = default,
            bool? uploadStart = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Attach data to a task<br/>
        /// Allows to upload data (images, video, etc.) to a task.<br/>
        /// Supports the TUS open file uploading protocol (https://tus.io/).<br/>
        /// Supports the following protocols:<br/>
        /// 1. A single Data request<br/>
        /// and<br/>
        /// 2.1. An Upload-Start request<br/>
        /// 2.2.a. Regular TUS protocol requests (Upload-Length + Chunks)<br/>
        /// 2.2.b. Upload-Multiple requests<br/>
        /// 2.3. An Upload-Finish request<br/>
        /// Requests:<br/>
        /// - Data - POST, no extra headers or 'Upload-Start' + 'Upload-Finish' headers.<br/>
        ///   Contains data in the body.<br/>
        /// - Upload-Start - POST, has an 'Upload-Start' header. No body is expected.<br/>
        /// - Upload-Length - POST, has an 'Upload-Length' header (see the TUS specification)<br/>
        /// - Chunk - HEAD/PATCH (see the TUS specification). Sent to /data/&lt;file id&gt; endpoints.<br/>
        /// - Upload-Finish - POST, has an 'Upload-Finish' header. Can contain data in the body.<br/>
        /// - Upload-Multiple - POST, has an 'Upload-Multiple' header. Contains data in the body.<br/>
        /// The 'Upload-Finish' request allows to specify the uploaded files should be ordered.<br/>
        /// This may be needed if the files can be sent unordered. To state that the input files<br/>
        /// are sent ordered, pass an empty list of files in the 'upload_file_order' field.<br/>
        /// If the files are sent unordered, the ordered file list is expected<br/>
        /// in the 'upload_file_order' field. It must be a list of string file paths,<br/>
        /// relative to the dataset root.<br/>
        /// Example:<br/>
        /// files = [<br/>
        ///     "cats/cat_1.jpg",<br/>
        ///     "dogs/dog2.jpg",<br/>
        ///     "image_3.png",<br/>
        ///     ...<br/>
        /// ]<br/>
        /// Independently of the file declaration field used<br/>
        /// ('client_files', 'server_files', etc.), when the 'predefined'<br/>
        /// sorting method is selected, the uploaded files will be ordered according<br/>
        /// to the '.jsonl' manifest file, if it is found in the list of files.<br/>
        /// For archives (e.g. '.zip'), a manifest file ('*.jsonl') is required when using<br/>
        /// the 'predefined' file ordering. Such file must be provided next to the archive<br/>
        /// in the list of files. Read more about manifest files here:<br/>
        /// https://docs.cvat.ai/docs/manual/advanced/dataset_manifest/<br/>
        /// After all data is sent, the operation status can be retrieved via<br/>
        /// the `GET /api/requests/&lt;rq_id&gt;`, where **rq_id** is request ID returned for this request.<br/>
        /// Once data is attached to a task, it cannot be detached or replaced.
        /// </summary>
        /// <param name="uploadFinish"></param>
        /// <param name="uploadMultiple"></param>
        /// <param name="uploadStart"></param>
        /// <param name="id"></param>
        /// <param name="chunkSize">
        /// Maximum number of frames per chunk
        /// </param>
        /// <param name="imageQuality">
        /// Image quality to use during annotation
        /// </param>
        /// <param name="startFrame">
        /// First frame index
        /// </param>
        /// <param name="stopFrame">
        /// Last frame index
        /// </param>
        /// <param name="frameFilter">
        /// Frame filter. The only supported syntax is: 'step=N'
        /// </param>
        /// <param name="clientFiles">
        /// Uploaded files.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="serverFiles">
        /// Paths to files from a file share mounted on the server, or from a cloud storage.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="remoteFiles">
        /// Direct download URLs for files.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="useZipChunks">
        /// When true, video chunks will be represented as zip archives with decoded video frames.<br/>
        /// When false, video chunks are represented as video segments<br/>
        /// Default Value: false
        /// </param>
        /// <param name="serverFilesExclude">
        /// Paths to files and directories from a file share mounted on the server, or from a cloud storage<br/>
        /// that should be excluded from the directories specified in server_files.<br/>
        /// This option cannot be used together with filename_pattern.<br/>
        /// The server_files_exclude parameter cannot be used to exclude a part of dataset from an archive.<br/>
        /// Examples:<br/>
        /// Exclude all files from subfolder 'sub/sub_1/sub_2'and single file 'sub/image.jpg' from specified folder:<br/>
        /// server_files = ['sub/'], server_files_exclude = ['sub/sub_1/sub_2/', 'sub/image.jpg']<br/>
        /// Exclude all cloud storage files with prefix 'sub' from the content of manifest file:<br/>
        /// server_files = ['manifest.jsonl'], server_files_exclude = ['sub/']<br/>
        /// Default Value: []
        /// </param>
        /// <param name="cloudStorageId">
        /// If not null, the files referenced by server_files will be retrieved<br/>
        /// from the cloud storage with the specified ID.<br/>
        /// The cloud storages applicable depend on the context.<br/>
        /// In the user sandbox, only the user sandbox cloud storages can be used.<br/>
        /// In an organization, only the organization cloud storages can be used.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="useCache">
        /// Enable or disable task data chunk caching for the task.<br/>
        /// Read more: https://docs.cvat.ai/docs/manual/advanced/data_on_fly/<br/>
        /// Default Value: false
        /// </param>
        /// <param name="copyData">
        /// Copy data from the server file share to CVAT during the task creation.<br/>
        /// This will create a copy of the data, making the server independent from<br/>
        /// the file share availability<br/>
        /// Default Value: false
        /// </param>
        /// <param name="storageMethod">
        /// * `cache` - CACHE<br/>
        /// * `file_system` - FILE_SYSTEM
        /// </param>
        /// <param name="sortingMethod">
        /// * `lexicographical` - LEXICOGRAPHICAL<br/>
        /// * `natural` - NATURAL<br/>
        /// * `predefined` - PREDEFINED<br/>
        /// * `random` - RANDOM
        /// </param>
        /// <param name="filenamePattern">
        /// A filename filter for cloud storage files<br/>
        /// listed in the manifest. Supports fnmatch wildcards.<br/>
        /// Read more: https://docs.python.org/3/library/fnmatch.html
        /// </param>
        /// <param name="jobFileMapping">
        /// Represents a file-to-job mapping.<br/>
        /// Useful to specify a custom job configuration during task creation.<br/>
        /// This option is not compatible with most other job split-related options.<br/>
        /// Files in the jobs must not overlap or repeat.<br/>
        /// Job file mapping files must be a subset of the input files.<br/>
        /// If directories are specified in server_files, all files obtained by recursive search<br/>
        /// in the specified directories will be used as input files.<br/>
        /// In case of missing items in the input files, an error will be raised.<br/>
        /// Example:<br/>
        /// [<br/>
        ///     ["file1.jpg", "file2.jpg"], # job #1 files<br/>
        ///     ["file3.png"], # job #2 files<br/>
        ///     ["file4.jpg", "file5.png", "file6.bmp"], # job #3 files<br/>
        /// ]<br/>
        /// Included only in requests
        /// </param>
        /// <param name="uploadFileOrder">
        /// Allows to specify file order for client_file uploads.<br/>
        /// Only valid with the "predefined" sorting method selected.<br/>
        /// To state that the input files are sent in the correct order,<br/>
        /// pass an empty list.<br/>
        /// If you want to send files in an arbitrary order<br/>
        /// and reorder them afterwards on the server,<br/>
        /// pass the list of file names in the required order.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="validationParams"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::CVAT.DataResponse> TasksCreateDataAsync(
            int id,
            int imageQuality,
            int? cloudStorageId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>> jobFileMapping,
            global::System.Collections.Generic.IList<string> uploadFileOrder,
            bool? uploadFinish = default,
            bool? uploadMultiple = default,
            bool? uploadStart = default,
            int? chunkSize = default,
            int? startFrame = default,
            int? stopFrame = default,
            string? frameFilter = default,
            global::System.Collections.Generic.IList<byte[]>? clientFiles = default,
            global::System.Collections.Generic.IList<string>? serverFiles = default,
            global::System.Collections.Generic.IList<string>? remoteFiles = default,
            bool? useZipChunks = default,
            global::System.Collections.Generic.IList<string>? serverFilesExclude = default,
            bool? useCache = default,
            bool? copyData = default,
            global::CVAT.StorageMethod? storageMethod = default,
            global::CVAT.SortingMethod? sortingMethod = default,
            string? filenamePattern = default,
            global::CVAT.ValidationParamsRequest? validationParams = default,
            global::CVAT.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}