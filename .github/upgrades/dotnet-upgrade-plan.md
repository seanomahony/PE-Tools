# .NET 10.0 Upgrade Plan

## Execution Steps

Execute steps below sequentially one by one in the order they are listed.

1. Validate that an .NET 10.0 SDK required for this upgrade is installed on the machine and if not, help to get it installed.
2. Ensure that the SDK version specified in global.json files is compatible with the .NET 10.0 upgrade.
3. Upgrade PE-Tools\PE-Tools.csproj

## Settings

This section contains settings and data used by execution steps.

### Excluded projects

Table below contains projects that do belong to the dependency graph for selected projects and should not be included in the upgrade.

| Project name                                   | Description                 |
|:-----------------------------------------------|:---------------------------:|

### Aggregate NuGet packages modifications across all projects

NuGet packages used across all selected projects or their dependencies that need version update in projects that reference them.

| Package Name                                   | Current Version             | New Version | Description                                   |
|:-----------------------------------------------|:---------------------------:|:-----------:|:----------------------------------------------|
| Microsoft.PowerShell.5.ReferenceAssemblies      | 1.1.0                       |             | No compatible version for .NET 10.0; remove or replace as needed |

### Project upgrade details
This section contains details about each project upgrade and modifications that need to be done in the project.

#### PE-Tools\PE-Tools.csproj modifications

Project properties changes:
  - Target framework should be changed from `net48` to `net10.0-windows`.
  - Project must be converted to SDK-style.

NuGet packages changes:
  - Microsoft.PowerShell.5.ReferenceAssemblies should be removed (no compatible version for .NET 10.0).

Other changes:
  - After conversion to SDK-style, re-add any necessary references in SDK-style format as needed.
