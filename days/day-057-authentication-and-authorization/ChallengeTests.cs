using Xunit;

namespace Days.Day057;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "057")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.CanAccess(true, ["reader"], "reader"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.CanAccess(false, ["admin"], "admin"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.CanAccess(true, ["Admin"], "admin"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.False(Challenge.CanAccess(true, [], "admin"));
    }

}
