using Xunit;

namespace Days.Day082;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "082")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(2, Challenge.Reserve(5, 3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.Reserve(3, 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.Reserve(2, 3));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Reserve(2, 0));
    }

}
