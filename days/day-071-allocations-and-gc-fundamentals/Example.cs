namespace Days.Day071;

// Learning example: Allocations and GC fundamentals. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        long before = GC.GetAllocatedBytesForCurrentThread(); var bytes = new byte[1024]; Console.WriteLine($"Allocated: {GC.GetAllocatedBytesForCurrentThread() - before}; payload {bytes.Length}");
    }


}
