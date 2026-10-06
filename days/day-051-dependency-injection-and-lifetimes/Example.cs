using Microsoft.Extensions.DependencyInjection;

namespace Days.Day051;

// Learning example: Dependency injection and lifetimes. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var services = new Microsoft.Extensions.DependencyInjection.ServiceCollection(); services.AddSingleton<Marker>(); using var provider = services.BuildServiceProvider(); Console.WriteLine(ReferenceEquals(provider.GetRequiredService<Marker>(), provider.GetRequiredService<Marker>()));
    }

    private sealed class Marker { }
}
