using Xunit;

namespace Days.Day013;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "013")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        int calls = 0; Assert.Equal(6m, Challenge.Shipping(3m, w => { calls++; return w * 2; })); Assert.Equal(1, calls);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0m, Challenge.Shipping(0m, _ => 0m));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Shipping(-1m, _ => 0m));
    }

}
