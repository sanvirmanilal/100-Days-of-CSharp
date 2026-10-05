using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day094;

// Learning example: Resilience and degraded operation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var response = new { Data = "cached", IsStale = true, AgeSeconds = 30 }; Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(response));
    }


}
