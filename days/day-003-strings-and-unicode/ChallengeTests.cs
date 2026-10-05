using Xunit;

namespace Days.Day003;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "003")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("Hello, Ada!", Challenge.Greet(" Ada "));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("Hello, Zoë!", Challenge.Greet("Zoë"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Greet(null));
    }

}
