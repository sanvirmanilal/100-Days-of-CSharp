namespace Days.Day074;

// Learning example: High-performance text and binary IO. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        Span<byte> data = stackalloc byte[4]; System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(data, 42); Console.WriteLine(Convert.ToHexString(data));
    }


}
