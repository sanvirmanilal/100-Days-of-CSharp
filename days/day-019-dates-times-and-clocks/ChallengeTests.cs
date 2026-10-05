using Xunit;

namespace Days.Day019;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "019")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(2, Challenge.DaysBetween(new(2024, 2, 28), new(2024, 3, 1)));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.DaysBetween(new(2026, 1, 1), new(2026, 1, 1)));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.DaysBetween(new(2026, 2, 1), new(2026, 1, 1)));
    }

}
