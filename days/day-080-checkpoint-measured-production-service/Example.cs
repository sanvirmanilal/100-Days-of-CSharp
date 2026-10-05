using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day080;

// Learning example: Checkpoint: measured production service. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var summary = new { Requests = 1000, Errors = 2, P95Milliseconds = 42 }; Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(summary));
    }


}
