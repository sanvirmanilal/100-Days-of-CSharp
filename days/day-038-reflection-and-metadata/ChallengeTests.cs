using Xunit;

namespace Days.Day038;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "038")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "Length" }, Challenge.PropertyNames(typeof(string)));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.PropertyNames(typeof(int)));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Contains("Year", Challenge.PropertyNames(typeof(DateOnly)));
    }

}
