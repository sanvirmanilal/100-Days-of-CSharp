using Xunit;

namespace Days.Day069;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "069")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.True(Challenge.SameRows([1, 2, 2], [2, 1, 2]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.False(Challenge.SameRows([1, 2, 2], [1, 2]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.True(Challenge.SameRows([], []));
    }

}
