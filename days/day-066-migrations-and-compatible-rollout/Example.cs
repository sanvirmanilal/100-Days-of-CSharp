namespace Days.Day066;

// Learning example: Migrations and compatible rollout. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(new { Migration = "add_nullable_column", Reversible = true }));
    }


}
