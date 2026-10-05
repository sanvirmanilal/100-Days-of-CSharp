using Xunit;

namespace Days.Day045;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "045")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        int[] state = [0]; Parallel.For(0, 10000, _ => Challenge.Increment(state)); Assert.Equal(10000, state[0]);
    }
    [Fact]
    public void Contract_02()
    {
        int[] state = [3]; Challenge.Increment(state); Assert.Equal(4, state[0]);
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Increment([]));
    }

}
