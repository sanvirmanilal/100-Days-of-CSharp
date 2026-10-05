using Xunit;

namespace Days.Day017;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "017")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var next = Challenge.CreateCounter(3); Assert.Equal(4, next()); Assert.Equal(5, next());
    }
    [Fact]
    public void Contract_02()
    {
        var a = Challenge.CreateCounter(0); var b = Challenge.CreateCounter(0); a(); Assert.Equal(1, b());
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<OverflowException>(() => Challenge.CreateCounter(int.MaxValue)());
    }

}
