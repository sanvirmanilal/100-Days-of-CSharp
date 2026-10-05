using Xunit;

namespace Days.Day068;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "068")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "b", "c" }, Challenge.Pending(["a", "b", "c"], new() { "a" }));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.Pending([], new()));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(new[] { "A" }, Challenge.Pending(["A"], new() { "a" }));
    }

}
