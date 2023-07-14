using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;
using Runtime;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddNLog();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

builder.Services.AddLogging();
builder.Services.AddHostedService<GraphRunnerService>();

IHost host = builder.Build();

host.Run();