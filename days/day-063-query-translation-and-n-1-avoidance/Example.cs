using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day063;

// Learning example: Query translation and N+1 avoidance. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var ids = new[] { 1, 2, 1 }; Console.WriteLine(string.Join(", ", ids.Distinct()));
    }


}
