namespace Singleton.Logger;

// Lazy Loading Singleton with Lazy Class feature.
public sealed class LazyLogger : ILogger
{
    private static readonly Lazy<LazyLogger> _logger = new(() => new LazyLogger());

    private LazyLogger()
    {
        Console.WriteLine("A new logger object has been created (Lazy Loading).");
    }

    public static LazyLogger GetInstance
    {
        get
        {
            return _logger.Value;
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

