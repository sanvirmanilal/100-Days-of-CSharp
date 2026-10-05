using Xunit;

namespace Days.Day055;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "055")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(200, Challenge.StatusFor("found"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(400, Challenge.StatusFor("invalid"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(409, Challenge.StatusFor("conflict"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.StatusFor("other"));
    }

}
