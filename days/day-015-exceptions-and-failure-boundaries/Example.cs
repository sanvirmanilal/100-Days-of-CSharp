using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day015;

// Learning example: Exceptions and failure boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        try { _ = int.Parse("oops"); } catch (FormatException error) { Console.WriteLine(error.GetType().Name); }
    }


}
