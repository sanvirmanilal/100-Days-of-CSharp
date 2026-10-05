using Xunit;

namespace Days.Day093;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "093")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("t1:item7", Challenge.TenantKey("t1", "item7"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.NotEqual(Challenge.TenantKey("t1", "x"), Challenge.TenantKey("t2", "x"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.TenantKey("t:1", "x"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.TenantKey("", "x"));
    }

}
