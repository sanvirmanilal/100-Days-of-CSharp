using Xunit;

namespace Days.Day066;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "066")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.Compatible(3, 2, 4));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.Compatible(5, 2, 4));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Compatible(3, 4, 2));
    }

}
