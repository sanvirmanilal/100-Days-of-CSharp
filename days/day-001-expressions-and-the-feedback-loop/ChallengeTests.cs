using Xunit;

namespace Days.Day001;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "001")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(7, Challenge.Add(3, 4));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(-2, Challenge.Add(-2, 0));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<OverflowException>(() => Challenge.Add(int.MaxValue, 1));
    }

}
