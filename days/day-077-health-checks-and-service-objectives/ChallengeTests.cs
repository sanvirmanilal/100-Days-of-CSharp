using Xunit;

namespace Days.Day077;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "077")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(0.001m, Challenge.ErrorBudget(0.999m));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0m, Challenge.ErrorBudget(1m));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.ErrorBudget(1.1m));
    }

}
