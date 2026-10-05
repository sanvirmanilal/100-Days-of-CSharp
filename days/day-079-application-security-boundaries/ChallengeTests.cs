using Xunit;

namespace Days.Day079;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "079")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.SameTenant("t1", "t1"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.SameTenant("t1", "t2"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.SameTenant("", ""));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.False(Challenge.SameTenant("T1", "t1"));
    }

}
