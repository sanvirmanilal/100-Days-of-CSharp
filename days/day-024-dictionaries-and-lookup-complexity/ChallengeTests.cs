using Xunit;

namespace Days.Day024;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "024")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("Ada", Challenge.Index([(7, "Ada")])[7]);
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.Index([]));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.Index([(1, "a"), (1, "b")]));
    }

}
