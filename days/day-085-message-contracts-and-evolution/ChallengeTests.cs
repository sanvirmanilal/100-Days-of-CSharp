using Xunit;

namespace Days.Day085;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "085")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.Supports(2, 3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.Supports(0, 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.Supports(4, 3));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Supports(1, 0));
    }

}
