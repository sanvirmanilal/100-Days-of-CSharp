# Reservation platform capstone

Build a tenant-aware product inventory and reservation platform. This is a set of requirements and evaluation criteria,
not a solution design. Start the application during Days 051-060 and evolve it through Day 100.

## Business requirements

- A tenant owns products with a unique SKU and a nonnegative available quantity.
- Authenticated readers see only their tenant's inventory. Writers reserve/release inventory only within their tenant.
- A reservation has a stable identity, quantity, status and expiry.
- Repeated requests with the same idempotency key and payload return the same business outcome.
- Reuse of the key with a different payload is rejected.
- Concurrent reservations must not oversell. Define the business rule for expiry versus confirmation races.
- An external payment step can fail or time out; explain how inventory and payment state recover.
- Auditable events carry stable message IDs, schema versions and trace context.
- Read models may lag: expose/document staleness and a read-your-writes policy.
- Database migrations must support a defined rolling deployment window.
- Secrets and personal data must not leak through logs, errors or API schemas.

Define quantities, monetary rounding, expiry and authorization policy explicitly before implementing.
Choose a modular monolith unless requirements and measured evidence justify independent services.
Distribution is a challenge to evaluate, not a prerequisite for good architecture.

## Acceptance scenarios to implement as executable tests

| Scenario | Required assertion |
| --- | --- |
| Valid creation/reservation/release | Correct status, persisted state and domain invariants |
| Invalid or unknown inputs | Stable error contract and no unintended write |
| Authentication/authorization | 401/403 behavior; no protected data access first |
| Cross-tenant lookup/write/cache | No data exposure or change in another tenant |
| Duplicate HTTP request | Same result; one business effect |
| Concurrent same-key requests | One durable command result |
| Concurrent last-item reservations | Exactly one success; stock never negative |
| Failure between business write and outbox write | Both committed or neither |
| Crash after publish before acknowledgement | Replay does not duplicate business effects |
| Consumer duplicate/out-of-order delivery | Stated ordering/idempotency policy is upheld |
| Payment fault after inventory reservation | Recorded recoverable saga/compensation state |
| Expiry/confirmation race | One valid terminal business outcome |
| Slow downstream and cancellation | Bounded memory/concurrency; resources released |
| Old/new API/event/database versions | Explicit compatibility matrix passes |
| Dependency outage or overload | Predictable rejection/degradation within resource budget |
| Restore and replay | Checksums/checkpoints/invariants pass; no duplicate effects |

Tests must use real HTTP hosting and relational database semantics where appropriate.
Use controlled fault injection and synchronization for race tests. Avoid external paid/live services.

## Engineering deliverables

- Source, unit tests, HTTP/database integration tests and reproducible run instructions.
- Context/container/component diagrams and a dependency map.
- At least four ADRs covering boundaries, persistence, consistency/retries and deployment.
- Threat model with trust boundaries, tenant isolation and mitigation evidence.
- Load report: workload, environment, latency distribution, throughput, errors and allocations.
- SLI/SLO definitions and observability showing one request across the workflow.
- Deployment/migration/rollback plan; graceful shutdown test results.
- Incident runbook and backup/restore drill with measured RPO/RTO.
- Compatibility fixtures and release gates.
- Peer-review findings, resolutions and explicit residual risks.

## Final defense

Present a working system and evidence. A reviewer chooses one change:
tenfold traffic, stricter tenant isolation, a new payment provider, or a new retention policy.
Explain the impact, implement a focused slice, and extend the tests.

Then handle a dependency outage and recover a failed workflow from durable state.
Passing the small Day 100 starter does not complete this capstone.

Create your own implementation under capstone/ when ready. No implementation, provider choice or finished architecture
has been supplied here, so you can make and defend the decisions yourself.
