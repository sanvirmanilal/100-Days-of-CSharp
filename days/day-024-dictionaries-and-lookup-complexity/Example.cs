namespace Days.Day024;

// Learning example: Dictionaries and lookup complexity. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Dictionary<string, int> ages = new(StringComparer.OrdinalIgnoreCase) { ["ADA"] = 36 }; Console.WriteLine(ages.TryGetValue("ada", out var age) ? age : -1);
    }


}
