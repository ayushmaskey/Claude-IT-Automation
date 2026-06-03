# Contributing — Branching & Workflow

## Branch naming

| Type | Pattern | Example |
|---|---|---|
| Feature | `feature/<WBS-ID>-<short-desc>` | `feature/1.3.2-oidc-middleware` |
| Bugfix | `bugfix/<WBS-ID>-<short-desc>` | `bugfix/2.1.1-siteCode-constraint` |
| Hotfix | `hotfix/<short-desc>` | `hotfix/session-expiry-crash` |
| Release | `release/<version>` | `release/1.0.0` |

- Use lowercase and hyphens only — no spaces or slashes beyond the prefix
- WBS ID ties the branch back to the project plan
- Keep descriptions short (3–5 words)

## Rules

- Cut feature and bugfix branches from `develop`
- Cut hotfix branches from `main`; merge back to both `main` and `develop`
- No direct pushes to `main` or `develop` — PRs only
- Delete branches after merge
- No long-lived branches — open a draft PR for WIP if a task spans more than one session
- No production code merged without a corresponding test (see TDD workflow at 1.1.5)

## PR checklist

- [ ] Branch name follows convention above
- [ ] `dotnet build` passes locally
- [ ] `dotnet test` passes locally
- [ ] `ng build` passes locally
- [ ] No secrets or credentials in diff
