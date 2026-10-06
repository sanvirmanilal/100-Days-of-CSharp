namespace Days.Day002;

// Starter only. Preserve this contract; implement after writing/reading tests.
public static class Challenge
{
    public static decimal LineTotal(int quantity, decimal price)
        => quantity < 0 ? throw new ArgumentOutOfRangeException(nameof(quantity)) : Math.Round(quantity * price, 2);
}
