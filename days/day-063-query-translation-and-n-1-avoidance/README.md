# Day 063: Query translation and N+1 avoidance

Phase: **Persistence and correctness**. Prerequisite: Day 062, including tests and review.
Time guide: 60-120 minutes for study and starter; allow additional sessions for practice and mastery.
A day is a learning unit, not a deadline.

## Learn by running the example

LINQ against IQueryable builds an expression tree that a provider translates. Projection, includes and batching affect SQL and round trips; inspect generated SQL instead of guessing from the C# query.

Read [Example.cs](Example.cs), predict its output, then run from the repository root:

```powershell
dotnet run --project src/Examples -- 63
```

The example demonstrates **Query translation and N+1 avoidance** on an adjacent problem.
Trace each expression and identify its types, state changes and failure boundaries.
Change one input and predict the result before rerunning. Explain the feature in your own words.
For IO/async examples, identify resource ownership and what determines ordering.
Read the [official phase reference](https://learn.microsoft.com/ef/core/what-is-new/ef-core-10.0/whatsnew) and follow relevant topic pages.
An example is teaching code; it is not the exercise implementation.

## Exercise 1 — Implement the contract

Return distinct requested IDs in first-appearance order for one batch lookup.

Implement only the body in [Challenge.cs](Challenge.cs):

```csharp
public static int[] BatchIds(int[] requested)
```

Acceptance tests: [ChallengeTests.cs](ChallengeTests.cs). Read inputs, expected values and failure assertions before coding.
Inputs outside the stated contract are unspecified: choose and document a policy in your own tests.
Do not weaken supplied assertions, skip tests, or hardcode sample outputs.

```powershell
./scripts/Test-Day.ps1 -Day 63
```

The starter throws `NotImplementedException`: tests are expected to fail before your attempt.

## Exercise 2 — Extend and test

Project directly to DTOs and count database round trips with a command interceptor.

Add APIs and tests to this day's files (or split into projects for larger systems).
Write at least one normal-path, one boundary and one invalid-input/failure test **before** implementation.
Use the same `Day=063` trait.
Provided tests cover Exercise 1; you own the tests for Exercises 2 and 3.

## Exercise 3 — Production or design challenge

Test translated SQL, explain plans and indexes against representative data; eliminate N+1 requests.

Prove an invariant or recovery guarantee with a test that fails for a plausible incorrect implementation.
Use barriers/task completion sources instead of sleeps for concurrency.
Use a real relational provider or in-process HTTP host for persistence/HTTP work.
Attach reproducible measurements for performance/operations work instead of machine-dependent timing assertions.
Explain tradeoffs and rejected alternatives in [Reflection.md](Reflection.md).

## Completion gate

- Supplied tests pass, with none skipped.
- Your Exercise 2 and 3 tests prove behavior beyond the supplied cases.
- Explain the mechanism, complexity and failure modes without reading the code.
- Record commands, results and limitations in Reflection.md.
- Refactor after tests establish behavior.

Then add 63 to `completedDays` in `progress.json` and run `./scripts/Test-Completed.ps1 -IncludeInfrastructure`.
Solutions are deferred until after your attempt; request review/hints with your code and test output.
