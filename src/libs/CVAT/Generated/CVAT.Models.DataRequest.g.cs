
#nullable enable

namespace CVAT
{
    /// <summary>
    /// Read more about parameters here:<br/>
    /// https://docs.cvat.ai/docs/manual/basics/create-annotation-task/#advanced-configuration
    /// </summary>
    public sealed partial class DataRequest
    {
        /// <summary>
        /// Maximum number of frames per chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_size")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Image quality to use during annotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_quality")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ImageQuality { get; set; }

        /// <summary>
        /// First frame index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame")]
        public int? StartFrame { get; set; }

        /// <summary>
        /// Last frame index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_frame")]
        public int? StopFrame { get; set; }

        /// <summary>
        /// Frame filter. The only supported syntax is: 'step=N'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_filter")]
        public string? FrameFilter { get; set; }

        /// <summary>
        /// Uploaded files.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_files")]
        public global::System.Collections.Generic.IList<byte[]>? ClientFiles { get; set; }

        /// <summary>
        /// Paths to files from a file share mounted on the server, or from a cloud storage.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_files")]
        public global::System.Collections.Generic.IList<string>? ServerFiles { get; set; }

        /// <summary>
        /// Direct download URLs for files.<br/>
        /// Must contain all files from job_file_mapping if job_file_mapping is not empty.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_files")]
        public global::System.Collections.Generic.IList<string>? RemoteFiles { get; set; }

        /// <summary>
        /// When true, video chunks will be represented as zip archives with decoded video frames.<br/>
        /// When false, video chunks are represented as video segments<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_zip_chunks")]
        public bool? UseZipChunks { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_files_exclude")]
        public global::System.Collections.Generic.IList<string>? ServerFilesExclude { get; set; }

        /// <summary>
        /// If not null, the files referenced by server_files will be retrieved<br/>
        /// from the cloud storage with the specified ID.<br/>
        /// The cloud storages applicable depend on the context.<br/>
        /// In the user sandbox, only the user sandbox cloud storages can be used.<br/>
        /// In an organization, only the organization cloud storages can be used.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud_storage_id")]
        public int? CloudStorageId { get; set; }

        /// <summary>
        /// Enable or disable task data chunk caching for the task.<br/>
        /// Read more: https://docs.cvat.ai/docs/manual/advanced/data_on_fly/<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_cache")]
        public bool? UseCache { get; set; }

        /// <summary>
        /// Copy data from the server file share to CVAT during the task creation.<br/>
        /// This will create a copy of the data, making the server independent from<br/>
        /// the file share availability<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("copy_data")]
        public bool? CopyData { get; set; }

        /// <summary>
        /// * `cache` - CACHE<br/>
        /// * `file_system` - FILE_SYSTEM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.StorageMethodJsonConverter))]
        public global::CVAT.StorageMethod? StorageMethod { get; set; }

        /// <summary>
        /// * `lexicographical` - LEXICOGRAPHICAL<br/>
        /// * `natural` - NATURAL<br/>
        /// * `predefined` - PREDEFINED<br/>
        /// * `random` - RANDOM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sorting_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::CVAT.JsonConverters.SortingMethodJsonConverter))]
        public global::CVAT.SortingMethod? SortingMethod { get; set; }

        /// <summary>
        /// A filename filter for cloud storage files<br/>
        /// listed in the manifest. Supports fnmatch wildcards.<br/>
        /// Read more: https://docs.python.org/3/library/fnmatch.html
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename_pattern")]
        public string? FilenamePattern { get; set; }

        /// <summary>
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
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_file_mapping")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? JobFileMapping { get; set; }

        /// <summary>
        /// Allows to specify file order for client_file uploads.<br/>
        /// Only valid with the "predefined" sorting method selected.<br/>
        /// To state that the input files are sent in the correct order,<br/>
        /// pass an empty list.<br/>
        /// If you want to send files in an arbitrary order<br/>
        /// and reorder them afterwards on the server,<br/>
        /// pass the list of file names in the required order.<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upload_file_order")]
        public global::System.Collections.Generic.IList<string>? UploadFileOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_params")]
        public global::CVAT.ValidationParamsRequest? ValidationParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRequest" /> class.
        /// </summary>
        /// <param name="imageQuality">
        /// Image quality to use during annotation
        /// </param>
        /// <param name="chunkSize">
        /// Maximum number of frames per chunk
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataRequest(
            int imageQuality,
            int? chunkSize,
            int? startFrame,
            int? stopFrame,
            string? frameFilter,
            global::System.Collections.Generic.IList<byte[]>? clientFiles,
            global::System.Collections.Generic.IList<string>? serverFiles,
            global::System.Collections.Generic.IList<string>? remoteFiles,
            bool? useZipChunks,
            global::System.Collections.Generic.IList<string>? serverFilesExclude,
            int? cloudStorageId,
            bool? useCache,
            bool? copyData,
            global::CVAT.StorageMethod? storageMethod,
            global::CVAT.SortingMethod? sortingMethod,
            string? filenamePattern,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? jobFileMapping,
            global::System.Collections.Generic.IList<string>? uploadFileOrder,
            global::CVAT.ValidationParamsRequest? validationParams)
        {
            this.ChunkSize = chunkSize;
            this.ImageQuality = imageQuality;
            this.StartFrame = startFrame;
            this.StopFrame = stopFrame;
            this.FrameFilter = frameFilter;
            this.ClientFiles = clientFiles;
            this.ServerFiles = serverFiles;
            this.RemoteFiles = remoteFiles;
            this.UseZipChunks = useZipChunks;
            this.ServerFilesExclude = serverFilesExclude;
            this.CloudStorageId = cloudStorageId;
            this.UseCache = useCache;
            this.CopyData = copyData;
            this.StorageMethod = storageMethod;
            this.SortingMethod = sortingMethod;
            this.FilenamePattern = filenamePattern;
            this.JobFileMapping = jobFileMapping;
            this.UploadFileOrder = uploadFileOrder;
            this.ValidationParams = validationParams;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataRequest" /> class.
        /// </summary>
        public DataRequest()
        {
        }
    }
}