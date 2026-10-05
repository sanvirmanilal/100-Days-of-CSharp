# Initial verification

Verified on 2026-10-05 using .NET SDK 10.0.401 and .NET runtime 10.0.12 on Windows.

| Check | Result |
| --- | --- |
| Release build of HundredDays.slnx | Passed, zero warnings and errors |
| All 100 learning examples | Executed successfully |
| Curriculum structure and local Markdown links | Passed: 100 days, 300 exercise descriptions, 10 checkpoints |
| Infrastructure test | Passed, one test |
| Entire unsolved challenge selection | 328 discovered, 328 intentionally failed, zero skipped |
| Day 001 helper | Selected its three tests; intentional NotImplementedException failures |
| Multi-day query: Day 001, Day 100, infrastructure | Discovered exactly seven tests |
| Completed-day gate with empty progress, Release | Passed; infrastructure only |

No exercise implementation was written to make tests pass.
Provided tests cover starter contracts. Harder exercises require learner-authored tests and evidence.
This is initial repository/tooling verification, not evidence of learner competence.

Reproduce the green infrastructure checks:

~~~powershell
dotnet build HundredDays.slnx --configuration Release
py -3 scripts/validate_curriculum.py
./scripts/Smoke-Examples.ps1
./scripts/Test-Completed.ps1 -IncludeInfrastructure -Configuration Release
~~~

Reproduce intentional starter failures:

~~~powershell
./scripts/Test-Day.ps1 -Day 1
dotnet test --project tests/Challenges.Tests/Challenges.Tests.csproj --configuration Release --filter-trait "Category=Challenge"
~~~

The full-suite verbose log is local under artifacts/verification/unsolved.log and excluded from Git.
