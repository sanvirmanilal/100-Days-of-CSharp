using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day035;

// Learning example: Spans and allocation-conscious APIs. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        ReadOnlySpan<char> text = "ticket:42"; Console.WriteLine(text[7..].ToString());
    }


}
