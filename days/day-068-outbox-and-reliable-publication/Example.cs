using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day068;

// Learning example: Outbox and reliable publication. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var eventEnvelope = new { Id = Guid.NewGuid(), Type = "ItemAdded", Version = 1 }; Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(eventEnvelope));
    }


}
