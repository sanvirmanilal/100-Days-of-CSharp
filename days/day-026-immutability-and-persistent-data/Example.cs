using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day026;

// Learning example: Immutability and persistent data. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var original = System.Collections.Immutable.ImmutableArray.Create(1, 2); var added = original.Add(3); Console.WriteLine($"{original.Length} -> {added.Length}");
    }


}
