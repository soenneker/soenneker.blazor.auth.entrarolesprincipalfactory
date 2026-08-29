[![](https://img.shields.io/nuget/v/soenneker.blazor.auth.entrarolesprincipalfactory.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.auth.entrarolesprincipalfactory/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.auth.entrarolesprincipalfactory.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.auth.entrarolesprincipalfactory/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/actions/workflows/codeql.yml)

# Soenneker.Blazor.Auth.EntraRolesPrincipalFactory

Customizes Blazor authentication by extending AccountClaimsPrincipalFactory to add standard roles claims from Azure Entra.

## Install

```bash
dotnet add package Soenneker.Blazor.Auth.EntraRolesPrincipalFactory
```

## What you get

- `IEntraRolesPrincipalFactory` — Customizes Blazor authentication by extending AccountClaimsPrincipalFactory to add standard roles claims from Azure Entra.
