using Xunit;

namespace Days.Day039;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "039")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("order_id", Challenge.Identifier("order-id"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("_42", Challenge.Identifier("42"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal("_", Challenge.Identifier(""));
    }
    [Fact]
    public void Contract_04()
    {
        Assert.Equal("_", Challenge.Identifier("é"));
    }

}
