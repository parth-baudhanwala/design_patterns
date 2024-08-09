namespace Singleton.Logger;

// Lazy Loading Singleton.
// Used sealed to prevent inheritance in same/different class.
public sealed class Logger : ILogger
{
    private static Logger? _logger = null;
    private static readonly object _lockObj = new();

    private Logger()
    {
        Console.WriteLine("A new logger object has been created.");
    }

    public static Logger GetInstance
    {
        get
        {
            // Refer: https://en.wikipedia.org/wiki/Double-checked_locking
            if (_logger == null)
            {
                // Used lock to achieve thread safety.
                lock (_lockObj)
                {
                    return _logger ??= new();
                }
            }

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
