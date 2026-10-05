using Xunit;

namespace Days.Day088;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "088")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(2, Challenge.Partition(10, 4));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.Partition(0, 4));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Partition(1, 0));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Partition(-1, 4));
    }

}
