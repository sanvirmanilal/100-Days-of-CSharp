using Xunit;

namespace Days.Day065;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "065")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(4, Challenge.NextVersion(3, 3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.NextVersion(2, 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<OverflowException>(() => Challenge.NextVersion(int.MaxValue, int.MaxValue));
    }

}
