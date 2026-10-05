using Xunit;

namespace Days.Day041;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "041")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(8, await Challenge.DoubleAsync(() => Task.FromResult(4)));
    }
    [Fact]
    public async Task Contract_02()
    {
        await Assert.ThrowsAsync<InvalidOperationException>(() => Challenge.DoubleAsync(() => Task.FromException<int>(new InvalidOperationException())));
    }
    [Fact]
    public async Task Contract_03()
    {
        await Assert.ThrowsAsync<OverflowException>(() => Challenge.DoubleAsync(() => Task.FromResult(int.MaxValue)));
    }

}
