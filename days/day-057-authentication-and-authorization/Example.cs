using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day057;

// Learning example: Authentication and authorization. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var identity = new System.Security.Claims.ClaimsIdentity(new[] { new System.Security.Claims.Claim(System.Security.Claims.ClaimTypes.Role, "reader") }, "demo"); Console.WriteLine(new System.Security.Claims.ClaimsPrincipal(identity).IsInRole("reader"));
    }


}
