using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day019;

// Learning example: Dates, times and clocks. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var instant = new DateTimeOffset(2026, 10, 5, 12, 0, 0, TimeSpan.Zero); Console.WriteLine(instant.ToOffset(TimeSpan.FromHours(2)));
    }


}
