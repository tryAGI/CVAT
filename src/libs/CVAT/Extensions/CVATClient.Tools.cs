#nullable enable

using System.ComponentModel;
using Microsoft.Extensions.AI;

namespace CVAT;

/// <summary>
/// Extension methods providing MEAI AIFunction tools for CVATClient.
/// </summary>
public static class CVATClientTools
{
    /// <summary>
    /// Creates an AIFunction tool that lists annotation projects.
    /// </summary>
    public static AIFunction AsListProjectsTool(this CVATClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional search query to filter projects by name")] string? search,
                   [Description("Page number for pagination (default: 1)")] int? page,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Projects.ProjectsListAsync(
                    search: search,
                    page: page,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Count,
                    response.Next,
                    response.Previous,
                    Results = response.Results?.Select(p => new
                    {
                        p.Id,
                        p.Name,
                        Status = p.Status?.ToValueString(),
                        OwnerUsername = p.Owner?.Username,
                        AssigneeUsername = p.Assignee?.Username,
                        p.CreatedDate,
                        p.UpdatedDate,
                        TasksCount = p.Tasks?.Count ?? 0,
                    }),
                };
            },
            name: "CVAT_ListProjects",
            description: "List annotation projects in CVAT with optional search filter and pagination.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets details of a specific task.
    /// </summary>
    public static AIFunction AsGetTaskTool(this CVATClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the task to retrieve")] int id,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Tasks.TasksRetrieveAsync(
                    id: id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.Name,
                    Status = response.Status?.ToValueString(),
                    response.Size,
                    response.Mode,
                    OwnerUsername = response.Owner?.Username,
                    AssigneeUsername = response.Assignee?.Username,
                    response.ProjectId,
                    response.CreatedDate,
                    response.UpdatedDate,
                    response.Overlap,
                    response.SegmentSize,
                    JobsCount = response.Jobs?.Count ?? 0,
                    JobsCompleted = response.Jobs?.Completed ?? 0,
                    LabelsUrl = response.Labels?.Url,
                };
            },
            name: "CVAT_GetTask",
            description: "Get details of a specific annotation task in CVAT including status, size, assignee, and job/label counts.");
    }

    /// <summary>
    /// Creates an AIFunction tool that lists labels/categories.
    /// </summary>
    public static AIFunction AsListLabelsTool(this CVATClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("Optional project ID to filter labels by project")] int? projectId,
                   [Description("Optional task ID to filter labels by task")] int? taskId,
                   [Description("Optional job ID to filter labels by job")] int? jobId,
                   [Description("Page number for pagination (default: 1)")] int? page,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Labels.LabelsListAsync(
                    projectId: projectId,
                    taskId: taskId,
                    jobId: jobId,
                    page: page,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Count,
                    response.Next,
                    response.Previous,
                    Results = response.Results?.Select(l => new
                    {
                        l.Id,
                        l.Name,
                        l.Color,
                        Type = l.Type?.ToValueString(),
                        l.ParentId,
                        SubLabelsCount = l.Sublabels?.Count ?? 0,
                    }),
                };
            },
            name: "CVAT_ListLabels",
            description: "List annotation labels/categories in CVAT with optional filtering by project, task, or job.");
    }

    /// <summary>
    /// Creates an AIFunction tool that gets the status and details of a specific job.
    /// </summary>
    public static AIFunction AsGetJobStatusTool(this CVATClient client)
    {
        return AIFunctionFactory.Create(
            async ([Description("The ID of the job to retrieve")] int id,
                   CancellationToken cancellationToken) =>
            {
                var response = await client.Jobs.JobsRetrieveAsync(
                    id: id,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return new
                {
                    response.Id,
                    response.TaskId,
                    response.ProjectId,
                    Stage = response.Stage?.ToValueString(),
                    State = response.State?.ToValueString(),
                    Status = response.Status?.ToValueString(),
                    AssigneeUsername = response.Assignee?.Username,
                    response.StartFrame,
                    response.StopFrame,
                    response.FrameCount,
                    response.CreatedDate,
                    response.UpdatedDate,
                };
            },
            name: "CVAT_GetJobStatus",
            description: "Get the status and details of a specific annotation job in CVAT including stage, state, assignee, and frame range.");
    }
}
