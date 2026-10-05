using Xunit;

namespace Days.Day084;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "084")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(new[] { "Payments" }, Challenge.Forbidden(["Catalog", "Payments", "Payments"], ["Catalog"]));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Empty(Challenge.Forbidden([], []));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(new[] { "A", "B" }, Challenge.Forbidden(["B", "A"], []));
    }

}
