namespace Days.Day038;

// Learning example: Reflection and metadata. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        foreach (var property in typeof(DateOnly).GetProperties().Take(3)) Console.WriteLine(property.Name);
    }


}
