namespace Days.Day065;

// Learning example: Optimistic concurrency. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var left = (Version: 3, Value: "old"); var right = (Version: 4, Value: "updated"); Console.WriteLine(left.Version == right.Version);
    }


}
