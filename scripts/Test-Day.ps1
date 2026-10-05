param([Parameter(Mandatory)][ValidateRange(1, 100)][int]$Day)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$project = Join-Path $repoRoot 'tests/Challenges.Tests/Challenges.Tests.csproj'
dotnet test --project $project --filter-trait ('Day={0:000}' -f $Day)
exit $LASTEXITCODE
