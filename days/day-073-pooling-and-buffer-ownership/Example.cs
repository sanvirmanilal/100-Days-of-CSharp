namespace Days.Day073;

// Learning example: Pooling and buffer ownership. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var pool = System.Buffers.ArrayPool<byte>.Shared; var buffer = pool.Rent(16); try { Console.WriteLine(buffer.Length); } finally { pool.Return(buffer, clearArray: true); }
    }


}
