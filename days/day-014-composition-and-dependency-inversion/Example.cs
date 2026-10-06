namespace Days.Day014;

// Learning example: Composition and dependency inversion. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Func<string, string> quote = s => $"<{s}>"; Console.WriteLine(quote("composed"));
    }


}
