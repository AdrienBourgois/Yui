using Microsoft.Extensions.Logging;

namespace Core;

public class GraphSettings
{
    public readonly ILoggerProvider loggerProvider;

    public GraphSettings(ILoggerProvider _loggerProvider)
    {
        loggerProvider = _loggerProvider;
    }
}