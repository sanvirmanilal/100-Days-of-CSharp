namespace Days.Day029;

// Learning example: Regular expressions and parsing. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(System.Text.RegularExpressions.Regex.IsMatch("1234", @"^\d{4}$", System.Text.RegularExpressions.RegexOptions.None, TimeSpan.FromMilliseconds(100)));
    }


}
