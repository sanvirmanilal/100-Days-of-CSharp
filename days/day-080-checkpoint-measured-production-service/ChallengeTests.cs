using Xunit;

namespace Days.Day080;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "080")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.MeetsSlo(100, 100, 0.01, 0.01));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.MeetsSlo(101, 100, 0, 0.01));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.MeetsSlo(50, 100, 0.02, 0.01));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.MeetsSlo(-1, 100, 0, 0));
    }

}
