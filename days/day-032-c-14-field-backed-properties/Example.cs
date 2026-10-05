using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day032;

// Learning example: C# 14 field-backed properties. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var badge = new Badge { Title = "  Visitor  " }; Console.WriteLine(badge.Title);
    }

    private sealed class Badge { public string Title { get; set => field = value.Trim(); } = ""; }
}
