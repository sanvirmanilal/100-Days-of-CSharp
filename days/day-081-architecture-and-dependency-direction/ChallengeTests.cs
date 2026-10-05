using Xunit;

namespace Days.Day081;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "081")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.AllowedDependency("Application", "Domain"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.AllowedDependency("Domain", "Infrastructure"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.AllowedDependency("Infrastructure", "Application"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.AllowedDependency("UI", "Domain"));
    }

}
