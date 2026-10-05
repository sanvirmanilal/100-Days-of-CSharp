using Xunit;

namespace Days.Day100;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "100")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "load-test", "restore" }, Challenge.MissingEvidence(["restore", "tests", "load-test"], ["tests"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.MissingEvidence(["tests"], ["tests"]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(new[] { "ADR" }, Challenge.MissingEvidence(["ADR", "ADR"], []));
    }

}
