using System.Reflection;

if (args.Length != 1 || !int.TryParse(args[0], out var day) || day is < 1 or > 100)
{
    Console.Error.WriteLine("Usage: dotnet run --project src/Examples -- <day: 1-100>");
    return 2;
}

var type = Assembly.GetExecutingAssembly().GetType($"Days.Day{day:000}.Example")!;
var run = type.GetMethod("Run", BindingFlags.Public | BindingFlags.Static)!;
if (run.Invoke(null, null) is Task task)
    await task;
return 0;
