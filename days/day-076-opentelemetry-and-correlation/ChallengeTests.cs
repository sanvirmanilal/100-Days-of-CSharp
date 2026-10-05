using Xunit;

namespace Days.Day076;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "076")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.ValidTraceId("0123456789abcdef0123456789abcdef"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.ValidTraceId(new string('0', 32)));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.False(Challenge.ValidTraceId("ABCDEF"));
    }

}
