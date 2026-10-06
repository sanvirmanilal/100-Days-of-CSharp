namespace Days.Day037;

// Learning example: Equality, hashing and comparison. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var set = new HashSet<string>(StringComparer.OrdinalIgnoreCase) { "A", "a" }; Console.WriteLine(set.Count);
    }


}
