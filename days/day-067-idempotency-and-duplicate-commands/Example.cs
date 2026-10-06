namespace Days.Day067;

// Learning example: Idempotency and duplicate commands. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var seen = new HashSet<Guid>(); var id = Guid.NewGuid(); Console.WriteLine($"{seen.Add(id)} / {seen.Add(id)}");
    }


}
