using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day020;

// Learning example: Checkpoint: domain model. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var line = (Sku: "BOOK", Quantity: 2, Price: 7.5m); Console.WriteLine($"{line.Sku}: {line.Quantity}");
    }


}
