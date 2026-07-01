# WorkMailReport

WorkMailReport is a local Windows application for running predefined checks and creating a daily work report.

## Stack

- C#
- .NET 8
- WinForms
- SQLite
- xUnit

## Structure

```text
WorkMailReport
├─ src
│  ├─ WorkMailReport.WinForms
│  ├─ WorkMailReport.Core
│  ├─ WorkMailReport.Data
│  └─ WorkMailReport.Tests
├─ docs
└─ WorkMailReport.sln
```

## Build

```bash
dotnet restore
dotnet build
```

## Documents

- [Phase 1 / Phase 2 Plan](docs/PHASE_1_2_PLAN.md)
