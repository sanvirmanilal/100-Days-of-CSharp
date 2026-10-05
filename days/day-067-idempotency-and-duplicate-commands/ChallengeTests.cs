using Xunit;

namespace Days.Day067;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "067")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var completed = new HashSet<string>(); int calls = 0; Assert.True(Challenge.ExecuteOnce(completed, "x", () => calls++)); Assert.False(Challenge.ExecuteOnce(completed, "x", () => calls++)); Assert.Equal(1, calls);
    }
    [Fact]
    public void Contract_02()
    {
        var completed = new HashSet<string>(); Assert.Throws<InvalidOperationException>(() => Challenge.ExecuteOnce(completed, "x", () => throw new InvalidOperationException())); Assert.DoesNotContain("x", completed);
    }

}
