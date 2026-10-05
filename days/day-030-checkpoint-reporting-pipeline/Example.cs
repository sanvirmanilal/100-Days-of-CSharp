using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day030;

// Learning example: Checkpoint: reporting pipeline. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        foreach (var row in new[] { ("north", 2), ("south", 5) }.OrderByDescending(r => r.Item2)) Console.WriteLine(row);
    }


}
