using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day082;

// Learning example: DDD aggregates and consistency boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var reservation = new Reservation(Guid.NewGuid(), "BOOK", 2); Console.WriteLine(reservation);
    }

    private sealed record Reservation(Guid Id, string Sku, int Quantity);
}
