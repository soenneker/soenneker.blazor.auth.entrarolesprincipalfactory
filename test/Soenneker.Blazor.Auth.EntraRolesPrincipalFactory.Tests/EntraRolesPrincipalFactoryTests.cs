using Soenneker.Blazor.Auth.EntraRolesPrincipalFactory.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Blazor.Auth.EntraRolesPrincipalFactory.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class EntraRolesPrincipalFactoryTests : HostedUnitTest
{

    public EntraRolesPrincipalFactoryTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
