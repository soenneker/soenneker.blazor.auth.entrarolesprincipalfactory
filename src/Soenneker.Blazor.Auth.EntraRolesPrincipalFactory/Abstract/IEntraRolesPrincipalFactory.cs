namespace Soenneker.Blazor.Auth.EntraRolesPrincipalFactory.Abstract;

/// <summary>
/// Marks the account principal factory that converts the JSON array in an Entra <c>roles</c> claim into standard <see cref="System.Security.Claims.ClaimTypes.Role"/> claims.
/// </summary>
public interface IEntraRolesPrincipalFactory
{
}
