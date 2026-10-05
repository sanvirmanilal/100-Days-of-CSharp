using Xunit;

namespace Days.Day025;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "025")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "b", "a" }, Challenge.IntersectOrdered(["b", "a", "b", "c"], ["a", "b"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.IntersectOrdered(["x"], []));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.IntersectOrdered(["A"], ["a"]));
    }

}
