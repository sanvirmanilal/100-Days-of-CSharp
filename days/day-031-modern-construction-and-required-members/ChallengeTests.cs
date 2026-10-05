using Xunit;

namespace Days.Day031;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "031")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("https://example.test/api/items", Challenge.Endpoint(new("https://example.test/api/"), "items").AbsoluteUri);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("https://example.test/api/items", Challenge.Endpoint(new("https://example.test/api/"), "./items").AbsoluteUri);
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Endpoint(new("ftp://example.test/"), "items"));
    }

}
