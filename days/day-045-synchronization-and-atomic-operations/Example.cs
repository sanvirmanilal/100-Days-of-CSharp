using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day045;

// Learning example: Synchronization and atomic operations. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int counter = 0; Parallel.For(0, 1000, _ => Interlocked.Increment(ref counter)); Console.WriteLine(counter);
    }


}
