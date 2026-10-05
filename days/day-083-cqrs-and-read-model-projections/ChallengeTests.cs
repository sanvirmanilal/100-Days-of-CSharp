using Xunit;

namespace Days.Day083;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "083")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(7, Challenge.Project([10, -3]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.Project([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<OverflowException>(() => Challenge.Project([int.MaxValue, 1]));
    }

}
