using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Days.Day050;

// Learning example: Checkpoint: concurrent importer. Predict the output before running.
public static class Example
{
    public static async Task Run()
    {
        var queue = new Queue<int>([1, 2, 3]); while (queue.TryDequeue(out var item)) { await Task.Yield(); Console.WriteLine(item); }
    }


}
