using Xunit;

namespace Days.Day026;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "026")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        int[] before = [1, 2]; var after = Challenge.AppendCopy(before, 3); Assert.Equal(new[] { 1, 2, 3 }, after); Assert.Equal(new[] { 1, 2 }, before); Assert.NotSame(before, after);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(new[] { 9 }, Challenge.AppendCopy([], 9));
    }

}
