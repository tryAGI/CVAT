# CLAUDE.md -- CVAT SDK

## Overview

Auto-generated C# SDK for [CVAT](https://www.cvat.ai/) (Computer Vision Annotation Tool) -- an Intel-backed open-source platform for annotating images and videos for computer vision tasks.
OpenAPI spec dynamically generated from `https://app.cvat.ai/api/schema/?format=openapi-json` (OpenAPI 3.0.3, v2.61.0).

## Build & Test

```bash
dotnet build CVAT.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API Access Token via Bearer auth. Generate tokens in the CVAT UI (User Profile > Access Tokens) or via `/auth/access_tokens` API:

```csharp
var client = new CVATClient(apiKey); // CVAT_API_KEY env var
```

## Key Files

- `src/libs/CVAT/openapi.yaml` -- Downloaded and transformed OpenAPI spec (YAML -> JSON)
- `src/libs/CVAT/generate.sh` -- Downloads spec, fixes auth/servers, runs autosdk
- `src/libs/CVAT/Generated/` -- **Never edit** -- auto-generated code (1124 files)
- `src/libs/CVAT/Extensions/CVATClient.Tools.cs` -- MEAI `AIFunction` tools
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Sub-client Pattern

```csharp
var client = new CVATClient(apiKey);

// Projects -- manage annotation projects
client.Projects.ProjectsListAsync()
client.Projects.ProjectsRetrieveAsync(id)
client.Projects.ProjectsCreateAsync(request)

// Tasks -- manage annotation tasks
client.Tasks.TasksListAsync()
client.Tasks.TasksRetrieveAsync(id)
client.Tasks.TasksCreateAsync(request)

// Jobs -- manage annotation jobs
client.Jobs.JobsListAsync()
client.Jobs.JobsRetrieveAsync(id)

// Labels -- manage annotation labels/categories
client.Labels.LabelsListAsync()
client.Labels.LabelsRetrieveAsync(id)

// Users, Organizations, Webhooks, Quality, etc.
client.Users.UsersListAsync()
client.Organizations.OrganizationsListAsync()
client.Quality.QualityListReportsAsync()
```

## MEAI Integration

AIFunction tools for use with any `IChatClient`:
- `AsListProjectsTool()` -- List annotation projects with search/pagination
- `AsGetTaskTool()` -- Get task details including status, assignee, job/label counts
- `AsListLabelsTool()` -- List labels filtered by project, task, or job
- `AsGetJobStatusTool()` -- Get job status including stage, state, and frame range

## Spec Notes

- Base URL: `https://app.cvat.ai`
- Spec is dynamically generated (not a static file in the CVAT repo)
- Auth: Bearer token (API Access Token) -- spec has 6 auth schemes; we use `accessTokenAuth` (http/bearer)
- `generate.sh` adds top-level `security` and `servers` arrays (spec only has per-operation security)
- `generate.sh` removes `/api/cloudstorages/{id}/status` endpoint (bare enum response incompatible with generated FromJson)
- `--security-scheme Http:Header:Bearer` ensures proper constructor generation
