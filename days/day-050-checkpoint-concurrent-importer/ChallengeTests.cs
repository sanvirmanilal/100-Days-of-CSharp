using Xunit;

namespace Days.Day050;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "050")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        Assert.Equal(new[] { 2, 4 }, await Challenge.MapAsync([1, 2], n => Task.FromResult(n * 2)));
    }
    [Fact]
    public async Task Contract_02()
    {
        Assert.Empty(await Challenge.MapAsync([], n => Task.FromResult(n)));
    }
    [Fact]
    public async Task Contract_03()
    {
        int calls = 0; await Assert.ThrowsAsync<InvalidOperationException>(() => Challenge.MapAsync([1, 2, 3], _ => { calls++; return Task.FromException<int>(new InvalidOperationException()); })); Assert.Equal(1, calls);
    }

}
