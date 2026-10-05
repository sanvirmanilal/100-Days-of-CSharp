using Xunit;

namespace Days.Day011;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "011")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(70m, Challenge.Withdraw(100m, 30m));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(100m, Challenge.Withdraw(100m, 0m));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.Withdraw(10m, 11m));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Withdraw(10m, -1m));
    }

}
