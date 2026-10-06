namespace Days.Day023;

// Learning example: Deferred execution and enumeration. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        int visits = 0; var query = Enumerable.Range(1, 3).Select(n => { visits++; return n; }); Console.WriteLine(visits); _ = query.ToArray(); Console.WriteLine(visits);
    }


}
