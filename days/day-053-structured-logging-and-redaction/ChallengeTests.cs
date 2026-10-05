using Xunit;

namespace Days.Day053;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "053")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("****", Challenge.Redact("abcd"));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("", Challenge.Redact(""));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.DoesNotContain("token", Challenge.Redact("token"));
    }

}
