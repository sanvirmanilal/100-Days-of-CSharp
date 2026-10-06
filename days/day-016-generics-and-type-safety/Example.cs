namespace Days.Day016;

// Learning example: Generics and type safety. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Console.WriteLine(Identity(3)); Console.WriteLine(Identity("typed"));
    }

    private static T Identity<T>(T value) => value;
}
