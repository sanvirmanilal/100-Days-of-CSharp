using Xunit;

namespace Days.Day004;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "004")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.Qualifies(18, true, false));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.Qualifies(17, true, true));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.Qualifies(25, false, true));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Qualifies(-1, false, false));
    }

}
