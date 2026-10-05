using Xunit;

namespace Days.Day058;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "058")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 3, 4 }, Challenge.Page([1, 2, 3, 4, 5], 2, 2));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.Page([1], 4, 2));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Page([1], -1, 2));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Page([1], 0, 0));
    }

}
