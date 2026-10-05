using Xunit;

namespace Days.Day044;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "044")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(new[] { 3, 1 }, await Challenge.AllAsync([() => Task.FromResult(3), () => Task.FromResult(1)]));
    }
    [Fact]
    public async Task Contract_02()
    {
        Assert.Empty(await Challenge.AllAsync([]));
    }
    [Fact]
    public async Task Contract_03()
    {
        await Assert.ThrowsAsync<InvalidOperationException>(() => Challenge.AllAsync([() => Task.FromException<int>(new InvalidOperationException())]));
    }

}
