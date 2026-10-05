using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day098;

// Learning example: Backup, recovery and disaster exercises. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        byte[] data = System.Text.Encoding.UTF8.GetBytes("backup sample"); Console.WriteLine(Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(data)));
    }


}
