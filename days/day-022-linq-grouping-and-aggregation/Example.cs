using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day022;

// Learning example: LINQ grouping and aggregation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        foreach (var group in new[] { 1, 2, 3, 4 }.GroupBy(n => n % 2)) Console.WriteLine($"{group.Key}: {group.Count()}");
    }


}
