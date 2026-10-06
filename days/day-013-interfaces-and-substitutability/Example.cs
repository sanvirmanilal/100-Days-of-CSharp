namespace Days.Day013;

// Learning example: Interfaces and substitutability. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        IFormatter formatter = new BracketFormatter(); Console.WriteLine(formatter.Format("ready"));
    }

    private interface IFormatter { string Format(string value); }
    private sealed class BracketFormatter : IFormatter { public string Format(string value) => $"[{value}]"; }
}
