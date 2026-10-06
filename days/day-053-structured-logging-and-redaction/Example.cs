using Microsoft.Extensions.Logging;

namespace Days.Day053;

// Learning example: Structured logging and redaction. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        using var factory = Microsoft.Extensions.Logging.LoggerFactory.Create(builder => builder.AddConsole()); var logger = factory.CreateLogger("Example"); logger.LogInformation("Processed batch {BatchId} with {Count} items", "B17", 4);
    }


}
