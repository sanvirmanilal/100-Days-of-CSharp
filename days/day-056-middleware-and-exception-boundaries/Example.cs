using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day056;

// Learning example: Middleware and exception boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var problem = new Microsoft.AspNetCore.Mvc.ProblemDetails { Status = 400, Title = "Invalid request" }; Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(problem));
    }


}
