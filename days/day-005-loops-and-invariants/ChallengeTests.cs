using Xunit;

namespace Days.Day005;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "005")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(10, Challenge.SumTo(4));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.SumTo(0));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.SumTo(-1));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<OverflowException>(() => Challenge.SumTo(100000));
    }

}
