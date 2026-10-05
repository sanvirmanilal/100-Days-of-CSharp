using Xunit;

namespace Days.Day071;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "071")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(3, Challenge.NonSpaceCount("a b c"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.NonSpaceCount(""));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(2, Challenge.NonSpaceCount("😀"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentNullException>(() => Challenge.NonSpaceCount(null!));
    }

}
