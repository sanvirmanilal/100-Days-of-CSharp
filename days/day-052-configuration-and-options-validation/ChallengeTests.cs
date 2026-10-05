using Xunit;

namespace Days.Day052;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "052")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(8, Challenge.PositiveSetting("8"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Throws<ArgumentException>(() => Challenge.PositiveSetting(null));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.PositiveSetting("0"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.PositiveSetting("x"));
    }

}
