using System.Security.Cryptography;

namespace Days.Day079;

// Store password verifiers, not passwords. A unique salt prevents identical passwords sharing a hash.
// Production identity uses framework services; this only demonstrates the primitive.
public static class Example
{
    public static void Run()
    {
        byte[] salt = RandomNumberGenerator.GetBytes(16);
        byte[] verifier = Rfc2898DeriveBytes.Pbkdf2("demonstration-password", salt, 600_000, HashAlgorithmName.SHA256, 32);
        byte[] supplied = Rfc2898DeriveBytes.Pbkdf2("demonstration-password", salt, 600_000, HashAlgorithmName.SHA256, 32);
        Console.WriteLine($"Verifier matches: {CryptographicOperations.FixedTimeEquals(verifier, supplied)}");
        CryptographicOperations.ZeroMemory(verifier);
        CryptographicOperations.ZeroMemory(supplied);
    }
}
