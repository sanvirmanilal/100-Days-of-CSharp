param(
    [switch]$IncludeInfrastructure,
    [ValidateSet('Debug', 'Release')][string]$Configuration = 'Debug'
)
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$progress = Get-Content -LiteralPath (Join-Path $repoRoot 'progress.json') -Raw | ConvertFrom-Json
if (-not ($progress.PSObject.Properties.Name -contains 'completedDays')) {
    throw 'progress.json must contain a completedDays array.'
}
if ($progress.completedDays -isnot [array]) { throw 'completedDays must be an array.' }
if (@($progress.completedDays | Select-Object -Unique).Count -ne $progress.completedDays.Count) {
    throw 'completedDays must not contain duplicates.'
}
$clauses = @($progress.completedDays | ForEach-Object {
    if ($_ -isnot [long] -and $_ -isnot [int]) { throw 'Completed days must be integers.' }
    if ($_ -lt 1 -or $_ -gt 100) { throw 'Completed days must be between 1 and 100.' }
    'Day={0:000}' -f $_
})
if ($IncludeInfrastructure) { $clauses += 'Category=Infrastructure' }
if ($clauses.Count -eq 0) {
    Write-Host 'No days marked complete. Run Test-Day.ps1 for your current challenge.'
    exit 0
}
dotnet test --project (Join-Path $repoRoot 'tests/Challenges.Tests/Challenges.Tests.csproj') --configuration $Configuration --filter-query ('/[{0}]' -f (($clauses | ForEach-Object { '({0})' -f $_ }) -join '|'))
exit $LASTEXITCODE



