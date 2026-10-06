namespace Days.Day081;

// Learning example: Architecture and dependency direction. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var port = typeof(IStore); Console.WriteLine($"Application port: {port.Name}");
    }

    private interface IStore { Task<string?> FindAsync(int id, CancellationToken token); }
}
