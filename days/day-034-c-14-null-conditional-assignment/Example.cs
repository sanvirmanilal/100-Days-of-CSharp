using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day034;

// Learning example: C# 14 null-conditional assignment. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Widget? widget = new(); widget?.Caption = "updated"; Console.WriteLine(widget!.Caption);
    }

    private sealed class Widget { public string Caption { get; set; } = ""; }
}
