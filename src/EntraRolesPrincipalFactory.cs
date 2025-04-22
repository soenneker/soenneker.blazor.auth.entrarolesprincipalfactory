using Soenneker.Blazor.Auth.EntraRolesPrincipalFactory.Abstract;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication.Internal;
using Soenneker.Extensions.IIdentity;
using Soenneker.Extensions.ValueTask;

namespace Soenneker.Blazor.Auth.EntraRolesPrincipalFactory;

/// <inheritdoc cref="IEntraRolesPrincipalFactory"/>
public sealed class EntraRolesPrincipalFactory : AccountClaimsPrincipalFactory<RemoteUserAccount>, IEntraRolesPrincipalFactory
{
    public EntraRolesPrincipalFactory(IAccessTokenProviderAccessor accessor) : base(accessor)
    {
    }

    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(RemoteUserAccount account, RemoteAuthenticationUserOptions options)
    {
        ClaimsPrincipal user = await base.CreateUserAsync(account, options).NoSync();

        user.Identity.AddRolesFromRoles();

        return user;
    }
}