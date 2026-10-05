using Xunit;

namespace Days.Day036;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "036")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(6, Challenge.Sum(new[] { 1, 2, 3 }));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(3.5m, Challenge.Sum(new[] { 1.2m, 2.3m }));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(0, Challenge.Sum(Array.Empty<int>()));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<OverflowException>(() => Challenge.Sum(new[] { int.MaxValue, 1 }));
    }

}
