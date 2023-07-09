using NLog;
using NLog.Config;
using NLog.Targets;

namespace Core;

public class Graph
{
    public void Run()
    {
        LoggingConfiguration config = new();
        ConsoleTarget log_console = new("Basic Log");
        config.AddRule(LogLevel.Info, LogLevel.Fatal, log_console);
        LogManager.Configuration = config;
        LogManager.GetCurrentClassLogger().Info("Log");
    }
}