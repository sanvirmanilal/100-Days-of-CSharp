namespace Days.Day054;

// Learning example: HTTP clients and protocol semantics. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        using var request = new HttpRequestMessage(HttpMethod.Get, "https://example.test/items"); request.Headers.Accept.ParseAdd("application/json"); Console.WriteLine(request.Headers.Accept);
    }


}
