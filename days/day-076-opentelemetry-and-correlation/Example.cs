using System.Diagnostics;

namespace Days.Day076;

// Without a listener, ActivitySource may return null to avoid instrumentation overhead.
public static class Example
{
    public static void Run()
    {
        using var listener = new ActivityListener
        {
            ShouldListenTo = source => source.Name == "Learning",
            Sample = (ref ActivityCreationOptions<ActivityContext> options) => ActivitySamplingResult.AllDataAndRecorded
        };
        ActivitySource.AddActivityListener(listener);
        using var source = new ActivitySource("Learning");
        using var activity = source.StartActivity("ReadCatalogue");
        activity?.SetTag("catalogue.region", "eu");
        Console.WriteLine($"Trace: {activity?.TraceId}; operation: {activity?.OperationName}");
    }
}
