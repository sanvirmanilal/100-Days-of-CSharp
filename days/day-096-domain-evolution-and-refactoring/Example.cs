namespace Days.Day096;

// Learning example: Domain evolution and refactoring. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var eventName = nameof(QuantityAdjusted); Console.WriteLine(eventName);
    }

    private sealed record QuantityAdjusted(int Delta);
}
