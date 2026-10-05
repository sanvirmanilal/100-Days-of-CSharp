using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day009;

// Learning example: Nullability and optional values. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        string? nickname = null; Console.WriteLine(nickname?.ToUpperInvariant() ?? "ANONYMOUS");
    }


}
