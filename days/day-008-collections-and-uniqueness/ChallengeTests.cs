using Xunit;

namespace Days.Day008;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "008")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "a", "b" }, Challenge.DistinctInOrder(["a", "b", "a"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(new[] { "A", "a" }, Challenge.DistinctInOrder(["A", "a"]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.DistinctInOrder([]));
    }

}
