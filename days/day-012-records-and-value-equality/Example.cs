namespace Days.Day012;

// Learning example: Records and value equality. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var original = new Coordinates(2, 3); Console.WriteLine(original with { X = 9 });
    }

    private sealed record Coordinates(int X, int Y);
}
