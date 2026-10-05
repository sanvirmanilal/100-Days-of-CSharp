using Xunit;

namespace Days.Day073;

// Observable contracts. Add learner-owned tests for the harder exercises.
[Trait("Day", "073")]
[Trait("Category", "Challenge")]
public class ChallengeTests
{
    [Fact]
    public void Contract_01()
    {
        byte[] data = [1, 2, 3]; Challenge.ClearUsed(data, 2); Assert.Equal(new byte[] { 0, 0, 3 }, data);
    }
    [Fact]
    public void Contract_02()
    {
        byte[] data = [9]; Challenge.ClearUsed(data, 0); Assert.Equal((byte)9, data[0]);
    }
    [Fact]
    public void Contract_03()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Challenge.ClearUsed([1], 2));
    }

}
