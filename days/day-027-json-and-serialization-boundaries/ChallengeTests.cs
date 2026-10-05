using Xunit;

namespace Days.Day027;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "027")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(3, Challenge.ReadCount("{\"count\":3}"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(0, Challenge.ReadCount("{\"count\":0,\"extra\":true}"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<FormatException>(() => Challenge.ReadCount("{}"));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Throws<System.Text.Json.JsonException>(() => Challenge.ReadCount("{"));
    }

}
