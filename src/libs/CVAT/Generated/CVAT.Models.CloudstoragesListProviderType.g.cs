
#nullable enable

namespace CVAT
{
    /// <summary>
    /// 
    /// </summary>
    public enum CloudstoragesListProviderType
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
    public static class CloudstoragesListProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloudstoragesListProviderType value)
        {
            return value switch
            {
                CloudstoragesListProviderType.AwsS3Bucket => "AWS_S3_BUCKET",
                CloudstoragesListProviderType.AzureContainer => "AZURE_CONTAINER",
                CloudstoragesListProviderType.GoogleCloudStorage => "GOOGLE_CLOUD_STORAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloudstoragesListProviderType? ToEnum(string value)
        {
            return value switch
            {
                "AWS_S3_BUCKET" => CloudstoragesListProviderType.AwsS3Bucket,
                "AZURE_CONTAINER" => CloudstoragesListProviderType.AzureContainer,
                "GOOGLE_CLOUD_STORAGE" => CloudstoragesListProviderType.GoogleCloudStorage,
                _ => null,
            };
        }
    }
}