using Microsoft.Extensions.Configuration;

namespace Days.Day052;

// Learning example: Configuration and options validation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var config = new Microsoft.Extensions.Configuration.ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?> { ["Worker:Limit"] = "4" }).Build(); Console.WriteLine(config["Worker:Limit"]);
    }


}
