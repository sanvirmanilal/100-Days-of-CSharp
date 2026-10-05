using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day070;

// Learning example: Checkpoint: durable service. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var stock = new Dictionary<string, int> { ["BOOK"] = 10 }; Console.WriteLine(stock["BOOK"]);
    }


}
