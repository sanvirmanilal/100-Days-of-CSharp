using Xunit;

namespace Days.Day051;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "051")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        var instance = new object(); Assert.Same(instance, Challenge.ResolveRequired(new Provider(instance), typeof(object)));
    }
    [Fact]
    public void Contract_02()
    {
        Assert.Throws<InvalidOperationException>(() => Challenge.ResolveRequired(new Provider(null), typeof(object)));
    }

    private sealed class Provider(object? service) : IServiceProvider
    {
        public object? GetService(Type serviceType) => serviceType == typeof(object) ? service : null;
    }

}
