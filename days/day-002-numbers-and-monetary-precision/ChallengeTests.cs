using Xunit;

namespace Days.Day002;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "002")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(7.50m, Challenge.LineTotal(3, 2.50m));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0m, Challenge.LineTotal(0, 3m));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(1.00m, Challenge.LineTotal(1, 1.005m));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.LineTotal(-1, 2m));
    }

}
