using Xunit;

namespace Days.Day060;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "060")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(401, Challenge.ReadStatus(false, false, true));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(403, Challenge.ReadStatus(true, false, true));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(404, Challenge.ReadStatus(true, true, false));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Equal(200, Challenge.ReadStatus(true, true, true));
    }

}
