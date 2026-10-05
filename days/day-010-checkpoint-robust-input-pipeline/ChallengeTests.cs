using Xunit;

namespace Days.Day010;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "010")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 1, -2 }, Challenge.ParseLines(["1", " ", "-2"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.ParseLines([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<FormatException>(() => Challenge.ParseLines(["x"]));
    }

}
