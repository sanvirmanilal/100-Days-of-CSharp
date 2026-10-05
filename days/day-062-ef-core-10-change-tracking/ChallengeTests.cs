using Xunit;

namespace Days.Day062;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "062")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 2, 3 }, Challenge.ChangedIds([(1, "a"), (2, "b")], [(1, "a"), (2, "c"), (3, "d")]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.ChangedIds([], []));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Empty(Challenge.ChangedIds([(1, "a")], [(1, "a")]));
    }

}
