using Xunit;

namespace Days.Day029;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "029")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.IsSlug("csharp-14"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.IsSlug("-start"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.IsSlug("two--parts"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.False(Challenge.IsSlug(null));
    }
    [Fact]
    public void Contract_05()
    {
        Assert.False(Challenge.IsSlug("UPPER"));
    }
    [Fact]
    public void Contract_06()
    {
        Assert.False(Challenge.IsSlug(""));
    }

}
