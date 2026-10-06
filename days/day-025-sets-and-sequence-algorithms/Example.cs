namespace Days.Day025;

// Learning example: Sets and sequence algorithms. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var permissions = new HashSet<string> { "read", "write" }; Console.WriteLine(permissions.IsSupersetOf(["read"]));
    }


}
