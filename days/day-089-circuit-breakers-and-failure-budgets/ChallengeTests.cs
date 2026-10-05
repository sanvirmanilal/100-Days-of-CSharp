using Xunit;

namespace Days.Day089;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "089")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.False(Challenge.OpenCircuit(2, 3));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.True(Challenge.OpenCircuit(3, 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.OpenCircuit(0, 0));
    }

}
