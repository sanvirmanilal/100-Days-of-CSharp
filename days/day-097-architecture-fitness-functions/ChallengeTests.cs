using Xunit;

namespace Days.Day097;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "097")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.NoSelfEdges([("A", "B")]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.NoSelfEdges([("A", "A")]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.NoSelfEdges([]));
    }

}
