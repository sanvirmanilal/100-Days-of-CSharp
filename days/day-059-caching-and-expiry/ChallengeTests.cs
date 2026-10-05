using Xunit;

namespace Days.Day059;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "059")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var now = DateTimeOffset.UnixEpoch; Assert.True(Challenge.IsFresh(now, now.AddSeconds(1)));
    }
    [Fact]
    public void Contract_02()
    {
        var now = DateTimeOffset.UnixEpoch; Assert.False(Challenge.IsFresh(now, now));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.IsFresh(DateTimeOffset.UnixEpoch.AddSeconds(1), DateTimeOffset.UnixEpoch));
    }

}
