
#nullable enable

namespace CVAT
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchedUserGrowthDataRequest
    {
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
        /// Initializes a new instance of the <see cref="PatchedUserGrowthDataRequest" /> class.
        /// </summary>
        /// <param name="githubPromptShown"></param>
        /// <param name="githubPromptSupportClicked"></param>
        /// <param name="promotionNotificationsAllowed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchedUserGrowthDataRequest(
            bool? githubPromptShown,
            bool? githubPromptSupportClicked,
            bool? promotionNotificationsAllowed)
        {
            this.GithubPromptShown = githubPromptShown;
            this.GithubPromptSupportClicked = githubPromptSupportClicked;
            this.PromotionNotificationsAllowed = promotionNotificationsAllowed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchedUserGrowthDataRequest" /> class.
        /// </summary>
        public PatchedUserGrowthDataRequest()
        {
        }

    }
}