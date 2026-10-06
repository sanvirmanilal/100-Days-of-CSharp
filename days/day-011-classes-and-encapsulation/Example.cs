namespace Days.Day011;

// Learning example: Classes and encapsulation. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var counter = new Counter(); counter.Increment(); Console.WriteLine(counter.Value);
    }

    private sealed class Counter { public int Value { get; private set; } public void Increment() => Value++; }
}
