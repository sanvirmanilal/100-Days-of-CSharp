using Xunit;

namespace Days.Day009;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "009")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("Ada", Challenge.NameOrDefault(" Ada ", "guest"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("guest", Challenge.NameOrDefault(null, "guest"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal("guest", Challenge.NameOrDefault(" ", "guest"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<ArgumentException>(() => Challenge.NameOrDefault(null, " "));
    }

}
