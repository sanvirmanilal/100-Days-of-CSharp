using Xunit;

namespace Days.Day087;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "087")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var seen = new HashSet<string> { "x" }; Assert.False(Challenge.ShouldProcess(seen, "x")); Assert.Single(seen);
    }
    [Fact]
    public void Contract_02()
    {
        var seen = new HashSet<string>(); Assert.True(Challenge.ShouldProcess(seen, "y")); Assert.Empty(seen);
    }

}
