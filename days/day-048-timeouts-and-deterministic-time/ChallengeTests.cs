using Xunit;

namespace Days.Day048;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "048")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(3, await Challenge.WithTimeoutAsync(Task.FromResult(3), TimeSpan.FromSeconds(1), CancellationToken.None));
    }
    [Fact]
    public async Task Contract_02()
    {
        var pending = new TaskCompletionSource<int>(TaskCreationOptions.RunContinuationsAsynchronously); await Assert.ThrowsAsync<TimeoutException>(() => Challenge.WithTimeoutAsync(pending.Task, TimeSpan.Zero, CancellationToken.None));
    }
    [Fact]
    public async Task Contract_03()
    {
        using var cts = new CancellationTokenSource(); cts.Cancel(); var pending = new TaskCompletionSource<int>(); await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.WithTimeoutAsync(pending.Task, TimeSpan.FromMinutes(1), cts.Token));
    }

}
