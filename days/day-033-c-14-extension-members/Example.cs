namespace Days.Day033;

// Learning example: C# 14 extension members. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(TextExtensions.CountWords("hello world"));
    }


}
public static class TextExtensions { public static int CountWords(string value) => value.WordCount; extension(string value) { public int WordCount => value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length; } }
