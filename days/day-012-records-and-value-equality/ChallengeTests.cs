using Xunit;

namespace Days.Day012;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "012")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("AB-12", Challenge.NormalizeCode(" ab-12 "));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("I", Challenge.NormalizeCode("i"));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentException>(() => Challenge.NormalizeCode(" "));
    }

}
