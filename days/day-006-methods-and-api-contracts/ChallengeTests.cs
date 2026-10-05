using Xunit;

namespace Days.Day006;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "006")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(5, Challenge.Clamp(5, 0, 10));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.Clamp(-4, 0, 10));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(10, Challenge.Clamp(20, 0, 10));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Clamp(1, 5, 2));
    }

}
