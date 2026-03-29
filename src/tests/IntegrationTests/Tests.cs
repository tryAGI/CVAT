namespace CVAT.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static CVATClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("CVAT_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("CVAT_API_KEY environment variable is not found.");

        var client = new CVATClient(apiKey);
        
        return client;
    }
}
