using Xunit;

namespace Days.Day054;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "054")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.IsSuccess(200));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.True(Challenge.IsSuccess(299));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.IsSuccess(300));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.False(Challenge.IsSuccess(404));
    }

}
