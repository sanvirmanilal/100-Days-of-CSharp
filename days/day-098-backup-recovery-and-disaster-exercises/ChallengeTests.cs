using Xunit;

namespace Days.Day098;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "098")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.RecoveryValid("abc", "abc", 10, 9));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.RecoveryValid("abc", "ABC", 10, 9));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.RecoveryValid("abc", "abc", 8, 9));
    }

}
