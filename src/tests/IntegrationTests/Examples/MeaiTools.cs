/*
order: 20
title: MEAI Tools
slug: meai-tools

Example showing how to create MEAI AIFunction tools for use with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace CVAT.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_MeaiTools()
    {
        //// Create CVAT AIFunction tools for use with any IChatClient.
        //// These tools allow AI agents to interact with CVAT for
        //// computer vision annotation workflows.
        using var client = GetAuthenticatedClient();

        //// Create tools for common CVAT operations:
        var listProjectsTool = client.AsListProjectsTool();
        var getTaskTool = client.AsGetTaskTool();
        var listLabelsTool = client.AsListLabelsTool();
        var getJobStatusTool = client.AsGetJobStatusTool();

        //// Verify all tools are created successfully:
        listProjectsTool.Should().NotBeNull();
        listProjectsTool.Name.Should().Be("CVAT_ListProjects");

        getTaskTool.Should().NotBeNull();
        getTaskTool.Name.Should().Be("CVAT_GetTask");

        listLabelsTool.Should().NotBeNull();
        listLabelsTool.Name.Should().Be("CVAT_ListLabels");

        getJobStatusTool.Should().NotBeNull();
        getJobStatusTool.Name.Should().Be("CVAT_GetJobStatus");

        //// These tools can be passed to any IChatClient implementation:
        //// var response = await chatClient.GetResponseAsync(
        ////     "List all annotation projects",
        ////     new ChatOptions
        ////     {
        ////         Tools = [listProjectsTool, getTaskTool, listLabelsTool, getJobStatusTool],
        ////     });
    }
}
