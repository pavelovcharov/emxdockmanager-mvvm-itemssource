using System;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Markup.Xaml;

namespace EremexAvaloniaApplication1;

public class PaneTemplateSelector : MarkupExtension, IDataTemplate
{
    public IDataTemplate? DocumentTemplate { get; set; }
    public IDataTemplate? DockPaneTemplate { get; set; }
    public Control? Build(object? param)
    {
        if (param is DocumentPaneViewModel) return DocumentTemplate?.Build(param);
        return DockPaneTemplate?.Build(param);
    }

    public bool Match(object? data)
    {
        return data is PaneViewModelBase;
    }

    public override object ProvideValue(IServiceProvider serviceProvider) => this;
}