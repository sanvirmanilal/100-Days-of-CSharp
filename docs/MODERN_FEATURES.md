# Modern feature investigations

The stable baseline is .NET 10 and C# 14. Learn why a feature helps, not just its syntax.
Sources: [C# 14](https://learn.microsoft.com/dotnet/csharp/whats-new/csharp-14/),
[.NET 10](https://learn.microsoft.com/dotnet/core/whats-new/dotnet-10/overview),
[EF Core 10](https://learn.microsoft.com/ef/core/what-is-new/ef-core-10.0/whatsnew).

## Day 040 optional library lab

Investigate remaining C# 14 features in an API you own:
- User-defined compound assignment operators: test mutation, aliasing and overflow semantics.
- Partial constructors/events: demonstrate a generator/use case and compile the result.
- Lambda parameter modifiers: test a callback contract using the new syntax.
- nameof with unbound generic types: inspect metadata naming and diagnostic usefulness.
- First-class span conversions: compare overload resolution and allocations without unsafe lifetime escapes.

Use compilable experiments and tests; explain when conventional syntax is clearer.
Partial members belong in a justified generation/design exercise, not every class.

## Days 055-056: .NET 10 web platform

Use Minimal API validation, typed results, ProblemDetails and built-in OpenAPI generation.
Write integration tests for validation, status codes and advertised schemas.
Explore Server-Sent Events if streaming updates solve a real requirement; test cancellation and slow consumers.

## Days 062-063: EF Core 10

Explore complex types, JSON mapping and named query filters where the chosen provider supports them.
Inspect generated SQL and test real provider semantics. Check tenant filters cannot be bypassed accidentally.
Do not assume all database providers implement every feature identically.

## Day 075 optional runtime/interop lab

Publish and test Native AOT/trimming with source-generated serializers.
For interop, add a separate safe wrapper around a small native API with explicit ownership and SafeHandle.
If using unsafe code/ref structs, state the benefit, test buffer bounds and document lifetime restrictions.
Keep unsafe code out of the normal curriculum unless measured evidence justifies it.

## Latest is a maintenance practice

The repository uses a verified stable baseline, not a moving preview target.
Recheck official SDK releases and update deliberately as you progress.
Compare a new feature to its alternative through behavior and evidence, not novelty alone.
