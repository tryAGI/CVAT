
#nullable enable

namespace CVAT
{
    /// <summary>
    /// REST API for Computer Vision Annotation Tool (CVAT)<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICVATClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::CVAT.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::CVAT.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// 
        /// </summary>
        public AssetsClient Assets { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// 
        /// </summary>
        public CloudstoragesClient Cloudstorages { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConsensusClient Consensus { get; }

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events { get; }

        /// <summary>
        /// 
        /// </summary>
        public FunctionsClient Functions { get; }

        /// <summary>
        /// 
        /// </summary>
        public GuidesClient Guides { get; }

        /// <summary>
        /// 
        /// </summary>
        public InvitationsClient Invitations { get; }

        /// <summary>
        /// 
        /// </summary>
        public IssuesClient Issues { get; }

        /// <summary>
        /// 
        /// </summary>
        public JobsClient Jobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels { get; }

        /// <summary>
        /// 
        /// </summary>
        public LambdaClient Lambda { get; }

        /// <summary>
        /// 
        /// </summary>
        public LimitsClient Limits { get; }

        /// <summary>
        /// 
        /// </summary>
        public MembershipsClient Memberships { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public QualityClient Quality { get; }

        /// <summary>
        /// 
        /// </summary>
        public RequestsClient Requests { get; }

        /// <summary>
        /// 
        /// </summary>
        public SchemaClient Schema { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServerClient Server { get; }

        /// <summary>
        /// 
        /// </summary>
        public SubscriptionsClient Subscriptions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

    }
}