# Contributing to PE-Tools

This document describes the workflow, coding standards, and expectations for contributions so we can maintain a high-quality codebase.

## Table of Contents

- Purpose
- Getting started
- Development environment
- Building and running
- Tests
- Coding standards
- Commit messages
- Branching and pull request workflow
- Code review checklist
- Adding or updating dependencies
- Reporting issues and security
- License

## Purpose

PE-Tools is a developer tool. Contributions should be focused on correctness, reliability, and maintainability. This document explains how to prepare and submit changes so they can be reviewed and merged quickly.

## Getting started

1. Fork the repository on GitHub.
2. Clone your fork:

   ```bash
   git clone https://github.com/<your-username>/PE-Tools.git
   cd PE-Tools
   ```

3. Add the upstream remote:

   ```bash
   git remote add upstream https://github.com/seanomahony/PE-Tools.git
   git fetch upstream
   ```

4. Create a feature branch for your work (see Branching below).

## Development environment

- IDE: Visual Studio 2026. Use the solution in the repository and open it via File > Open > Project/Solution or from Solution Explorer.
- .NET SDK: .NET 10
- Language: C# 14.0
- Ensure Tools > Options is configured to respect `.editorconfig` and to keep formatting consistent with the project.

If you prefer the command line, the repository builds with the .NET CLI installed for .NET 10.

## Building and running

From Visual Studio:
- Use Build > Rebuild Solution to build all projects.
- Use Debug > Start Debugging or Debug > Start Without Debugging to run.

From the command line:

```bash
dotnet build
dotnet run --project path/to/startup/project
```

Logging is initialized early in the app; see `Program.cs` for the bootstrap sequence.

## Tests

If tests are present, run them with:

```bash
dotnet test
```

Add unit tests for any behavior you change. New code should include tests where feasible.

## Coding standards

The repository enforces formatting and naming via `.editorconfig`. Please make sure your editor respects `.editorconfig` (Visual Studio does this by default when enabled). Basic expectations:

- Use the repository's `.editorconfig` for formatting (indentation, spacing, file headers).
- Always include explicit access modifiers for types and members.
- PascalCase for types, methods, properties, and events.
- camelCase for local variables and parameters.
- _underscore-prefixed_ `private` fields are allowed when present in existing files; follow the surrounding file style for new code.
- Prefer expression-bodied members for simple getters or single-line methods when it improves readability.
- Target null-safety: follow nullable annotations consistent with the project.
- Keep methods short and single-responsibility. Extract helper methods instead of long procedures.

If the repository does not yet contain an `.editorconfig`, add one and follow team conventions. The project will include one after preferences are finalized.

## Commit messages

Follow Conventional Commits format to make history readable and to support automated changelogs:

- Use a short, imperative subject (max 72 characters): `feat: add project selector control`
- Optionally include a body explaining the motivation and design decisions.
- Reference issues by number when relevant: `fix: correct null handling (#42)`

Examples:

```
fix(parser): handle empty input

Previously the parser crashed when input was empty. This adds a guard and unit tests.
```

## Branching and pull request workflow

- Keep `main` protected. Merge to `main` via pull requests only.
- Branch naming:
  - `feature/<short-description>` for new features
  - `fix/<issue-number>-<short-description>` for bug fixes
  - `chore/<short-description>` for maintenance
  - `release/vX.Y.Z` for release preparation

Workflow:
1. Update your `main` from upstream: `git fetch upstream && git checkout main && git reset --hard upstream/main`
2. Create a branch from `main`.
3. Commit logically grouped changes with clear messages.
4. Push your branch to your fork and open a Pull Request against `main`.
5. In the PR description include:
   - A short summary of changes
   - Motivation and context
   - Testing steps (how to reproduce and verify)
   - Any migration or compatibility notes
6. Assign reviewers and respond to review feedback.

Pull requests must pass CI and include passing unit tests for changed code.

## Code review checklist

Before requesting review, ensure:

- Code builds and all tests pass.
- No warnings introduced by the compiler.
- No trailing whitespace or accidental formatting changes.
- Public APIs are documented with XML comments where appropriate.
- Additive and non-breaking changes are preferred for library behavior.
- Update `CHANGELOG.md` for user-visible changes.

Reviewers will focus on correctness, readability, test coverage, and alignment with project conventions.

## Adding or updating dependencies

- Adding new dependencies requires justification. Consider whether functionality can be implemented with existing libraries or the standard library.
- For third-party packages, prefer packages with active maintenance, clear licensing, and no known security issues.
- Add the dependency, update package references, and include rationale in the PR description.
- Ensure CI builds and tests pass after changes.

## Reporting issues and security

- File issues for bugs and feature requests using the repository's Issues on GitHub.
- When reporting a bug include reproducible steps, environment, expected vs actual behavior, and logs if available.
- For security vulnerabilities, avoid public disclosure. Contact the repository owner via a private channel (open a private GitHub issue if available) and do not include exploit details in public issues.

## License

This repository follows the license defined in `LICENSE` at the repository root. By contributing you agree to license your contributions under the same terms.

-----

If anything in this document is unclear or you have suggestions for improving the contributor experience, please open an issue or submit a PR to update this file.
