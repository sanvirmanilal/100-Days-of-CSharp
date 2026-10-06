namespace Days.Day083;

// Learning example: CQRS and read-model projections. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var readModel = new { Sku = "BOOK", Available = 7 }; Console.WriteLine(readModel.Available);
    }


}
