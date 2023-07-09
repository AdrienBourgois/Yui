using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace Editor;

class Program
{
    [STAThread]
    public static void Main(string[] _args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(_args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace()
            .UseReactiveUI();
}