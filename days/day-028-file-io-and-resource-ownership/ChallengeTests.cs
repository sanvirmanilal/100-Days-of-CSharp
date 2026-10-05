using Xunit;

namespace Days.Day028;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "028")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        string path = Path.GetTempFileName(); try { await File.WriteAllTextAsync(path, "hello", TestContext.Current.CancellationToken); Assert.Equal("hello", await Challenge.ReadTextAsync(path, CancellationToken.None)); } finally { File.Delete(path); }
    }
    [Fact]
    public async Task Contract_02()
    {
        using var cts = new CancellationTokenSource(); cts.Cancel(); await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.ReadTextAsync("unused", cts.Token));
    }
    [Fact]
    public async Task Contract_03()
    {
        await Assert.ThrowsAsync<FileNotFoundException>(() => Challenge.ReadTextAsync(Path.Combine(Path.GetTempPath(), Guid.NewGuid() + ".txt"), CancellationToken.None));
    }

}

