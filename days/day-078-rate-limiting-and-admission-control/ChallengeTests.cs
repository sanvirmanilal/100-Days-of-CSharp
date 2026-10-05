using Xunit;

namespace Days.Day078;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "078")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.Admit(3, 3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.Admit(2, 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.Admit(0, 0));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Admit(-1, 1));
    }

}
