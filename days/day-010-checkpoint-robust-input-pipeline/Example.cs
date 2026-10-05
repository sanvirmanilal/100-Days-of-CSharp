using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day010;

// Learning example: Checkpoint: robust input pipeline. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(int.TryParse("42", out int number) ? $"Parsed {number}" : "Invalid");
    }


}
