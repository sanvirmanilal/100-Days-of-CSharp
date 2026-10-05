using Xunit;

namespace Days.Day096;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "096")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(5, Challenge.Replay([10, -5]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.Replay([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.Replay([-1, 2]));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<OverflowException>(() => Challenge.Replay([int.MaxValue, 1]));
    }

}
