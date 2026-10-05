using Xunit;

namespace Days.Day034;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "034")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var target = new List<int>(); Assert.True(Challenge.UpdateIfPresent(target, t => t.Add(1))); Assert.Equal(new[] { 1 }, target);
    }
    [Fact]
    public void Contract_02()
    {
        int calls = 0; Assert.False(Challenge.UpdateIfPresent<object>(null, _ => calls++)); Assert.Equal(0, calls);
    }

}
