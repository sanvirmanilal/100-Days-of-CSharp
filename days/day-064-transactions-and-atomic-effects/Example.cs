using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day064;

// Learning example: Transactions and atomic effects. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        decimal before = 100m + 20m; decimal after = 70m + 50m; Console.WriteLine(before == after);
    }


}
