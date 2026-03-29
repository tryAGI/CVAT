/*
order: 10
title: Client Creation
slug: client-creation

Basic example showing how to create a CVAT client with API key authentication.
*/

namespace CVAT.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_ClientCreation()
    {
        //// Create a CVAT client using an API Access token.
        //// You can generate a token in the CVAT UI under User Profile > Access Tokens,
        //// or via the /auth/access_tokens API endpoint.
        using var client = GetAuthenticatedClient();

        //// The client provides access to all CVAT API endpoints via sub-clients:
        //// - client.Projects — manage annotation projects
        //// - client.Tasks — manage annotation tasks
        //// - client.Jobs — manage annotation jobs
        //// - client.Labels — manage annotation labels/categories
        //// - client.Users — manage users
        //// - client.Organizations — manage organizations

        client.Should().NotBeNull();
    }
}
