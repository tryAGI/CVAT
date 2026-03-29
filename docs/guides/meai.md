# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The CVAT SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to CVAT annotation project management, task inspection, label browsing, and job status tracking.

## Installation

```bash
dotnet add package CVAT
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListProjectsTool()` | `CVAT_ListProjects` | List annotation projects with optional search filter and pagination |
| `AsGetTaskTool()` | `CVAT_GetTask` | Get details of a specific annotation task including status, size, assignee, and job/label counts |
| `AsListLabelsTool()` | `CVAT_ListLabels` | List annotation labels/categories with optional filtering by project, task, or job |
| `AsGetJobStatusTool()` | `CVAT_GetJobStatus` | Get the status and details of a specific annotation job including stage, state, and frame range |

## Usage

```csharp
using CVAT;
using Microsoft.Extensions.AI;

var cvatClient = new CVATClient(
    apiKey: Environment.GetEnvironmentVariable("CVAT_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        cvatClient.AsListProjectsTool(),
        cvatClient.AsGetTaskTool(),
        cvatClient.AsListLabelsTool(),
        cvatClient.AsGetJobStatusTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all annotation projects and show me the labels for the first one."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
