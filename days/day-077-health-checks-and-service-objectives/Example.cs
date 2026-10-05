using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day077;

// Learning example: Health checks and service objectives. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var result = Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy("process responds"); Console.WriteLine(result.Status);
    }


}
