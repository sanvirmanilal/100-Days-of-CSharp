namespace Days.Day007;

// Learning example: Arrays and mutation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int[] stops = [10, 20, 30, 40]; Console.WriteLine(string.Join(", ", stops[1..^1]));
    }


}
