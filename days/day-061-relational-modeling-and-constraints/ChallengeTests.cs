using Xunit;

namespace Days.Day061;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "061")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.KeyAvailable(["A", "B"], "C"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.KeyAvailable(["A", "B"], "A"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.KeyAvailable(["A"], "a"));
    }

}
