using Xunit;

namespace Days.Day092;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "092")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(16m, Challenge.WeightedScore([(2, 5m), (3, 2m)]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0m, Challenge.WeightedScore([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.WeightedScore([(-1, 5m)]));
    }

}
