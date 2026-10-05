using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day084;

// Learning example: Modular monoliths and boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var catalog = new CatalogContract("BOOK", 7); Console.WriteLine(catalog.Sku);
    }

    private sealed record CatalogContract(string Sku, int Available);
}
