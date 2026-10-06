namespace Days.Day046;

// Learning example: Channels and bounded pipelines. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        var channel = System.Threading.Channels.Channel.CreateBounded<string>(1); await channel.Writer.WriteAsync("message"); Console.WriteLine(await channel.Reader.ReadAsync());
    }


}
