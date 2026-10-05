using Xunit;

namespace Days.Day023;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "023")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 1, 2 }, Challenge.TakeLazy(new[] { 1, 2, 3 }, 2));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.TakeLazy(Array.Empty<int>(), 3));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.TakeLazy(new[] { 1 }, -1).ToArray());
    }
    [Fact]
    public void Contract_04()
    {
        int seen = 0; var source = Enumerable.Range(1, 3).Select(n => { seen++; return n; }); var result = Challenge.TakeLazy(source, 1); Assert.Equal(0, seen); Assert.Equal(new[] { 1 }, result); Assert.Equal(1, seen);
    }

}
