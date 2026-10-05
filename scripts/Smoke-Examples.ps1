param()
$ErrorActionPreference = 'Stop'
$repoRoot = Split-Path -Parent $PSScriptRoot
$exampleAssembly = Join-Path $repoRoot 'src/Examples/bin/Release/net10.0/Examples.dll'
$failures = @()
for ($day = 1; $day -le 100; $day++) {
    $output = & dotnet $exampleAssembly $day 2>&1
    if ($LASTEXITCODE -ne 0) { $failures += "Day $($day): $output" }
}
if ($failures.Count -gt 0) {
    $failures | Write-Output
    exit 1
}
Write-Host 'All 100 learning examples executed successfully.'
