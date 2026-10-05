using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day036;

// Learning example: Generic math and numeric algorithms. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(Twice(4)); Console.WriteLine(Twice(1.5m));
    }

    private static T Twice<T>(T value) where T : System.Numerics.INumber<T> => value + value;
}
