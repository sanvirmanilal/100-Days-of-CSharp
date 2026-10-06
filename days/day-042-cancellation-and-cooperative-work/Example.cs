namespace Days.Day042;

// Learning example: Cancellation and cooperative work. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        using var source = new CancellationTokenSource(); source.Cancel(); Console.WriteLine(source.Token.IsCancellationRequested);
    }


}
