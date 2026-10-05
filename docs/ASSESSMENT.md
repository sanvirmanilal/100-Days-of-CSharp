# Assessment and milestone reviews

A green starter test suite proves only its stated observable contracts. It does not prove knowledge of an entire topic.
Complete all three levels and collect evidence before declaring a day complete.

## Review rubric

Score each dimension 0 (missing), 1 (works with help), 2 (independent with evidence), or 3 (can explain alternatives and failure modes).
A checkpoint needs at least 2 in every dimension; do not average away a weakness.

| Dimension | Evidence |
| --- | --- |
| Correctness | Normal, boundary and failure tests; named invariants; no weakened assertions |
| Understanding | Explain implementation without reading it; predict a changed input |
| Test design | Show at least one plausible incorrect implementation the tests reject |
| API/domain design | Valid states, ownership, dependency direction and compatibility |
| Failure behavior | Cancellation/rollback/retry/cleanup as applicable; documented guarantees |
| Engineering evidence | Complexity, allocations or load data as relevant; reproducible commands |
| Communication | Reflection, decisions and limitations another developer can follow |

No need to invent metrics for a simple early-day function. Match evidence to the size and risk of the exercise.

## Milestones

| Day | Review and required demonstration |
| --- | --- |
| 010 | Import malformed/blank/valid inputs; explain validation boundaries and checked arithmetic |
| 020 | Review cart/account invariants, immutable values, equality and dependency ownership |
| 030 | Import a large file with bounded memory, deterministic report and useful errors |
| 040 | Review public library API, nullability, span lifetimes, modern features and compatibility |
| 050 | Run bounded concurrent import; cancel mid-flight; inject a worker fault; prove clean shutdown |
| 060 | Run HTTP integration tests for 200/201/400/401/403/404/409 and tenant isolation |
| 070 | Race two database writers; inject transaction failure; replay a duplicate command; migrate an old schema |
| 080 | Attach load/GC/trace evidence, rate-limit behavior and a readiness/SLO runbook |
| 090 | Replay events, duplicate delivery, saga partial failure and projection lag; recover without double effects |
| 100 | Complete capstone requirements, operational drills and independent architecture review |

## Knowledge checks

At each checkpoint explain:
- Which invariant belongs in which layer, and why?
- What happens when a dependency fails halfway through?
- What is the largest input/workload the design handles, based on evidence?
- Which test detects your most likely bug?
- Which reasonable alternative did you reject, and when would you choose it?
- What are the remaining limitations?

Ask a reviewer to change one requirement and challenge one assumption.
Record findings and actions in the day's Reflection.md. Use code review after an attempt, not a prewritten answer.

## Recording progress

progress.json is a declaration, not an automatic certificate. Mark a day complete only after its three exercise levels
and review gates are satisfied. CI reruns the tests; a reviewer checks the evidence.
If a later change breaks a completed day, fix it or remove that day from the completed list with an explanation.

A failed test should lead to a diagnosis and a minimal correction. A passed test should lead to a check that it could fail.
