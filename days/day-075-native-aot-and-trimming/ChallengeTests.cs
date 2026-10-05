using Xunit;

namespace Days.Day075;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "075")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.Registered("Order", ["Order", "Item"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.Registered("order", ["Order"]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.Registered("Order", []));
    }

}
