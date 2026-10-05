using Xunit;

namespace Days.Day091;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "091")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("stop-admission", Challenge.ShutdownStage(0));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("dispose", Challenge.ShutdownStage(3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.ShutdownStage(4));
    }

}
