using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day062;

// Learning example: EF Core 10 change tracking. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var original = new Row(1, "old"); var updated = original with { Value = "new" }; Console.WriteLine(original == updated);
    }

    private sealed record Row(int Id, string Value);
}
