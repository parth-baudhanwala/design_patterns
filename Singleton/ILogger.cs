namespace Singleton;

public interface ILogger
{
    public void LogInformation(string message);

    public void LogError(string message);
}
