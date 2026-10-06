namespace Days.Day086;

// Learning example: Sagas and compensation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var step = (Name: "charge", Status: "pending"); Console.WriteLine($"{step.Name}: {step.Status}");
    }


}
