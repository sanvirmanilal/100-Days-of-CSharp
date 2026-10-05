using Xunit;

namespace Days.Day033;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "033")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.IsLowerOrUncased("abc-123"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.IsLowerOrUncased("Abc"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.IsLowerOrUncased(""));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentNullException>(() => Challenge.IsLowerOrUncased(null!));
    }

}
