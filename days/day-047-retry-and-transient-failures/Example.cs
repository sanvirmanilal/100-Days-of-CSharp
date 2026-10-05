using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day047;

// Learning example: Retry and transient failures. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        try { await Task.FromException<int>(new IOException("sample failure")); } catch (IOException error) { Console.WriteLine(error.Message); }
    }


}
