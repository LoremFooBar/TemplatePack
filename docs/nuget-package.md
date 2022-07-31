# NuGet Package Template

## What's included

1. Implements best practices described
   [here](https://docs.microsoft.com/en-us/nuget/create-packages/package-authoring-best-practices).
2. Using the [DotNet.ReproducibleBuilds](https://github.com/dotnet/reproducible-builds) package for reproducible builds
   and debugging best practices (includes SourceLink integration).
3. Versioning using [NerdBank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning).
4. Testing using [NUnit](https://nunit.org)
   and [LoremFooBar.SimpleGwt.NUnit](https://github.com/LoremFooBar/SimpleGwt.NUnit) (for obvious reasons 🙂).
5. Code style and formatting:
   1. A strict `.editorconfig` file defining code style and formatting rules following my personal preferences. Some
     rules are Jetbrains ReSharper/Rider specific rules, as Rider is my IDE of choice for .NET development.
   2. [ReSharper tools](https://www.nuget.org/packages/jetbrains.resharper.globaltools) installed for code inspections in
     CI.
6. GitHub Actions workflow including build, test, code inspections and coverage report.
