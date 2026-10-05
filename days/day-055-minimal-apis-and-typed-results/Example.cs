using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day055;

// Learning example: Minimal APIs and typed results. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var result = Microsoft.AspNetCore.Http.TypedResults.Ok(new { Id = 7 }); Console.WriteLine(result.StatusCode);
    }


}
