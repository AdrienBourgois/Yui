using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Editor.ViewModels;

namespace Editor;

public class ViewLocator : IDataTemplate
{
    public Control Build(object? _data)
    {
        if (_data != null)
        {
            string name = _data.GetType().FullName!.Replace("ViewModel", "View");
            Type? type = Type.GetType(name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance(type)!;
            }
        }

        return new TextBlock { Text = "Data null" };
    }

    public bool Match(object? _data)
    {
        return _data is ViewModelBase;
    }
}