namespace Days.Day072;

// Learning example: Benchmarking and experimental design. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var watch = System.Diagnostics.Stopwatch.StartNew(); _ = Enumerable.Range(0, 1000).Sum(); watch.Stop(); Console.WriteLine(watch.ElapsedTicks);
    }


}
