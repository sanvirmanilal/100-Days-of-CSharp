namespace Days.Day031;

// Learning example: Modern construction and required members. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var label = new Label { Text = "required at construction" }; Console.WriteLine(label.Text);
    }

    private sealed class Label { public required string Text { get; init; } }
}
