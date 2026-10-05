using Xunit;

namespace Days.Day046;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "046")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public async Task Contract_01()
    {
        var channel = System.Threading.Channels.Channel.CreateUnbounded<int>(); channel.Writer.TryWrite(7); channel.Writer.TryWrite(8); channel.Writer.Complete(); Assert.Equal(new[] { 7, 8 }, await Challenge.DrainAsync(channel.Reader, CancellationToken.None));
    }
    [Fact]
    public async Task Contract_02()
    {
        var channel = System.Threading.Channels.Channel.CreateUnbounded<int>(); channel.Writer.Complete(); Assert.Empty(await Challenge.DrainAsync(channel.Reader, CancellationToken.None));
    }
    [Fact]
    public async Task Contract_03()
    {
        using var cts = new CancellationTokenSource(); cts.Cancel(); var channel = System.Threading.Channels.Channel.CreateUnbounded<int>(); await Assert.ThrowsAnyAsync<OperationCanceledException>(() => Challenge.DrainAsync(channel.Reader, cts.Token));
    }

}
