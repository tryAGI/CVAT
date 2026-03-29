
#nullable enable

namespace CVAT
{
    /// <summary>
    /// * `AWS_S3_BUCKET` - Amazon S3<br/>
    /// * `AZURE_CONTAINER` - Azure Blob Storage<br/>
    /// * `GOOGLE_CLOUD_STORAGE` - Google Cloud Storage
    /// </summary>
    public enum ProviderTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AwsS3Bucket,
        /// <summary>
        /// 
        /// </summary>
        AzureContainer,
        /// <summary>
        /// 
        /// </summary>
        GoogleCloudStorage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderTypeEnum value)
        {
            return value switch
            {
                ProviderTypeEnum.AwsS3Bucket => "AWS_S3_BUCKET",
                ProviderTypeEnum.AzureContainer => "AZURE_CONTAINER",
                ProviderTypeEnum.GoogleCloudStorage => "GOOGLE_CLOUD_STORAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "AWS_S3_BUCKET" => ProviderTypeEnum.AwsS3Bucket,
                "AZURE_CONTAINER" => ProviderTypeEnum.AzureContainer,
                "GOOGLE_CLOUD_STORAGE" => ProviderTypeEnum.GoogleCloudStorage,
                _ => null,
            };
        }
    }
}