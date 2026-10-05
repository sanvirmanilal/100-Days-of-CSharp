using Xunit;

namespace Days.Day072;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "072")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(19d, Challenge.P95(Enumerable.Range(1, 20).Select(n => (double)n).ToArray()));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(7d, Challenge.P95([7]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.P95([]));
    }

}
