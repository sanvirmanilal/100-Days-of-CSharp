using Xunit;

namespace Days.Day074;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "074")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(258, Challenge.ReadInt32([0, 0, 1, 2]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(-1, Challenge.ReadInt32([255, 255, 255, 255]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.ReadInt32([1, 2]));
    }

}
