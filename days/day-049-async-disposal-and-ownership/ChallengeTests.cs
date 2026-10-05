using Xunit;

namespace Days.Day049;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "049")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        using var stream = new MemoryStream(); await Challenge.WriteAsync(stream, "hello", CancellationToken.None); Assert.True(stream.CanWrite); Assert.Equal("hello", System.Text.Encoding.UTF8.GetString(stream.ToArray()));
    }
    [Fact]
    public async Task Contract_02()
    {
        using var stream = new MemoryStream(); using var cts = new CancellationTokenSource(); cts.Cancel(); await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.WriteAsync(stream, "x", cts.Token));
    }

}
