# 100 days of C#

A practice repository that grows from C# fundamentals into production .NET engineering and architecture.
Baseline: **.NET 10 / C# 14**, with SDK **10.0.401** pinned in global.json.
There are **100 distinct days**, **300 exercises**, **328 supplied starter acceptance tests**, and **10 integration checkpoints**.
Exercise solutions have deliberately not been written.

Start with [Day 001](days/day-001-expressions-and-the-feedback-loop/README.md), or browse the [full curriculum](CURRICULUM.md).

## Get started

Install the [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0). Your SDK must satisfy global.json.
An editor with C# support and Git are sufficient for the early days. PowerShell 7 is needed for the helper scripts.
Python 3 is only needed for repository structure validation. Later labs introduce a relational database and optionally containers.

From the repository root:

~~~powershell
dotnet restore HundredDays.slnx
dotnet build HundredDays.slnx
dotnet run --project src/Examples -- 1
./scripts/Test-Day.ps1 -Day 1
~~~

The final command initially **fails** with NotImplementedException. Read the day contract, attempt Challenge.cs, and rerun.
Without PowerShell:

~~~shell
dotnet test --project tests/Challenges.Tests/Challenges.Tests.csproj --filter-trait "Day=001"
~~~

Do not run the entire challenge suite expecting it to be green before doing the challenges.

## The daily loop

1. Read the topic and official reference; predict and run Example.cs.
2. Read the Exercise 1 contract and acceptance tests; write an attempt in Challenge.cs.
3. Add your own tests and implementation for Exercise 2, then Exercise 3.
4. Record understanding, results and tradeoffs in Reflection.md.
5. Complete the review gate, then mark the day complete in progress.json.

Provided tests cover **Exercise 1 only**. Writing meaningful tests for the harder exercises is part of the curriculum.
Later starter functions isolate one rule; they are not substitutes for the required API, database, concurrency or architecture labs.

After completing all three exercises for Day 1:

~~~json
{
  "completedDays": [1]
}
~~~

~~~powershell
./scripts/Test-Completed.ps1 -IncludeInfrastructure
~~~

This reruns completed days and repository infrastructure tests. CI builds every starter/example, validates the curriculum,
and tests only completed days plus infrastructure. An empty progress list does not claim challenge completion.

## Progression

| Days | Focus | Evidence |
| --- | --- | --- |
| 001-010 | Types, expressions, control flow and contracts | Robust input pipeline |
| 011-020 | Encapsulation, records, interfaces and domain types | Tested cart model |
| 021-030 | LINQ, enumeration, Unicode, JSON and IO | Streaming report tool |
| 031-040 | C# 14, spans, generic math and library design | Reviewed modern library |
| 041-050 | Async, cancellation, synchronization and channels | Bounded importer |
| 051-060 | DI, options, logging, HTTP, security and APIs | Secured inventory API |
| 061-070 | EF Core 10, transactions, migrations and outbox | Durable inventory service |
| 071-080 | GC, benchmarks, AOT, telemetry and overload | Measured production service |
| 081-090 | DDD, CQRS, boundaries, events, sagas and resilience | Distributed reservation workflow |
| 091-100 | Deployment, decisions, isolation and recovery | Architecture defense |

C# 14 learning examples include field-backed properties, extension members, null-conditional assignment and span APIs.
C# 14 compound operators, partial constructors/events and lambda modifiers are optional library-design investigations
in the [modern features lab](docs/MODERN_FEATURES.md).
.NET 10 API validation/OpenAPI and EF Core 10 features appear in the production exercises.

## Repository map

~~~text
days/day-NNN-topic/
  README.md          objectives, contract, three exercise levels, completion gate
  Example.cs         runnable adjacent learning example
  Challenge.cs       intentionally unimplemented public starter contract
  ChallengeTests.cs  supplied tests; add learner tests here
  Reflection.md      evidence and review journal
src/Examples/        one runner for all daily examples
src/Exercises/       compiles the independent daily starter contracts
tests/Challenges.Tests/
docs/                assessment, capstone, test strategy, tooling and solution policy
scripts/             test selection and curriculum validation
curriculum.json      machine-readable index
progress.json        learner-declared completed days
~~~

Namespace isolation keeps days independent. Shared projects keep the first build simple.
To add new .cs files, include them in the relevant project: the initial globs compile Example.cs, Challenge.cs and ChallengeTests.cs only.
For substantial later exercises, create projects under capstone/ and add them to HundredDays.slnx;
add their tests to CI once they are runnable. Do not put application implementations into the example runner.

## What completion means

[Assessment](docs/ASSESSMENT.md) requires tests, explanations, measured behavior, failure recovery and review.
The [capstone](docs/CAPSTONE.md) supplies business requirements and acceptance scenarios, with no architecture implementation.

One hundred learning units can build strong expertise, but do not certify an expert architect.
Trust comes from demonstrated decisions, maintained systems, operational experience and independent review.
Spend extra sessions on checkpoints and revisit weak areas. See the [testing strategy](docs/TESTING.md).

## Versions and maintenance

The installed SDK was verified as 10.0.401 when this repository was created on 2026-10-05.
Use stable releases as the default; preview experiments belong in separate opt-in projects.
Update SDK/runtime patches deliberately and build/test before changing the pin.
Sources: [.NET download](https://dotnet.microsoft.com/download/dotnet),
[C# 14](https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-14/),
[.NET 10](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-10/overview),
[EF Core 10](https://learn.microsoft.com/ef/core/what-is-new/ef-core-10.0/whatsnew).

The repository is local. No remote repository has been created and no code has been published.
