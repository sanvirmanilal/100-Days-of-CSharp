using Xunit;

namespace Days.Day035;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "035")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(42, Challenge.ParsePair("42"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.ParsePair("00"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<FormatException>(() => Challenge.ParsePair("123"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<FormatException>(() => Challenge.ParsePair("a2"));
    }

}
