using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day100;

// Learning example: Capstone: architecture defense. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var evidence = new { ArchitectureDecisions = 4, IntegrationScenarios = 12, RestoreDrills = 1 }; Console.WriteLine(evidence);
    }


}
