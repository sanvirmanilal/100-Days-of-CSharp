using Xunit;

namespace Challenges.Tests;

[Trait("Category", "Infrastructure")]
public class InfrastructureTests
{
    [Fact]
    public void Exactly_one_challenge_and_one_test_suite_exist_for_every_day()
    {
        var challenges = typeof(Days.Day001.Challenge).Assembly.GetTypes()
            .Where(t => t.Name == "Challenge").Select(t => t.Namespace).Order().ToArray();
        var tests = typeof(InfrastructureTests).Assembly.GetTypes()
            .Where(t => t.Name == "ChallengeTests").Select(t => t.Namespace).Order().ToArray();
        var expected = Enumerable.Range(1, 100).Select(d => $"Days.Day{d:000}").ToArray();
        Assert.Equal(expected, challenges);
        Assert.Equal(expected, tests);
    }
}
