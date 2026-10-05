using Xunit;

namespace Days.Day030;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "030")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 9, 8, 7 }, Challenge.TopThree([9, 7, 8, 9, 1]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(new[] { -1, -5 }, Challenge.TopThree([-5, -1]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.TopThree([]));
    }

}
