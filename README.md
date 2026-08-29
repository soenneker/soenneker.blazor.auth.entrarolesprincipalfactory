[![](https://img.shields.io/nuget/v/soenneker.blazor.auth.entrarolesprincipalfactory.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.auth.entrarolesprincipalfactory/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.blazor.auth.entrarolesprincipalfactory.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.blazor.auth.entrarolesprincipalfactory/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.blazor.auth.entrarolesprincipalfactory/actions/workflows/codeql.yml)

# Soenneker.Blazor.Auth.EntraRolesPrincipalFactory

A Blazor WebAssembly account principal factory that converts Microsoft Entra app roles into standard .NET role claims.

## Installation

```bash
dotnet add package Soenneker.Blazor.Auth.EntraRolesPrincipalFactory
```

## Registration

Register the factory on the authentication builder returned by `AddMsalAuthentication`:

```csharp
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Soenneker.Blazor.Auth.EntraRolesPrincipalFactory;

builder.Services
    .AddMsalAuthentication(options =>
    {
        builder.Configuration.Bind("AzureAd", options.ProviderOptions.Authentication);
    })
    .AddAccountClaimsPrincipalFactory<EntraRolesPrincipalFactory>();
```

Do not also register another account claims principal factory; the last factory registration controls principal creation.

## Role checks

For an Entra claim shaped like:

```json
{
  "roles": ["Administrator", "Billing.Read"]
}
```

the factory adds one `ClaimTypes.Role` claim per nonblank value. Blazor authorization can then use the normal role APIs:

```razor
<AuthorizeView Roles="Administrator">
    <Authorized>
        <AdminDashboard />
    </Authorized>
</AuthorizeView>
```

```csharp
bool isAdministrator = user.IsInRole("Administrator");
```

Role names are trimmed but otherwise preserved, including casing. Missing or empty `roles` claims add no roles. The package only maps claims already present in the authenticated account; app-role assignment and token emission remain Entra configuration concerns.
