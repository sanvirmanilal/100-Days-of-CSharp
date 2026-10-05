using Xunit;

namespace Days.Day070;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "070")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(7, Challenge.StockAfter(10, -3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.StockAfter(1, -1));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.StockAfter(1, -2));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<OverflowException>(() => Challenge.StockAfter(int.MaxValue, 1));
    }

}
