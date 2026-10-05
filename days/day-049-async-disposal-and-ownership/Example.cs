using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day049;

// Learning example: Async disposal and ownership. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        await using var stream = new MemoryStream(); await stream.WriteAsync(new byte[] { 1, 2 }); Console.WriteLine(stream.Length);
    }


}
