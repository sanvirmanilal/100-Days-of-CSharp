namespace Days.Day006;

// Learning example: Methods and API contracts. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(Describe("train", 2));
    }

    private static string Describe(string item, int count = 1) => $"{count} {item}";
}
