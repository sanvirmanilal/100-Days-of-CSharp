using System.Text.RegularExpressions;

namespace Days.Day039;

// The compiler generates this regex implementation; there is no hand-written parser here.
public static partial class Example
{
    public static void Run()
    {
        Console.WriteLine(TicketPattern().IsMatch("AB-123"));
        Console.WriteLine(TicketPattern().IsMatch("invalid"));
    }

    [GeneratedRegex("^[A-Z]{2}-[0-9]{3}$", RegexOptions.CultureInvariant)]
    private static partial Regex TicketPattern();
}
