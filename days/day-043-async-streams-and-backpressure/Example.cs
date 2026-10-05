using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day043;

// Learning example: Async streams and backpressure. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        await foreach (var value in Values()) Console.WriteLine(value);
    }

    private static async IAsyncEnumerable<int> Values() { await Task.Yield(); yield return 4; yield return 8; }
}
