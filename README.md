# Windows GitHub Actions .NET demo

This is a deliberately small learning project for experiencing the full CI loop:

1. Push a passing C#/.NET project.
2. Let a Windows runner restore, build, and test it.
3. Push a deliberately broken test and watch the workflow turn red.
4. Fix the test and push again to turn the workflow green.

## Project layout

- `src/HelloActions` — a tiny class library with one greeting method.
- `tests/HelloActions.Tests` — two xUnit tests.
- `.github/workflows/windows-dotnet.yml` — runs on `windows-latest`.

The workflow has three visible stages: restore, build, and test. It runs for both pushes and pull requests, and it only requests read access to repository contents.

## Try it locally

```text
dotnet restore tests/HelloActions.Tests/HelloActions.Tests.csproj
dotnet build tests/HelloActions.Tests/HelloActions.Tests.csproj --configuration Release --no-restore
dotnet test tests/HelloActions.Tests/HelloActions.Tests.csproj --configuration Release --no-build
```

## Three commits in the demo history

The hosted repository is intended to contain these commits in order:

- `green: add minimal Windows .NET CI demo` — the two tests pass.
- `red: intentionally break one test` — one expected value is changed, so the test job fails.
- `green: fix the intentionally broken test` — the original expectation is restored.

Open the **Actions** tab after each push to compare the green, red, and green runs. The failure is intentional and limited to a test assertion; the application code does not need a secret or external service.
