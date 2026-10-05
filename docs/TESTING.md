# Testing as evidence

## Red, green, refactor

Read the contract, run its tests, see failure, implement your attempt, then refactor.
Every supplied Challenge.cs starts with NotImplementedException.
Supplied assertions express behavior, not an algorithm. Do not remove or skip them to get a green run.

Exercise 1 has supplied acceptance tests. For Exercises 2 and 3 you design the APIs and tests.
Write at least normal, boundary and failure cases, then add a relevant invariant or recovery test.
Use descriptive test names and this day's [Trait("Day", "NNN")] so test selection includes your work.

## Selecting tests

~~~powershell
./scripts/Test-Day.ps1 -Day 43
./scripts/Test-Completed.ps1 -IncludeInfrastructure
dotnet test --project tests/Challenges.Tests/Challenges.Tests.csproj --filter-trait "Day=043"
dotnet test --project tests/Challenges.Tests/Challenges.Tests.csproj --filter-trait "Category=Infrastructure"
dotnet test --project tests/Challenges.Tests/Challenges.Tests.csproj --list-tests
~~~

Class-level traits apply to learner-added test methods in the same class.
A new test class needs its own Day and Category traits.
A new source file needs a Compile entry in the relevant project, or a new project added to the solution.
For later capstone projects, extend CI to run their integration tests; the initial workflow does not discover arbitrary new projects.

## Strong test cases

- Test boundaries immediately below/at/above a rule.
- Test empty/null/malformed inputs when the contract defines them.
- Assert the input was not mutated when ownership requires a copy.
- Assert exact callback counts and arguments when side effects matter.
- Prove cancellation stops work and disposes resources.
- Use task completion sources/barriers for ordering and races; no arbitrary sleeps.
- Use checked overflow, Unicode, culture and serialization compatibility cases.
- Use relational databases for transaction/constraint/query-translation claims.
- Use an in-process server for real routing, middleware and authorization.
- Include fault injection and crash/replay scenarios for messaging.

Unit tests can establish a domain invariant. They cannot establish database isolation,
API security behavior, or a latency SLO by testing a boolean helper.

## Determinism and measurements

Inject TimeProvider for time-dependent behavior and deterministic randomness for retry schedules.
Link long-running test operations to TestContext.Current.CancellationToken.
Run load tests/benchmarks separately from unit tests. Record environment, workload, warmup and variation.
Never assert that a computation takes fewer than a fixed number of milliseconds in a shared CI runner.

At checkpoints, demonstrate a plausible wrong implementation caught by your tests.
Mutation testing is an optional advanced technique after the basic test suite is meaningful.

## Initial repository verification

Build and structure checks are expected to pass with all exercises unsolved.
Challenge tests are expected to fail with NotImplementedException.
The structure test checks all 100 day namespaces, not learner competence.
progress.json selects declared completed days; it does not inspect reflection evidence or certify knowledge.
