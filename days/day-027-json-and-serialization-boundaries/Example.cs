using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day027;

// Learning example: JSON and serialization boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new { Name = "Ada", Active = true }));
    }


}
