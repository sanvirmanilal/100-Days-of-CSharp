using Xunit;

namespace Days.Day014;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "014")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal("[HI]", Challenge.Transform("hi", [s => s.ToUpperInvariant(), s => $"[{s}]"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal("x", Challenge.Transform("x", []));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.Transform("x", [_ => throw new InvalidOperationException()]));
    }

}
