namespace Singleton.Logger;

public interface ILogger
{
    public void LogInformation(string message);

    public void LogError(string message);
}
