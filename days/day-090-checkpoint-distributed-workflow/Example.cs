namespace Days.Day090;

// Learning example: Checkpoint: distributed workflow. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var status = new { WriteVersion = 8, ReadVersion = 6 }; Console.WriteLine($"Projection lag: {status.WriteVersion - status.ReadVersion}");
    }


}
