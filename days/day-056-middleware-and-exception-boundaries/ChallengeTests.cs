using Xunit;

namespace Days.Day056;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "056")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        Assert.Equal(400, Challenge.ErrorStatus(new ArgumentException("private")));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Equal(403, Challenge.ErrorStatus(new UnauthorizedAccessException()));
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Equal(500, Challenge.ErrorStatus(new Exception("secret")));
    }

}
