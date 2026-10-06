namespace Days.Day085;

// Learning example: Message contracts and evolution. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var envelope = new { MessageId = Guid.NewGuid(), SchemaVersion = 1, Kind = "Reserved", Data = new { Quantity = 2 } }; Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(envelope));
    }


}
