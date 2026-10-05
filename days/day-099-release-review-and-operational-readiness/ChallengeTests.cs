using Xunit;

namespace Days.Day099;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "099")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.ReleaseAllowed(true, true, true, true));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.ReleaseAllowed(true, false, true, true));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.ReleaseAllowed(true, true, true, false));
    }

}
