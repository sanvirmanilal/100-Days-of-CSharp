using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day075;

// Learning example: Native AOT and trimming. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(System.Runtime.CompilerServices.RuntimeFeature.IsDynamicCodeSupported);
    }


}
