using Xunit;

namespace Days.Day015;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "015")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(9, Challenge.ParseOr(() => 9, -1));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(-1, Challenge.ParseOr(() => throw new FormatException(), -1));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.ParseOr(() => throw new InvalidOperationException(), 0));
    }

}
