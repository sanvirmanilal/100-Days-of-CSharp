namespace Days.Day078;

// Learning example: Rate limiting and admission control. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        using var limiter = new System.Threading.RateLimiting.ConcurrencyLimiter(new() { PermitLimit = 1, QueueLimit = 0, QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst }); using var lease = limiter.AttemptAcquire(); Console.WriteLine(lease.IsAcquired);
    }


}
