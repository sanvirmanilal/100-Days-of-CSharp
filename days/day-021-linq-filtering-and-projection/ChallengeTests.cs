using Xunit;

namespace Days.Day021;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "021")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { 4, 16 }, Challenge.EvenSquares([1, 2, 3, 4]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.EvenSquares([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<OverflowException>(() => Challenge.EvenSquares([50000]));
    }

}
