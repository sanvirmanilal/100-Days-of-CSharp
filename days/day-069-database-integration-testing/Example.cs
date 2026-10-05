using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day069;

// Learning example: Database integration testing. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var fixtureId = Guid.NewGuid().ToString("N"); Console.WriteLine($"Isolated fixture: {fixtureId}");
    }


}
