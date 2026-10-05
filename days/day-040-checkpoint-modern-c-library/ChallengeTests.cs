using Xunit;

namespace Days.Day040;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "040")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var chunks = Challenge.Chunk([1, 2, 3], 2); Assert.Equal(2, chunks.Length); Assert.Equal(new[] { 1, 2 }, chunks[0]); Assert.Equal(new[] { 3 }, chunks[1]);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.Chunk([], 2));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Chunk([1], 0));
    }

}
