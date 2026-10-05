using Xunit;

namespace Days.Day043;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "043")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(new[] { 1, 2 }, await Challenge.CollectAsync(Sequence(TestContext.Current.CancellationToken), TestContext.Current.CancellationToken));
    }
    [Fact]
    public async Task Contract_02()
    {
        using var cts = new CancellationTokenSource(); cts.Cancel(); await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.CollectAsync(Sequence(cts.Token), cts.Token));
    }

    private static async IAsyncEnumerable<int> Sequence(
        [System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken token = default)
    {
        token.ThrowIfCancellationRequested();
        await Task.Yield();
        yield return 1;
        token.ThrowIfCancellationRequested();
        yield return 2;
    }

}

