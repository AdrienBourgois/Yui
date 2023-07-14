using Microsoft.Extensions.Logging;
using ILogger = Microsoft.Extensions.Logging.ILogger;

namespace Core;

public class Graph
{
    private ILogger logger;

    public Graph(GraphSettings _settings)
    {
        logger = _settings.loggerProvider.CreateLogger("Graph");
    }
    
    public async Task<bool> Run(CancellationToken _cancellationToken = default)
    {
        logger.LogDebug("Run Graph");
        
        await Task.Delay(TimeSpan.FromSeconds(2), _cancellationToken);

        return true;
    }
}