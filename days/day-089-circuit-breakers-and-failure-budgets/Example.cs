namespace Days.Day089;

// Learning example: Circuit breakers and failure budgets. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var state = "closed"; state = "open"; Console.WriteLine($"Dependency state: {state}");
    }


}
