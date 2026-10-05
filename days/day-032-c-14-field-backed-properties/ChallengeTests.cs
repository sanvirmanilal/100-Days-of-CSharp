using Xunit;

namespace Days.Day032;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "032")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("Grace", Challenge.ValidateName(" Grace "));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("李", Challenge.ValidateName("李"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.ValidateName(" "));
    }

}
