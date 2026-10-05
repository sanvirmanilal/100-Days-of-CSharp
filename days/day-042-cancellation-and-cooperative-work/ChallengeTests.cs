using Xunit;

namespace Days.Day042;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "042")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(5, await Challenge.RunAsync(_ => Task.FromResult(5), CancellationToken.None));
    }
    [Fact]
    public async Task Contract_02()
    {
        using var cts = new CancellationTokenSource(); cts.Cancel(); bool called = false; await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.RunAsync(_ => { called = true; return Task.FromResult(1); }, cts.Token)); Assert.False(called);
    }
    [Fact]
    public async Task Contract_03()
    {
        using var source = new CancellationTokenSource(); await Challenge.RunAsync(token => { Assert.Equal(source.Token, token); return Task.FromResult(0); }, source.Token);
    }

}
