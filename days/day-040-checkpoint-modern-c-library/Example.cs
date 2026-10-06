namespace Days.Day040;

// Learning example: Checkpoint: modern C# library. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int[] initial = [1, 2]; int[] extended = [.. initial, 3]; Console.WriteLine(string.Join(", ", extended));
    }


}
