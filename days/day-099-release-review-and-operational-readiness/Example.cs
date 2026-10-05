using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day099;

// Learning example: Release review and operational readiness. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var gates = new Dictionary<string, bool> { ["build"] = true, ["restore drill"] = false }; foreach (var gate in gates) Console.WriteLine($"{gate.Key}: {gate.Value}");
    }


}
