using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day028;

// Learning example: File IO and resource ownership. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        using var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes("sample")); using var reader = new StreamReader(stream); Console.WriteLine(reader.ReadToEnd());
    }


}
