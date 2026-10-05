using Xunit;

namespace Days.Day063;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "063")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 4, 2 }, Challenge.BatchIds([4, 2, 4]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.BatchIds([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(new[] { 0 }, Challenge.BatchIds([0, 0]));
    }

}
