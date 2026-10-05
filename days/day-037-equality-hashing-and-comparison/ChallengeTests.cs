using Xunit;

namespace Days.Day037;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "037")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "ABC", "def" }, Challenge.UniqueIds(["ABC", "abc", "def"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(new[] { "I" }, Challenge.UniqueIds(["I", "i"]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.UniqueIds([]));
    }

}
