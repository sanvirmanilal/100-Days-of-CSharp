namespace Days.Day058;

// Learning example: Pagination and query boundaries. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var query = new Uri("https://example.test/items?after=42&limit=10"); Console.WriteLine(query.Query);
    }


}
