using Xunit;

namespace Days.Day064;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "064")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal((70m, 40m), Challenge.Transfer(100m, 10m, 30m));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal((5m, 2m), Challenge.Transfer(5m, 2m, 0m));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.Transfer(2m, 0m, 3m));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Transfer(2m, 0m, -1m));
    }

}
