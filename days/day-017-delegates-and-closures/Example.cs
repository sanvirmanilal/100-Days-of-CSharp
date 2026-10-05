using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day017;

// Learning example: Delegates and closures. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int factor = 3; Func<int, int> scale = n => n * factor; Console.WriteLine(scale(4));
    }


}
