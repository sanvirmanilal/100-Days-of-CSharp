using Xunit;

namespace Days.Day086;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "086")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        string[] steps = ["reserve", "charge"]; Assert.Equal(new[] { "charge", "reserve" }, Challenge.CompensationOrder(steps)); Assert.Equal(new[] { "reserve", "charge" }, steps);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.CompensationOrder([]));
    }

}
