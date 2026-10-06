namespace Days.Day018;

// Learning example: Pattern matching. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        object value = 12; Console.WriteLine(value switch { int n when n > 0 => "positive integer", string => "text", _ => "other" });
    }


}
