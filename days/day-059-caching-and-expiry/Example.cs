using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day059;

// Learning example: Caching and expiry. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var cache = new System.Collections.Concurrent.ConcurrentDictionary<string, int>(); cache.TryAdd("version", 1); Console.WriteLine(cache["version"]);
    }


}
