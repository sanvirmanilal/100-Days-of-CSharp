using Xunit;

namespace Days.Day020;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "020")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(11m, Challenge.Subtotal([(2, 3m), (1, 5m)]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0m, Challenge.Subtotal([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.Subtotal([(-1, 2m)]));
    }

}
