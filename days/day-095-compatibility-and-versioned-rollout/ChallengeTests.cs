using Xunit;

namespace Days.Day095;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "095")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.UpgradeSafe([2, 3], 2));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.UpgradeSafe([1, 3], 2));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.UpgradeSafe([], 2));
    }

}
