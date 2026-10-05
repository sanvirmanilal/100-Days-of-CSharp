using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day041;

// Learning example: Task-based asynchronous programming. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        Console.WriteLine(await Task.FromResult("await unwraps a result"));
    }


}
