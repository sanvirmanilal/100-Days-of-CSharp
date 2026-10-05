# Tooling and adding later projects

The root pins .NET SDK 10.0.401 (stable) with latestPatch roll-forward in its feature band.
All initial projects use net10.0, C# 14.0, nullable reference types and warnings as errors.
Versions of test packages are centralized in Directory.Packages.props.
The test runner is Microsoft Testing Platform, selected in global.json. Use xUnit's --filter-trait or --filter-query syntax.
No databases, containers, workloads or credentials are required for the first build.

## Commands

~~~powershell
dotnet --info
dotnet restore HundredDays.slnx
dotnet build HundredDays.slnx --configuration Release
py -3 scripts/validate_curriculum.py
dotnet format whitespace HundredDays.slnx --verify-no-changes --no-restore
./scripts/Test-Day.ps1 -Day 1
~~~

On macOS/Linux use python3 instead of py -3, and dotnet test directly or PowerShell 7 for helper scripts.

## Larger exercises

Initial source globs include each day's Example.cs, Challenge.cs and ChallengeTests.cs.
Keep small extensions in those files. For separate files, add explicit Compile Include entries.
For APIs/EF Core/benchmarks/analyzers, add dedicated projects instead:

~~~powershell
dotnet new webapi -o capstone/Api
dotnet sln HundredDays.slnx add capstone/Api/Api.csproj
~~~

Inspect generated templates before use and keep domain/application dependencies deliberate.
Use central PackageVersion entries for new packages and PackageReference without inline Version attributes.
Use EF Core 10/provider versions compatible with the runtime and production database.
Choose a real relational provider for database correctness tests; EF InMemory does not prove relational behavior.
Containers/Testcontainers are optional tooling choices and require a container runtime.
Never store database passwords or tokens in tracked files.

## Updating the baseline

Read official release notes. Update global.json to an installed stable SDK, update central package versions,
then build and run completed-day tests plus examples.
Do not set LangVersion to preview for the main curriculum.
An optional preview experiment should be isolated in its own project with an explicit SDK strategy.

## Editing the curriculum

curriculum.json is the machine-readable index. Edit the day files in place and preserve learner attempts.
Structure validation is read-only and safe to rerun.
To check all learning examples after editing:

~~~powershell
dotnet build HundredDays.slnx --configuration Release
./scripts/Smoke-Examples.ps1
~~~
