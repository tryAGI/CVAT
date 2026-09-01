
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserGrowthData
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        public global::CVAT.BasicUser? Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_prompt_shown")]
        public bool? GithubPromptShown { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_prompt_support_clicked")]
        public bool? GithubPromptSupportClicked { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_prompt_enabled")]
        public bool? GithubPromptEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_notifications_allowed")]
        public bool? PromotionNotificationsAllowed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGrowthData" /> class.
        /// </summary>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="owner">
        /// Included only in responses
        /// </param>
        /// <param name="githubPromptShown"></param>
        /// <param name="githubPromptSupportClicked"></param>
        /// <param name="githubPromptEnabled">
        /// Included only in responses
        /// </param>
        /// <param name="promotionNotificationsAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserGrowthData(
            int? id,
            global::CVAT.BasicUser? owner,
            bool? githubPromptShown,
            bool? githubPromptSupportClicked,
            bool? githubPromptEnabled,
            bool? promotionNotificationsAllowed)
        {
            this.Id = id;
            this.Owner = owner;
            this.GithubPromptShown = githubPromptShown;
            this.GithubPromptSupportClicked = githubPromptSupportClicked;
            this.GithubPromptEnabled = githubPromptEnabled;
            this.PromotionNotificationsAllowed = promotionNotificationsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGrowthData" /> class.
        /// </summary>
        public UserGrowthData()
        {
        }

    }
}