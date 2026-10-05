using Xunit;

namespace Days.Day090;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "090")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.CaughtUp(5, 4));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.True(Challenge.CaughtUp(4, 4));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.CaughtUp(3, 4));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.CaughtUp(-1, 0));
    }

}
