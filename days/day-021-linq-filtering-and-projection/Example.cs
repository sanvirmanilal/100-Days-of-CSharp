namespace Days.Day021;

// Learning example: LINQ filtering and projection. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        string[] names = ["Ada", "Grace", "Linus"]; Console.WriteLine(string.Join(", ", names.Where(n => n.Length > 3).Select(n => n.ToUpperInvariant())));
    }


}
