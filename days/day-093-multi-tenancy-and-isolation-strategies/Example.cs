using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day093;

// Learning example: Multi-tenancy and isolation strategies. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var scope = new { TenantId = "t1", ResourceId = "r7" }; Console.WriteLine($"{scope.TenantId}/{scope.ResourceId}");
    }


}
