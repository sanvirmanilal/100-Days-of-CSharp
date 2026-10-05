using Xunit;

namespace Days.Day016;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "016")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(4, Challenge.FirstOr(new[] { 1, 4, 6 }, n => n % 2 == 0, -1));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("none", Challenge.FirstOr(Array.Empty<string>(), _ => true, "none"));
    }
    [Fact]
    public void Contract_03()
    {
        int calls = 0; Challenge.FirstOr(new[] { 2, 4 }, n => { calls++; return true; }, -1); Assert.Equal(1, calls);
    }

}
