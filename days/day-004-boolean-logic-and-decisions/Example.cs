using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day004;

// Learning example: Boolean logic and decisions. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int temperature = 12; Console.WriteLine(temperature is >= 5 and <= 20 ? "Walk" : "Check forecast");
    }


}
