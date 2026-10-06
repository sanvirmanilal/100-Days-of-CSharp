namespace Days.Day048;

// Learning example: Timeouts and deterministic time. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(TimeProvider.System.GetUtcNow().Offset);
    }


}
