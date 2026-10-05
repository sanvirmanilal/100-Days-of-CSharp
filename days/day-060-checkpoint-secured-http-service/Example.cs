using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day060;

// Learning example: Checkpoint: secured HTTP service. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var builder = Microsoft.AspNetCore.Builder.WebApplication.CreateBuilder(); Console.WriteLine(builder.Environment.EnvironmentName);
    }


}
