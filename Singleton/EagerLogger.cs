namespace Singleton;

// Eager Loading Singleton.
public sealed class EagerLogger : ILogger
{
    private static readonly EagerLogger _logger = new();

    private EagerLogger()
    {
        Console.WriteLine("A new logger object has been created (Eager Loading).");
    }

    public static EagerLogger GetInstance
    {
        get
        {
            return _logger;
        }
    }

    public void LogInformation(string message)
    {
        Console.WriteLine(message);
    }

    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

