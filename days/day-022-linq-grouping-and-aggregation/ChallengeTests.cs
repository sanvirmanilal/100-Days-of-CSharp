using Xunit;

namespace Days.Day022;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "022")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var counts = Challenge.Frequencies(["a", "b", "a"]); Assert.Equal(2, counts["a"]); Assert.Equal(1, counts["b"]);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(2, Challenge.Frequencies(["A", "a"]).Count);
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.Frequencies([]));
    }

}
