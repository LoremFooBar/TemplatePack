# LoremFooBar.TemplatePack

> .NET templates following best practices and personal preferences.

## Getting Started

### Prerequisites

[.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Installation

with .NET 6.0 or below:
```shell
dotnet new -i LoremFooBar.TemplatePack
```

with .NET 8.0 or above:
```shell
dotnet new install LoremFooBar.TemplatePack
```

## Create a NuGet Package Project

The following command will create a solution named `YourName.YourPackageName` 
in folder `./YourPackageName`:

```shell
dotnet new lfb-package --name YourName.YourPackageName -o YourPackageName
```

[//]: # (## Implement Missing Functionality In Created Project)

[//]: # ()
[//]: # (Some functionality needs to be completed/implemented by you. In the created)

[//]: # (project search for `// TODO` comments and `NotImplementedException`s, or find)

[//]: # (the TODO view in your IDE.)

## Updating Installed Template Pack Version

To check for template updates, run:

```shell
dotnet new --update-check
```

Output will contain the update command for each available update.

To update all templates, run:

```shell
dotnet new --update-apply
```
