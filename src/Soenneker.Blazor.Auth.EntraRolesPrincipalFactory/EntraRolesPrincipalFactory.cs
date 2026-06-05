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

    /// <summary>
    /// Creates user async.
    /// </summary>
    /// <param name="account">The account.</param>
    /// <param name="options">The options.</param>
    /// <returns>A task containing the result of the operation.</returns>
    public override async ValueTask<ClaimsPrincipal> CreateUserAsync(RemoteUserAccount account, RemoteAuthenticationUserOptions options)
    {
        ClaimsPrincipal user = await base.CreateUserAsync(account, options);

        user.Identity.AddRolesFromRoles();

        return user;
    }
}
