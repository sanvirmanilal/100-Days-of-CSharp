namespace Days.Day044;

// Learning example: Parallel work and ordering. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        var results = await Task.WhenAll(Task.FromResult("first"), Task.FromResult("second")); Console.WriteLine(string.Join(", ", results));
    }


}
