using Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Runtime;

public class GraphRunnerService : BackgroundService
{
    private ILogger<GraphRunnerService> logger;
    private ILoggerProvider loggerProvider;
    private IHostApplicationLifetime applicationLifetime;

    public GraphRunnerService(ILogger<GraphRunnerService> _logger, ILoggerProvider _loggerProvider, IHostApplicationLifetime _applicationLifetime)
    {
        logger = _logger;
        loggerProvider = _loggerProvider;
        applicationLifetime = _applicationLifetime;
    }
    
    public override Task StartAsync(CancellationToken _cancellationToken)
    {
        base.StartAsync(_cancellationToken);
        
        logger.LogDebug("Start Runner Service");
        
        return Task.CompletedTask;
    }
    
    protected override async Task ExecuteAsync(CancellationToken _stoppingToken)
    {
        Graph graph = new(new(loggerProvider));
        bool result = await graph.Run(_stoppingToken);
        
        logger.LogDebug("Graph result: {Result}", result);
        
        applicationLifetime.StopApplication();
    }

    public override Task StopAsync(CancellationToken _cancellationToken)
    {
        base.StopAsync(_cancellationToken);
        
        logger.LogDebug("Stop Runner Service");
        
        return Task.CompletedTask;
    }
}