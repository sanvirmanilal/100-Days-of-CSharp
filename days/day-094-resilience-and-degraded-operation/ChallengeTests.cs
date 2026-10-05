using Xunit;

namespace Days.Day094;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "094")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("live", Challenge.SelectValue("live", "old", true));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("old", Challenge.SelectValue(null, "old", true));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.SelectValue(null, "old", false));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.SelectValue(null, null, true));
    }

}
