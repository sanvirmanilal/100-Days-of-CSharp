using Xunit;

namespace Days.Day018;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "018")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("freezing", Challenge.Classify(-1));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("cool", Challenge.Classify(0));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal("warm", Challenge.Classify(20));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Equal("hot", Challenge.Classify(30));
    }

}
