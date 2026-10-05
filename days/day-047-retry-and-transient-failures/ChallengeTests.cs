using Xunit;

namespace Days.Day047;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "047")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        int calls = 0; Assert.Equal(9, await Challenge.RetryAsync(() => ++calls < 3 ? Task.FromException<int>(new InvalidOperationException()) : Task.FromResult(9), 3)); Assert.Equal(3, calls);
    }
    [Fact]
    public async Task Contract_02()
    {
        int calls = 0; await Assert.ThrowsAsync<FormatException>(() => Challenge.RetryAsync(() => { calls++; return Task.FromException<int>(new FormatException()); }, 5)); Assert.Equal(1, calls);
    }
    [Fact]
    public async Task Contract_03()
    {
        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => Challenge.RetryAsync(() => Task.FromResult(1), 0));
    }

}
