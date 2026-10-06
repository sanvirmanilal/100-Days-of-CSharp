namespace Days.Day088;

// Learning example: Partitioning and ordering. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var keys = new[] { 1, 5, 9 }; foreach (var key in keys) Console.WriteLine($"Key {key}, bucket {key % 4}");
    }


}
