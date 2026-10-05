using Xunit;

namespace Days.Day007;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "007")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        int[] input = [1, 2, 3]; Assert.Equal(new[] { 3, 2, 1 }, Challenge.ReverseCopy(input)); Assert.Equal(new[] { 1, 2, 3 }, input);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.ReverseCopy([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentNullException>(() => Challenge.ReverseCopy(null!));
    }

}
