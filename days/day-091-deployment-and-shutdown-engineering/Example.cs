using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day091;

// Learning example: Deployment and shutdown engineering. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription);
    }


}
